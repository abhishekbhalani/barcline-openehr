namespace Barcline.OpenEhr.Forms
{
    partial class ArchetypeVisualizer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArchetypeVisualizer));
            this.pg = new System.Windows.Forms.PropertyGrid();
            this.tv = new System.Windows.Forms.TreeView();
            this.ctx = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuExpand = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCollapse = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuGenerateInstance = new System.Windows.Forms.ToolStripMenuItem();
            this.iml = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.txtNodeXml = new ScintillaNET.Scintilla();
            this.txtInstanceXml = new ScintillaNET.Scintilla();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.spl = new System.Windows.Forms.Splitter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbbGenerateInstance = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ctx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pg
            // 
            this.pg.CategoryForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pg.Dock = System.Windows.Forms.DockStyle.Right;
            this.pg.Location = new System.Drawing.Point(669, 0);
            this.pg.Name = "pg";
            this.pg.Size = new System.Drawing.Size(233, 265);
            this.pg.TabIndex = 0;
            // 
            // tv
            // 
            this.tv.ContextMenuStrip = this.ctx;
            this.tv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv.HideSelection = false;
            this.tv.ImageIndex = 0;
            this.tv.ImageList = this.iml;
            this.tv.Location = new System.Drawing.Point(0, 0);
            this.tv.Name = "tv";
            this.tv.SelectedImageIndex = 0;
            this.tv.Size = new System.Drawing.Size(665, 265);
            this.tv.TabIndex = 2;
            this.tv.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tv_MouseDown);
            // 
            // ctx
            // 
            this.ctx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExpand,
            this.mnuCollapse,
            this.toolStripMenuItem1,
            this.mnuGenerateInstance});
            this.ctx.Name = "ctx";
            this.ctx.Size = new System.Drawing.Size(169, 76);
            // 
            // mnuExpand
            // 
            this.mnuExpand.Name = "mnuExpand";
            this.mnuExpand.Size = new System.Drawing.Size(199, 22);
            this.mnuExpand.Text = "&Expand";
            // 
            // mnuCollapse
            // 
            this.mnuCollapse.Name = "mnuCollapse";
            this.mnuCollapse.Size = new System.Drawing.Size(199, 22);
            this.mnuCollapse.Text = "&Collapse";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(196, 6);
            // 
            // mnuGenerateInstance
            // 
            this.mnuGenerateInstance.Image = global::Barcline.OpenEhr.Forms.Properties.Resources.FormRunHS;
            this.mnuGenerateInstance.Name = "mnuGenerateInstance";
            this.mnuGenerateInstance.Size = new System.Drawing.Size(168, 22);
            this.mnuGenerateInstance.Text = "&Generate Instance";
            // 
            // iml
            // 
            this.iml.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iml.ImageStream")));
            this.iml.TransparentColor = System.Drawing.Color.Transparent;
            this.iml.Images.SetKeyName(0, "Property");
            this.iml.Images.SetKeyName(1, "Object");
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer.Location = new System.Drawing.Point(0, 294);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.txtNodeXml);
            this.splitContainer.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.txtInstanceXml);
            this.splitContainer.Panel2.Controls.Add(this.label2);
            this.splitContainer.Size = new System.Drawing.Size(902, 287);
            this.splitContainer.SplitterDistance = 300;
            this.splitContainer.TabIndex = 0;
            // 
            // txtNodeXml
            // 
            this.txtNodeXml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNodeXml.Location = new System.Drawing.Point(0, 23);
            this.txtNodeXml.Name = "txtNodeXml";
            this.txtNodeXml.Size = new System.Drawing.Size(300, 264);
            this.txtNodeXml.TabIndex = 0;
            this.txtNodeXml.UseTabs = false;
            // 
            // txtInstanceXml
            // 
            this.txtInstanceXml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInstanceXml.Location = new System.Drawing.Point(0, 23);
            this.txtInstanceXml.Name = "txtInstanceXml";
            this.txtInstanceXml.Size = new System.Drawing.Size(598, 264);
            this.txtInstanceXml.TabIndex = 1;
            this.txtInstanceXml.UseTabs = false;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.tv);
            this.pnlTop.Controls.Add(this.spl);
            this.pnlTop.Controls.Add(this.pg);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTop.Location = new System.Drawing.Point(0, 25);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(902, 265);
            this.pnlTop.TabIndex = 4;
            // 
            // spl
            // 
            this.spl.Dock = System.Windows.Forms.DockStyle.Right;
            this.spl.Location = new System.Drawing.Point(665, 0);
            this.spl.Name = "spl";
            this.spl.Size = new System.Drawing.Size(4, 265);
            this.spl.TabIndex = 3;
            this.spl.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 290);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(902, 4);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbbGenerateInstance});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(902, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbbGenerateInstance
            // 
            this.tbbGenerateInstance.Image = global::Barcline.OpenEhr.Forms.Properties.Resources.FormRunHS;
            this.tbbGenerateInstance.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbGenerateInstance.Name = "tbbGenerateInstance";
            this.tbbGenerateInstance.Size = new System.Drawing.Size(121, 22);
            this.tbbGenerateInstance.Text = "Generate instance";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Archetype Element XML";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(598, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Instance XML";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ArchetypeVisualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ArchetypeVisualizer";
            this.Size = new System.Drawing.Size(902, 581);
            this.ctx.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PropertyGrid pg;
        internal System.Windows.Forms.TreeView tv;
        private System.Windows.Forms.ImageList iml;
        private System.Windows.Forms.ContextMenuStrip ctx;
        internal System.Windows.Forms.ToolStripMenuItem mnuExpand;
        internal System.Windows.Forms.ToolStripMenuItem mnuCollapse;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem mnuGenerateInstance;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Splitter spl;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.SplitContainer splitContainer;
        protected internal ScintillaNET.Scintilla txtNodeXml;
        protected internal ScintillaNET.Scintilla txtInstanceXml;
        private System.Windows.Forms.ToolStrip toolStrip1;
        protected internal System.Windows.Forms.ToolStripButton tbbGenerateInstance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
