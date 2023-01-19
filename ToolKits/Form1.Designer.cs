namespace ToolKits
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ImageFolderPath = new System.Windows.Forms.Button();
            this.ImageFolderPathTxt = new System.Windows.Forms.TextBox();
            this.NumDirBox = new System.Windows.Forms.NumericUpDown();
            this.FramePerDirTxt = new System.Windows.Forms.TextBox();
            this.TotalImagesInFolderTxt = new System.Windows.Forms.TextBox();
            this.BtnCopyRename = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OutPutImgTxt = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.FileNameListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FileNameDestinationListBox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnLoadFileOutPut = new System.Windows.Forms.Button();
            this.BtnClearOutPut = new System.Windows.Forms.Button();
            this.BtnOpenBatchPhoto = new System.Windows.Forms.Button();
            this.BtnOpenSprViewer = new System.Windows.Forms.Button();
            this.BtnOpenSprTool = new System.Windows.Forms.Button();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.BatchPhotoPathTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumDirBox)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImageFolderPath
            // 
            this.ImageFolderPath.Location = new System.Drawing.Point(12, 12);
            this.ImageFolderPath.Name = "ImageFolderPath";
            this.ImageFolderPath.Size = new System.Drawing.Size(70, 24);
            this.ImageFolderPath.TabIndex = 0;
            this.ImageFolderPath.Text = "Browse";
            this.ImageFolderPath.UseVisualStyleBackColor = true;
            this.ImageFolderPath.Click += new System.EventHandler(this.ImageFolderPath_Click);
            // 
            // ImageFolderPathTxt
            // 
            this.ImageFolderPathTxt.Location = new System.Drawing.Point(88, 12);
            this.ImageFolderPathTxt.Name = "ImageFolderPathTxt";
            this.ImageFolderPathTxt.Size = new System.Drawing.Size(113, 20);
            this.ImageFolderPathTxt.TabIndex = 1;
            this.ImageFolderPathTxt.Text = "D:\\2025\\ngua_KT\\rs01";
            this.ImageFolderPathTxt.TextChanged += new System.EventHandler(this.ImageFolderPathTxt_TextChanged);
            // 
            // NumDirBox
            // 
            this.NumDirBox.Location = new System.Drawing.Point(185, 42);
            this.NumDirBox.Name = "NumDirBox";
            this.NumDirBox.Size = new System.Drawing.Size(44, 20);
            this.NumDirBox.TabIndex = 3;
            this.NumDirBox.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // FramePerDirTxt
            // 
            this.FramePerDirTxt.Location = new System.Drawing.Point(203, 68);
            this.FramePerDirTxt.Name = "FramePerDirTxt";
            this.FramePerDirTxt.Size = new System.Drawing.Size(26, 20);
            this.FramePerDirTxt.TabIndex = 5;
            this.FramePerDirTxt.Text = "12";
            // 
            // TotalImagesInFolderTxt
            // 
            this.TotalImagesInFolderTxt.Location = new System.Drawing.Point(207, 12);
            this.TotalImagesInFolderTxt.Name = "TotalImagesInFolderTxt";
            this.TotalImagesInFolderTxt.ReadOnly = true;
            this.TotalImagesInFolderTxt.Size = new System.Drawing.Size(29, 20);
            this.TotalImagesInFolderTxt.TabIndex = 2;
            this.TotalImagesInFolderTxt.Text = "0";
            this.TotalImagesInFolderTxt.TextChanged += new System.EventHandler(this.TotalImagesInFolderTxt_TextChanged);
            // 
            // BtnCopyRename
            // 
            this.BtnCopyRename.Location = new System.Drawing.Point(149, 217);
            this.BtnCopyRename.Name = "BtnCopyRename";
            this.BtnCopyRename.Size = new System.Drawing.Size(110, 24);
            this.BtnCopyRename.TabIndex = 9;
            this.BtnCopyRename.Text = "Chép và đổi tên";
            this.BtnCopyRename.UseVisualStyleBackColor = true;
            this.BtnCopyRename.Click += new System.EventHandler(this.BtnCopyRename_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Số hướng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Frame/hướng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Images";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Đường dẫn Output";
            // 
            // OutPutImgTxt
            // 
            this.OutPutImgTxt.Location = new System.Drawing.Point(129, 107);
            this.OutPutImgTxt.Name = "OutPutImgTxt";
            this.OutPutImgTxt.Size = new System.Drawing.Size(154, 20);
            this.OutPutImgTxt.TabIndex = 16;
            this.OutPutImgTxt.Text = "D:\\2025\\chep\\";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripSplitButton2,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 336);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(300, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(97, 17);
            this.toolStripStatusLabel1.Text = "@ Jackie Gaming";
            // 
            // FileNameListBox
            // 
            this.FileNameListBox.FormattingEnabled = true;
            this.FileNameListBox.Location = new System.Drawing.Point(15, 58);
            this.FileNameListBox.Name = "FileNameListBox";
            this.FileNameListBox.Size = new System.Drawing.Size(105, 108);
            this.FileNameListBox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Danh sách file nguồn";
            // 
            // FileNameDestinationListBox
            // 
            this.FileNameDestinationListBox.FormattingEnabled = true;
            this.FileNameDestinationListBox.Location = new System.Drawing.Point(15, 188);
            this.FileNameDestinationListBox.Name = "FileNameDestinationListBox";
            this.FileNameDestinationListBox.Size = new System.Drawing.Size(105, 108);
            this.FileNameDestinationListBox.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Danh sách file đích";
            // 
            // BtnLoadFileOutPut
            // 
            this.BtnLoadFileOutPut.Location = new System.Drawing.Point(15, 302);
            this.BtnLoadFileOutPut.Name = "BtnLoadFileOutPut";
            this.BtnLoadFileOutPut.Size = new System.Drawing.Size(51, 23);
            this.BtnLoadFileOutPut.TabIndex = 23;
            this.BtnLoadFileOutPut.Text = "Load";
            this.BtnLoadFileOutPut.UseVisualStyleBackColor = true;
            this.BtnLoadFileOutPut.Click += new System.EventHandler(this.BtnLoadFileOutPut_Click);
            // 
            // BtnClearOutPut
            // 
            this.BtnClearOutPut.Location = new System.Drawing.Point(72, 302);
            this.BtnClearOutPut.Name = "BtnClearOutPut";
            this.BtnClearOutPut.Size = new System.Drawing.Size(48, 23);
            this.BtnClearOutPut.TabIndex = 24;
            this.BtnClearOutPut.Text = "Clear";
            this.BtnClearOutPut.UseVisualStyleBackColor = true;
            this.BtnClearOutPut.Click += new System.EventHandler(this.BtnClearOutPut_Click);
            // 
            // BtnOpenBatchPhoto
            // 
            this.BtnOpenBatchPhoto.Location = new System.Drawing.Point(149, 247);
            this.BtnOpenBatchPhoto.Name = "BtnOpenBatchPhoto";
            this.BtnOpenBatchPhoto.Size = new System.Drawing.Size(110, 23);
            this.BtnOpenBatchPhoto.TabIndex = 27;
            this.BtnOpenBatchPhoto.Text = "Batch Photo";
            this.BtnOpenBatchPhoto.UseVisualStyleBackColor = true;
            this.BtnOpenBatchPhoto.Click += new System.EventHandler(this.BtnOpenBatchPhoto_Click);
            // 
            // BtnOpenSprViewer
            // 
            this.BtnOpenSprViewer.Location = new System.Drawing.Point(149, 188);
            this.BtnOpenSprViewer.Name = "BtnOpenSprViewer";
            this.BtnOpenSprViewer.Size = new System.Drawing.Size(110, 23);
            this.BtnOpenSprViewer.TabIndex = 28;
            this.BtnOpenSprViewer.Text = "Jx Spr Viewer";
            this.BtnOpenSprViewer.UseVisualStyleBackColor = true;
            this.BtnOpenSprViewer.Click += new System.EventHandler(this.BtnOpenSprViewer_Click);
            // 
            // BtnOpenSprTool
            // 
            this.BtnOpenSprTool.Location = new System.Drawing.Point(149, 276);
            this.BtnOpenSprTool.Name = "BtnOpenSprTool";
            this.BtnOpenSprTool.Size = new System.Drawing.Size(110, 23);
            this.BtnOpenSprTool.TabIndex = 29;
            this.BtnOpenSprTool.Text = "Spr Tool Convert";
            this.BtnOpenSprTool.UseVisualStyleBackColor = true;
            this.BtnOpenSprTool.Click += new System.EventHandler(this.BtnOpenSprTool_Click);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton2.Text = "toolStripSplitButton2";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel2.Text = "   ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Đường dẫn Batch Photo";
            // 
            // BatchPhotoPathTxt
            // 
            this.BatchPhotoPathTxt.Location = new System.Drawing.Point(129, 151);
            this.BatchPhotoPathTxt.Name = "BatchPhotoPathTxt";
            this.BatchPhotoPathTxt.Size = new System.Drawing.Size(154, 20);
            this.BatchPhotoPathTxt.TabIndex = 31;
            this.BatchPhotoPathTxt.Text = "C:\\Program Files (x86)\\BatchPhoto\\BatchPhoto.exe";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 358);
            this.Controls.Add(this.BatchPhotoPathTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnOpenSprTool);
            this.Controls.Add(this.BtnOpenSprViewer);
            this.Controls.Add(this.BtnOpenBatchPhoto);
            this.Controls.Add(this.BtnClearOutPut);
            this.Controls.Add(this.BtnLoadFileOutPut);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FileNameDestinationListBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FileNameListBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.OutPutImgTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnCopyRename);
            this.Controls.Add(this.TotalImagesInFolderTxt);
            this.Controls.Add(this.FramePerDirTxt);
            this.Controls.Add(this.NumDirBox);
            this.Controls.Add(this.ImageFolderPathTxt);
            this.Controls.Add(this.ImageFolderPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "ToolKits Converts 96 to 112 images";
            ((System.ComponentModel.ISupportInitialize)(this.NumDirBox)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ImageFolderPath;
        private System.Windows.Forms.TextBox ImageFolderPathTxt;
        private System.Windows.Forms.NumericUpDown NumDirBox;
        private System.Windows.Forms.TextBox FramePerDirTxt;
        private System.Windows.Forms.TextBox TotalImagesInFolderTxt;
        private System.Windows.Forms.Button BtnCopyRename;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox OutPutImgTxt;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ListBox FileNameListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox FileNameDestinationListBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnLoadFileOutPut;
        private System.Windows.Forms.Button BtnClearOutPut;
        private System.Windows.Forms.Button BtnOpenBatchPhoto;
        private System.Windows.Forms.Button BtnOpenSprViewer;
        private System.Windows.Forms.Button BtnOpenSprTool;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BatchPhotoPathTxt;
    }
}

