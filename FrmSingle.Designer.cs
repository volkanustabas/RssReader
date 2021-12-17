
namespace RssReader
{
    partial class FrmSingle
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_url = new System.Windows.Forms.Label();
            this.rtb_content = new System.Windows.Forms.RichTextBox();
            this.pb_image = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_title.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_title.Location = new System.Drawing.Point(10, 10);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(77, 16);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "NewsTitle";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_date.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_date.Location = new System.Drawing.Point(10, 50);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(30, 13);
            this.lbl_date.TabIndex = 1;
            this.lbl_date.Text = "Date";
            // 
            // lbl_url
            // 
            this.lbl_url.AutoSize = true;
            this.lbl_url.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_url.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_url.Location = new System.Drawing.Point(10, 200);
            this.lbl_url.Name = "lbl_url";
            this.lbl_url.Size = new System.Drawing.Size(29, 13);
            this.lbl_url.TabIndex = 2;
            this.lbl_url.Text = "URL";
            this.lbl_url.Click += new System.EventHandler(this.lbl_url_Click);
            // 
            // rtb_content
            // 
            this.rtb_content.BackColor = System.Drawing.Color.Gainsboro;
            this.rtb_content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_content.Location = new System.Drawing.Point(10, 80);
            this.rtb_content.Name = "rtb_content";
            this.rtb_content.ReadOnly = true;
            this.rtb_content.Size = new System.Drawing.Size(550, 100);
            this.rtb_content.TabIndex = 3;
            this.rtb_content.Text = "";
            // 
            // pb_image
            // 
            this.pb_image.Location = new System.Drawing.Point(580, 80);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(100, 100);
            this.pb_image.TabIndex = 4;
            this.pb_image.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Location = new System.Drawing.Point(3, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 5);
            this.panel1.TabIndex = 5;
            // 
            // FrmSingle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pb_image);
            this.Controls.Add(this.rtb_content);
            this.Controls.Add(this.lbl_url);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_title);
            this.Name = "FrmSingle";
            this.Size = new System.Drawing.Size(700, 250);
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lbl_title;
        public System.Windows.Forms.Label lbl_date;
        public System.Windows.Forms.Label lbl_url;
        public System.Windows.Forms.PictureBox pb_image;
        public System.Windows.Forms.RichTextBox rtb_content;
    }
}
