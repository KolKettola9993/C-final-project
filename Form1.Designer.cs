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
            uiLabel1 = new Sunny.UI.UILabel();
            tabPage6 = new TabPage();
            tabPage7 = new TabPage();
            imageList1 = new ImageList(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            progressBar1 = new ProgressBar();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            label8 = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            label9 = new Label();
            uiTabControlMenu1.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            uiTabControlMenu1.Margin = new Padding(2, 2, 2, 2);
            uiTabControlMenu1.Multiline = true;
            uiTabControlMenu1.Name = "uiTabControlMenu1";
            uiTabControlMenu1.SelectedIndex = 0;
            uiTabControlMenu1.Size = new Size(1138, 619);
            uiTabControlMenu1.SizeMode = TabSizeMode.Fixed;
            uiTabControlMenu1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(201, 0);
            tabPage1.Margin = new Padding(2, 2, 2, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(937, 619);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dashboard";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(201, 0);
            tabPage2.Margin = new Padding(2, 2, 2, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(937, 619);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Income";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(201, 0);
            tabPage3.Margin = new Padding(2, 2, 2, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(937, 619);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Expenses";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label9);
            tabPage4.Controls.Add(label8);
            tabPage4.Controls.Add(label7);
            tabPage4.Controls.Add(dataGridView1);
            tabPage4.Controls.Add(button4);
            tabPage4.Controls.Add(button3);
            tabPage4.Controls.Add(button2);
            tabPage4.Controls.Add(button1);
            tabPage4.Controls.Add(progressBar1);
            tabPage4.Controls.Add(textBox4);
            tabPage4.Controls.Add(textBox3);
            tabPage4.Controls.Add(textBox2);
            tabPage4.Controls.Add(textBox1);
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(label5);
            tabPage4.Controls.Add(label4);
            tabPage4.Controls.Add(label3);
            tabPage4.Controls.Add(label2);
            tabPage4.Controls.Add(label1);
            tabPage4.Location = new Point(201, 0);
            tabPage4.Margin = new Padding(2, 2, 2, 2);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(937, 619);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Goals";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(uiLabel1);
            tabPage5.Location = new Point(201, 0);
            tabPage5.Margin = new Padding(2, 2, 2, 2);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(937, 619);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Reports";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // uiLabel1
            // 
            uiLabel1.BackColor = Color.RoyalBlue;
            uiLabel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(2, 0);
            uiLabel1.Margin = new Padding(2, 0, 2, 0);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(975, 66);
            uiLabel1.TabIndex = 0;
            uiLabel1.Text = "REPORT";
            uiLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(201, 0);
            tabPage6.Margin = new Padding(2, 2, 2, 2);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(937, 619);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Account";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            tabPage7.Location = new Point(201, 0);
            tabPage7.Margin = new Padding(2, 2, 2, 2);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(937, 619);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 192);
            label1.ImageKey = "(none)";
            label1.ImageList = imageList1;
            label1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label1.Location = new Point(16, 8);
            label1.Name = "label1";
            label1.Size = new Size(167, 35);
            label1.TabIndex = 0;
            label1.Text = "Saving Goal";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 91);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 1;
            label2.Text = "Goal ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 125);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 2;
            label3.Text = "Goal Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 162);
            label4.Name = "label4";
            label4.Size = new Size(142, 25);
            label4.TabIndex = 3;
            label4.Text = "Target Amount";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 198);
            label5.Name = "label5";
            label5.Size = new Size(142, 25);
            label5.TabIndex = 4;
            label5.Text = "Saved Amount";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 233);
            label6.Name = "label6";
            label6.Size = new Size(90, 25);
            label6.TabIndex = 5;
            label6.Text = "Progress";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(166, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(361, 30);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(166, 127);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(361, 30);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(166, 163);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(361, 30);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(166, 198);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(361, 30);
            textBox4.TabIndex = 9;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(166, 234);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(361, 24);
            progressBar1.TabIndex = 10;
            progressBar1.Click += progressBar1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(26, 289);
            button1.Name = "button1";
            button1.Size = new Size(134, 53);
            button1.TabIndex = 11;
            button1.Text = "INSERT";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkBlue;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(166, 289);
            button2.Name = "button2";
            button2.Size = new Size(134, 53);
            button2.TabIndex = 12;
            button2.Text = "UPDATE";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(306, 289);
            button3.Name = "button3";
            button3.Size = new Size(134, 53);
            button3.TabIndex = 13;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Aqua;
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(446, 289);
            button4.Name = "button4";
            button4.Size = new Size(134, 53);
            button4.TabIndex = 14;
            button4.Text = "CLEAR";
            button4.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(26, 378);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(734, 241);
            dataGridView1.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 345);
            label7.Name = "label7";
            label7.Size = new Size(129, 25);
            label7.TabIndex = 16;
            label7.Text = "Goald History";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(533, 234);
            label8.Name = "label8";
            label8.Size = new Size(30, 25);
            label8.TabIndex = 17;
            label8.Text = "%";
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 30;
            // 
            // Column2
            // 
            Column2.HeaderText = "Goal Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "Target";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // Column4
            // 
            Column4.HeaderText = "Saved";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Progress";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Cursor = Cursors.IBeam;
            label9.FlatStyle = FlatStyle.Popup;
            label9.Location = new Point(336, 24);
            label9.Name = "label9";
            label9.Size = new Size(0, 25);
            label9.TabIndex = 18;
            label9.UseMnemonic = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 618);
            Controls.Add(uiTabControlMenu1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            uiTabControlMenu1.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private ProgressBar progressBar1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private DataGridView dataGridView1;
        private Button button4;
        private Label label8;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Label label9;
    }
}
