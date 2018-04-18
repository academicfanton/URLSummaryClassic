namespace URLSummaryClassic
{
    partial class OGAttributes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OGAttributes));
            this.listViewElements = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxDetail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listViewElements
            // 
            this.listViewElements.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewElements.FullRowSelect = true;
            this.listViewElements.GridLines = true;
            this.listViewElements.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewElements.Location = new System.Drawing.Point(13, 13);
            this.listViewElements.MultiSelect = false;
            this.listViewElements.Name = "listViewElements";
            this.listViewElements.Size = new System.Drawing.Size(775, 246);
            this.listViewElements.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewElements.TabIndex = 0;
            this.listViewElements.UseCompatibleStateImageBehavior = false;
            this.listViewElements.View = System.Windows.Forms.View.Details;
            this.listViewElements.SelectedIndexChanged += new System.EventHandler(this.listViewElements_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Attribute";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 620;
            // 
            // textBoxDetail
            // 
            this.textBoxDetail.Location = new System.Drawing.Point(13, 281);
            this.textBoxDetail.Multiline = true;
            this.textBoxDetail.Name = "textBoxDetail";
            this.textBoxDetail.Size = new System.Drawing.Size(775, 157);
            this.textBoxDetail.TabIndex = 1;
            // 
            // OGAttributes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxDetail);
            this.Controls.Add(this.listViewElements);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OGAttributes";
            this.Text = "OGAttributes";
            this.Load += new System.EventHandler(this.OGAttributes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewElements;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox textBoxDetail;
    }
}