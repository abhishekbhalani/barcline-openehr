﻿namespace Barcline.OpenEhr.Forms
{
    partial class ArchetypeStorageToolWindow
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
            this.StorageVisualizer = new Barcline.OpenEhr.Forms.StorageVisualizer();
            this.SuspendLayout();
            // 
            // StorageVisualizer
            // 
            this.StorageVisualizer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StorageVisualizer.Location = new System.Drawing.Point(0, 0);
            this.StorageVisualizer.Name = "StorageVisualizer";
            this.StorageVisualizer.Size = new System.Drawing.Size(723, 361);
            this.StorageVisualizer.TabIndex = 0;
            // 
            // ArchetypeStorageToolWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 361);
            this.Controls.Add(this.StorageVisualizer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "ArchetypeStorageToolWindow";
            this.Text = "Archetype Storage";
            this.ResumeLayout(false);

        }

        #endregion

        internal StorageVisualizer StorageVisualizer;

    }
}