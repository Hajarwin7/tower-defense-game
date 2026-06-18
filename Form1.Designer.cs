namespace TowerDefense
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.topPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSkor = new System.Windows.Forms.Label();
            this.lblDalga = new System.Windows.Forms.Label();
            this.lblCan = new System.Windows.Forms.Label();
            this.lblAltin = new System.Windows.Forms.Label();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.pnlLazer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLazerCost = new System.Windows.Forms.Label();
            this.lblLazer = new System.Windows.Forms.Label();
            this.pbLazer = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblTopCost = new System.Windows.Forms.Label();
            this.lblTopName = new System.Windows.Forms.Label();
            this.picTop = new System.Windows.Forms.PictureBox();
            this.panelBuyu = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblBuyuCost = new System.Windows.Forms.Label();
            this.lblBuyuName = new System.Windows.Forms.Label();
            this.picBuyu = new System.Windows.Forms.PictureBox();
            this.pnlOkKulesi = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblOkPrice = new System.Windows.Forms.Label();
            this.lblOkName = new System.Windows.Forms.Label();
            this.picOk = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblWaveMessage = new System.Windows.Forms.Label();
            this.waveMessageTimer = new System.Windows.Forms.Timer(this.components);
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GamePanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.pnlLazer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLazer)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTop)).BeginInit();
            this.panelBuyu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuyu)).BeginInit();
            this.pnlOkKulesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOk)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.AccessibleName = "";
            this.topPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.topPanel.Controls.Add(this.pictureBox3);
            this.topPanel.Controls.Add(this.pictureBox2);
            this.topPanel.Controls.Add(this.pictureBox1);
            this.topPanel.Controls.Add(this.lblSkor);
            this.topPanel.Controls.Add(this.lblDalga);
            this.topPanel.Controls.Add(this.lblCan);
            this.topPanel.Controls.Add(this.lblAltin);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1465, 63);
            this.topPanel.TabIndex = 0;
            this.topPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topPanel_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(46, 12);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TowerDefense.Properties.Resources.ScoreIcon;
            this.pictureBox2.Location = new System.Drawing.Point(952, 6);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TowerDefense.Properties.Resources.HeartIcon;
            this.pictureBox1.Location = new System.Drawing.Point(282, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkor.ForeColor = System.Drawing.Color.White;
            this.lblSkor.Location = new System.Drawing.Point(994, 12);
            this.lblSkor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(106, 37);
            this.lblSkor.TabIndex = 3;
            this.lblSkor.Text = "Skor: 0";
            // 
            // lblDalga
            // 
            this.lblDalga.AutoSize = true;
            this.lblDalga.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDalga.ForeColor = System.Drawing.Color.White;
            this.lblDalga.Location = new System.Drawing.Point(518, 12);
            this.lblDalga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDalga.Name = "lblDalga";
            this.lblDalga.Size = new System.Drawing.Size(150, 37);
            this.lblDalga.TabIndex = 2;
            this.lblDalga.Text = "Dalga: 1/5";
            // 
            // lblCan
            // 
            this.lblCan.AutoSize = true;
            this.lblCan.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCan.ForeColor = System.Drawing.Color.White;
            this.lblCan.Location = new System.Drawing.Point(336, 12);
            this.lblCan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCan.Name = "lblCan";
            this.lblCan.Size = new System.Drawing.Size(111, 37);
            this.lblCan.TabIndex = 1;
            this.lblCan.Text = "Can: 20";
            // 
            // lblAltin
            // 
            this.lblAltin.AutoSize = true;
            this.lblAltin.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltin.ForeColor = System.Drawing.Color.White;
            this.lblAltin.Location = new System.Drawing.Point(100, 12);
            this.lblAltin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAltin.Name = "lblAltin";
            this.lblAltin.Size = new System.Drawing.Size(109, 37);
            this.lblAltin.TabIndex = 0;
            this.lblAltin.Text = "Altın: 0";
            // 
            // GamePanel
            // 
            this.GamePanel.BackColor = System.Drawing.Color.Honeydew;
            this.GamePanel.Controls.Add(this.lblWaveMessage);
            this.GamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GamePanel.Location = new System.Drawing.Point(0, 63);
            this.GamePanel.Margin = new System.Windows.Forms.Padding(4);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(1465, 729);
            this.GamePanel.TabIndex = 1;
            this.GamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.GamePanel_Paint);
            this.GamePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GamePanel_MouseClick);
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.bottomPanel.Controls.Add(this.pnlLazer);
            this.bottomPanel.Controls.Add(this.panelTop);
            this.bottomPanel.Controls.Add(this.panelBuyu);
            this.bottomPanel.Controls.Add(this.pnlOkKulesi);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.bottomPanel.Location = new System.Drawing.Point(0, 692);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(4);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1465, 100);
            this.bottomPanel.TabIndex = 2;
            // 
            // pnlLazer
            // 
            this.pnlLazer.BackColor = System.Drawing.Color.White;
            this.pnlLazer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLazer.Controls.Add(this.label1);
            this.pnlLazer.Controls.Add(this.lblLazerCost);
            this.pnlLazer.Controls.Add(this.lblLazer);
            this.pnlLazer.Controls.Add(this.pbLazer);
            this.pnlLazer.Enabled = false;
            this.pnlLazer.Location = new System.Drawing.Point(934, 8);
            this.pnlLazer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLazer.Name = "pnlLazer";
            this.pnlLazer.Size = new System.Drawing.Size(156, 73);
            this.pnlLazer.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(58, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Soon";
            // 
            // lblLazerCost
            // 
            this.lblLazerCost.AutoSize = true;
            this.lblLazerCost.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLazerCost.Location = new System.Drawing.Point(48, 38);
            this.lblLazerCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLazerCost.Name = "lblLazerCost";
            this.lblLazerCost.Size = new System.Drawing.Size(0, 30);
            this.lblLazerCost.TabIndex = 2;
            this.lblLazerCost.Click += new System.EventHandler(this.lblLazerCost_Click);
            // 
            // lblLazer
            // 
            this.lblLazer.AutoSize = true;
            this.lblLazer.BackColor = System.Drawing.Color.Transparent;
            this.lblLazer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLazer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLazer.Location = new System.Drawing.Point(60, 4);
            this.lblLazer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLazer.Name = "lblLazer";
            this.lblLazer.Size = new System.Drawing.Size(74, 32);
            this.lblLazer.TabIndex = 1;
            this.lblLazer.Text = "Lazer";
            // 
            // pbLazer
            // 
            this.pbLazer.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.pbLazer.Location = new System.Drawing.Point(16, 6);
            this.pbLazer.Margin = new System.Windows.Forms.Padding(4);
            this.pbLazer.Name = "pbLazer";
            this.pbLazer.Size = new System.Drawing.Size(36, 62);
            this.pbLazer.TabIndex = 0;
            this.pbLazer.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTop.Controls.Add(this.pictureBox6);
            this.panelTop.Controls.Add(this.lblTopCost);
            this.panelTop.Controls.Add(this.lblTopName);
            this.panelTop.Controls.Add(this.picTop);
            this.panelTop.Location = new System.Drawing.Point(648, 8);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(156, 73);
            this.panelTop.TabIndex = 2;
            this.toolTip1.SetToolTip(this.panelTop, "Top Kulesi\r\nDamage: 50\r\nRange: 120\r\nArea Damage\r\nFire Rate: 3s\r\nUpgradable\r\n+Dama" +
        "ge\r\n+ Range\r\n\r\n\r\n\r\n");
            this.panelTop.Click += new System.EventHandler(this.pnlTopKulesi_Click);
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_Paint);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(110, 31);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(40, 42);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 3;
            this.pictureBox6.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox6, "Top Kulesi\r\nDamage: 50\r\nRange: 120\r\nArea Damage\r\nFire Rate: 3s\r\nUpgradable\r\n+ Dam" +
        "age\r\n+ Range\r\n\r\n\r\n");
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // lblTopCost
            // 
            this.lblTopCost.AutoSize = true;
            this.lblTopCost.BackColor = System.Drawing.Color.Transparent;
            this.lblTopCost.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopCost.Location = new System.Drawing.Point(66, 38);
            this.lblTopCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTopCost.Name = "lblTopCost";
            this.lblTopCost.Size = new System.Drawing.Size(46, 30);
            this.lblTopCost.TabIndex = 2;
            this.lblTopCost.Text = "250";
            this.toolTip1.SetToolTip(this.lblTopCost, "Top Kulesi\r\nDamage: 50\r\nRange: 120\r\nArea Damage\r\nFire Rate: 3s\r\n\r\n");
            this.lblTopCost.Click += new System.EventHandler(this.lblTopCost_Click);
            // 
            // lblTopName
            // 
            this.lblTopName.AutoSize = true;
            this.lblTopName.BackColor = System.Drawing.Color.Transparent;
            this.lblTopName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTopName.Location = new System.Drawing.Point(76, 4);
            this.lblTopName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTopName.Name = "lblTopName";
            this.lblTopName.Size = new System.Drawing.Size(56, 32);
            this.lblTopName.TabIndex = 1;
            this.lblTopName.Text = "Top";
            this.toolTip1.SetToolTip(this.lblTopName, "Top Kulesi\r\nDamage: 50\r\nRange: 120\r\nArea Damage\r\nFire Rate: 3s\r\n\r\n");
            this.lblTopName.Click += new System.EventHandler(this.lblTopName_Click);
            // 
            // picTop
            // 
            this.picTop.BackColor = System.Drawing.Color.Transparent;
            this.picTop.Image = global::TowerDefense.Properties.Resources.TopKulesi;
            this.picTop.Location = new System.Drawing.Point(-2, -2);
            this.picTop.Margin = new System.Windows.Forms.Padding(4);
            this.picTop.Name = "picTop";
            this.picTop.Size = new System.Drawing.Size(60, 77);
            this.picTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTop.TabIndex = 0;
            this.picTop.TabStop = false;
            this.toolTip1.SetToolTip(this.picTop, "Top Kulesi\r\nDamage: 50\r\nRange: 120\r\nArea Damage\r\nFire Rate: 3s\r\nUpgradable\r\n+Dama" +
        "ge\r\n+ Range\r\n\r\n\r\n");
            this.picTop.Click += new System.EventHandler(this.picTop_Click);
            // 
            // panelBuyu
            // 
            this.panelBuyu.BackColor = System.Drawing.Color.White;
            this.panelBuyu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBuyu.Controls.Add(this.pictureBox5);
            this.panelBuyu.Controls.Add(this.lblBuyuCost);
            this.panelBuyu.Controls.Add(this.lblBuyuName);
            this.panelBuyu.Controls.Add(this.picBuyu);
            this.panelBuyu.Location = new System.Drawing.Point(344, 8);
            this.panelBuyu.Margin = new System.Windows.Forms.Padding(4);
            this.panelBuyu.Name = "panelBuyu";
            this.panelBuyu.Size = new System.Drawing.Size(156, 73);
            this.panelBuyu.TabIndex = 1;
            this.toolTip1.SetToolTip(this.panelBuyu, "Buyu Kulesi\r\nDamage: 25\r\nRange: 130\r\nHits: Up to 5 enemies\r\nFire Rate: 1.5s\r\n\r\n");
            this.panelBuyu.Click += new System.EventHandler(this.pnlBuyuKulesi_Click);
            this.panelBuyu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBuyu_Paint);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(108, 31);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 42);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox5, "Buyu Kulesi\r\nDamage: 25\r\nRange: 130\r\nHits: Up to 5 enemies\r\nFire Rate: 1.5s\r\n\r\n");
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // lblBuyuCost
            // 
            this.lblBuyuCost.AutoSize = true;
            this.lblBuyuCost.BackColor = System.Drawing.Color.Transparent;
            this.lblBuyuCost.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyuCost.Location = new System.Drawing.Point(56, 38);
            this.lblBuyuCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuyuCost.Name = "lblBuyuCost";
            this.lblBuyuCost.Size = new System.Drawing.Size(46, 30);
            this.lblBuyuCost.TabIndex = 2;
            this.lblBuyuCost.Text = "200";
            this.toolTip1.SetToolTip(this.lblBuyuCost, "Buyu Kulesi\r\nDamage: 25\r\nRange: 130\r\nHits: Up to 5 enemies\r\nFire Rate: 1.5s\r\n\r\n");
            this.lblBuyuCost.Click += new System.EventHandler(this.lblBuyuCost_Click);
            // 
            // lblBuyuName
            // 
            this.lblBuyuName.AutoSize = true;
            this.lblBuyuName.BackColor = System.Drawing.Color.Transparent;
            this.lblBuyuName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyuName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBuyuName.Location = new System.Drawing.Point(60, 4);
            this.lblBuyuName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuyuName.Name = "lblBuyuName";
            this.lblBuyuName.Size = new System.Drawing.Size(72, 32);
            this.lblBuyuName.TabIndex = 1;
            this.lblBuyuName.Text = "Büyü";
            this.toolTip1.SetToolTip(this.lblBuyuName, "Buyu Kulesi\r\nDamage: 25\r\nRange: 130\r\nHits: Up to 5 enemies\r\nFire Rate: 1.5s\r\n\r\n");
            this.lblBuyuName.Click += new System.EventHandler(this.lblBuyuName_Click);
            // 
            // picBuyu
            // 
            this.picBuyu.BackColor = System.Drawing.Color.Transparent;
            this.picBuyu.Image = global::TowerDefense.Properties.Resources.BuyuKulesi;
            this.picBuyu.Location = new System.Drawing.Point(-2, -2);
            this.picBuyu.Margin = new System.Windows.Forms.Padding(4);
            this.picBuyu.Name = "picBuyu";
            this.picBuyu.Size = new System.Drawing.Size(60, 77);
            this.picBuyu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBuyu.TabIndex = 0;
            this.picBuyu.TabStop = false;
            this.toolTip1.SetToolTip(this.picBuyu, "Buyu Kulesi\r\nDamage: 25\r\nRange: 130\r\nHits: Up to 5 enemies\r\nFire Rate: 1.5s\r\n");
            this.picBuyu.WaitOnLoad = true;
            this.picBuyu.Click += new System.EventHandler(this.picBuyu_Click);
            // 
            // pnlOkKulesi
            // 
            this.pnlOkKulesi.BackColor = System.Drawing.Color.White;
            this.pnlOkKulesi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlOkKulesi.Controls.Add(this.pictureBox4);
            this.pnlOkKulesi.Controls.Add(this.lblOkPrice);
            this.pnlOkKulesi.Controls.Add(this.lblOkName);
            this.pnlOkKulesi.Controls.Add(this.picOk);
            this.pnlOkKulesi.Location = new System.Drawing.Point(46, 8);
            this.pnlOkKulesi.Margin = new System.Windows.Forms.Padding(4);
            this.pnlOkKulesi.Name = "pnlOkKulesi";
            this.pnlOkKulesi.Size = new System.Drawing.Size(156, 73);
            this.pnlOkKulesi.TabIndex = 0;
            this.toolTip1.SetToolTip(this.pnlOkKulesi, "Ok Kulesi\r\nDamage: 15\r\nRange: 150\r\nFire Rate: 1s\r\nUpgradable\r\nCost: 50 \r\nIncrease" +
        "s Damage + Range");
            this.pnlOkKulesi.Click += new System.EventHandler(this.pnlOkKulesi_Click);
            this.pnlOkKulesi.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlOkKulesi_Paint);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(110, 31);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 42);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox4, "Ok Kulesi\r\nDamage: 15\r\nRange: 150\r\nFire Rate: 1s\r\nUpgradable\r\nCost: 50 Gold\r\nIncr" +
        "eases Damage + Range");
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // lblOkPrice
            // 
            this.lblOkPrice.AutoSize = true;
            this.lblOkPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblOkPrice.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOkPrice.Location = new System.Drawing.Point(66, 38);
            this.lblOkPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOkPrice.Name = "lblOkPrice";
            this.lblOkPrice.Size = new System.Drawing.Size(52, 30);
            this.lblOkPrice.TabIndex = 2;
            this.lblOkPrice.Text = "100 ";
            this.toolTip1.SetToolTip(this.lblOkPrice, "Ok Kulesi\r\nDamage: 15\r\nRange: 150\r\nFire Rate: 1s\r\n");
            this.lblOkPrice.Click += new System.EventHandler(this.lblOkPrice_Click);
            // 
            // lblOkName
            // 
            this.lblOkName.AutoSize = true;
            this.lblOkName.BackColor = System.Drawing.Color.Transparent;
            this.lblOkName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOkName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblOkName.Location = new System.Drawing.Point(66, 6);
            this.lblOkName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOkName.Name = "lblOkName";
            this.lblOkName.Size = new System.Drawing.Size(45, 32);
            this.lblOkName.TabIndex = 1;
            this.lblOkName.Text = "Ok";
            this.toolTip1.SetToolTip(this.lblOkName, "Ok Kulesi\r\nDamage: 15\r\nRange: 150\r\nFire Rate: 1s\r\n\r\n");
            this.lblOkName.Click += new System.EventHandler(this.lblOkName_Click);
            // 
            // picOk
            // 
            this.picOk.BackColor = System.Drawing.Color.Transparent;
            this.picOk.Image = global::TowerDefense.Properties.Resources.OkKulesi;
            this.picOk.Location = new System.Drawing.Point(-2, -4);
            this.picOk.Margin = new System.Windows.Forms.Padding(4);
            this.picOk.Name = "picOk";
            this.picOk.Size = new System.Drawing.Size(60, 77);
            this.picOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOk.TabIndex = 0;
            this.picOk.TabStop = false;
            this.toolTip1.SetToolTip(this.picOk, "Ok Kulesi\r\nDamage: 15\r\nRange: 150\r\nFire Rate: 1s\r\n");
            this.picOk.Click += new System.EventHandler(this.picOk_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 30;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // lblWaveMessage
            // 
            this.lblWaveMessage.BackColor = System.Drawing.Color.SeaGreen;
            this.lblWaveMessage.ForeColor = System.Drawing.Color.White;
            this.lblWaveMessage.Location = new System.Drawing.Point(643, 44);
            this.lblWaveMessage.Name = "lblWaveMessage";
            this.lblWaveMessage.Size = new System.Drawing.Size(341, 83);
            this.lblWaveMessage.TabIndex = 0;
            this.lblWaveMessage.Text = "DALGA";
            this.lblWaveMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWaveMessage.Visible = false;
            this.lblWaveMessage.Click += new System.EventHandler(this.lblWaveMessage_Click);
            // 
            // waveMessageTimer
            // 
            this.waveMessageTimer.Interval = 2000;
            this.waveMessageTimer.Tick += new System.EventHandler(this.waveMessageTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 792);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.GamePanel);
            this.Controls.Add(this.topPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GamePanel.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.pnlLazer.ResumeLayout(false);
            this.pnlLazer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLazer)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTop)).EndInit();
            this.panelBuyu.ResumeLayout(false);
            this.panelBuyu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuyu)).EndInit();
            this.pnlOkKulesi.ResumeLayout(false);
            this.pnlOkKulesi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Label lblAltin;
        private System.Windows.Forms.Label lblCan;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Label lblDalga;
        private System.Windows.Forms.Panel pnlOkKulesi;
        private System.Windows.Forms.Label lblOkName;
        private System.Windows.Forms.PictureBox picOk;
        private System.Windows.Forms.Label lblOkPrice;
        private System.Windows.Forms.Panel panelBuyu;
        private System.Windows.Forms.PictureBox picBuyu;
        private System.Windows.Forms.Label lblBuyuCost;
        private System.Windows.Forms.Label lblBuyuName;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTopName;
        private System.Windows.Forms.PictureBox picTop;
        private System.Windows.Forms.Label lblTopCost;
        private System.Windows.Forms.Panel pnlLazer;
        private System.Windows.Forms.Label lblLazer;
        private System.Windows.Forms.PictureBox pbLazer;
        private System.Windows.Forms.Label lblLazerCost;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblWaveMessage;
        private System.Windows.Forms.Timer waveMessageTimer;
    }
}

