﻿namespace ATAY_webcam_image_processing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            dIPToolStripMenuItem = new ToolStripMenuItem();
            pixelCopyToolStripMenuItem = new ToolStripMenuItem();
            greyscaleToolStripMenuItem = new ToolStripMenuItem();
            inversionToolStripMenuItem = new ToolStripMenuItem();
            histogramToolStripMenuItem = new ToolStripMenuItem();
            sepiaToolStripMenuItem = new ToolStripMenuItem();
            gaucianBlurToolStripMenuItem = new ToolStripMenuItem();
            sharpenToolStripMenuItem = new ToolStripMenuItem();
            meanRemovalToolStripMenuItem = new ToolStripMenuItem();
            embossingToolStripMenuItem = new ToolStripMenuItem();
            LaplascianToolStripMenuItem = new ToolStripMenuItem();
            horzVertToolStripMenuItem = new ToolStripMenuItem();
            allDirectionsToolStripMenuItem = new ToolStripMenuItem();
            lossyToolStripMenuItem = new ToolStripMenuItem();
            horizontalOnlyToolStripMenuItem = new ToolStripMenuItem();
            verticalOnlyToolStripMenuItem = new ToolStripMenuItem();
            activateCameraToolStripMenuItem = new ToolStripMenuItem();
            deactivateCameraToolStripMenuItem = new ToolStripMenuItem();
            cameraToolStripMenuItem = new ToolStripMenuItem();
            greyscaleToolStripMenuItem1 = new ToolStripMenuItem();
            PixelCopyStripMenuItem1 = new ToolStripMenuItem();
            inversionToolStripMenuItem1 = new ToolStripMenuItem();
            histogramToolStripMenuItem1 = new ToolStripMenuItem();
            sepiaToolStripMenuItem1 = new ToolStripMenuItem();
            countCoinsToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            PicBox_Input = new PictureBox();
            PicBox_Output = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            Btn_LoadImage = new Button();
            btn_Subtract = new Button();
            txtBox_Report = new TextBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicBox_Input).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBox_Output).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, dIPToolStripMenuItem, activateCameraToolStripMenuItem, deactivateCameraToolStripMenuItem, cameraToolStripMenuItem, countCoinsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1498, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(158, 34);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(158, 34);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // dIPToolStripMenuItem
            // 
            dIPToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pixelCopyToolStripMenuItem, greyscaleToolStripMenuItem, inversionToolStripMenuItem, histogramToolStripMenuItem, sepiaToolStripMenuItem, gaucianBlurToolStripMenuItem, sharpenToolStripMenuItem, meanRemovalToolStripMenuItem, embossingToolStripMenuItem });
            dIPToolStripMenuItem.Name = "dIPToolStripMenuItem";
            dIPToolStripMenuItem.Size = new Size(56, 29);
            dIPToolStripMenuItem.Text = "DIP";
            // 
            // pixelCopyToolStripMenuItem
            // 
            pixelCopyToolStripMenuItem.Name = "pixelCopyToolStripMenuItem";
            pixelCopyToolStripMenuItem.Size = new Size(231, 34);
            pixelCopyToolStripMenuItem.Text = "Pixel Copy";
            pixelCopyToolStripMenuItem.Click += pixelCopyToolStripMenuItem_Click;
            // 
            // greyscaleToolStripMenuItem
            // 
            greyscaleToolStripMenuItem.Name = "greyscaleToolStripMenuItem";
            greyscaleToolStripMenuItem.Size = new Size(231, 34);
            greyscaleToolStripMenuItem.Text = "Greyscale";
            greyscaleToolStripMenuItem.Click += greyscaleToolStripMenuItem_Click;
            // 
            // inversionToolStripMenuItem
            // 
            inversionToolStripMenuItem.Name = "inversionToolStripMenuItem";
            inversionToolStripMenuItem.Size = new Size(231, 34);
            inversionToolStripMenuItem.Text = "Inversion";
            inversionToolStripMenuItem.Click += inversionToolStripMenuItem_Click;
            // 
            // histogramToolStripMenuItem
            // 
            histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            histogramToolStripMenuItem.Size = new Size(231, 34);
            histogramToolStripMenuItem.Text = "Histogram";
            histogramToolStripMenuItem.Click += histogramToolStripMenuItem_Click_1;
            // 
            // sepiaToolStripMenuItem
            // 
            sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            sepiaToolStripMenuItem.Size = new Size(231, 34);
            sepiaToolStripMenuItem.Text = "Sepia";
            sepiaToolStripMenuItem.Click += sepiaToolStripMenuItem_Click;
            // 
            // gaucianBlurToolStripMenuItem
            // 
            gaucianBlurToolStripMenuItem.Name = "gaucianBlurToolStripMenuItem";
            gaucianBlurToolStripMenuItem.Size = new Size(231, 34);
            gaucianBlurToolStripMenuItem.Text = "Gaussian Blur";
            gaucianBlurToolStripMenuItem.Click += gaucianBlurToolStripMenuItem_Click;
            // 
            // sharpenToolStripMenuItem
            // 
            sharpenToolStripMenuItem.Name = "sharpenToolStripMenuItem";
            sharpenToolStripMenuItem.Size = new Size(231, 34);
            sharpenToolStripMenuItem.Text = "Sharpen";
            sharpenToolStripMenuItem.Click += sharpenToolStripMenuItem_Click;
            // 
            // meanRemovalToolStripMenuItem
            // 
            meanRemovalToolStripMenuItem.Name = "meanRemovalToolStripMenuItem";
            meanRemovalToolStripMenuItem.Size = new Size(231, 34);
            meanRemovalToolStripMenuItem.Text = "Mean Removal";
            meanRemovalToolStripMenuItem.Click += meanRemovalToolStripMenuItem_Click;
            // 
            // embossingToolStripMenuItem
            // 
            embossingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { LaplascianToolStripMenuItem, horzVertToolStripMenuItem, allDirectionsToolStripMenuItem, lossyToolStripMenuItem, horizontalOnlyToolStripMenuItem, verticalOnlyToolStripMenuItem });
            embossingToolStripMenuItem.Name = "embossingToolStripMenuItem";
            embossingToolStripMenuItem.Size = new Size(231, 34);
            embossingToolStripMenuItem.Text = "Embossing";
            // 
            // LaplascianToolStripMenuItem
            // 
            LaplascianToolStripMenuItem.Name = "LaplascianToolStripMenuItem";
            LaplascianToolStripMenuItem.Size = new Size(238, 34);
            LaplascianToolStripMenuItem.Text = "Laplascian";
            LaplascianToolStripMenuItem.Click += LaplascianToolStripMenuItem_Click;
            // 
            // horzVertToolStripMenuItem
            // 
            horzVertToolStripMenuItem.Name = "horzVertToolStripMenuItem";
            horzVertToolStripMenuItem.Size = new Size(238, 34);
            horzVertToolStripMenuItem.Text = "Horz/Vert";
            horzVertToolStripMenuItem.Click += horzVertToolStripMenuItem_Click;
            // 
            // allDirectionsToolStripMenuItem
            // 
            allDirectionsToolStripMenuItem.Name = "allDirectionsToolStripMenuItem";
            allDirectionsToolStripMenuItem.Size = new Size(238, 34);
            allDirectionsToolStripMenuItem.Text = "All Directions";
            allDirectionsToolStripMenuItem.Click += allDirectionsToolStripMenuItem_Click;
            // 
            // lossyToolStripMenuItem
            // 
            lossyToolStripMenuItem.Name = "lossyToolStripMenuItem";
            lossyToolStripMenuItem.Size = new Size(238, 34);
            lossyToolStripMenuItem.Text = "Lossy";
            lossyToolStripMenuItem.Click += lossyToolStripMenuItem_Click;
            // 
            // horizontalOnlyToolStripMenuItem
            // 
            horizontalOnlyToolStripMenuItem.Name = "horizontalOnlyToolStripMenuItem";
            horizontalOnlyToolStripMenuItem.Size = new Size(238, 34);
            horizontalOnlyToolStripMenuItem.Text = "Horizontal Only";
            horizontalOnlyToolStripMenuItem.Click += horizontalOnlyToolStripMenuItem_Click;
            // 
            // verticalOnlyToolStripMenuItem
            // 
            verticalOnlyToolStripMenuItem.Name = "verticalOnlyToolStripMenuItem";
            verticalOnlyToolStripMenuItem.Size = new Size(238, 34);
            verticalOnlyToolStripMenuItem.Text = "Vertical Only";
            verticalOnlyToolStripMenuItem.Click += verticalOnlyToolStripMenuItem_Click;
            // 
            // activateCameraToolStripMenuItem
            // 
            activateCameraToolStripMenuItem.Name = "activateCameraToolStripMenuItem";
            activateCameraToolStripMenuItem.Size = new Size(156, 29);
            activateCameraToolStripMenuItem.Text = "Activate Camera";
            activateCameraToolStripMenuItem.Click += activateCameraToolStripMenuItem_Click;
            // 
            // deactivateCameraToolStripMenuItem
            // 
            deactivateCameraToolStripMenuItem.Name = "deactivateCameraToolStripMenuItem";
            deactivateCameraToolStripMenuItem.Size = new Size(175, 29);
            deactivateCameraToolStripMenuItem.Text = "Deactivate Camera";
            deactivateCameraToolStripMenuItem.Click += deactivateCameraToolStripMenuItem_Click;
            // 
            // cameraToolStripMenuItem
            // 
            cameraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { greyscaleToolStripMenuItem1, PixelCopyStripMenuItem1, inversionToolStripMenuItem1, histogramToolStripMenuItem1, sepiaToolStripMenuItem1 });
            cameraToolStripMenuItem.Name = "cameraToolStripMenuItem";
            cameraToolStripMenuItem.Size = new Size(88, 29);
            cameraToolStripMenuItem.Text = "Camera";
            // 
            // greyscaleToolStripMenuItem1
            // 
            greyscaleToolStripMenuItem1.Name = "greyscaleToolStripMenuItem1";
            greyscaleToolStripMenuItem1.Size = new Size(198, 34);
            greyscaleToolStripMenuItem1.Text = "Pixel Copy";
            greyscaleToolStripMenuItem1.Click += greyscaleToolStripMenuItem1_Click_1;
            // 
            // PixelCopyStripMenuItem1
            // 
            PixelCopyStripMenuItem1.Name = "PixelCopyStripMenuItem1";
            PixelCopyStripMenuItem1.Size = new Size(198, 34);
            PixelCopyStripMenuItem1.Text = "Greyscale";
            PixelCopyStripMenuItem1.Click += greyscaleToolStripMenuItem1_Click;
            // 
            // inversionToolStripMenuItem1
            // 
            inversionToolStripMenuItem1.Name = "inversionToolStripMenuItem1";
            inversionToolStripMenuItem1.Size = new Size(198, 34);
            inversionToolStripMenuItem1.Text = "Inversion";
            inversionToolStripMenuItem1.Click += inversionToolStripMenuItem1_Click;
            // 
            // histogramToolStripMenuItem1
            // 
            histogramToolStripMenuItem1.Name = "histogramToolStripMenuItem1";
            histogramToolStripMenuItem1.Size = new Size(198, 34);
            histogramToolStripMenuItem1.Text = "Histogram";
            histogramToolStripMenuItem1.Click += histogramToolStripMenuItem1_Click;
            // 
            // sepiaToolStripMenuItem1
            // 
            sepiaToolStripMenuItem1.Name = "sepiaToolStripMenuItem1";
            sepiaToolStripMenuItem1.Size = new Size(198, 34);
            sepiaToolStripMenuItem1.Text = "Sepia";
            sepiaToolStripMenuItem1.Click += sepiaToolStripMenuItem1_Click;
            // 
            // countCoinsToolStripMenuItem
            // 
            countCoinsToolStripMenuItem.Name = "countCoinsToolStripMenuItem";
            countCoinsToolStripMenuItem.Size = new Size(125, 29);
            countCoinsToolStripMenuItem.Text = "Count Coins";
            countCoinsToolStripMenuItem.Click += countCoinsToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk_1;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // PicBox_Input
            // 
            PicBox_Input.Location = new Point(12, 95);
            PicBox_Input.Name = "PicBox_Input";
            PicBox_Input.Size = new Size(680, 702);
            PicBox_Input.SizeMode = PictureBoxSizeMode.StretchImage;
            PicBox_Input.TabIndex = 1;
            PicBox_Input.TabStop = false;
            // 
            // PicBox_Output
            // 
            PicBox_Output.Location = new Point(806, 95);
            PicBox_Output.Name = "PicBox_Output";
            PicBox_Output.Size = new Size(680, 702);
            PicBox_Output.SizeMode = PictureBoxSizeMode.StretchImage;
            PicBox_Output.TabIndex = 2;
            PicBox_Output.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // Btn_LoadImage
            // 
            Btn_LoadImage.Location = new Point(985, 809);
            Btn_LoadImage.Name = "Btn_LoadImage";
            Btn_LoadImage.Size = new Size(151, 34);
            Btn_LoadImage.TabIndex = 3;
            Btn_LoadImage.Text = "Load Image";
            Btn_LoadImage.UseVisualStyleBackColor = true;
            Btn_LoadImage.Click += Btn_LoadImage_Click;
            // 
            // btn_Subtract
            // 
            btn_Subtract.Location = new Point(1258, 809);
            btn_Subtract.Name = "btn_Subtract";
            btn_Subtract.Size = new Size(112, 34);
            btn_Subtract.TabIndex = 4;
            btn_Subtract.Text = "Subtract";
            btn_Subtract.UseVisualStyleBackColor = true;
            btn_Subtract.Click += btn_Subtract_Click;
            // 
            // txtBox_Report
            // 
            txtBox_Report.Location = new Point(698, 195);
            txtBox_Report.Multiline = true;
            txtBox_Report.Name = "txtBox_Report";
            txtBox_Report.ReadOnly = true;
            txtBox_Report.ScrollBars = ScrollBars.Vertical;
            txtBox_Report.Size = new Size(105, 369);
            txtBox_Report.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1498, 855);
            Controls.Add(txtBox_Report);
            Controls.Add(btn_Subtract);
            Controls.Add(Btn_LoadImage);
            Controls.Add(PicBox_Output);
            Controls.Add(PicBox_Input);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicBox_Input).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBox_Output).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem dIPToolStripMenuItem;
        private ToolStripMenuItem pixelCopyToolStripMenuItem;
        private ToolStripMenuItem greyscaleToolStripMenuItem;
        private ToolStripMenuItem inversionToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private PictureBox PicBox_Input;
        private PictureBox PicBox_Output;
        private ToolStripMenuItem histogramToolStripMenuItem;
        private ToolStripMenuItem sepiaToolStripMenuItem;
        private ToolStripMenuItem activateCameraToolStripMenuItem;
        private ToolStripMenuItem deactivateCameraToolStripMenuItem;
        private ToolStripMenuItem cameraToolStripMenuItem;
        private ToolStripMenuItem PixelCopyStripMenuItem1;
        private ToolStripMenuItem greyscaleToolStripMenuItem1;
        private ToolStripMenuItem inversionToolStripMenuItem1;
        private ToolStripMenuItem histogramToolStripMenuItem1;
        private ToolStripMenuItem sepiaToolStripMenuItem1;
        private System.Windows.Forms.Timer timer1;
        private Button Btn_LoadImage;
        private Button btn_Subtract;
        private ToolStripMenuItem gaucianBlurToolStripMenuItem;
        private ToolStripMenuItem sharpenToolStripMenuItem;
        private ToolStripMenuItem meanRemovalToolStripMenuItem;
        private ToolStripMenuItem embossingToolStripMenuItem;
        private ToolStripMenuItem LaplascianToolStripMenuItem;
        private ToolStripMenuItem horzVertToolStripMenuItem;
        private ToolStripMenuItem allDirectionsToolStripMenuItem;
        private ToolStripMenuItem lossyToolStripMenuItem;
        private ToolStripMenuItem horizontalOnlyToolStripMenuItem;
        private ToolStripMenuItem verticalOnlyToolStripMenuItem;
        private TextBox txtBox_Report;
        private ToolStripMenuItem countCoinsToolStripMenuItem;
    }
}
