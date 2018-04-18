namespace URLSummaryClassic
{
    partial class FormURLExtractor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormURLExtractor));
            this.TextBox_URLToExtract = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_OK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_Title = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_Summary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Image_Sample = new System.Windows.Forms.PictureBox();
            this.Text_Info = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBox_URLImage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Text_Width = new System.Windows.Forms.Label();
            this.Text_Height = new System.Windows.Forms.Label();
            this.buttonShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Image_Sample)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox_URLToExtract
            // 
            this.TextBox_URLToExtract.Location = new System.Drawing.Point(111, 50);
            this.TextBox_URLToExtract.Name = "TextBox_URLToExtract";
            this.TextBox_URLToExtract.Size = new System.Drawing.Size(709, 26);
            this.TextBox_URLToExtract.TabIndex = 0;
            this.TextBox_URLToExtract.Text = "https://github.com/academicfanton/URLSummaryClassic";
            this.TextBox_URLToExtract.TextChanged += new System.EventHandler(this.TextBox_URLToExtract_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL:";
            // 
            // Button_OK
            // 
            this.Button_OK.Location = new System.Drawing.Point(870, 46);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(91, 35);
            this.Button_OK.TabIndex = 2;
            this.Button_OK.Text = "&Retrieve";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Title:";
            // 
            // TextBox_Title
            // 
            this.TextBox_Title.Location = new System.Drawing.Point(111, 87);
            this.TextBox_Title.Name = "TextBox_Title";
            this.TextBox_Title.Size = new System.Drawing.Size(709, 26);
            this.TextBox_Title.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Description:";
            // 
            // TextBox_Summary
            // 
            this.TextBox_Summary.Location = new System.Drawing.Point(111, 122);
            this.TextBox_Summary.Multiline = true;
            this.TextBox_Summary.Name = "TextBox_Summary";
            this.TextBox_Summary.Size = new System.Drawing.Size(709, 163);
            this.TextBox_Summary.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Image:";
            // 
            // Image_Sample
            // 
            this.Image_Sample.Location = new System.Drawing.Point(111, 352);
            this.Image_Sample.Name = "Image_Sample";
            this.Image_Sample.Size = new System.Drawing.Size(709, 506);
            this.Image_Sample.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Image_Sample.TabIndex = 8;
            this.Image_Sample.TabStop = false;
            // 
            // Text_Info
            // 
            this.Text_Info.AutoSize = true;
            this.Text_Info.Location = new System.Drawing.Point(107, 9);
            this.Text_Info.Name = "Text_Info";
            this.Text_Info.Size = new System.Drawing.Size(17, 20);
            this.Text_Info.TabIndex = 9;
            this.Text_Info.Text = "..";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Img URL:";
            // 
            // TextBox_URLImage
            // 
            this.TextBox_URLImage.Location = new System.Drawing.Point(111, 300);
            this.TextBox_URLImage.Name = "TextBox_URLImage";
            this.TextBox_URLImage.Size = new System.Drawing.Size(709, 26);
            this.TextBox_URLImage.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(848, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Width:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(848, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Height:";
            // 
            // Text_Width
            // 
            this.Text_Width.AutoSize = true;
            this.Text_Width.Location = new System.Drawing.Point(914, 352);
            this.Text_Width.Name = "Text_Width";
            this.Text_Width.Size = new System.Drawing.Size(18, 20);
            this.Text_Width.TabIndex = 15;
            this.Text_Width.Text = "0";
            // 
            // Text_Height
            // 
            this.Text_Height.AutoSize = true;
            this.Text_Height.Location = new System.Drawing.Point(914, 372);
            this.Text_Height.Name = "Text_Height";
            this.Text_Height.Size = new System.Drawing.Size(18, 20);
            this.Text_Height.TabIndex = 16;
            this.Text_Height.Text = "0";
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(870, 103);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(91, 35);
            this.buttonShow.TabIndex = 17;
            this.buttonShow.Text = "&Show";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // FormURLExtractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 880);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.Text_Height);
            this.Controls.Add(this.Text_Width);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBox_URLImage);
            this.Controls.Add(this.Text_Info);
            this.Controls.Add(this.Image_Sample);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBox_Summary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBox_Title);
            this.Controls.Add(this.Button_OK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox_URLToExtract);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormURLExtractor";
            this.Text = "URL Extractor";
            ((System.ComponentModel.ISupportInitialize)(this.Image_Sample)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_URLToExtract;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_OK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox_Title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBox_Summary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox Image_Sample;
        private System.Windows.Forms.Label Text_Info;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBox_URLImage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Text_Width;
        private System.Windows.Forms.Label Text_Height;
        private System.Windows.Forms.Button buttonShow;
    }
}

