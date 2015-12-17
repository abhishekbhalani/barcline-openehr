namespace Barcline.OpenEhr.Forms
{
    partial class TerminologyVisualizer
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
            this.bsCodeSystem = new System.Windows.Forms.BindingSource(this.components);
            this.bsCodeSystemVersion = new System.Windows.Forms.BindingSource(this.components);
            this.bsConcept = new System.Windows.Forms.BindingSource(this.components);
            this.lvCodeSystems = new System.Windows.Forms.ListView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lvConcepts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.bsCodeSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCodeSystemVersion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConcept)).BeginInit();
            this.SuspendLayout();
            // 
            // bsCodeSystem
            // 
            this.bsCodeSystem.DataSource = typeof(Barcline.OpenEhr.CodeSystem);
            this.bsCodeSystem.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bsCodeSystem_ListChanged);
            // 
            // bsCodeSystemVersion
            // 
            this.bsCodeSystemVersion.DataMember = "Versions";
            this.bsCodeSystemVersion.DataSource = this.bsCodeSystem;
            // 
            // bsConcept
            // 
            this.bsConcept.DataMember = "Concepts";
            this.bsConcept.DataSource = this.bsCodeSystemVersion;
            this.bsConcept.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bsConcept_ListChanged);
            // 
            // lvCodeSystems
            // 
            this.lvCodeSystems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvCodeSystems.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvCodeSystems.HideSelection = false;
            this.lvCodeSystems.Location = new System.Drawing.Point(0, 0);
            this.lvCodeSystems.Name = "lvCodeSystems";
            this.lvCodeSystems.Size = new System.Drawing.Size(250, 416);
            this.lvCodeSystems.TabIndex = 0;
            this.lvCodeSystems.UseCompatibleStateImageBehavior = false;
            this.lvCodeSystems.View = System.Windows.Forms.View.Details;
            this.lvCodeSystems.SelectedIndexChanged += new System.EventHandler(this.lvCodeSystems_SelectedIndexChanged);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(250, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 416);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // lvConcepts
            // 
            this.lvConcepts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.lvConcepts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvConcepts.HideSelection = false;
            this.lvConcepts.Location = new System.Drawing.Point(254, 0);
            this.lvConcepts.Name = "lvConcepts";
            this.lvConcepts.Size = new System.Drawing.Size(438, 416);
            this.lvConcepts.TabIndex = 2;
            this.lvConcepts.UseCompatibleStateImageBehavior = false;
            this.lvConcepts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Code System";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Concept";
            this.columnHeader2.Width = 400;
            // 
            // TerminologyVisualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 416);
            this.Controls.Add(this.lvConcepts);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.lvCodeSystems);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "TerminologyVisualizer";
            this.Text = "Terminology";
            ((System.ComponentModel.ISupportInitialize)(this.bsCodeSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCodeSystemVersion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConcept)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.BindingSource bsCodeSystem;
        protected internal System.Windows.Forms.BindingSource bsCodeSystemVersion;
        protected internal System.Windows.Forms.BindingSource bsConcept;
        private System.Windows.Forms.ListView lvCodeSystems;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ListView lvConcepts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;

    }
}
