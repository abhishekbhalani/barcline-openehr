using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Serialization;

namespace Barcline.Core
{
    public static class EntityUtil
    {
        private static Dictionary<Type, List<PropertyInfo>> primaryKeyCache = new Dictionary<Type, List<PropertyInfo>>();
        private static Dictionary<Type, List<PropertyInfo>> propertiesCache = new Dictionary<Type, List<PropertyInfo>>();

        public static List<IModelObject> GetChildren(IModelObject parent)
        {
            List<IModelObject> rv = new List<IModelObject>();

            var type = parent.GetType();
            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance).ToList();
            foreach (var property in properties)
            {
                var value = property.GetValue(parent);
                if (value == null)
                    continue;

                if (value is IModelObjectCollection)
                {
                    foreach (IModelObject collectionItem in (IModelObjectCollection)value)
                    {
                        rv.Add(collectionItem);
                    }
                    continue;
                }

                if (IsModelObject(value))
                    rv.Add((IModelObject)value);
            }
            return rv;
        }

        public static T Load<T>(Stream stream)
            where T: class, IModelObject, new()
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            return (T)ser.Deserialize(stream);
        }

        public static T LoadFromFile<T>(String fileName)
            where T: class, IModelObject, new()
        {
            FileInfo fi = new FileInfo(fileName);
            using (Stream fs = fi.OpenRead())
            {
                return Load<T>(fs);
            }
        }

        public static String GetXml(this IModelObject obj)
        {
            XmlSerializer ser = new XmlSerializer(obj.GetType());
            using (StringWriter sw = new StringWriter())
            {
                ser.Serialize(sw, obj);
                sw.Flush();
                return sw.ToString();
            }
        }

        public static bool Supports(Type type, Type iface)
        {
            return type.GetInterfaces().Contains(iface);
        }

        public static String[] GetPrimaryKeyColumnNames(Object obj)
        {
            if (obj == null)
                return null;
            var type = obj.GetType();
            List<PropertyInfo> primaryKeyColumnsList = null;
            if (!primaryKeyCache.TryGetValue(type, out primaryKeyColumnsList))
            {
                primaryKeyColumnsList = new List<PropertyInfo>();
                primaryKeyColumnsList.AddRange(
                    from property in obj.GetType().GetProperties()
                    where Attribute.IsDefined(property, typeof(KeyAttribute), true)
                    let columnAttr = property.GetCustomAttributes(true).OfType<ColumnAttribute>().FirstOrDefault()
                    orderby columnAttr == null ? 0 : columnAttr.Order ascending
                    select property);
                primaryKeyCache.Add(type, primaryKeyColumnsList);
            }
            return (from property in primaryKeyColumnsList
                    select property.Name).ToArray();
        }

        public static object[] GetPrimaryKey(Object obj)
        {
            if (obj == null)
                return null;
            var type = obj.GetType();
            List<PropertyInfo> primaryKeyColumnsList = null;
            if (!primaryKeyCache.TryGetValue(type, out primaryKeyColumnsList))
            {
                primaryKeyColumnsList = new List<PropertyInfo>();
                primaryKeyColumnsList.AddRange(
                    from property in obj.GetType().GetProperties()
                    where Attribute.IsDefined(property, typeof(KeyAttribute), true)
                    let columnAttr = property.GetCustomAttributes(true).OfType<ColumnAttribute>().FirstOrDefault()
                    orderby columnAttr == null ? 0 : columnAttr.Order ascending
                    select property);
                primaryKeyCache.Add(type, primaryKeyColumnsList);
            }

            return (from property in primaryKeyColumnsList
                    select property.GetValue(obj)).ToArray();
        }

        public static bool IsGenericCollection(Type type)
        {
            return typeof(IEnumerable<>).IsAssignableFrom(type);
        }

        public static bool IsGenericCollection(PropertyInfo propertyInfo)
        {
            return typeof(IEnumerable<>).IsAssignableFrom(propertyInfo.PropertyType);
        }

        public static bool IsCollection(Type type)
        {
            return typeof(IEnumerable).IsAssignableFrom(type);
        }

        public static bool IsCollection(PropertyInfo propertyInfo)
        {
            return typeof(IEnumerable).IsAssignableFrom(propertyInfo.PropertyType);
        }

        public static List<PropertyInfo> GetProperties(Type type)
        {
            List<PropertyInfo> properties = null;
            if (!propertiesCache.TryGetValue(type, out properties))
            {
                properties = new List<PropertyInfo>();
                properties.AddRange(type.GetProperties(BindingFlags.Public | BindingFlags.Instance));
                propertiesCache.Add(type, properties);
            }
            return properties;
        }

        public static bool HaveSamePrimaryKey(Object obj1, Object obj2)
        {
            if (obj1 == null || obj2 == null)
                return false;
            Object[] thisKey = GetPrimaryKey(obj1);
            Object[] thatKey = GetPrimaryKey(obj2);
            if (thisKey.Length != thatKey.Length)
                return false;
            return System.Linq.Enumerable.SequenceEqual(thisKey, thatKey);
        }

        public static bool IsModelObject(Object obj)
        {
            if (obj == null)
                return false;
            return obj is IModelObject;
        }

        public static bool IsObject(Object obj)
        {
            return Convert.GetTypeCode(obj) == TypeCode.Object;
        }

        public static bool IsPrimitive(Type type)
        {
            return type.IsPrimitive ||
                    type.IsValueType ||
                    type.IsEnum ||
                    type.Equals(typeof(String)) ||
                    type.Equals(typeof(Decimal)) ||
                    type.Equals(typeof(DateTime)) ||
                    type.Equals(typeof(DateTimeOffset)) ||
                    type.Equals(typeof(Guid)) ||
                    type.Equals(typeof(TimeSpan));
        }
    }
}