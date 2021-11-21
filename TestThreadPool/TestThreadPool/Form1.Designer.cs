namespace TestThreadPool
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
            this.rtbStatus = new System.Windows.Forms.RichTextBox();
            this.lbInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbStatus
            // 
            this.rtbStatus.Location = new System.Drawing.Point(12, 53);
            this.rtbStatus.Name = "rtbStatus";
            this.rtbStatus.Size = new System.Drawing.Size(754, 283);
            this.rtbStatus.TabIndex = 0;
            this.rtbStatus.Text = "";
            this.rtbStatus.TextChanged += new System.EventHandler(this.rtbStatus_TextChanged);
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.Location = new System.Drawing.Point(301, 9);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(201, 25);
            this.lbInfo.TabIndex = 1;
            this.lbInfo.Text = "Status RichTextBox";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 352);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.rtbStatus);
            this.Name = "Form1";
            this.Text = "FormTest";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbStatus;
        private System.Windows.Forms.Label lbInfo;
    }
}

