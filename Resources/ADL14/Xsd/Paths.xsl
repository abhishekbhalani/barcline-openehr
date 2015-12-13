<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
    xmlns:xs="http://www.w3.org/2001/XMLSchema"
    xmlns:openehr="http://schemas.openehr.org/v1"
>
    <xsl:output method="text" indent="yes" encoding="windows-1252" />
  
    <xsl:param name="ROOT" select="'ARCHETYPE'" />

    <xsl:template match="/">
      <xsl:call-template name="processComplexType">
        <xsl:with-param name="complexTypeElement" select="//xs:complexType[@name=$ROOT]" />
        <xsl:with-param name="path" select="''"/>
        <xsl:with-param name="level" select="0" />
      </xsl:call-template>
    </xsl:template>

    <xsl:template name="processComplexType">
      <xsl:param name="complexTypeElement" />
      <xsl:param name="path" />
      <xsl:param name="level" />

      <xsl:if test="$level &lt; 100">
        <xsl:if test="msxsl:node-set($complexTypeElement)/xs:complexContent/xs:extension/@base">
          <xsl:variable name="ancestorTypeName" select="string(msxsl:node-set($complexTypeElement)/xs:complexContent/xs:extension/@base)" />
          <xsl:variable name="ancestor">
            <xsl:value-of select="//xs:complexType[@name=$ancestorTypeName]" />
          </xsl:variable>
          <xsl:if test="$ancestor">
            <xsl:call-template name="processComplexType">
              <xsl:with-param name="complexTypeElement" select="$ancestor" />
            </xsl:call-template>
          </xsl:if>
        </xsl:if>
        <xsl:for-each select="$complexTypeElement//xs:sequence/xs:element">
          <xsl:variable name="typeName" select="@type" />
          <xsl:variable name="ct" select="//xs:complexType[@name=$typeName]" />
          <xsl:if test="$ct">
            <xsl:variable name="propPath">
              <xsl:choose>
                <xsl:when test="normalize-space($path) != ''">
                  <xsl:value-of select="concat($path, '.', @name)" />
                </xsl:when>
                <xsl:otherwise>
                  <xsl:value-of select="@name"/>
                </xsl:otherwise>
              </xsl:choose>
            </xsl:variable>
            <xsl:value-of select="concat('.Include(&quot;', $propPath, '&quot;)')" />
            <xsl:text>&#13;&#10;</xsl:text>
            <xsl:call-template name="processComplexType">
              <xsl:with-param name="complexTypeElement" select="$ct" />
              <xsl:with-param name="path" select="$propPath" />
              <xsl:with-param name="level" select="$level + 1" />
            </xsl:call-template>
          </xsl:if>
        </xsl:for-each>
      </xsl:if>
    </xsl:template>
</xsl:stylesheet>
