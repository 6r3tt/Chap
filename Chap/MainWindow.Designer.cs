namespace Chap
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.rtbMessageLog = new System.Windows.Forms.RichTextBox();
            this.txtEnterMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Version 0.0.0.0.0";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(373, 144);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(104, 33);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "Do Things";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // rtbMessageLog
            // 
            this.rtbMessageLog.BackColor = System.Drawing.SystemColors.Control;
            this.rtbMessageLog.Location = new System.Drawing.Point(12, 12);
            this.rtbMessageLog.Name = "rtbMessageLog";
            this.rtbMessageLog.Size = new System.Drawing.Size(355, 133);
            this.rtbMessageLog.TabIndex = 2;
            this.rtbMessageLog.Text = "";
            // 
            // txtEnterMessage
            // 
            this.txtEnterMessage.Location = new System.Drawing.Point(12, 151);
            this.txtEnterMessage.Name = "txtEnterMessage";
            this.txtEnterMessage.Size = new System.Drawing.Size(355, 26);
            this.txtEnterMessage.TabIndex = 3;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(483, 203);
            this.Controls.Add(this.txtEnterMessage);
            this.Controls.Add(this.rtbMessageLog);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Chap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.RichTextBox rtbMessageLog;
        private System.Windows.Forms.TextBox txtEnterMessage;
    }
}