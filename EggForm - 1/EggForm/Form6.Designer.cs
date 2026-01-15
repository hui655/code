namespace EggForm
{
    partial class Form6
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel userManagementPanel;
        private System.Windows.Forms.Panel userContentPanel;
        private System.Windows.Forms.ListView userListView;
        private System.Windows.Forms.ColumnHeader userNameColumn;
        private System.Windows.Forms.ColumnHeader userRoleColumn;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private FontAwesome.Sharp.IconPictureBox userIcon;
        private System.Windows.Forms.Label userTitleLabel;
        
        private System.Windows.Forms.Panel macBindingPanel;
        private System.Windows.Forms.Panel macContentPanel;
        private System.Windows.Forms.ListView macListView;
        private System.Windows.Forms.ColumnHeader macAddressColumn;
        private System.Windows.Forms.ColumnHeader macStatusColumn;
        private System.Windows.Forms.ColumnHeader macDeviceColumn;
        private System.Windows.Forms.ColumnHeader macBindDateColumn;
        private FontAwesome.Sharp.IconPictureBox macIcon;
        private System.Windows.Forms.Label macTitleLabel;
        
        private System.Windows.Forms.Panel interfaceConfigPanel;
        private System.Windows.Forms.Panel interfaceContentPanel;
        private System.Windows.Forms.Button saveSettingsButton;
        private System.Windows.Forms.ComboBox fontSizeComboBox;
        private System.Windows.Forms.Label fontSizeLabel;
        private System.Windows.Forms.ComboBox refreshRateComboBox;
        private System.Windows.Forms.Label refreshRateLabel;
        private FontAwesome.Sharp.IconPictureBox interfaceIcon;
        private System.Windows.Forms.Label interfaceTitleLabel;
        
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.userManagementPanel = new System.Windows.Forms.Panel();
            this.userContentPanel = new System.Windows.Forms.Panel();
            this.userListView = new System.Windows.Forms.ListView();
            this.userNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userRoleColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.addUserButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.roleLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.userIcon = new FontAwesome.Sharp.IconPictureBox();
            this.userTitleLabel = new System.Windows.Forms.Label();
            this.macBindingPanel = new System.Windows.Forms.Panel();
            this.macContentPanel = new System.Windows.Forms.Panel();
            this.macListView = new System.Windows.Forms.ListView();
            this.macAddressColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.macStatusColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.macDeviceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.macBindDateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.macIcon = new FontAwesome.Sharp.IconPictureBox();
            this.macTitleLabel = new System.Windows.Forms.Label();
            this.interfaceConfigPanel = new System.Windows.Forms.Panel();
            this.interfaceContentPanel = new System.Windows.Forms.Panel();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.fontSizeComboBox = new System.Windows.Forms.ComboBox();
            this.fontSizeLabel = new System.Windows.Forms.Label();
            this.refreshRateComboBox = new System.Windows.Forms.ComboBox();
            this.refreshRateLabel = new System.Windows.Forms.Label();
            this.interfaceIcon = new FontAwesome.Sharp.IconPictureBox();
            this.interfaceTitleLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            
            this.userManagementPanel.SuspendLayout();
            this.userContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            this.macBindingPanel.SuspendLayout();
            this.macContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.macIcon)).BeginInit();
            this.interfaceConfigPanel.SuspendLayout();
            this.interfaceContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interfaceIcon)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userManagementPanel
            // 
            this.userManagementPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.userManagementPanel.BackColor = System.Drawing.Color.White;
            this.userManagementPanel.Controls.Add(this.userContentPanel);
            this.userManagementPanel.Controls.Add(this.userIcon);
            this.userManagementPanel.Controls.Add(this.userTitleLabel);
            this.userManagementPanel.Location = new System.Drawing.Point(4, 20);
            this.userManagementPanel.Name = "userManagementPanel";
            this.userManagementPanel.Padding = new System.Windows.Forms.Padding(10);
            this.userManagementPanel.Size = new System.Drawing.Size(700, 160);
            this.userManagementPanel.TabIndex = 0;
            // 
            // userContentPanel
            // 
            this.userContentPanel.Controls.Add(this.userListView);
            this.userContentPanel.Controls.Add(this.deleteUserButton);
            this.userContentPanel.Controls.Add(this.addUserButton);
            this.userContentPanel.Controls.Add(this.passwordTextBox);
            this.userContentPanel.Controls.Add(this.passwordLabel);
            this.userContentPanel.Controls.Add(this.roleComboBox);
            this.userContentPanel.Controls.Add(this.roleLabel);
            this.userContentPanel.Controls.Add(this.usernameTextBox);
            this.userContentPanel.Controls.Add(this.usernameLabel);
            this.userContentPanel.Location = new System.Drawing.Point(13, 59);
            this.userContentPanel.Name = "userContentPanel";
            this.userContentPanel.Size = new System.Drawing.Size(674, 82);
            this.userContentPanel.TabIndex = 0;
            // 
            // userListView
            // 
            this.userListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.userNameColumn,
            this.userRoleColumn});
            this.userListView.Dock = System.Windows.Forms.DockStyle.Right;
            this.userListView.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.userListView.Location = new System.Drawing.Point(350, 0);
            this.userListView.Name = "userListView";
            this.userListView.Size = new System.Drawing.Size(324, 82);
            this.userListView.TabIndex = 8;
            this.userListView.UseCompatibleStateImageBehavior = false;
            this.userListView.View = System.Windows.Forms.View.Details;
            // 
            // userNameColumn
            // 
            this.userNameColumn.Text = "用户名";
            this.userNameColumn.Width = 150;
            // 
            // userRoleColumn
            // 
            this.userRoleColumn.Text = "角色";
            this.userRoleColumn.Width = 150;
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.deleteUserButton.FlatAppearance.BorderSize = 0;
            this.deleteUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteUserButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.deleteUserButton.ForeColor = System.Drawing.Color.White;
            this.deleteUserButton.Location = new System.Drawing.Point(140, 50);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(80, 25);
            this.deleteUserButton.TabIndex = 7;
            this.deleteUserButton.Text = "删除";
            this.deleteUserButton.UseVisualStyleBackColor = false;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // addUserButton
            // 
            this.addUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.addUserButton.FlatAppearance.BorderSize = 0;
            this.addUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.addUserButton.ForeColor = System.Drawing.Color.White;
            this.addUserButton.Location = new System.Drawing.Point(50, 50);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(80, 25);
            this.addUserButton.TabIndex = 6;
            this.addUserButton.Text = "添加";
            this.addUserButton.UseVisualStyleBackColor = false;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.passwordTextBox.Location = new System.Drawing.Point(240, 20);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(100, 23);
            this.passwordTextBox.TabIndex = 5;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.passwordLabel.Location = new System.Drawing.Point(240, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(41, 17);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "密码";
            // 
            // roleComboBox
            // 
            this.roleComboBox.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Items.AddRange(new object[] {
            "管理员",
            "操作员",
            "查看者"});
            this.roleComboBox.Location = new System.Drawing.Point(130, 20);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(100, 25);
            this.roleComboBox.TabIndex = 3;
            this.roleComboBox.Text = "管理员";
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.roleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.roleLabel.Location = new System.Drawing.Point(130, 0);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(41, 17);
            this.roleLabel.TabIndex = 2;
            this.roleLabel.Text = "角色";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.usernameTextBox.Location = new System.Drawing.Point(20, 20);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 23);
            this.usernameTextBox.TabIndex = 1;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.usernameLabel.Location = new System.Drawing.Point(20, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(41, 17);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "用户名";
            // 
            // userIcon
            // 
            this.userIcon.BackColor = System.Drawing.Color.White;
            this.userIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.userIcon.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.userIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.userIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.userIcon.IconSize = 32;
            this.userIcon.Location = new System.Drawing.Point(13, 15);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(32, 32);
            this.userIcon.TabIndex = 2;
            this.userIcon.TabStop = false;
            // 
            // userTitleLabel
            // 
            this.userTitleLabel.AutoSize = true;
            this.userTitleLabel.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.userTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.userTitleLabel.Location = new System.Drawing.Point(51, 19);
            this.userTitleLabel.Name = "userTitleLabel";
            this.userTitleLabel.Size = new System.Drawing.Size(110, 26);
            this.userTitleLabel.TabIndex = 3;
            this.userTitleLabel.Text = "用户管理区";
            // 
            // macBindingPanel
            // 
            this.macBindingPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.macBindingPanel.BackColor = System.Drawing.Color.White;
            this.macBindingPanel.Controls.Add(this.macContentPanel);
            this.macBindingPanel.Controls.Add(this.macIcon);
            this.macBindingPanel.Controls.Add(this.macTitleLabel);
            this.macBindingPanel.Location = new System.Drawing.Point(4, 190);
            this.macBindingPanel.Name = "macBindingPanel";
            this.macBindingPanel.Padding = new System.Windows.Forms.Padding(10);
            this.macBindingPanel.Size = new System.Drawing.Size(700, 160);
            this.macBindingPanel.TabIndex = 1;
            // 
            // macContentPanel
            // 
            this.macContentPanel.Controls.Add(this.macListView);
            this.macContentPanel.Location = new System.Drawing.Point(13, 59);
            this.macContentPanel.Name = "macContentPanel";
            this.macContentPanel.Size = new System.Drawing.Size(674, 82);
            this.macContentPanel.TabIndex = 0;
            // 
            // macListView
            // 
            this.macListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.macAddressColumn,
            this.macStatusColumn,
            this.macDeviceColumn,
            this.macBindDateColumn});
            this.macListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.macListView.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.macListView.Location = new System.Drawing.Point(0, 0);
            this.macListView.Name = "macListView";
            this.macListView.Size = new System.Drawing.Size(674, 82);
            this.macListView.TabIndex = 0;
            this.macListView.UseCompatibleStateImageBehavior = false;
            this.macListView.View = System.Windows.Forms.View.Details;
            // 
            // macAddressColumn
            // 
            this.macAddressColumn.Text = "MAC地址";
            this.macAddressColumn.Width = 150;
            // 
            // macStatusColumn
            // 
            this.macStatusColumn.Text = "绑定状态";
            this.macStatusColumn.Width = 100;
            // 
            // macDeviceColumn
            // 
            this.macDeviceColumn.Text = "设备名称";
            this.macDeviceColumn.Width = 120;
            // 
            // macBindDateColumn
            // 
            this.macBindDateColumn.Text = "绑定日期";
            this.macBindDateColumn.Width = 120;
            // 
            // macIcon
            // 
            this.macIcon.BackColor = System.Drawing.Color.White;
            this.macIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.macIcon.IconChar = FontAwesome.Sharp.IconChar.Microchip;
            this.macIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.macIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.macIcon.IconSize = 32;
            this.macIcon.Location = new System.Drawing.Point(13, 15);
            this.macIcon.Name = "macIcon";
            this.macIcon.Size = new System.Drawing.Size(32, 32);
            this.macIcon.TabIndex = 2;
            this.macIcon.TabStop = false;
            // 
            // macTitleLabel
            // 
            this.macTitleLabel.AutoSize = true;
            this.macTitleLabel.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.macTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.macTitleLabel.Location = new System.Drawing.Point(51, 19);
            this.macTitleLabel.Name = "macTitleLabel";
            this.macTitleLabel.Size = new System.Drawing.Size(110, 26);
            this.macTitleLabel.TabIndex = 3;
            this.macTitleLabel.Text = "MAC绑定区";
            // 
            // interfaceConfigPanel
            // 
            this.interfaceConfigPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.interfaceConfigPanel.BackColor = System.Drawing.Color.White;
            this.interfaceConfigPanel.Controls.Add(this.interfaceContentPanel);
            this.interfaceConfigPanel.Controls.Add(this.interfaceIcon);
            this.interfaceConfigPanel.Controls.Add(this.interfaceTitleLabel);
            this.interfaceConfigPanel.Location = new System.Drawing.Point(4, 360);
            this.interfaceConfigPanel.Name = "interfaceConfigPanel";
            this.interfaceConfigPanel.Padding = new System.Windows.Forms.Padding(10);
            this.interfaceConfigPanel.Size = new System.Drawing.Size(700, 160);
            this.interfaceConfigPanel.TabIndex = 2;
            // 
            // interfaceContentPanel
            // 
            this.interfaceContentPanel.Controls.Add(this.saveSettingsButton);
            this.interfaceContentPanel.Controls.Add(this.fontSizeComboBox);
            this.interfaceContentPanel.Controls.Add(this.fontSizeLabel);
            this.interfaceContentPanel.Controls.Add(this.refreshRateComboBox);
            this.interfaceContentPanel.Controls.Add(this.refreshRateLabel);
            this.interfaceContentPanel.Location = new System.Drawing.Point(13, 59);
            this.interfaceContentPanel.Name = "interfaceContentPanel";
            this.interfaceContentPanel.Size = new System.Drawing.Size(674, 82);
            this.interfaceContentPanel.TabIndex = 0;
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.saveSettingsButton.FlatAppearance.BorderSize = 0;
            this.saveSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveSettingsButton.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.saveSettingsButton.ForeColor = System.Drawing.Color.White;
            this.saveSettingsButton.Location = new System.Drawing.Point(240, 20);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(100, 40);
            this.saveSettingsButton.TabIndex = 4;
            this.saveSettingsButton.Text = "保存设置";
            this.saveSettingsButton.UseVisualStyleBackColor = false;
            this.saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
            // 
            // fontSizeComboBox
            // 
            this.fontSizeComboBox.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.fontSizeComboBox.FormattingEnabled = true;
            this.fontSizeComboBox.Items.AddRange(new object[] {
            "10",
            "12",
            "14",
            "16",
            "18"});
            this.fontSizeComboBox.Location = new System.Drawing.Point(130, 30);
            this.fontSizeComboBox.Name = "fontSizeComboBox";
            this.fontSizeComboBox.Size = new System.Drawing.Size(100, 25);
            this.fontSizeComboBox.TabIndex = 3;
            // 
            // fontSizeLabel
            // 
            this.fontSizeLabel.AutoSize = true;
            this.fontSizeLabel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.fontSizeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.fontSizeLabel.Location = new System.Drawing.Point(130, 10);
            this.fontSizeLabel.Name = "fontSizeLabel";
            this.fontSizeLabel.Size = new System.Drawing.Size(41, 17);
            this.fontSizeLabel.TabIndex = 2;
            this.fontSizeLabel.Text = "字体大小";
            // 
            // refreshRateComboBox
            // 
            this.refreshRateComboBox.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.refreshRateComboBox.FormattingEnabled = true;
            this.refreshRateComboBox.Items.AddRange(new object[] {
            "0.5",
            "1",
            "2",
            "5",
            "10"});
            this.refreshRateComboBox.Location = new System.Drawing.Point(20, 30);
            this.refreshRateComboBox.Name = "refreshRateComboBox";
            this.refreshRateComboBox.Size = new System.Drawing.Size(100, 25);
            this.refreshRateComboBox.TabIndex = 1;
            // 
            // refreshRateLabel
            // 
            this.refreshRateLabel.AutoSize = true;
            this.refreshRateLabel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.refreshRateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.refreshRateLabel.Location = new System.Drawing.Point(20, 10);
            this.refreshRateLabel.Name = "refreshRateLabel";
            this.refreshRateLabel.Size = new System.Drawing.Size(65, 17);
            this.refreshRateLabel.TabIndex = 0;
            this.refreshRateLabel.Text = "刷新频率（秒）";
            // 
            // interfaceIcon
            // 
            this.interfaceIcon.BackColor = System.Drawing.Color.White;
            this.interfaceIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.interfaceIcon.IconChar = FontAwesome.Sharp.IconChar.SlidersH;
            this.interfaceIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.interfaceIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.interfaceIcon.IconSize = 32;
            this.interfaceIcon.Location = new System.Drawing.Point(13, 15);
            this.interfaceIcon.Name = "interfaceIcon";
            this.interfaceIcon.Size = new System.Drawing.Size(32, 32);
            this.interfaceIcon.TabIndex = 2;
            this.interfaceIcon.TabStop = false;
            // 
            // interfaceTitleLabel
            // 
            this.interfaceTitleLabel.AutoSize = true;
            this.interfaceTitleLabel.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.interfaceTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.interfaceTitleLabel.Location = new System.Drawing.Point(51, 19);
            this.interfaceTitleLabel.Name = "interfaceTitleLabel";
            this.interfaceTitleLabel.Size = new System.Drawing.Size(110, 26);
            this.interfaceTitleLabel.TabIndex = 3;
            this.interfaceTitleLabel.Text = "界面配置区";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.userManagementPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.macBindingPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.interfaceConfigPanel, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(710, 530);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(710, 530);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form6";
            this.Text = "系统设置界面";
            
            this.userManagementPanel.ResumeLayout(false);
            this.userManagementPanel.PerformLayout();
            this.userContentPanel.ResumeLayout(false);
            this.userContentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            this.macBindingPanel.ResumeLayout(false);
            this.macBindingPanel.PerformLayout();
            this.macContentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.macIcon)).EndInit();
            this.interfaceConfigPanel.ResumeLayout(false);
            this.interfaceConfigPanel.PerformLayout();
            this.interfaceContentPanel.ResumeLayout(false);
            this.interfaceContentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interfaceIcon)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
