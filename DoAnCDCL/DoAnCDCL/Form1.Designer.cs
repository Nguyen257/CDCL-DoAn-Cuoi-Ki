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
            this.indexQuery = new System.Windows.Forms.Button();
            this.rtbKetQua = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbQuery = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnTranfer
            // 
            this.btnTranfer.Location = new System.Drawing.Point(751, 13);
            this.btnTranfer.Name = "btnTranfer";
            this.btnTranfer.Size = new System.Drawing.Size(75, 23);
            this.btnTranfer.TabIndex = 0;
            this.btnTranfer.Text = "IndexData";
            this.btnTranfer.UseVisualStyleBackColor = true;
            this.btnTranfer.Click += new System.EventHandler(this.btnTranfer_Click);
            // 
            // indexQuery
            // 
            this.indexQuery.Location = new System.Drawing.Point(751, 49);
            this.indexQuery.Name = "indexQuery";
            this.indexQuery.Size = new System.Drawing.Size(75, 23);
            this.indexQuery.TabIndex = 8;
            this.indexQuery.Text = "Tìm Kiếm";
            this.indexQuery.UseVisualStyleBackColor = true;
            this.indexQuery.Click += new System.EventHandler(this.indexQuery_Click);
            // 
            // rtbKetQua
            // 
            this.rtbKetQua.Location = new System.Drawing.Point(13, 103);
            this.rtbKetQua.Name = "rtbKetQua";
            this.rtbKetQua.Size = new System.Drawing.Size(1059, 379);
            this.rtbKetQua.TabIndex = 9;
            this.rtbKetQua.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kết quả tìm kiếm";
            // 
            // rtbQuery
            // 
            this.rtbQuery.Location = new System.Drawing.Point(15, 13);
            this.rtbQuery.Name = "rtbQuery";
            this.rtbQuery.Size = new System.Drawing.Size(696, 59);
            this.rtbQuery.TabIndex = 11;
            this.rtbQuery.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 494);
            this.Controls.Add(this.rtbQuery);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbKetQua);
            this.Controls.Add(this.indexQuery);
            this.Controls.Add(this.btnTranfer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTranfer;
        private System.Windows.Forms.Button indexQuery;
        private System.Windows.Forms.RichTextBox rtbKetQua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbQuery;
    }
}

