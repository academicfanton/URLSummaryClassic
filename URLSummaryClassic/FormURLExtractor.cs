// PURPOSE: 
//     Test to explore the content and format of the information about a URL
//     embedded in the OpenGraph protocol(http://ogp.me/)
// 
// (C) 2018 Fernando Anton Alonso
// fernando.anton.academic@gmail.com
// 
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License version 3 as
// published by the Free Software Foundation.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HtmlAgilityPack;
using System.Net;
using System.Net.Http;
using System.IO;

namespace URLSummaryClassic
{

    public partial class FormURLExtractor : Form
    {
        HtmlAgilityPack.HtmlDocument htmlDoc;
        OGAttributes DetailsDialog;

        public FormURLExtractor()
        {
            InitializeComponent();
            this.Button_OK.Enabled = true;
            this.Text_Info.Text = "Press OK to retrieve summary";
            DetailsDialog = new OGAttributes();
        }



        private void TextBox_URLToExtract_TextChanged(object sender, EventArgs e)
        {

        }
        public static bool CheckURLValid(string source)
        {
            Uri uriResult;
            return Uri.TryCreate(source, UriKind.Absolute, out uriResult)
                && (Uri.CheckSchemeName("http") || Uri.CheckSchemeName("https"))
                && (uriResult != null);
        }
        private Bitmap LoadPicture(string url)
        {
            HttpWebRequest wreq;
            HttpWebResponse wresp;
            Stream mystream;
            Bitmap bmp;

            bmp = null;
            mystream = null;
            wresp = null;
            try
            {
                wreq = (HttpWebRequest)WebRequest.Create(url);
                wreq.AllowWriteStreamBuffering = true;

                wresp = (HttpWebResponse)wreq.GetResponse();

                if ((mystream = wresp.GetResponseStream()) != null)
                {
                    bmp = new Bitmap(mystream);
                }
            }
            finally
            {
                if (mystream != null)
                    mystream.Close();

                if (wresp != null)
                    wresp.Close();
            }
            return (bmp);
        }
        private static string StrLeft(string sParam, int iLength)
        {
            string sResult = "";
            if (sParam.Length > 0)
            {
                if (iLength > sParam.Length)
                    iLength = sParam.Length;
                sResult = sParam.Substring(0, iLength);
            }
            return sResult;
        }
        private async Task DownloadPage(string sPage)
        {
            try
            {
                Uri uri;
                Uri.TryCreate(sPage, UriKind.Absolute, out uri);
                HttpClient httpClient = new HttpClient();
                string html = await httpClient.GetStringAsync(uri);
                this.Text_Info.Text = "Page downloaded .. Processing";
                htmlDoc = new HtmlAgilityPack.HtmlDocument();
                htmlDoc.LoadHtml(html);
                HtmlNodeCollection metaTags = htmlDoc.DocumentNode.SelectNodes("//meta");
                if (metaTags is null)
                {
                    this.Text_Info.Text = "No meta tags found";

                }
                else
                {
                    this.Text_Info.Text = "Processing meta tags";
                    foreach (HtmlNode tag in metaTags)
                    {
                        string sName = tag.GetAttributeValue("property", "");
                        string sContent = tag.GetAttributeValue("content", "");
                        if (StrLeft(sName,3)=="og:")
                        {
                            string sTag = sName.Substring(3, sName.Length - 3);
                            DetailsDialog.AddElement(sTag, sContent);
                            if (sName == "og:title")
                            {
                                TextBox_Title.Text = sContent;
                            }
                            else if (sName == "og:description")
                            {
                                TextBox_Summary.Text = sContent;
                            }
                            else if (sName == "og:image")
                            {
                                TextBox_URLImage.Text = sContent;
                            }
                        }
                    }
                }
                // Process image URL
                this.Text_Info.Text = "Downloading image";
                if (TextBox_URLImage.Text != "")
                {
                    try
                    {
                        string sURLImage = TextBox_URLImage.Text;
                        Image_Sample.Image = LoadPicture(sURLImage);
                        Text_Width.Text = Image_Sample.Image.Width.ToString();
                        Text_Height.Text = Image_Sample.Image.Height.ToString();
                    }
                    catch (Exception)
                    {
                    }
                }
                this.Text_Info.Text = "Completed";

            }
            catch (Exception e)
            {
                string err = e.Message;
                Text_Info.Text = "Error: " + err;
            }

        }

        private async void Button_OK_Click(object sender, EventArgs e)
        {
            this.Text_Info.Text = "Downloading Page";
            TextBox_Title.Text = "";
            TextBox_Summary.Text = "";
            TextBox_URLImage.Text = "";
            Text_Width.Text = "";
            Text_Height.Text = "";
            Image_Sample.Image= null;
            DetailsDialog.ClearLists();
            await DownloadPage(this.TextBox_URLToExtract.Text);
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            DetailsDialog.ShowDialog();
        }
    }
}
