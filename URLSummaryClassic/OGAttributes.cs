using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace URLSummaryClassic
{
    public partial class OGAttributes : Form
    {
        public OGAttributes()
        {
            InitializeComponent();
        }

        private void OGAttributes_Load(object sender, EventArgs e)
        {
        }

        public void ClearLists()
        {
            this.listViewElements.Items.Clear();
            this.textBoxDetail.Clear();
        }

        public void AddElement(string sTag, string sValue)
        {
            ListViewItem NewItem = new ListViewItem();
            NewItem.Text = sTag;
            NewItem.SubItems.Add(sValue);
            listViewElements.Items.Add(NewItem);
        }

        private void listViewElements_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxDetail.Clear();
            foreach (ListViewItem item in listViewElements.SelectedItems)
            {
                textBoxDetail.Text = item.SubItems[1].Text;
            }
        }
    }
}
