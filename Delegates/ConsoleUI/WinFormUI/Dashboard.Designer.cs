﻿
namespace WinFormUI
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.msgBoxBtn = new System.Windows.Forms.Button();
            this.textBoxBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.subTotalTxt = new System.Windows.Forms.TextBox();
            this.totalTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // msgBoxBtn
            // 
            this.msgBoxBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.msgBoxBtn.Location = new System.Drawing.Point(59, 233);
            this.msgBoxBtn.Name = "msgBoxBtn";
            this.msgBoxBtn.Size = new System.Drawing.Size(209, 95);
            this.msgBoxBtn.TabIndex = 0;
            this.msgBoxBtn.Text = "MessageBox Demo";
            this.msgBoxBtn.UseVisualStyleBackColor = true;
            this.msgBoxBtn.Click += new System.EventHandler(this.msgBoxBtn_Click);
            // 
            // textBoxBtn
            // 
            this.textBoxBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxBtn.Location = new System.Drawing.Point(340, 233);
            this.textBoxBtn.Name = "textBoxBtn";
            this.textBoxBtn.Size = new System.Drawing.Size(209, 95);
            this.textBoxBtn.TabIndex = 1;
            this.textBoxBtn.Text = "TextBox Demo";
            this.textBoxBtn.UseVisualStyleBackColor = true;
            this.textBoxBtn.Click += new System.EventHandler(this.textBoxBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(336, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Subtotal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(334, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total";
            // 
            // subTotalTxt
            // 
            this.subTotalTxt.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subTotalTxt.Location = new System.Drawing.Point(340, 81);
            this.subTotalTxt.Name = "subTotalTxt";
            this.subTotalTxt.Size = new System.Drawing.Size(200, 38);
            this.subTotalTxt.TabIndex = 4;
            // 
            // totalTxt
            // 
            this.totalTxt.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalTxt.Location = new System.Drawing.Point(340, 168);
            this.totalTxt.Name = "totalTxt";
            this.totalTxt.Size = new System.Drawing.Size(200, 38);
            this.totalTxt.TabIndex = 5;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 360);
            this.Controls.Add(this.totalTxt);
            this.Controls.Add(this.subTotalTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBtn);
            this.Controls.Add(this.msgBoxBtn);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button msgBoxBtn;
        private System.Windows.Forms.Button textBoxBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox subTotalTxt;
        private System.Windows.Forms.TextBox totalTxt;
    }
}

