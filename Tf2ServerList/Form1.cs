using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace Tf2ServerList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
        }

        #region WholeFormDragable   
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            HtmlWeb web = new HtmlWeb();


            HtmlAgilityPack.HtmlDocument NowPage
                = web.Load("https://tf2-servers.com/servers/players/");

            string TotalPagesElement = "//ul[@class='pagination']";


            HtmlNodeCollection TableElements = NowPage.DocumentNode.SelectNodes(TotalPagesElement);

            int NumberOfPages = 0;

            foreach (string item in TableElements[0].InnerText.Replace(" ", "").Replace("\n", "").Replace("\r", "").Split())
            {
                if(!string.IsNullOrWhiteSpace(item))
                {
                    if (item.Contains("Next"))
                    {
                        break;
                    }

                    NumberOfPages++;
                }
             

            }
            Console.WriteLine(NumberOfPages);

            //string TotalPagesElement = "//table[@class='table table-bordered']"; 

            for (int i = 0; i < NumberOfPages; i++)
            {
                Console.WriteLine(i);
                try
                {
                    GetWebsiteData(web, i);
                }
                catch (Exception)
                {
                    textBox1.Text = "Server is OFFLINE.";
                    //throw;
                }
            }


        }

        private void GetWebsiteData(HtmlWeb web,int Token)
        {
            string TotalPagesElement = "//tr";

            string Url = string.Concat("https://tf2-servers.com/servers/players/", Token.ToString(), "/");
            //Console.WriteLine(Url);

            HtmlAgilityPack.HtmlDocument NowPage
                   = web.Load(Url);

            HtmlNodeCollection TableElements = NowPage.DocumentNode.SelectNodes(TotalPagesElement);

            List<string> ListOfTr = new List<string>();

            foreach (var item in TableElements)
            {
                //Console.WriteLine();
                string InnerText = item.InnerText.Replace(" ", "").Replace("\n", "").Replace("\r", "");
                //Console.WriteLine(InnerText);
                Console.WriteLine(Regex.Replace(InnerText, @"\s+", " |=| "));

                ListOfTr.Add(InnerText.Replace(" ", "").Replace("\n", "").Replace("\r", ""));
            }

            ListViewItem ListViewItemVar = null;
            ListViewItemVar = new ListViewItem();


            List<string> ListElements = new List<string>();

            foreach (string item in ListOfTr)
            {
                if (!item.Contains("Map"))
                {
                    foreach (string SelectedString in item.Split())
                    {
                        if (!string.IsNullOrWhiteSpace(SelectedString))
                        {
                            ListElements.Add(SelectedString);
                        }
                    }

                    if (ListElements.Count > 3)
                    {
                        if (ListElements[1] != "Online" && ListElements[1] != "Offline")
                        {
                            ListViewItem item1 = new ListViewItem(ListElements[0]);
                            item1.SubItems.Add(ListElements[1]);
                            item1.SubItems.Add(ListElements[5].Replace("&nbsp;", ""));
                            item1.SubItems.Add(ListElements[2]);
                            item1.SubItems.Add(ListElements[6]);

                            listView1.Items.Add(item1);
                        }
                        ListElements.Clear();
                        ListViewItemVar = new ListViewItem();
                    }
                }
            }
            //Console.WriteLine(listView1.Items.Count);

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            var info = listView1.HitTest(e.X, e.Y);
            var row = info.Item.Index;
            var col = info.Item.SubItems.IndexOf(info.SubItem);
            //var value = info.Item.SubItems[col].Text;
            var value = info.Item.SubItems[4].Text;
            //listView1.Items.SubItems[1].BackColor = Color.FromArgb(-16711936);
            //info.Item.SubItems[4].BackColor = Color.FromArgb(-16711936);

            Clipboard.SetText(value);

            CopyIndicator.BackColor = Color.FromArgb(128, 255, 128);

            //timer1.Start();
        }



        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CopyIndicator.BackColor = Color.FromArgb(139, 155, 180);
            timer1.Stop();
        }
    }
}
