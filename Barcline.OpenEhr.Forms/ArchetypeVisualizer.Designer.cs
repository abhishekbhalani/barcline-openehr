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
            this.tvArchetype = new System.Windows.Forms.TreeView();
            this.ctx = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuExpand = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCollapse = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuGenerateInstance = new System.Windows.Forms.ToolStripMenuItem();
            this.iml = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.txtNodeXml = new ScintillaNET.Scintilla();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInstanceXml = new ScintillaNET.Scintilla();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbbGenerateInstance = new System.Windows.Forms.ToolStripButton();
            this.pg = new System.Windows.Forms.PropertyGrid();
            this.spl = new System.Windows.Forms.Splitter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.tvInstance = new System.Windows.Forms.TreeView();
            this.ctx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvArchetype
            // 
            this.tvArchetype.ContextMenuStrip = this.ctx;
            this.tvArchetype.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvArchetype.HideSelection = false;
            this.tvArchetype.ImageIndex = 0;
            this.tvArchetype.ImageList = this.iml;
            this.tvArchetype.Location = new System.Drawing.Point(0, 23);
            this.tvArchetype.Name = "tvArchetype";
            this.tvArchetype.SelectedImageIndex = 0;
            this.tvArchetype.Size = new System.Drawing.Size(211, 282);
            this.tvArchetype.TabIndex = 2;
            this.tvArchetype.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tv_MouseDown);
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
            this.mnuExpand.Size = new System.Drawing.Size(168, 22);
            this.mnuExpand.Text = "&Expand";
            // 
            // mnuCollapse
            // 
            this.mnuCollapse.Name = "mnuCollapse";
            this.mnuCollapse.Size = new System.Drawing.Size(168, 22);
            this.mnuCollapse.Text = "&Collapse";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(165, 6);
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
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 25);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.tvArchetype);
            this.splitContainer.Panel1.Controls.Add(this.splitter1);
            this.splitContainer.Panel1.Controls.Add(this.txtNodeXml);
            this.splitContainer.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tvInstance);
            this.splitContainer.Panel2.Controls.Add(this.splitter2);
            this.splitContainer.Panel2.Controls.Add(this.txtInstanceXml);
            this.splitContainer.Panel2.Controls.Add(this.label2);
            this.splitContainer.Size = new System.Drawing.Size(635, 556);
            this.splitContainer.SplitterDistance = 211;
            this.splitContainer.TabIndex = 0;
            this.splitContainer.Resize += new System.EventHandler(this.splitContainer_Resize);
            // 
            // txtNodeXml
            // 
            this.txtNodeXml.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtNodeXml.Location = new System.Drawing.Point(0, 310);
            this.txtNodeXml.Name = "txtNodeXml";
            this.txtNodeXml.Size = new System.Drawing.Size(211, 246);
            this.txtNodeXml.TabIndex = 0;
            this.txtNodeXml.UseTabs = false;
            this.txtNodeXml.Resize += new System.EventHandler(this.OnXmlEditorResize);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Archetype";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtInstanceXml
            // 
            this.txtInstanceXml.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtInstanceXml.Location = new System.Drawing.Point(0, 310);
            this.txtInstanceXml.Name = "txtInstanceXml";
            this.txtInstanceXml.Size = new System.Drawing.Size(420, 246);
            this.txtInstanceXml.TabIndex = 1;
            this.txtInstanceXml.UseTabs = false;
            this.txtInstanceXml.Resize += new System.EventHandler(this.OnXmlEditorResize);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Instance";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // pg
            // 
            this.pg.Dock = System.Windows.Forms.DockStyle.Right;
            this.pg.Location = new System.Drawing.Point(640, 25);
            this.pg.Name = "pg";
            this.pg.Size = new System.Drawing.Size(262, 556);
            this.pg.TabIndex = 2;
            // 
            // spl
            // 
            this.spl.Dock = System.Windows.Forms.DockStyle.Right;
            this.spl.Location = new System.Drawing.Point(635, 25);
            this.spl.Name = "spl";
            this.spl.Size = new System.Drawing.Size(5, 556);
            this.spl.TabIndex = 3;
            this.spl.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 305);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(211, 5);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            this.splitter1.Move += new System.EventHandler(this.OnSplitterMove);
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(0, 305);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(420, 5);
            this.splitter2.TabIndex = 4;
            this.splitter2.TabStop = false;
            this.splitter2.Move += new System.EventHandler(this.OnSplitterMove);
            // 
            // tvInstance
            // 
            this.tvInstance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvInstance.HideSelection = false;
            this.tvInstance.ImageIndex = 0;
            this.tvInstance.ImageList = this.iml;
            this.tvInstance.Location = new System.Drawing.Point(0, 23);
            this.tvInstance.Name = "tvInstance";
            this.tvInstance.SelectedImageIndex = 0;
            this.tvInstance.Size = new System.Drawing.Size(420, 282);
            this.tvInstance.TabIndex = 5;
            // 
            // ArchetypeVisualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.spl);
            this.Controls.Add(this.pg);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ArchetypeVisualizer";
            this.Size = new System.Drawing.Size(902, 581);
            this.ctx.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TreeView tvArchetype;
        private System.Windows.Forms.ImageList iml;
        private System.Windows.Forms.ContextMenuStrip ctx;
        internal System.Windows.Forms.ToolStripMenuItem mnuExpand;
        internal System.Windows.Forms.ToolStripMenuItem mnuCollapse;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem mnuGenerateInstance;
        private System.Windows.Forms.SplitContainer splitContainer;
        protected internal ScintillaNET.Scintilla txtNodeXml;
        protected internal ScintillaNET.Scintilla txtInstanceXml;
        private System.Windows.Forms.ToolStrip toolStrip1;
        protected internal System.Windows.Forms.ToolStripButton tbbGenerateInstance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Splitter spl;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        internal System.Windows.Forms.TreeView tvInstance;
        protected internal System.Windows.Forms.PropertyGrid pg;
    }
}
