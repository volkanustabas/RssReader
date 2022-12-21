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
            lb_rss_items.Items.Add("https://evrimagaci.org/rss.xml");
            lb_rss_items.Items.Add("https://www.aa.com.tr/rss/ajansguncel.xml");
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FillListBox();
        }

        private async void GetRss()
        {
            var feedUrl = lb_rss_items.Items[lb_rss_items.SelectedIndex].ToString();

            var feed = await FeedReader.ReadAsync(feedUrl);
            var xDocument = XDocument.Parse(feed.OriginalDocument);
            if (xDocument.Root != null)
            {
                var xNamespace = xDocument.Root.GetDefaultNamespace();

                string thumbnail = null;

                foreach (var item in feed.Items)
                {
                    var baseFeedItem = item.SpecificItem;


                    if (lb_rss_items.SelectedItem.ToString() == "https://www.aa.com.tr/rss/ajansguncel.xml")
                    {
                        if (baseFeedItem.Element.Descendants().Any(x => x.Name.LocalName == xNamespace + "image"))
                            thumbnail = baseFeedItem.Element.Descendants()
                                .First(x => x.Name.LocalName == xNamespace + "image")
                                ?.Value;
                    }
                    else if (lb_rss_items.SelectedItem.ToString() == "https://evrimagaci.org/rss.xml")

                    {
                        if (baseFeedItem.Element.Descendants().Any(x => x.Name.LocalName == xNamespace + "content"))
                            thumbnail = baseFeedItem.Element.Descendants()
                                .First(x => x.Name.LocalName == xNamespace + "content").Attribute("url")
                                ?.Value;
                    }

                    else
                    {
                        if (baseFeedItem.Element.Descendants().Any(x => x.Name.LocalName == xNamespace + "thumbnail"))
                            thumbnail = baseFeedItem.Element.Descendants()
                                .First(x => x.Name.LocalName == xNamespace + "thumbnail").Attribute("url")
                                ?.Value;
                    }

                    var rssSingle = new FrmSingle();
                    rssSingle.lbl_title.Text = ClearText(item.Title);
                    rssSingle.rtb_content.Text = Environment.NewLine + ClearText(item.Description);
                    rssSingle.lbl_url.Text = item.Link;
                    rssSingle.lbl_date.Text = item.PublishingDateString;
                    rssSingle.pb_image.ImageLocation = thumbnail;
                    rssSingle.pb_image.SizeMode = PictureBoxSizeMode.StretchImage;
                    rssSingle.Margin = new Padding(0, -7, 0, 0);

                    rssSingle.rtb_content.SelectAll();
                    rssSingle.rtb_content.SelectionIndent += 5;
                    flp_content.Controls.Add(rssSingle);
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

        private void lb_rss_items_DoubleClick(object sender, EventArgs e)
        {
            flp_content.Controls.Clear();
            GetRss();
        }
    }
}