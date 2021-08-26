
namespace Xem_Ngay
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimQue = new System.Windows.Forms.TextBox();
            this.btnTimQue = new System.Windows.Forms.Button();
            this.logTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên quẻ";
            // 
            // txtTimQue
            // 
            this.txtTimQue.Location = new System.Drawing.Point(65, 6);
            this.txtTimQue.Name = "txtTimQue";
            this.txtTimQue.Size = new System.Drawing.Size(235, 20);
            this.txtTimQue.TabIndex = 1;
            // 
            // btnTimQue
            // 
            this.btnTimQue.Location = new System.Drawing.Point(306, 6);
            this.btnTimQue.Name = "btnTimQue";
            this.btnTimQue.Size = new System.Drawing.Size(75, 23);
            this.btnTimQue.TabIndex = 2;
            this.btnTimQue.Text = "Tìm kiếm";
            this.btnTimQue.UseVisualStyleBackColor = true;
            this.btnTimQue.Click += new System.EventHandler(this.btnTimQue_Click);
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(15, 50);
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.Size = new System.Drawing.Size(366, 146);
            this.logTextBox.TabIndex = 3;
            this.logTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.btnTimQue);
            this.Controls.Add(this.txtTimQue);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Xem ngày";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimQue;
        private System.Windows.Forms.Button btnTimQue;
        private System.Windows.Forms.RichTextBox logTextBox;
    }
}

