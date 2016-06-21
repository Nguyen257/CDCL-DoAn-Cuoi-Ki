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
            this.rtbIn = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtbOut = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rtbFound = new System.Windows.Forms.RichTextBox();
            this.txtNumberWord = new System.Windows.Forms.TextBox();
            this.btnTrongSo = new System.Windows.Forms.Button();
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
            this.btnTranfer.Text = "TranInput";
            this.btnTranfer.UseVisualStyleBackColor = true;
            this.btnTranfer.Click += new System.EventHandler(this.btnTranfer_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rtbIn);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 268);
            this.panel1.TabIndex = 1;
            // 
            // rtbIn
            // 
            this.rtbIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbIn.Location = new System.Drawing.Point(0, 0);
            this.rtbIn.Name = "rtbIn";
            this.rtbIn.Size = new System.Drawing.Size(593, 268);
            this.rtbIn.TabIndex = 0;
            this.rtbIn.Text = "";
            this.rtbIn.TextChanged += new System.EventHandler(this.rtbIn_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rtbOut);
            this.panel2.Location = new System.Drawing.Point(612, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(593, 268);
            this.panel2.TabIndex = 2;
            // 
            // rtbOut
            // 
            this.rtbOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbOut.Location = new System.Drawing.Point(0, 0);
            this.rtbOut.Name = "rtbOut";
            this.rtbOut.Size = new System.Drawing.Size(593, 268);
            this.rtbOut.TabIndex = 0;
            this.rtbOut.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(684, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tran";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtbFound
            // 
            this.rtbFound.Location = new System.Drawing.Point(12, 296);
            this.rtbFound.Name = "rtbFound";
            this.rtbFound.Size = new System.Drawing.Size(954, 150);
            this.rtbFound.TabIndex = 5;
            this.rtbFound.Text = "";
            // 
            // txtNumberWord
            // 
            this.txtNumberWord.Location = new System.Drawing.Point(1020, 296);
            this.txtNumberWord.Name = "txtNumberWord";
            this.txtNumberWord.Size = new System.Drawing.Size(185, 20);
            this.txtNumberWord.TabIndex = 6;
            // 
            // btnTrongSo
            // 
            this.btnTrongSo.Location = new System.Drawing.Point(786, 476);
            this.btnTrongSo.Name = "btnTrongSo";
            this.btnTrongSo.Size = new System.Drawing.Size(122, 23);
            this.btnTrongSo.TabIndex = 7;
            this.btnTrongSo.Text = "DanhTrongSO";
            this.btnTrongSo.UseVisualStyleBackColor = true;
            this.btnTrongSo.Click += new System.EventHandler(this.btnTrongSo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 502);
            this.Controls.Add(this.btnTrongSo);
            this.Controls.Add(this.txtNumberWord);
            this.Controls.Add(this.rtbFound);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTranfer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTranfer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtbIn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rtbOut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtbFound;
        private System.Windows.Forms.TextBox txtNumberWord;
        private System.Windows.Forms.Button btnTrongSo;
    }
}

