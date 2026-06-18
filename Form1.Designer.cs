namespace WinFormsApp13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            uiTabControlMenu1 = new Sunny.UI.UITabControlMenu();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            tabPage7 = new TabPage();
            imageList1 = new ImageList(components);
            uiLabel1 = new Sunny.UI.UILabel();
            uiTabControlMenu1.SuspendLayout();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // uiTabControlMenu1
            // 
            uiTabControlMenu1.Alignment = TabAlignment.Left;
            uiTabControlMenu1.Controls.Add(tabPage1);
            uiTabControlMenu1.Controls.Add(tabPage2);
            uiTabControlMenu1.Controls.Add(tabPage3);
            uiTabControlMenu1.Controls.Add(tabPage4);
            uiTabControlMenu1.Controls.Add(tabPage5);
            uiTabControlMenu1.Controls.Add(tabPage6);
            uiTabControlMenu1.Controls.Add(tabPage7);
            uiTabControlMenu1.DrawMode = TabDrawMode.OwnerDrawFixed;
            uiTabControlMenu1.Font = new Font("Microsoft Sans Serif", 12F);
            uiTabControlMenu1.Location = new Point(1, 1);
            uiTabControlMenu1.Multiline = true;
            uiTabControlMenu1.Name = "uiTabControlMenu1";
            uiTabControlMenu1.SelectedIndex = 0;
            uiTabControlMenu1.Size = new Size(1423, 774);
            uiTabControlMenu1.SizeMode = TabSizeMode.Fixed;
            uiTabControlMenu1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(201, 0);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1222, 774);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dashboard";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(201, 0);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(1222, 774);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Income";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(201, 0);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1222, 774);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Expenses";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(201, 0);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1222, 774);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Goals";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(uiLabel1);
            tabPage5.Location = new Point(201, 0);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(1222, 774);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Reports";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(201, 0);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(1222, 774);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Account";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            tabPage7.Location = new Point(201, 0);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(1222, 774);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "Logout";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "a-education-icon-education-icon-11553430161bimwyohogu.png");
            imageList1.Images.SetKeyName(1, "2331970.png");
            imageList1.Images.SetKeyName(2, "190190.png");
            imageList1.Images.SetKeyName(3, "food-icon-7.png");
            imageList1.Images.SetKeyName(4, "4599210.png");
            imageList1.Images.SetKeyName(5, "credit-card-bank-icon-png-26.png");
            imageList1.Images.SetKeyName(6, "10149443.png");
            imageList1.Images.SetKeyName(7, "340-3408958_results-icons-results-icon-hd-png-download.png");
            imageList1.Images.SetKeyName(8, "306405.png");
            imageList1.Images.SetKeyName(9, "12489840.png");
            imageList1.Images.SetKeyName(10, "1571098.png");
            // 
            // uiLabel1
            // 
            uiLabel1.BackColor = Color.RoyalBlue;
            uiLabel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(3, 0);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(1219, 83);
            uiLabel1.TabIndex = 0;
            uiLabel1.Text = "REPORT";
            uiLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1424, 773);
            Controls.Add(uiTabControlMenu1);
            Name = "Form1";
            Text = "Form1";
            uiTabControlMenu1.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITabControlMenu uiTabControlMenu1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private Sunny.UI.UILabel uiLabel1;
        private ImageList imageList1;
    }
}
