﻿namespace Dargon.Management.Views {
   partial class MobsTreeView {
      /// <summary> 
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary> 
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing) {
         if (disposing && (components != null)) {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent() {
         this.treeView = new System.Windows.Forms.TreeView();
         this.SuspendLayout();
         // 
         // treeView1
         // 
         this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
         this.treeView.Location = new System.Drawing.Point(0, 0);
         this.treeView.Name = "treeView";
         this.treeView.Size = new System.Drawing.Size(266, 372);
         this.treeView.TabIndex = 0;
         // 
         // MobsTreeView
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.treeView);
         this.Name = "MobsTreeView";
         this.Size = new System.Drawing.Size(266, 372);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TreeView treeView;
   }
}
