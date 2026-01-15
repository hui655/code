namespace EggForm
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button diagReportButton;
        private System.Windows.Forms.Button exportLogButton;
        private System.Windows.Forms.Button plcTestButton;

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
            modbusPanel = new Panel();
            modbusContentPanel = new Panel();
            modbusTimeoutLabel = new Label();
            modbusTimeoutTextBox = new TextBox();
            modbusSlaveIdLabel = new Label();
            modbusSlaveIdTextBox = new TextBox();
            modbusPortLabel = new Label();
            modbusPortTextBox = new TextBox();
            modbusIpLabel = new Label();
            modbusIpTextBox = new TextBox();
            modbusIcon = new FontAwesome.Sharp.IconPictureBox();
            modbusTitleLabel = new Label();
            dlcPanel = new Panel();
            dlcContentPanel = new Panel();
            dlcStopBitsComboBox = new ComboBox();
            dlcStopBitsLabel = new Label();
            dlcDataBitsTextBox = new TextBox();
            dlcDataBitsLabel = new Label();
            dlcParityComboBox = new ComboBox();
            dlcParityLabel = new Label();
            dlcBaudRateTextBox = new TextBox();
            dlcBaudRateLabel = new Label();
            dlcChannelTextBox = new TextBox();
            dlcChannelLabel = new Label();
            dlcIcon = new FontAwesome.Sharp.IconPictureBox();
            dlcTitleLabel = new Label();
            actionPanel = new Panel();
            actionContentPanel = new Panel();
            diagReportButton = new Button();
            exportLogButton = new Button();
            plcTestButton = new Button();
            testButton = new Button();
            saveButton = new Button();
            actionIcon = new FontAwesome.Sharp.IconPictureBox();
            actionTitleLabel = new Label();
            logPanel = new Panel();
            logContentPanel = new Panel();
            logListView = new ListView();
            logTimeColumn = new ColumnHeader();
            logTypeColumn = new ColumnHeader();
            logMessageColumn = new ColumnHeader();
            logIcon = new FontAwesome.Sharp.IconPictureBox();
            logTitleLabel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            modbusPanel.SuspendLayout();
            modbusContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)modbusIcon).BeginInit();
            dlcPanel.SuspendLayout();
            dlcContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dlcIcon).BeginInit();
            actionPanel.SuspendLayout();
            actionContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)actionIcon).BeginInit();
            logPanel.SuspendLayout();
            logContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logIcon).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // modbusPanel
            // 
            modbusPanel.Anchor = AnchorStyles.Left;
            modbusPanel.BackColor = Color.White;
            modbusPanel.Controls.Add(modbusContentPanel);
            modbusPanel.Controls.Add(modbusIcon);
            modbusPanel.Controls.Add(modbusTitleLabel);
            modbusPanel.Location = new Point(4, 16);
            modbusPanel.Margin = new Padding(4);
            modbusPanel.Name = "modbusPanel";
            modbusPanel.Padding = new Padding(12, 14, 12, 14);
            modbusPanel.Size = new Size(383, 332);
            modbusPanel.TabIndex = 0;
            // 
            // modbusContentPanel
            // 
            modbusContentPanel.Controls.Add(modbusTimeoutLabel);
            modbusContentPanel.Controls.Add(modbusTimeoutTextBox);
            modbusContentPanel.Controls.Add(modbusSlaveIdLabel);
            modbusContentPanel.Controls.Add(modbusSlaveIdTextBox);
            modbusContentPanel.Controls.Add(modbusPortLabel);
            modbusContentPanel.Controls.Add(modbusPortTextBox);
            modbusContentPanel.Controls.Add(modbusIpLabel);
            modbusContentPanel.Controls.Add(modbusIpTextBox);
            modbusContentPanel.Location = new Point(19, 84);
            modbusContentPanel.Margin = new Padding(4);
            modbusContentPanel.Name = "modbusContentPanel";
            modbusContentPanel.Size = new Size(337, 218);
            modbusContentPanel.TabIndex = 0;
            // 
            // modbusTimeoutLabel
            // 
            modbusTimeoutLabel.Anchor = AnchorStyles.None;
            modbusTimeoutLabel.AutoSize = true;
            modbusTimeoutLabel.Font = new Font("微软雅黑", 10.5F);
            modbusTimeoutLabel.ForeColor = Color.FromArgb(102, 102, 102);
            modbusTimeoutLabel.Location = new Point(36, 177);
            modbusTimeoutLabel.Margin = new Padding(4, 0, 4, 0);
            modbusTimeoutLabel.Name = "modbusTimeoutLabel";
            modbusTimeoutLabel.Size = new Size(51, 20);
            modbusTimeoutLabel.TabIndex = 7;
            modbusTimeoutLabel.Text = "超时：";
            // 
            // modbusTimeoutTextBox
            // 
            modbusTimeoutTextBox.Anchor = AnchorStyles.None;
            modbusTimeoutTextBox.Font = new Font("微软雅黑", 10.5F);
            modbusTimeoutTextBox.Location = new Point(135, 173);
            modbusTimeoutTextBox.Margin = new Padding(4);
            modbusTimeoutTextBox.Name = "modbusTimeoutTextBox";
            modbusTimeoutTextBox.Size = new Size(174, 26);
            modbusTimeoutTextBox.TabIndex = 8;
            // 
            // modbusSlaveIdLabel
            // 
            modbusSlaveIdLabel.Anchor = AnchorStyles.None;
            modbusSlaveIdLabel.AutoSize = true;
            modbusSlaveIdLabel.Font = new Font("微软雅黑", 10.5F);
            modbusSlaveIdLabel.ForeColor = Color.FromArgb(102, 102, 102);
            modbusSlaveIdLabel.Location = new Point(36, 120);
            modbusSlaveIdLabel.Margin = new Padding(4, 0, 4, 0);
            modbusSlaveIdLabel.Name = "modbusSlaveIdLabel";
            modbusSlaveIdLabel.Size = new Size(79, 20);
            modbusSlaveIdLabel.TabIndex = 5;
            modbusSlaveIdLabel.Text = "从站地址：";
            // 
            // modbusSlaveIdTextBox
            // 
            modbusSlaveIdTextBox.Anchor = AnchorStyles.None;
            modbusSlaveIdTextBox.Font = new Font("微软雅黑", 10.5F);
            modbusSlaveIdTextBox.Location = new Point(135, 116);
            modbusSlaveIdTextBox.Margin = new Padding(4);
            modbusSlaveIdTextBox.Name = "modbusSlaveIdTextBox";
            modbusSlaveIdTextBox.Size = new Size(174, 26);
            modbusSlaveIdTextBox.TabIndex = 6;
            // 
            // modbusPortLabel
            // 
            modbusPortLabel.Anchor = AnchorStyles.None;
            modbusPortLabel.AutoSize = true;
            modbusPortLabel.Font = new Font("微软雅黑", 10.5F);
            modbusPortLabel.ForeColor = Color.FromArgb(102, 102, 102);
            modbusPortLabel.Location = new Point(36, 64);
            modbusPortLabel.Margin = new Padding(4, 0, 4, 0);
            modbusPortLabel.Name = "modbusPortLabel";
            modbusPortLabel.Size = new Size(51, 20);
            modbusPortLabel.TabIndex = 3;
            modbusPortLabel.Text = "端口：";
            // 
            // modbusPortTextBox
            // 
            modbusPortTextBox.Anchor = AnchorStyles.None;
            modbusPortTextBox.Font = new Font("微软雅黑", 10.5F);
            modbusPortTextBox.Location = new Point(135, 60);
            modbusPortTextBox.Margin = new Padding(4);
            modbusPortTextBox.Name = "modbusPortTextBox";
            modbusPortTextBox.Size = new Size(174, 26);
            modbusPortTextBox.TabIndex = 4;
            // 
            // modbusIpLabel
            // 
            modbusIpLabel.Anchor = AnchorStyles.None;
            modbusIpLabel.AutoSize = true;
            modbusIpLabel.Font = new Font("微软雅黑", 10.5F);
            modbusIpLabel.ForeColor = Color.FromArgb(102, 102, 102);
            modbusIpLabel.Location = new Point(36, 7);
            modbusIpLabel.Margin = new Padding(4, 0, 4, 0);
            modbusIpLabel.Name = "modbusIpLabel";
            modbusIpLabel.Size = new Size(36, 20);
            modbusIpLabel.TabIndex = 1;
            modbusIpLabel.Text = "IP：";
            // 
            // modbusIpTextBox
            // 
            modbusIpTextBox.Anchor = AnchorStyles.None;
            modbusIpTextBox.Font = new Font("微软雅黑", 10.5F);
            modbusIpTextBox.Location = new Point(135, 3);
            modbusIpTextBox.Margin = new Padding(4);
            modbusIpTextBox.Name = "modbusIpTextBox";
            modbusIpTextBox.Size = new Size(174, 26);
            modbusIpTextBox.TabIndex = 2;
            // 
            // modbusIcon
            // 
            modbusIcon.BackColor = Color.White;
            modbusIcon.ForeColor = Color.FromArgb(41, 128, 185);
            modbusIcon.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            modbusIcon.IconColor = Color.FromArgb(41, 128, 185);
            modbusIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            modbusIcon.IconSize = 33;
            modbusIcon.Location = new Point(19, 23);
            modbusIcon.Margin = new Padding(4);
            modbusIcon.Name = "modbusIcon";
            modbusIcon.Size = new Size(33, 40);
            modbusIcon.TabIndex = 1;
            modbusIcon.TabStop = false;
            // 
            // modbusTitleLabel
            // 
            modbusTitleLabel.AutoSize = true;
            modbusTitleLabel.Font = new Font("微软雅黑", 13F, FontStyle.Bold);
            modbusTitleLabel.ForeColor = Color.FromArgb(41, 128, 185);
            modbusTitleLabel.Location = new Point(54, 26);
            modbusTitleLabel.Margin = new Padding(4, 0, 4, 0);
            modbusTitleLabel.Name = "modbusTitleLabel";
            modbusTitleLabel.Size = new Size(164, 25);
            modbusTitleLabel.TabIndex = 2;
            modbusTitleLabel.Text = "Modbus TCP配置";
            // 
            // dlcPanel
            // 
            dlcPanel.Anchor = AnchorStyles.Left;
            dlcPanel.BackColor = Color.White;
            dlcPanel.Controls.Add(dlcContentPanel);
            dlcPanel.Controls.Add(dlcIcon);
            dlcPanel.Controls.Add(dlcTitleLabel);
            dlcPanel.Location = new Point(4, 371);
            dlcPanel.Margin = new Padding(4);
            dlcPanel.Name = "dlcPanel";
            dlcPanel.Padding = new Padding(12, 14, 12, 14);
            dlcPanel.Size = new Size(383, 350);
            dlcPanel.TabIndex = 1;
            // 
            // dlcContentPanel
            // 
            dlcContentPanel.Controls.Add(dlcStopBitsComboBox);
            dlcContentPanel.Controls.Add(dlcStopBitsLabel);
            dlcContentPanel.Controls.Add(dlcDataBitsTextBox);
            dlcContentPanel.Controls.Add(dlcDataBitsLabel);
            dlcContentPanel.Controls.Add(dlcParityComboBox);
            dlcContentPanel.Controls.Add(dlcParityLabel);
            dlcContentPanel.Controls.Add(dlcBaudRateTextBox);
            dlcContentPanel.Controls.Add(dlcBaudRateLabel);
            dlcContentPanel.Controls.Add(dlcChannelTextBox);
            dlcContentPanel.Controls.Add(dlcChannelLabel);
            dlcContentPanel.Location = new Point(19, 84);
            dlcContentPanel.Margin = new Padding(4);
            dlcContentPanel.Name = "dlcContentPanel";
            dlcContentPanel.Size = new Size(337, 238);
            dlcContentPanel.TabIndex = 0;
            // 
            // dlcStopBitsComboBox
            // 
            dlcStopBitsComboBox.Anchor = AnchorStyles.None;
            dlcStopBitsComboBox.Font = new Font("微软雅黑", 10.5F);
            dlcStopBitsComboBox.FormattingEnabled = true;
            dlcStopBitsComboBox.Items.AddRange(new object[] { "1", "1.5", "2" });
            dlcStopBitsComboBox.Location = new Point(135, 194);
            dlcStopBitsComboBox.Margin = new Padding(4);
            dlcStopBitsComboBox.Name = "dlcStopBitsComboBox";
            dlcStopBitsComboBox.Size = new Size(174, 28);
            dlcStopBitsComboBox.TabIndex = 9;
            // 
            // dlcStopBitsLabel
            // 
            dlcStopBitsLabel.Anchor = AnchorStyles.None;
            dlcStopBitsLabel.AutoSize = true;
            dlcStopBitsLabel.Font = new Font("微软雅黑", 10.5F);
            dlcStopBitsLabel.ForeColor = Color.FromArgb(102, 102, 102);
            dlcStopBitsLabel.Location = new Point(36, 198);
            dlcStopBitsLabel.Margin = new Padding(4, 0, 4, 0);
            dlcStopBitsLabel.Name = "dlcStopBitsLabel";
            dlcStopBitsLabel.Size = new Size(65, 20);
            dlcStopBitsLabel.TabIndex = 8;
            dlcStopBitsLabel.Text = "停止位：";
            // 
            // dlcDataBitsTextBox
            // 
            dlcDataBitsTextBox.Anchor = AnchorStyles.None;
            dlcDataBitsTextBox.Font = new Font("微软雅黑", 10.5F);
            dlcDataBitsTextBox.Location = new Point(135, 143);
            dlcDataBitsTextBox.Margin = new Padding(4);
            dlcDataBitsTextBox.Name = "dlcDataBitsTextBox";
            dlcDataBitsTextBox.Size = new Size(174, 26);
            dlcDataBitsTextBox.TabIndex = 7;
            // 
            // dlcDataBitsLabel
            // 
            dlcDataBitsLabel.Anchor = AnchorStyles.None;
            dlcDataBitsLabel.AutoSize = true;
            dlcDataBitsLabel.Font = new Font("微软雅黑", 10.5F);
            dlcDataBitsLabel.ForeColor = Color.FromArgb(102, 102, 102);
            dlcDataBitsLabel.Location = new Point(36, 147);
            dlcDataBitsLabel.Margin = new Padding(4, 0, 4, 0);
            dlcDataBitsLabel.Name = "dlcDataBitsLabel";
            dlcDataBitsLabel.Size = new Size(65, 20);
            dlcDataBitsLabel.TabIndex = 6;
            dlcDataBitsLabel.Text = "数据位：";
            // 
            // dlcParityComboBox
            // 
            dlcParityComboBox.Anchor = AnchorStyles.None;
            dlcParityComboBox.Font = new Font("微软雅黑", 10.5F);
            dlcParityComboBox.FormattingEnabled = true;
            dlcParityComboBox.Items.AddRange(new object[] { "无", "奇校验", "偶校验" });
            dlcParityComboBox.Location = new Point(135, 92);
            dlcParityComboBox.Margin = new Padding(4);
            dlcParityComboBox.Name = "dlcParityComboBox";
            dlcParityComboBox.Size = new Size(174, 28);
            dlcParityComboBox.TabIndex = 5;
            // 
            // dlcParityLabel
            // 
            dlcParityLabel.Anchor = AnchorStyles.None;
            dlcParityLabel.AutoSize = true;
            dlcParityLabel.Font = new Font("微软雅黑", 10.5F);
            dlcParityLabel.ForeColor = Color.FromArgb(102, 102, 102);
            dlcParityLabel.Location = new Point(36, 96);
            dlcParityLabel.Margin = new Padding(4, 0, 4, 0);
            dlcParityLabel.Name = "dlcParityLabel";
            dlcParityLabel.Size = new Size(65, 20);
            dlcParityLabel.TabIndex = 4;
            dlcParityLabel.Text = "校验位：";
            // 
            // dlcBaudRateTextBox
            // 
            dlcBaudRateTextBox.Anchor = AnchorStyles.None;
            dlcBaudRateTextBox.Font = new Font("微软雅黑", 10.5F);
            dlcBaudRateTextBox.Location = new Point(135, 41);
            dlcBaudRateTextBox.Margin = new Padding(4);
            dlcBaudRateTextBox.Name = "dlcBaudRateTextBox";
            dlcBaudRateTextBox.Size = new Size(174, 26);
            dlcBaudRateTextBox.TabIndex = 3;
            // 
            // dlcBaudRateLabel
            // 
            dlcBaudRateLabel.Anchor = AnchorStyles.None;
            dlcBaudRateLabel.AutoSize = true;
            dlcBaudRateLabel.Font = new Font("微软雅黑", 10.5F);
            dlcBaudRateLabel.ForeColor = Color.FromArgb(102, 102, 102);
            dlcBaudRateLabel.Location = new Point(36, 45);
            dlcBaudRateLabel.Margin = new Padding(4, 0, 4, 0);
            dlcBaudRateLabel.Name = "dlcBaudRateLabel";
            dlcBaudRateLabel.Size = new Size(84, 20);
            dlcBaudRateLabel.TabIndex = 2;
            dlcBaudRateLabel.Text = "波特率(B)：";
            // 
            // dlcChannelTextBox
            // 
            dlcChannelTextBox.Anchor = AnchorStyles.None;
            dlcChannelTextBox.Font = new Font("微软雅黑", 10.5F);
            dlcChannelTextBox.Location = new Point(135, 4);
            dlcChannelTextBox.Margin = new Padding(4);
            dlcChannelTextBox.Name = "dlcChannelTextBox";
            dlcChannelTextBox.Size = new Size(174, 26);
            dlcChannelTextBox.TabIndex = 1;
            // 
            // dlcChannelLabel
            // 
            dlcChannelLabel.Anchor = AnchorStyles.None;
            dlcChannelLabel.AutoSize = true;
            dlcChannelLabel.Font = new Font("微软雅黑", 10.5F);
            dlcChannelLabel.ForeColor = Color.FromArgb(102, 102, 102);
            dlcChannelLabel.Location = new Point(36, 8);
            dlcChannelLabel.Margin = new Padding(4, 0, 4, 0);
            dlcChannelLabel.Name = "dlcChannelLabel";
            dlcChannelLabel.Size = new Size(79, 20);
            dlcChannelLabel.TabIndex = 0;
            dlcChannelLabel.Text = "通信通道：";
            // 
            // dlcIcon
            // 
            dlcIcon.BackColor = Color.White;
            dlcIcon.ForeColor = Color.FromArgb(41, 128, 185);
            dlcIcon.IconChar = FontAwesome.Sharp.IconChar.Microchip;
            dlcIcon.IconColor = Color.FromArgb(41, 128, 185);
            dlcIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            dlcIcon.IconSize = 33;
            dlcIcon.Location = new Point(19, 23);
            dlcIcon.Margin = new Padding(4);
            dlcIcon.Name = "dlcIcon";
            dlcIcon.Size = new Size(33, 40);
            dlcIcon.TabIndex = 1;
            dlcIcon.TabStop = false;
            // 
            // dlcTitleLabel
            // 
            dlcTitleLabel.AutoSize = true;
            dlcTitleLabel.Font = new Font("微软雅黑", 13F, FontStyle.Bold);
            dlcTitleLabel.ForeColor = Color.FromArgb(41, 128, 185);
            dlcTitleLabel.Location = new Point(54, 26);
            dlcTitleLabel.Margin = new Padding(4, 0, 4, 0);
            dlcTitleLabel.Name = "dlcTitleLabel";
            dlcTitleLabel.Size = new Size(120, 25);
            dlcTitleLabel.TabIndex = 2;
            dlcTitleLabel.Text = "DLC通信配置";
            // 
            // actionPanel
            // 
            actionPanel.Anchor = AnchorStyles.Left;
            actionPanel.BackColor = Color.White;
            actionPanel.Controls.Add(actionContentPanel);
            actionPanel.Controls.Add(actionIcon);
            actionPanel.Controls.Add(actionTitleLabel);
            actionPanel.Location = new Point(482, 16);
            actionPanel.Margin = new Padding(4);
            actionPanel.Name = "actionPanel";
            actionPanel.Padding = new Padding(12, 14, 12, 14);
            actionPanel.Size = new Size(416, 332);
            actionPanel.TabIndex = 2;
            // 
            // actionContentPanel
            // 
            actionContentPanel.Controls.Add(diagReportButton);
            actionContentPanel.Controls.Add(exportLogButton);
            actionContentPanel.Controls.Add(plcTestButton);
            actionContentPanel.Controls.Add(testButton);
            actionContentPanel.Controls.Add(saveButton);
            actionContentPanel.Location = new Point(15, 84);
            actionContentPanel.Margin = new Padding(4);
            actionContentPanel.Name = "actionContentPanel";
            actionContentPanel.Size = new Size(387, 218);
            actionContentPanel.TabIndex = 0;
            // 
            // diagReportButton
            // 
            diagReportButton.BackColor = Color.FromArgb(155, 89, 182);
            diagReportButton.FlatAppearance.BorderSize = 0;
            diagReportButton.FlatStyle = FlatStyle.Flat;
            diagReportButton.Font = new Font("微软雅黑", 9F, FontStyle.Bold);
            diagReportButton.ForeColor = Color.White;
            diagReportButton.Location = new Point(198, 142);
            diagReportButton.Margin = new Padding(4);
            diagReportButton.Name = "diagReportButton";
            diagReportButton.Size = new Size(140, 57);
            diagReportButton.TabIndex = 4;
            diagReportButton.Text = "生成诊断报告";
            diagReportButton.UseVisualStyleBackColor = false;
            diagReportButton.Click += diagReportButton_Click;
            // 
            // exportLogButton
            // 
            exportLogButton.BackColor = Color.FromArgb(243, 156, 18);
            exportLogButton.FlatAppearance.BorderSize = 0;
            exportLogButton.FlatStyle = FlatStyle.Flat;
            exportLogButton.Font = new Font("微软雅黑", 9F, FontStyle.Bold);
            exportLogButton.ForeColor = Color.White;
            exportLogButton.Location = new Point(35, 142);
            exportLogButton.Margin = new Padding(4);
            exportLogButton.Name = "exportLogButton";
            exportLogButton.Size = new Size(140, 57);
            exportLogButton.TabIndex = 3;
            exportLogButton.Text = "导出日志";
            exportLogButton.UseVisualStyleBackColor = false;
            exportLogButton.Click += exportLogButton_Click;
            // 
            // plcTestButton
            // 
            plcTestButton.BackColor = Color.FromArgb(52, 152, 219);
            plcTestButton.FlatAppearance.BorderSize = 0;
            plcTestButton.FlatStyle = FlatStyle.Flat;
            plcTestButton.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            plcTestButton.ForeColor = Color.White;
            plcTestButton.Location = new Point(198, 57);
            plcTestButton.Margin = new Padding(4);
            plcTestButton.Name = "plcTestButton";
            plcTestButton.Size = new Size(140, 64);
            plcTestButton.TabIndex = 2;
            plcTestButton.Text = "PLC/算力板测试";
            plcTestButton.UseVisualStyleBackColor = false;
            plcTestButton.Click += plcTestButton_Click;
            // 
            // testButton
            // 
            testButton.BackColor = Color.FromArgb(52, 152, 219);
            testButton.FlatAppearance.BorderSize = 0;
            testButton.FlatStyle = FlatStyle.Flat;
            testButton.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            testButton.ForeColor = Color.White;
            testButton.Location = new Point(35, 57);
            testButton.Margin = new Padding(4);
            testButton.Name = "testButton";
            testButton.Size = new Size(140, 64);
            testButton.TabIndex = 1;
            testButton.Text = "Modbus测试";
            testButton.UseVisualStyleBackColor = false;
            testButton.Click += testButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(46, 204, 113);
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(93, 14);
            saveButton.Margin = new Padding(4);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(198, 35);
            saveButton.TabIndex = 0;
            saveButton.Text = "保存配置";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // actionIcon
            // 
            actionIcon.BackColor = Color.White;
            actionIcon.ForeColor = Color.FromArgb(41, 128, 185);
            actionIcon.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
            actionIcon.IconColor = Color.FromArgb(41, 128, 185);
            actionIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            actionIcon.IconSize = 33;
            actionIcon.Location = new Point(19, 23);
            actionIcon.Margin = new Padding(4);
            actionIcon.Name = "actionIcon";
            actionIcon.Size = new Size(33, 40);
            actionIcon.TabIndex = 1;
            actionIcon.TabStop = false;
            // 
            // actionTitleLabel
            // 
            actionTitleLabel.AutoSize = true;
            actionTitleLabel.Font = new Font("微软雅黑", 13F, FontStyle.Bold);
            actionTitleLabel.ForeColor = Color.FromArgb(41, 128, 185);
            actionTitleLabel.Location = new Point(54, 26);
            actionTitleLabel.Margin = new Padding(4, 0, 4, 0);
            actionTitleLabel.Name = "actionTitleLabel";
            actionTitleLabel.Size = new Size(84, 25);
            actionTitleLabel.TabIndex = 2;
            actionTitleLabel.Text = "操作控制";
            // 
            // logPanel
            // 
            logPanel.Anchor = AnchorStyles.Left;
            logPanel.BackColor = Color.White;
            logPanel.Controls.Add(logContentPanel);
            logPanel.Controls.Add(logIcon);
            logPanel.Controls.Add(logTitleLabel);
            logPanel.Location = new Point(482, 371);
            logPanel.Margin = new Padding(4);
            logPanel.Name = "logPanel";
            logPanel.Padding = new Padding(12, 14, 12, 14);
            logPanel.Size = new Size(416, 350);
            logPanel.TabIndex = 3;
            // 
            // logContentPanel
            // 
            logContentPanel.Controls.Add(logListView);
            logContentPanel.Location = new Point(15, 84);
            logContentPanel.Margin = new Padding(4);
            logContentPanel.Name = "logContentPanel";
            logContentPanel.Size = new Size(387, 238);
            logContentPanel.TabIndex = 0;
            // 
            // logListView
            // 
            logListView.Columns.AddRange(new ColumnHeader[] { logTimeColumn, logTypeColumn, logMessageColumn });
            logListView.Dock = DockStyle.Fill;
            logListView.Font = new Font("微软雅黑", 9F);
            logListView.FullRowSelect = true;
            logListView.GridLines = true;
            logListView.Location = new Point(0, 0);
            logListView.Margin = new Padding(4);
            logListView.Name = "logListView";
            logListView.Size = new Size(387, 238);
            logListView.TabIndex = 0;
            logListView.UseCompatibleStateImageBehavior = false;
            logListView.View = View.Details;
            // 
            // logTimeColumn
            // 
            logTimeColumn.Text = "时间";
            logTimeColumn.Width = 120;
            // 
            // logTypeColumn
            // 
            logTypeColumn.Text = "类型";
            logTypeColumn.Width = 80;
            // 
            // logMessageColumn
            // 
            logMessageColumn.Text = "消息";
            logMessageColumn.Width = 200;
            // 
            // logIcon
            // 
            logIcon.BackColor = Color.White;
            logIcon.ForeColor = Color.FromArgb(41, 128, 185);
            logIcon.IconChar = FontAwesome.Sharp.IconChar.FileText;
            logIcon.IconColor = Color.FromArgb(41, 128, 185);
            logIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            logIcon.IconSize = 33;
            logIcon.Location = new Point(19, 23);
            logIcon.Margin = new Padding(4);
            logIcon.Name = "logIcon";
            logIcon.Size = new Size(33, 40);
            logIcon.TabIndex = 1;
            logIcon.TabStop = false;
            // 
            // logTitleLabel
            // 
            logTitleLabel.AutoSize = true;
            logTitleLabel.Font = new Font("微软雅黑", 13F, FontStyle.Bold);
            logTitleLabel.ForeColor = Color.FromArgb(41, 128, 185);
            logTitleLabel.Location = new Point(54, 26);
            logTitleLabel.Margin = new Padding(4, 0, 4, 0);
            logTitleLabel.Name = "logTitleLabel";
            logTitleLabel.Size = new Size(84, 25);
            logTitleLabel.TabIndex = 2;
            logTitleLabel.Text = "通信日志";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.5F));
            tableLayoutPanel1.Controls.Add(modbusPanel, 0, 0);
            tableLayoutPanel1.Controls.Add(dlcPanel, 0, 1);
            tableLayoutPanel1.Controls.Add(actionPanel, 1, 0);
            tableLayoutPanel1.Controls.Add(logPanel, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1008, 729);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 242, 255);
            ClientSize = new Size(1008, 729);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4);
            Name = "Form3";
            Text = "通信配置界面";
            modbusPanel.ResumeLayout(false);
            modbusPanel.PerformLayout();
            modbusContentPanel.ResumeLayout(false);
            modbusContentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)modbusIcon).EndInit();
            dlcPanel.ResumeLayout(false);
            dlcPanel.PerformLayout();
            dlcContentPanel.ResumeLayout(false);
            dlcContentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dlcIcon).EndInit();
            actionPanel.ResumeLayout(false);
            actionPanel.PerformLayout();
            actionContentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)actionIcon).EndInit();
            logPanel.ResumeLayout(false);
            logPanel.PerformLayout();
            logContentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logIcon).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel modbusPanel;
        private System.Windows.Forms.Panel modbusContentPanel;
        private System.Windows.Forms.Label modbusTimeoutLabel;
        private System.Windows.Forms.TextBox modbusTimeoutTextBox;
        private System.Windows.Forms.Label modbusSlaveIdLabel;
        private System.Windows.Forms.TextBox modbusSlaveIdTextBox;
        private System.Windows.Forms.Label modbusPortLabel;
        private System.Windows.Forms.TextBox modbusPortTextBox;
        private System.Windows.Forms.Label modbusIpLabel;
        private System.Windows.Forms.TextBox modbusIpTextBox;
        private FontAwesome.Sharp.IconPictureBox modbusIcon;
        private System.Windows.Forms.Label modbusTitleLabel;
        private System.Windows.Forms.Panel dlcPanel;
        private System.Windows.Forms.Panel dlcContentPanel;
        private System.Windows.Forms.ComboBox dlcStopBitsComboBox;
        private System.Windows.Forms.Label dlcStopBitsLabel;
        private System.Windows.Forms.TextBox dlcDataBitsTextBox;
        private System.Windows.Forms.Label dlcDataBitsLabel;
        private System.Windows.Forms.ComboBox dlcParityComboBox;
        private System.Windows.Forms.Label dlcParityLabel;
        private System.Windows.Forms.TextBox dlcBaudRateTextBox;
        private System.Windows.Forms.Label dlcBaudRateLabel;
        private System.Windows.Forms.TextBox dlcChannelTextBox;
        private System.Windows.Forms.Label dlcChannelLabel;
        private FontAwesome.Sharp.IconPictureBox dlcIcon;
        private System.Windows.Forms.Label dlcTitleLabel;
        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Panel actionContentPanel;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Button saveButton;
        private FontAwesome.Sharp.IconPictureBox actionIcon;
        private System.Windows.Forms.Label actionTitleLabel;
        private System.Windows.Forms.Panel logPanel;
        private System.Windows.Forms.Panel logContentPanel;
        private System.Windows.Forms.ListView logListView;
        private System.Windows.Forms.ColumnHeader logTimeColumn;
        private System.Windows.Forms.ColumnHeader logTypeColumn;
        private System.Windows.Forms.ColumnHeader logMessageColumn;
        private FontAwesome.Sharp.IconPictureBox logIcon;
        private System.Windows.Forms.Label logTitleLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}