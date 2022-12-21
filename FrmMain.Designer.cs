
namespace RssReader
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lb_rss_items = new System.Windows.Forms.ListBox();
            this.flp_content = new System.Windows.Forms.FlowLayoutPanel();
            this.tlp_main = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_rss_items
            // 
            this.lb_rss_items.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_rss_items.FormattingEnabled = true;
            this.lb_rss_items.HorizontalScrollbar = true;
            this.lb_rss_items.Location = new System.Drawing.Point(8, 8);
            this.lb_rss_items.Name = "lb_rss_items";
            this.lb_rss_items.Size = new System.Drawing.Size(176, 425);
            this.lb_rss_items.Sorted = true;
            this.lb_rss_items.TabIndex = 1;
            this.lb_rss_items.DoubleClick += new System.EventHandler(this.lb_rss_items_DoubleClick);
            // 
            // flp_content
            // 
            this.flp_content.AutoScroll = true;
            this.flp_content.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_content.Location = new System.Drawing.Point(190, 8);
            this.flp_content.Name = "flp_content";
            this.flp_content.Size = new System.Drawing.Size(726, 425);
            this.flp_content.TabIndex = 2;
            // 
            // tlp_main
            // 
            this.tlp_main.ColumnCount = 2;
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlp_main.Controls.Add(this.lb_rss_items, 0, 0);
            this.tlp_main.Controls.Add(this.flp_content, 1, 0);
            this.tlp_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_main.Location = new System.Drawing.Point(0, 0);
            this.tlp_main.Name = "tlp_main";
            this.tlp_main.Padding = new System.Windows.Forms.Padding(5);
            this.tlp_main.RowCount = 1;
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_main.Size = new System.Drawing.Size(924, 441);
            this.tlp_main.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 441);
            this.Controls.Add(this.tlp_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(940, 480);
            this.Name = "FrmMain";
            this.Text = "RssReader";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tlp_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lb_rss_items;
        private System.Windows.Forms.FlowLayoutPanel flp_content;
        private System.Windows.Forms.TableLayoutPanel tlp_main;
    }
}

