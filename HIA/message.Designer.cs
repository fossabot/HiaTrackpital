﻿namespace HIA
{
    partial class Message
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Message));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.l_result = new System.Windows.Forms.Label();
            this.b_ok = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.l_result);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(43, 23);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // l_result
            // 
            this.l_result.AutoSize = true;
            this.l_result.Location = new System.Drawing.Point(3, 0);
            this.l_result.Name = "l_result";
            this.l_result.Size = new System.Drawing.Size(35, 13);
            this.l_result.TabIndex = 0;
            this.l_result.Text = "label1";
            this.l_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b_ok
            // 
            this.b_ok.Image = global::HIA.Properties.Resources.check;
            this.b_ok.Location = new System.Drawing.Point(187, 129);
            this.b_ok.Name = "b_ok";
            this.b_ok.Size = new System.Drawing.Size(56, 45);
            this.b_ok.TabIndex = 1;
            this.b_ok.UseVisualStyleBackColor = true;
            this.b_ok.Click += new System.EventHandler(this.B_ok_Click);
            // 
            // message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 179);
            this.Controls.Add(this.b_ok);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "message";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Résultat";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label l_result;
        private System.Windows.Forms.Button b_ok;
    }
}