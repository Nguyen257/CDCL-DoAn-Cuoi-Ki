namespace DoAnCDCL
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
            this.btnTranfer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtbIn = new System.Windows.Forms.RichTextBox();
            this.rtbOut = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTranfer
            // 
            this.btnTranfer.Location = new System.Drawing.Point(556, 476);
            this.btnTranfer.Name = "btnTranfer";
            this.btnTranfer.Size = new System.Drawing.Size(75, 23);
            this.btnTranfer.TabIndex = 0;
            this.btnTranfer.Text = "button1";
            this.btnTranfer.UseVisualStyleBackColor = true;
            this.btnTranfer.Click += new System.EventHandler(this.btnTranfer_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rtbIn);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 441);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rtbOut);
            this.panel2.Location = new System.Drawing.Point(612, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(593, 441);
            this.panel2.TabIndex = 2;
            // 
            // rtbIn
            // 
            this.rtbIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbIn.Location = new System.Drawing.Point(0, 0);
            this.rtbIn.Name = "rtbIn";
            this.rtbIn.Size = new System.Drawing.Size(593, 441);
            this.rtbIn.TabIndex = 0;
            this.rtbIn.Text = "";
            // 
            // rtbOut
            // 
            this.rtbOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbOut.Location = new System.Drawing.Point(0, 0);
            this.rtbOut.Name = "rtbOut";
            this.rtbOut.Size = new System.Drawing.Size(593, 441);
            this.rtbOut.TabIndex = 0;
            this.rtbOut.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 502);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTranfer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTranfer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtbIn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rtbOut;
    }
}

