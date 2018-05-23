namespace TKCD_Save_Editor
{
    partial class TKCD_Save_Editor
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TKCD_Save_Editor));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.openItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutLabel = new System.Windows.Forms.LinkLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.resourceGroup = new System.Windows.Forms.GroupBox();
            this.rareShardBox = new System.Windows.Forms.NumericUpDown();
            this.lightShardBox = new System.Windows.Forms.NumericUpDown();
            this.waterShardBox = new System.Windows.Forms.NumericUpDown();
            this.fireShardBox = new System.Windows.Forms.NumericUpDown();
            this.boughtBox = new System.Windows.Forms.NumericUpDown();
            this.appleBox = new System.Windows.Forms.NumericUpDown();
            this.rareShardLabel = new System.Windows.Forms.Label();
            this.lightShardLabel = new System.Windows.Forms.Label();
            this.waterShardLebel = new System.Windows.Forms.Label();
            this.fireShardLebel = new System.Windows.Forms.Label();
            this.boughtLabel = new System.Windows.Forms.Label();
            this.appleLabel = new System.Windows.Forms.Label();
            this.lastMissionLabel = new System.Windows.Forms.Label();
            this.profileBox = new System.Windows.Forms.GroupBox();
            this.vigourBox = new System.Windows.Forms.NumericUpDown();
            this.vigourLabel = new System.Windows.Forms.Label();
            this.expBox = new System.Windows.Forms.NumericUpDown();
            this.multiBox = new System.Windows.Forms.NumericUpDown();
            this.encounterBox = new System.Windows.Forms.NumericUpDown();
            this.secLabel1 = new System.Windows.Forms.Label();
            this.timeBox = new System.Windows.Forms.NumericUpDown();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.expLabel = new System.Windows.Forms.Label();
            this.multiLabel = new System.Windows.Forms.Label();
            this.encounterLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.missionGroup = new System.Windows.Forms.GroupBox();
            this.missionStatusLabel = new System.Windows.Forms.Label();
            this.missionStatusBox = new System.Windows.Forms.ComboBox();
            this.secLabel2 = new System.Windows.Forms.Label();
            this.bestTimeBox = new System.Windows.Forms.NumericUpDown();
            this.medalBox = new System.Windows.Forms.ComboBox();
            this.scoreBox = new System.Windows.Forms.NumericUpDown();
            this.missionBox = new System.Windows.Forms.ComboBox();
            this.bestTimeLabel = new System.Windows.Forms.Label();
            this.medalLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.missionLabel = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.resourceGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rareShardBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightShardBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterShardBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireShardBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boughtBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appleBox)).BeginInit();
            this.profileBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vigourBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.encounterBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeBox)).BeginInit();
            this.missionGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bestTimeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.DereferenceLinks = false;
            this.openFileDialog.Filter = "存档文件|*.dat|所有文件|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "存档文件|*.dat|所有文件|*.*";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openItem,
            this.saveItem,
            this.aboutItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(584, 25);
            this.menuStrip.TabIndex = 0;
            // 
            // openItem
            // 
            this.openItem.Name = "openItem";
            this.openItem.Size = new System.Drawing.Size(90, 21);
            this.openItem.Text = "打开文件 (&O)";
            this.openItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // saveItem
            // 
            this.saveItem.Enabled = false;
            this.saveItem.Name = "saveItem";
            this.saveItem.Size = new System.Drawing.Size(87, 21);
            this.saveItem.Text = "保存文件 (&S)";
            this.saveItem.Click += new System.EventHandler(this.SaveFile);
            // 
            // aboutItem
            // 
            this.aboutItem.Name = "aboutItem";
            this.aboutItem.Size = new System.Drawing.Size(64, 21);
            this.aboutItem.Text = "关于 (&A)";
            this.aboutItem.Click += new System.EventHandler(this.AboutClick);
            // 
            // aboutLabel
            // 
            this.aboutLabel.AccessibleName = "";
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.aboutLabel.Location = new System.Drawing.Point(498, 413);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(80, 17);
            this.aboutLabel.TabIndex = 4;
            this.aboutLabel.TabStop = true;
            this.aboutLabel.Text = "制作：Xzonn";
            this.aboutLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AboutClick);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 439);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(584, 22);
            this.statusStrip.TabIndex = 14;
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(104, 17);
            this.statusLabel.Text = "未打开存档文件。";
            // 
            // resourceGroup
            // 
            this.resourceGroup.Controls.Add(this.rareShardBox);
            this.resourceGroup.Controls.Add(this.lightShardBox);
            this.resourceGroup.Controls.Add(this.waterShardBox);
            this.resourceGroup.Controls.Add(this.fireShardBox);
            this.resourceGroup.Controls.Add(this.boughtBox);
            this.resourceGroup.Controls.Add(this.appleBox);
            this.resourceGroup.Controls.Add(this.rareShardLabel);
            this.resourceGroup.Controls.Add(this.lightShardLabel);
            this.resourceGroup.Controls.Add(this.waterShardLebel);
            this.resourceGroup.Controls.Add(this.fireShardLebel);
            this.resourceGroup.Controls.Add(this.boughtLabel);
            this.resourceGroup.Controls.Add(this.appleLabel);
            this.resourceGroup.Enabled = false;
            this.resourceGroup.Location = new System.Drawing.Point(9, 211);
            this.resourceGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resourceGroup.Name = "resourceGroup";
            this.resourceGroup.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resourceGroup.Size = new System.Drawing.Size(263, 197);
            this.resourceGroup.TabIndex = 1;
            this.resourceGroup.TabStop = false;
            this.resourceGroup.Text = "资源";
            // 
            // rareShardBox
            // 
            this.rareShardBox.Location = new System.Drawing.Point(94, 164);
            this.rareShardBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.rareShardBox.Name = "rareShardBox";
            this.rareShardBox.Size = new System.Drawing.Size(163, 23);
            this.rareShardBox.TabIndex = 13;
            // 
            // lightShardBox
            // 
            this.lightShardBox.Location = new System.Drawing.Point(94, 135);
            this.lightShardBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.lightShardBox.Name = "lightShardBox";
            this.lightShardBox.Size = new System.Drawing.Size(163, 23);
            this.lightShardBox.TabIndex = 12;
            // 
            // waterShardBox
            // 
            this.waterShardBox.Location = new System.Drawing.Point(94, 106);
            this.waterShardBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.waterShardBox.Name = "waterShardBox";
            this.waterShardBox.Size = new System.Drawing.Size(163, 23);
            this.waterShardBox.TabIndex = 11;
            // 
            // fireShardBox
            // 
            this.fireShardBox.Location = new System.Drawing.Point(94, 77);
            this.fireShardBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.fireShardBox.Name = "fireShardBox";
            this.fireShardBox.Size = new System.Drawing.Size(163, 23);
            this.fireShardBox.TabIndex = 10;
            // 
            // boughtBox
            // 
            this.boughtBox.Location = new System.Drawing.Point(94, 48);
            this.boughtBox.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.boughtBox.Name = "boughtBox";
            this.boughtBox.Size = new System.Drawing.Size(163, 23);
            this.boughtBox.TabIndex = 9;
            // 
            // appleBox
            // 
            this.appleBox.Location = new System.Drawing.Point(94, 19);
            this.appleBox.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.appleBox.Name = "appleBox";
            this.appleBox.Size = new System.Drawing.Size(163, 23);
            this.appleBox.TabIndex = 8;
            // 
            // rareShardLabel
            // 
            this.rareShardLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rareShardLabel.Location = new System.Drawing.Point(9, 164);
            this.rareShardLabel.Name = "rareShardLabel";
            this.rareShardLabel.Size = new System.Drawing.Size(80, 23);
            this.rareShardLabel.TabIndex = 7;
            this.rareShardLabel.Text = "稀有碎片：";
            this.rareShardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lightShardLabel
            // 
            this.lightShardLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.lightShardLabel.Location = new System.Drawing.Point(9, 135);
            this.lightShardLabel.Name = "lightShardLabel";
            this.lightShardLabel.Size = new System.Drawing.Size(80, 23);
            this.lightShardLabel.TabIndex = 6;
            this.lightShardLabel.Text = "光之碎片：";
            this.lightShardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // waterShardLebel
            // 
            this.waterShardLebel.ForeColor = System.Drawing.Color.Blue;
            this.waterShardLebel.Location = new System.Drawing.Point(9, 106);
            this.waterShardLebel.Name = "waterShardLebel";
            this.waterShardLebel.Size = new System.Drawing.Size(80, 23);
            this.waterShardLebel.TabIndex = 5;
            this.waterShardLebel.Text = "水之碎片：";
            this.waterShardLebel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fireShardLebel
            // 
            this.fireShardLebel.ForeColor = System.Drawing.Color.Red;
            this.fireShardLebel.Location = new System.Drawing.Point(9, 77);
            this.fireShardLebel.Name = "fireShardLebel";
            this.fireShardLebel.Size = new System.Drawing.Size(80, 23);
            this.fireShardLebel.TabIndex = 4;
            this.fireShardLebel.Text = "火之碎片：";
            this.fireShardLebel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // boughtLabel
            // 
            this.boughtLabel.Location = new System.Drawing.Point(9, 48);
            this.boughtLabel.Name = "boughtLabel";
            this.boughtLabel.Size = new System.Drawing.Size(80, 23);
            this.boughtLabel.TabIndex = 3;
            this.boughtLabel.Text = "内购数量：";
            this.boughtLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // appleLabel
            // 
            this.appleLabel.Location = new System.Drawing.Point(9, 19);
            this.appleLabel.Name = "appleLabel";
            this.appleLabel.Size = new System.Drawing.Size(80, 23);
            this.appleLabel.TabIndex = 2;
            this.appleLabel.Text = "宝石苹果：";
            this.appleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lastMissionLabel
            // 
            this.lastMissionLabel.Location = new System.Drawing.Point(0, 0);
            this.lastMissionLabel.Name = "lastMissionLabel";
            this.lastMissionLabel.Size = new System.Drawing.Size(100, 23);
            this.lastMissionLabel.TabIndex = 0;
            this.lastMissionLabel.Text = "1-1";
            this.lastMissionLabel.Visible = false;
            // 
            // profileBox
            // 
            this.profileBox.Controls.Add(this.vigourBox);
            this.profileBox.Controls.Add(this.vigourLabel);
            this.profileBox.Controls.Add(this.expBox);
            this.profileBox.Controls.Add(this.multiBox);
            this.profileBox.Controls.Add(this.encounterBox);
            this.profileBox.Controls.Add(this.secLabel1);
            this.profileBox.Controls.Add(this.timeBox);
            this.profileBox.Controls.Add(this.messageBox);
            this.profileBox.Controls.Add(this.expLabel);
            this.profileBox.Controls.Add(this.multiLabel);
            this.profileBox.Controls.Add(this.encounterLabel);
            this.profileBox.Controls.Add(this.timeLabel);
            this.profileBox.Controls.Add(this.messageLabel);
            this.profileBox.Enabled = false;
            this.profileBox.Location = new System.Drawing.Point(315, 29);
            this.profileBox.Name = "profileBox";
            this.profileBox.Size = new System.Drawing.Size(263, 196);
            this.profileBox.TabIndex = 15;
            this.profileBox.TabStop = false;
            this.profileBox.Text = "资料";
            // 
            // vigourBox
            // 
            this.vigourBox.Location = new System.Drawing.Point(94, 165);
            this.vigourBox.Name = "vigourBox";
            this.vigourBox.Size = new System.Drawing.Size(163, 23);
            this.vigourBox.TabIndex = 24;
            // 
            // vigourLabel
            // 
            this.vigourLabel.Location = new System.Drawing.Point(9, 164);
            this.vigourLabel.Name = "vigourLabel";
            this.vigourLabel.Size = new System.Drawing.Size(80, 23);
            this.vigourLabel.TabIndex = 24;
            this.vigourLabel.Text = "活力：";
            this.vigourLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // expBox
            // 
            this.expBox.Location = new System.Drawing.Point(94, 135);
            this.expBox.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.expBox.Name = "expBox";
            this.expBox.Size = new System.Drawing.Size(163, 23);
            this.expBox.TabIndex = 23;
            // 
            // multiBox
            // 
            this.multiBox.Location = new System.Drawing.Point(94, 106);
            this.multiBox.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.multiBox.Name = "multiBox";
            this.multiBox.Size = new System.Drawing.Size(163, 23);
            this.multiBox.TabIndex = 22;
            // 
            // encounterBox
            // 
            this.encounterBox.Location = new System.Drawing.Point(94, 77);
            this.encounterBox.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.encounterBox.Name = "encounterBox";
            this.encounterBox.Size = new System.Drawing.Size(163, 23);
            this.encounterBox.TabIndex = 21;
            // 
            // secLabel1
            // 
            this.secLabel1.Location = new System.Drawing.Point(227, 48);
            this.secLabel1.Name = "secLabel1";
            this.secLabel1.Size = new System.Drawing.Size(30, 23);
            this.secLabel1.TabIndex = 20;
            this.secLabel1.Text = "秒";
            this.secLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeBox
            // 
            this.timeBox.Location = new System.Drawing.Point(94, 48);
            this.timeBox.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(127, 23);
            this.timeBox.TabIndex = 14;
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(94, 19);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(163, 23);
            this.messageBox.TabIndex = 19;
            // 
            // expLabel
            // 
            this.expLabel.Location = new System.Drawing.Point(9, 135);
            this.expLabel.Name = "expLabel";
            this.expLabel.Size = new System.Drawing.Size(80, 23);
            this.expLabel.TabIndex = 18;
            this.expLabel.Text = "经验值：";
            this.expLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // multiLabel
            // 
            this.multiLabel.Location = new System.Drawing.Point(9, 106);
            this.multiLabel.Name = "multiLabel";
            this.multiLabel.Size = new System.Drawing.Size(80, 23);
            this.multiLabel.TabIndex = 17;
            this.multiLabel.Text = "多人对战数：";
            this.multiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // encounterLabel
            // 
            this.encounterLabel.Location = new System.Drawing.Point(9, 77);
            this.encounterLabel.Name = "encounterLabel";
            this.encounterLabel.Size = new System.Drawing.Size(80, 23);
            this.encounterLabel.TabIndex = 16;
            this.encounterLabel.Text = "玩家相遇数：";
            this.encounterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timeLabel
            // 
            this.timeLabel.Location = new System.Drawing.Point(9, 48);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(80, 23);
            this.timeLabel.TabIndex = 15;
            this.timeLabel.Text = "游戏时间：";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // messageLabel
            // 
            this.messageLabel.Location = new System.Drawing.Point(9, 19);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(80, 23);
            this.messageLabel.TabIndex = 14;
            this.messageLabel.Text = "问候语：";
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // missionGroup
            // 
            this.missionGroup.Controls.Add(this.missionStatusLabel);
            this.missionGroup.Controls.Add(this.missionStatusBox);
            this.missionGroup.Controls.Add(this.secLabel2);
            this.missionGroup.Controls.Add(this.bestTimeBox);
            this.missionGroup.Controls.Add(this.medalBox);
            this.missionGroup.Controls.Add(this.scoreBox);
            this.missionGroup.Controls.Add(this.missionBox);
            this.missionGroup.Controls.Add(this.bestTimeLabel);
            this.missionGroup.Controls.Add(this.medalLabel);
            this.missionGroup.Controls.Add(this.scoreLabel);
            this.missionGroup.Controls.Add(this.missionLabel);
            this.missionGroup.Enabled = false;
            this.missionGroup.Location = new System.Drawing.Point(9, 29);
            this.missionGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.missionGroup.Name = "missionGroup";
            this.missionGroup.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.missionGroup.Size = new System.Drawing.Size(263, 174);
            this.missionGroup.TabIndex = 14;
            this.missionGroup.TabStop = false;
            this.missionGroup.Text = "关卡";
            // 
            // missionStatusLabel
            // 
            this.missionStatusLabel.Location = new System.Drawing.Point(6, 140);
            this.missionStatusLabel.Name = "missionStatusLabel";
            this.missionStatusLabel.Size = new System.Drawing.Size(80, 25);
            this.missionStatusLabel.TabIndex = 26;
            this.missionStatusLabel.Text = "状态：";
            this.missionStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // missionStatusBox
            // 
            this.missionStatusBox.FormattingEnabled = true;
            this.missionStatusBox.Items.AddRange(new object[] {
            "隐藏",
            "锁定",
            "未通关",
            "通关",
            "？？？"});
            this.missionStatusBox.Location = new System.Drawing.Point(92, 140);
            this.missionStatusBox.Name = "missionStatusBox";
            this.missionStatusBox.Size = new System.Drawing.Size(163, 25);
            this.missionStatusBox.TabIndex = 25;
            this.missionStatusBox.Text = "隐藏";
            // 
            // secLabel2
            // 
            this.secLabel2.Location = new System.Drawing.Point(227, 111);
            this.secLabel2.Name = "secLabel2";
            this.secLabel2.Size = new System.Drawing.Size(30, 23);
            this.secLabel2.TabIndex = 24;
            this.secLabel2.Text = "秒";
            this.secLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bestTimeBox
            // 
            this.bestTimeBox.DecimalPlaces = 2;
            this.bestTimeBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.bestTimeBox.Location = new System.Drawing.Point(92, 111);
            this.bestTimeBox.Maximum = new decimal(new int[] {
            59999,
            0,
            0,
            131072});
            this.bestTimeBox.Name = "bestTimeBox";
            this.bestTimeBox.Size = new System.Drawing.Size(129, 23);
            this.bestTimeBox.TabIndex = 19;
            // 
            // medalBox
            // 
            this.medalBox.FormattingEnabled = true;
            this.medalBox.Items.AddRange(new object[] {
            "铜",
            "银",
            "金",
            "白金"});
            this.medalBox.Location = new System.Drawing.Point(92, 80);
            this.medalBox.Name = "medalBox";
            this.medalBox.Size = new System.Drawing.Size(163, 25);
            this.medalBox.TabIndex = 18;
            this.medalBox.Text = "铜";
            // 
            // scoreBox
            // 
            this.scoreBox.Location = new System.Drawing.Point(92, 51);
            this.scoreBox.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.Size = new System.Drawing.Size(163, 23);
            this.scoreBox.TabIndex = 14;
            // 
            // missionBox
            // 
            this.missionBox.FormattingEnabled = true;
            this.missionBox.Items.AddRange(new object[] {
            "1-1",
            "1-2",
            "1-3",
            "1-4",
            "1-5",
            "1-6",
            "1-7",
            "1-8",
            "2-1",
            "2-2",
            "2-3",
            "2-4",
            "2-5",
            "2-6",
            "2-7",
            "2-8",
            "3-1",
            "3-2",
            "3-3",
            "3-4",
            "3-5",
            "3-6",
            "3-7",
            "3-8",
            "4-1",
            "4-2",
            "4-3",
            "4-4",
            "4-5",
            "4-6",
            "4-7",
            "5-1",
            "5-2",
            "5-3",
            "5-4",
            "5-5",
            "5-6",
            "6-1",
            "6-2",
            "6-3",
            "6-4",
            "6-5"});
            this.missionBox.Location = new System.Drawing.Point(92, 20);
            this.missionBox.Name = "missionBox";
            this.missionBox.Size = new System.Drawing.Size(163, 25);
            this.missionBox.TabIndex = 17;
            this.missionBox.Text = "1-1";
            this.missionBox.SelectedIndexChanged += new System.EventHandler(this.MissionChange);
            // 
            // bestTimeLabel
            // 
            this.bestTimeLabel.Location = new System.Drawing.Point(6, 111);
            this.bestTimeLabel.Name = "bestTimeLabel";
            this.bestTimeLabel.Size = new System.Drawing.Size(80, 23);
            this.bestTimeLabel.TabIndex = 16;
            this.bestTimeLabel.Text = "最短用时：";
            this.bestTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // medalLabel
            // 
            this.medalLabel.Location = new System.Drawing.Point(6, 80);
            this.medalLabel.Name = "medalLabel";
            this.medalLabel.Size = new System.Drawing.Size(80, 25);
            this.medalLabel.TabIndex = 15;
            this.medalLabel.Text = "奖牌：";
            this.medalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // scoreLabel
            // 
            this.scoreLabel.Location = new System.Drawing.Point(6, 51);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(80, 23);
            this.scoreLabel.TabIndex = 14;
            this.scoreLabel.Text = "最高分：";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // missionLabel
            // 
            this.missionLabel.Location = new System.Drawing.Point(6, 20);
            this.missionLabel.Name = "missionLabel";
            this.missionLabel.Size = new System.Drawing.Size(80, 25);
            this.missionLabel.TabIndex = 14;
            this.missionLabel.Text = "关卡：";
            this.missionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TKCD_Save_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.missionGroup);
            this.Controls.Add(this.profileBox);
            this.Controls.Add(this.lastMissionLabel);
            this.Controls.Add(this.aboutLabel);
            this.Controls.Add(this.resourceGroup);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "TKCD_Save_Editor";
            this.Text = "大家一起！卡比猎人Ｚ 存档修改器";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.resourceGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rareShardBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightShardBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterShardBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireShardBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boughtBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appleBox)).EndInit();
            this.profileBox.ResumeLayout(false);
            this.profileBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vigourBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.encounterBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeBox)).EndInit();
            this.missionGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bestTimeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem openItem;
        private System.Windows.Forms.ToolStripMenuItem saveItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.GroupBox resourceGroup;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.LinkLabel aboutLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutItem;
        private System.Windows.Forms.Label appleLabel;
        private System.Windows.Forms.Label lastMissionLabel;
        private System.Windows.Forms.NumericUpDown appleBox;
        private System.Windows.Forms.Label rareShardLabel;
        private System.Windows.Forms.Label lightShardLabel;
        private System.Windows.Forms.Label waterShardLebel;
        private System.Windows.Forms.Label fireShardLebel;
        private System.Windows.Forms.Label boughtLabel;
        private System.Windows.Forms.NumericUpDown rareShardBox;
        private System.Windows.Forms.NumericUpDown lightShardBox;
        private System.Windows.Forms.NumericUpDown waterShardBox;
        private System.Windows.Forms.NumericUpDown fireShardBox;
        private System.Windows.Forms.NumericUpDown boughtBox;
        private System.Windows.Forms.GroupBox profileBox;
        private System.Windows.Forms.NumericUpDown expBox;
        private System.Windows.Forms.NumericUpDown multiBox;
        private System.Windows.Forms.NumericUpDown encounterBox;
        private System.Windows.Forms.Label secLabel1;
        private System.Windows.Forms.NumericUpDown timeBox;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Label expLabel;
        private System.Windows.Forms.Label multiLabel;
        private System.Windows.Forms.Label encounterLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.GroupBox missionGroup;
        private System.Windows.Forms.Label secLabel2;
        private System.Windows.Forms.NumericUpDown bestTimeBox;
        private System.Windows.Forms.ComboBox medalBox;
        private System.Windows.Forms.NumericUpDown scoreBox;
        private System.Windows.Forms.ComboBox missionBox;
        private System.Windows.Forms.Label bestTimeLabel;
        private System.Windows.Forms.Label medalLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label missionLabel;
        private System.Windows.Forms.Label missionStatusLabel;
        private System.Windows.Forms.ComboBox missionStatusBox;
        private System.Windows.Forms.Label vigourLabel;
        private System.Windows.Forms.NumericUpDown vigourBox;
    }
}

