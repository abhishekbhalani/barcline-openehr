﻿namespace Barcline.OpenEhr.Forms
{
    partial class ArchetypeVisualizerToolWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ArchetypeVisualizer = new Barcline.OpenEhr.Forms.ArchetypeVisualizer();
            this.SuspendLayout();
            // 
            // ArchetypeVisualizer
            // 
            this.ArchetypeVisualizer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ArchetypeVisualizer.Location = new System.Drawing.Point(0, 0);
            this.ArchetypeVisualizer.Name = "ArchetypeVisualizer";
            this.ArchetypeVisualizer.Size = new System.Drawing.Size(543, 411);
            this.ArchetypeVisualizer.TabIndex = 0;
            this.ArchetypeVisualizer.Load += new System.EventHandler(this.ArchetypeVisualizer_Load);
            // 
            // ArchetypeVisualizerToolWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 411);
            this.Controls.Add(this.ArchetypeVisualizer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "ArchetypeVisualizerToolWindow";
            this.Text = "Archetype Visualizer";
            this.ResumeLayout(false);

        }

        #endregion

        internal ArchetypeVisualizer ArchetypeVisualizer;
    }
}