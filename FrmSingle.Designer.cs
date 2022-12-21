
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
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_url = new System.Windows.Forms.Label();
            this.rtb_content = new System.Windows.Forms.RichTextBox();
            this.pb_image = new System.Windows.Forms.PictureBox();
            this.pnl_space = new System.Windows.Forms.Panel();
            this.tlp_single_main = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_single_content = new System.Windows.Forms.TableLayoutPanel();
            this.tb_title = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            this.tlp_single_main.SuspendLayout();
            this.tlp_single_content.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_date.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_date.Location = new System.Drawing.Point(8, 35);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(684, 30);
            this.lbl_date.TabIndex = 1;
            this.lbl_date.Text = "Date";
            this.lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_url
            // 
            this.lbl_url.AutoSize = true;
            this.lbl_url.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_url.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_url.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_url.Location = new System.Drawing.Point(8, 155);
            this.lbl_url.Name = "lbl_url";
            this.lbl_url.Size = new System.Drawing.Size(684, 30);
            this.lbl_url.TabIndex = 2;
            this.lbl_url.Text = "URL";
            this.lbl_url.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_url.Click += new System.EventHandler(this.lbl_url_Click);
            // 
            // rtb_content
            // 
            this.rtb_content.BackColor = System.Drawing.Color.Gainsboro;
            this.rtb_content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_content.Location = new System.Drawing.Point(3, 3);
            this.rtb_content.Name = "rtb_content";
            this.rtb_content.ReadOnly = true;
            this.rtb_content.Size = new System.Drawing.Size(541, 78);
            this.rtb_content.TabIndex = 3;
            this.rtb_content.Text = "";
            // 
            // pb_image
            // 
            this.pb_image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_image.Location = new System.Drawing.Point(550, 3);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(131, 78);
            this.pb_image.TabIndex = 4;
            this.pb_image.TabStop = false;
            // 
            // pnl_space
            // 
            this.pnl_space.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pnl_space.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_space.Location = new System.Drawing.Point(8, 188);
            this.pnl_space.Name = "pnl_space";
            this.pnl_space.Size = new System.Drawing.Size(684, 4);
            this.pnl_space.TabIndex = 5;
            // 
            // tlp_single_main
            // 
            this.tlp_single_main.ColumnCount = 1;
            this.tlp_single_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_single_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_single_main.Controls.Add(this.pnl_space, 0, 4);
            this.tlp_single_main.Controls.Add(this.lbl_date, 0, 1);
            this.tlp_single_main.Controls.Add(this.lbl_url, 0, 3);
            this.tlp_single_main.Controls.Add(this.tlp_single_content, 0, 2);
            this.tlp_single_main.Controls.Add(this.tb_title, 0, 0);
            this.tlp_single_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_single_main.Location = new System.Drawing.Point(0, 0);
            this.tlp_single_main.Name = "tlp_single_main";
            this.tlp_single_main.Padding = new System.Windows.Forms.Padding(5);
            this.tlp_single_main.RowCount = 5;
            this.tlp_single_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_single_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_single_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_single_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_single_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_single_main.Size = new System.Drawing.Size(700, 200);
            this.tlp_single_main.TabIndex = 6;
            // 
            // tlp_single_content
            // 
            this.tlp_single_content.ColumnCount = 2;
            this.tlp_single_content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlp_single_content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_single_content.Controls.Add(this.rtb_content, 0, 0);
            this.tlp_single_content.Controls.Add(this.pb_image, 1, 0);
            this.tlp_single_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_single_content.Location = new System.Drawing.Point(8, 68);
            this.tlp_single_content.Name = "tlp_single_content";
            this.tlp_single_content.RowCount = 1;
            this.tlp_single_content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_single_content.Size = new System.Drawing.Size(684, 84);
            this.tlp_single_content.TabIndex = 6;
            // 
            // tb_title
            // 
            this.tb_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_title.Location = new System.Drawing.Point(8, 8);
            this.tb_title.Multiline = true;
            this.tb_title.Name = "tb_title";
            this.tb_title.ReadOnly = true;
            this.tb_title.Size = new System.Drawing.Size(684, 24);
            this.tb_title.TabIndex = 7;
            this.tb_title.Text = "Title";
            // 
            // FrmSingle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlp_single_main);
            this.MinimumSize = new System.Drawing.Size(700, 200);
            this.Name = "FrmSingle";
            this.Size = new System.Drawing.Size(700, 200);
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            this.tlp_single_main.ResumeLayout(false);
            this.tlp_single_main.PerformLayout();
            this.tlp_single_content.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_space;
        public System.Windows.Forms.Label lbl_date;
        public System.Windows.Forms.Label lbl_url;
        public System.Windows.Forms.PictureBox pb_image;
        public System.Windows.Forms.RichTextBox rtb_content;
        private System.Windows.Forms.TableLayoutPanel tlp_single_main;
        private System.Windows.Forms.TableLayoutPanel tlp_single_content;
        public System.Windows.Forms.TextBox tb_title;
    }
}
