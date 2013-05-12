using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagedOptionsDialog
{
    partial class EmailOptionsPage
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
            this.components = new System.ComponentModel.Container();

            this.label1 = new System.Windows.Forms.Label();
            this.smtpHost = new System.Windows.Forms.TextBox();
            this.useTls = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SMTP Host:";
            // 
            // smtpHost
            // 
            this.smtpHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.smtpHost.Location = new System.Drawing.Point(74, 18);
            this.smtpHost.Name = "smtpHost";
            this.smtpHost.Size = new System.Drawing.Size(281, 20);
            this.smtpHost.TabIndex = 1;
            // 
            // useTls
            // 
            this.useTls.AutoSize = true;
            this.useTls.Location = new System.Drawing.Point(74, 44);
            this.useTls.Name = "useTls";
            this.useTls.Size = new System.Drawing.Size(68, 17);
            this.useTls.TabIndex = 2;
            this.useTls.Text = "Use TLS";
            this.useTls.UseVisualStyleBackColor = true;
            // 
            // EmailOptionsPage
            // 
            this.Controls.Add(this.useTls);
            this.Controls.Add(this.smtpHost);
            this.Controls.Add(this.label1);
            this.Name = "EmailOptionsPage";
            this.Size = new System.Drawing.Size(358, 86);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox smtpHost;
        private System.Windows.Forms.CheckBox useTls;
    }
}
