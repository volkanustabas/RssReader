using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using CodeHollow.FeedReader;

namespace RssReader
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        public void FillListBox()
        {
            listBox1.Items.Add("https://www.tomshardware.com/feeds/all");
            listBox1.Items.Add("https://www.techradar.com/rss");
            listBox1.Items.Add("https://www.cnet.com/rss/news/");
            listBox1.Items.Add("https://webrazzi.com/feed/");
            listBox1.Items.Add("https://evrimagaci.org/rss.xml");
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FillListBox();
        }

        private async void GetRss()
        {
            var feedUrl = listBox1.Items[listBox1.SelectedIndex].ToString();

            var feed = await FeedReader.ReadAsync(feedUrl);
            var xDocument = XDocument.Parse(feed.OriginalDocument);
            if (xDocument.Root != null)
            {
                var xNamespace = xDocument.Root.GetDefaultNamespace();
                foreach (var item in feed.Items)
                {
                    var baseFeedItem = item.SpecificItem;
                    string thumbnail = null;
                    if (baseFeedItem.Element.Descendants().Any(x => x.Name.LocalName == xNamespace + "thumbnail"))
                        thumbnail = baseFeedItem.Element.Descendants()
                            .First(x => x.Name.LocalName == xNamespace + "thumbnail").Attribute("url")
                            ?.Value;

                    var rss = new FrmSingle();
                    rss.lbl_title.Text = ClearText(item.Title);
                    rss.rtb_content.Text = Environment.NewLine + ClearText(item.Description);
                    rss.lbl_url.Text = item.Link;
                    rss.lbl_date.Text = item.PublishingDateString;
                    rss.pb_image.ImageLocation = thumbnail;
                    rss.pb_image.SizeMode = PictureBoxSizeMode.StretchImage;
                    rss.Margin = new Padding(0, -7, 0, 0);

                    rss.rtb_content.SelectAll();
                    rss.rtb_content.SelectionIndent += 5;

                    flp_content.Controls.Add(rss);
                }
            }
        }

        private string ClearText(string text)
        {
            try
            {
                return text.Replace("&#46;", "").Replace("<p>", "").Replace("</p>", "").Replace("<a>", "")
                    .Replace("</a>", "").Replace("&#8217;", "").Replace("[&#8230;]", "")
                    .Replace("<a rel=", "").Replace("nofollow", "").Replace("href=", "").Replace(">", "")
                    .Replace('"', ' ');
            }
            catch (NullReferenceException)
            {
                return "Desc not found";
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            flp_content.Controls.Clear();
            GetRss();
        }
    }
}