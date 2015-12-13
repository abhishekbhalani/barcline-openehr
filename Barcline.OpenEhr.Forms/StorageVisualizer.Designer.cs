namespace Barcline.OpenEhr.Forms
{
    partial class StorageVisualizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StorageVisualizer));
            this.tbrStorage = new System.Windows.Forms.ToolStrip();
            this.tv = new System.Windows.Forms.TreeView();
            this.iml = new System.Windows.Forms.ImageList(this.components);
            this.lv = new System.Windows.Forms.ListView();
            this.colArchetype = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctxArchetypes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuArchetypeOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlStorage = new System.Windows.Forms.Panel();
            this.pnlArchetypes = new System.Windows.Forms.Panel();
            this.tbrArchetypes = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tbbReload = new System.Windows.Forms.ToolStripButton();
            this.tbrStorage.SuspendLayout();
            this.ctxArchetypes.SuspendLayout();
            this.pnlStorage.SuspendLayout();
            this.pnlArchetypes.SuspendLayout();
            this.tbrArchetypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbrStorage
            // 
            this.tbrStorage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbbReload});
            this.tbrStorage.Location = new System.Drawing.Point(0, 0);
            this.tbrStorage.Name = "tbrStorage";
            this.tbrStorage.Size = new System.Drawing.Size(200, 25);
            this.tbrStorage.TabIndex = 0;
            this.tbrStorage.Text = "toolStrip1";
            // 
            // tv
            // 
            this.tv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv.HideSelection = false;
            this.tv.ImageIndex = 0;
            this.tv.ImageList = this.iml;
            this.tv.Location = new System.Drawing.Point(0, 25);
            this.tv.Name = "tv";
            this.tv.SelectedImageIndex = 0;
            this.tv.Size = new System.Drawing.Size(200, 297);
            this.tv.TabIndex = 1;
            // 
            // iml
            // 
            this.iml.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iml.ImageStream")));
            this.iml.TransparentColor = System.Drawing.Color.Transparent;
            this.iml.Images.SetKeyName(0, "Folder");
            this.iml.Images.SetKeyName(1, "Document");
            this.iml.Images.SetKeyName(2, "Reload");
            // 
            // lv
            // 
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colArchetype});
            this.lv.ContextMenuStrip = this.ctxArchetypes;
            this.lv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(0, 25);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(614, 297);
            this.lv.SmallImageList = this.iml;
            this.lv.TabIndex = 2;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            this.lv.DoubleClick += new System.EventHandler(this.lv_DoubleClick);
            // 
            // colArchetype
            // 
            this.colArchetype.Text = "Archetype";
            this.colArchetype.Width = 400;
            // 
            // ctxArchetypes
            // 
            this.ctxArchetypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArchetypeOpen});
            this.ctxArchetypes.Name = "ctxArchetypes";
            this.ctxArchetypes.Size = new System.Drawing.Size(161, 48);
            // 
            // mnuArchetypeOpen
            // 
            this.mnuArchetypeOpen.Image = global::Barcline.OpenEhr.Forms.Properties.Resources.edit;
            this.mnuArchetypeOpen.Name = "mnuArchetypeOpen";
            this.mnuArchetypeOpen.Size = new System.Drawing.Size(160, 22);
            this.mnuArchetypeOpen.Text = "Open Archetype";
            this.mnuArchetypeOpen.Click += new System.EventHandler(this.lv_DoubleClick);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(200, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 322);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // pnlStorage
            // 
            this.pnlStorage.Controls.Add(this.tv);
            this.pnlStorage.Controls.Add(this.tbrStorage);
            this.pnlStorage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlStorage.Location = new System.Drawing.Point(0, 0);
            this.pnlStorage.Name = "pnlStorage";
            this.pnlStorage.Size = new System.Drawing.Size(200, 322);
            this.pnlStorage.TabIndex = 4;
            // 
            // pnlArchetypes
            // 
            this.pnlArchetypes.Controls.Add(this.lv);
            this.pnlArchetypes.Controls.Add(this.tbrArchetypes);
            this.pnlArchetypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlArchetypes.Location = new System.Drawing.Point(205, 0);
            this.pnlArchetypes.Name = "pnlArchetypes";
            this.pnlArchetypes.Size = new System.Drawing.Size(614, 322);
            this.pnlArchetypes.TabIndex = 5;
            // 
            // tbrArchetypes
            // 
            this.tbrArchetypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.tbrArchetypes.Location = new System.Drawing.Point(0, 0);
            this.tbrArchetypes.Name = "tbrArchetypes";
            this.tbrArchetypes.Size = new System.Drawing.Size(614, 25);
            this.tbrArchetypes.TabIndex = 0;
            this.tbrArchetypes.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Barcline.OpenEhr.Forms.Properties.Resources.edit;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(113, 22);
            this.toolStripButton1.Text = "Open Archetype";
            // 
            // tbbReload
            // 
            this.tbbReload.Image = global::Barcline.OpenEhr.Forms.Properties.Resources.refresh;
            this.tbbReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbReload.Name = "tbbReload";
            this.tbbReload.Size = new System.Drawing.Size(66, 22);
            this.tbbReload.Text = "Refresh";
            // 
            // StorageVisualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlArchetypes);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlStorage);
            this.Name = "StorageVisualizer";
            this.Size = new System.Drawing.Size(819, 322);
            this.tbrStorage.ResumeLayout(false);
            this.tbrStorage.PerformLayout();
            this.ctxArchetypes.ResumeLayout(false);
            this.pnlStorage.ResumeLayout(false);
            this.pnlStorage.PerformLayout();
            this.pnlArchetypes.ResumeLayout(false);
            this.pnlArchetypes.PerformLayout();
            this.tbrArchetypes.ResumeLayout(false);
            this.tbrArchetypes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tbrStorage;
        internal System.Windows.Forms.TreeView tv;
        private System.Windows.Forms.ImageList iml;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ColumnHeader colArchetype;
        internal System.Windows.Forms.ListView lv;
        protected internal System.Windows.Forms.ToolStripButton tbbReload;
        private System.Windows.Forms.Panel pnlStorage;
        private System.Windows.Forms.Panel pnlArchetypes;
        private System.Windows.Forms.ToolStrip tbrArchetypes;
        private System.Windows.Forms.ContextMenuStrip ctxArchetypes;
        protected internal System.Windows.Forms.ToolStripMenuItem mnuArchetypeOpen;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}
