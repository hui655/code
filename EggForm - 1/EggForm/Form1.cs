using System;
using System.Windows.Forms;

namespace EggForm
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer refreshTimer;

        public Form1()
        {
            InitializeComponent();
            InitializeRefreshMechanism();
            InitializeRoundedPanels();
        }

        private void InitializeRoundedPanels()
        {
            // 为所有面板添加圆角效果
            SetRoundedPanel(statusPanel);
            SetRoundedPanel(dataPanel);
            SetRoundedPanel(alarmPanel);
            SetRoundedPanel(operationPanel);
            SetRoundedPanel(communicationPanel);
        }

        private void SetRoundedPanel(Panel panel)
        {
            // 设置面板为双缓冲，减少闪烁
            typeof(Panel).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(panel, true, null);
            panel.Resize += (sender, e) => panel.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            // 绘制所有面板的圆角边框
            DrawRoundedPanel(statusPanel);
            DrawRoundedPanel(dataPanel);
            DrawRoundedPanel(alarmPanel);
            DrawRoundedPanel(operationPanel);
            DrawRoundedPanel(communicationPanel);
        }

        private void DrawRoundedPanel(Panel panel)
        {
            using (var path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int radius = 10;
                path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
                path.AddArc(panel.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90);
                path.AddArc(panel.Width - radius * 2, panel.Height - radius * 2, radius * 2, radius * 2, 0, 90);
                path.AddArc(0, panel.Height - radius * 2, radius * 2, radius * 2, 90, 90);
                path.CloseFigure();
                panel.Region = new Region(path);
            }
        }

        private void InitializeRefreshMechanism()
        {
            // 初始化定时刷新计时器
            refreshTimer = new System.Windows.Forms.Timer();
            refreshTimer.Interval = 5000; // 5秒刷新一次
            refreshTimer.Tick += RefreshTimer_Tick;
            refreshTimer.Start();

            // 添加手动刷新按钮事件
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            InitializeButtonEffects();
        }

        private void InitializeButtonEffects()
        {
            // 为所有按钮添加交互效果
            AddButtonEffects(cameraButton);
            AddButtonEffects(pathButton);
            AddButtonEffects(communicationButton);
            AddButtonEffects(manualControlButton);
            AddButtonEffects(alarmManageButton);
            AddButtonEffects(systemButton);
            AddButtonEffects(exportButton);
            AddButtonEffects(emergencyStopButton);
            AddButtonEffects(refreshButton);

            // 添加通信按钮点击事件
            this.communicationButton.Click += new System.EventHandler(this.communicationButton_Click);
            // 添加报警管理按钮点击事件
           // this.alarmManageButton.Click += new System.EventHandler(this.alarmManageButton_Click);
            // 添加系统设置按钮点击事件
            this.systemButton.Click += new System.EventHandler(this.systemButton_Click);
        }

        private void AddButtonEffects(Button button)
        {
            // 保存原始颜色
            button.Tag = button.BackColor;

            // 添加悬停效果
            button.MouseEnter += (sender, e) =>
            {
                Button btn = sender as Button;
                if (btn != null && btn.Tag is System.Drawing.Color)
                {
                    System.Drawing.Color originalColor = (System.Drawing.Color)btn.Tag;
                    btn.BackColor = System.Drawing.Color.FromArgb(
                        Math.Max(0, originalColor.R - 20),
                        Math.Max(0, originalColor.G - 20),
                        Math.Max(0, originalColor.B - 20)
                    );
                }
            };

            // 添加离开效果
            button.MouseLeave += (sender, e) =>
            {
                Button btn = sender as Button;
                if (btn != null && btn.Tag is System.Drawing.Color)
                {
                    btn.BackColor = (System.Drawing.Color)btn.Tag;
                }
            };

            // 添加点击效果
            button.MouseDown += (sender, e) =>
            {
                Button btn = sender as Button;
                if (btn != null && btn.Tag is System.Drawing.Color)
                {
                    System.Drawing.Color originalColor = (System.Drawing.Color)btn.Tag;
                    btn.BackColor = System.Drawing.Color.FromArgb(
                        Math.Max(0, originalColor.R - 40),
                        Math.Max(0, originalColor.G - 40),
                        Math.Max(0, originalColor.B - 40)
                    );
                }
            };

            // 添加释放效果
            button.MouseUp += (sender, e) =>
            {
                Button btn = sender as Button;
                if (btn != null && btn.Tag is System.Drawing.Color)
                {
                    System.Drawing.Color originalColor = (System.Drawing.Color)btn.Tag;
                    btn.BackColor = System.Drawing.Color.FromArgb(
                        Math.Max(0, originalColor.R - 20),
                        Math.Max(0, originalColor.G - 20),
                        Math.Max(0, originalColor.B - 20)
                    );
                }
            };
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            // 模拟实时数据刷新
            UpdateStatusInspectionData();
            UpdateSensorData();
            UpdateRFIDData();
            UpdateCommunicationStatus();
        }

        private void UpdateStatusInspectionData()
        {
            // 模拟设备状态数据刷新
            Random random = new Random();
            int battery = random.Next(80, 100);
            int inspectionCount = random.Next(10, 20);
            int totalCount = random.Next(300, 400);

            this.deviceModeValue.Text = "自动模式";
            this.currentPositionValue.Text = "RFID-001 | 鸡舍A-102";
            this.batteryValue.Text = $"{battery}% | 预计续航 {Math.Round(battery / 20.0, 1)}h";
            this.inspectionCountValue.Text = $"今日 {inspectionCount} | 累计 {totalCount}";
        }

        private void UpdateSensorData()
        {
            // 模拟传感器数据刷新
            Random random = new Random();
            double chassisSpeed = Math.Round(random.NextDouble() * 10, 1);
            double temperature = Math.Round(20 + random.NextDouble() * 10, 1);
            int humidity = random.Next(40, 60);
            int ammonia = random.Next(10, 25);
            double windSpeed = Math.Round(random.NextDouble() * 5, 1);
            double distance = Math.Round(random.NextDouble() * 20, 1);

            this.chassisSpeedValue.Text = $"{chassisSpeed} 转/秒";
            this.temperatureValue.Text = $"{temperature}°C";
            this.humidityValue.Text = $"{humidity}%";
            this.ammoniaValue.Text = $"{ammonia} ppm";
            this.windSpeedValue.Text = $"{windSpeed} m/s";
            this.distanceValue.Text = $"{distance} 米";
        }

        private void UpdateRFIDData()
        {
            // 模拟RFID标签数据刷新
            Random random = new Random();
            string tagId = $"RFID-{random.Next(1, 100).ToString("D3")}";
            string position = $"鸡舍{random.Next(1, 3)}-{random.Next(100, 200)}";
            int signalStrength = random.Next(-70, -40);

            this.rfidIdValue.Text = tagId;
            this.rfidPositionValue.Text = position;
            this.rfidTimeValue.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            this.rfidSignalValue.Text = $"{signalStrength} dBm";
        }

        private void UpdateCommunicationStatus()
        {
            // 模拟通信状态数据刷新
            Random random = new Random();
            bool plcConnected = random.Next(0, 10) > 1;
            bool canConnected = random.Next(0, 10) > 1;
            bool rfidConnected = random.Next(0, 10) > 1;

            this.plcStatusValue.Text = plcConnected ? "在线" : "离线";
            this.plcStatusValue.ForeColor = plcConnected ? System.Drawing.Color.Green : System.Drawing.Color.Red;
            this.plcStatusIcon.IconColor = plcConnected ? System.Drawing.Color.FromArgb(52, 152, 219) : System.Drawing.Color.Red;

            this.canStatusValue.Text = canConnected ? "正常" : "异常";
            this.canStatusValue.ForeColor = canConnected ? System.Drawing.Color.Green : System.Drawing.Color.Red;
            this.canStatusIcon.IconColor = canConnected ? System.Drawing.Color.FromArgb(52, 152, 219) : System.Drawing.Color.Red;

            this.rfidStatusValue.Text = rfidConnected ? "已连接" : "未连接";
            this.rfidStatusValue.ForeColor = rfidConnected ? System.Drawing.Color.Green : System.Drawing.Color.Red;
            this.rfidStatusIcon.IconColor = rfidConnected ? System.Drawing.Color.FromArgb(52, 152, 219) : System.Drawing.Color.Red;
        }

        private void distanceValue_Click(object sender, EventArgs e)
        {

        }

        private void communicationButton_Click(object sender, EventArgs e)
        {
            // 打开通信配置界面
            Form3 communicationForm = new Form3();
            communicationForm.ShowDialog();
        }

        //private void alarmManageButton_Click(object sender, EventArgs e)
        //{
        //    // 打开报警与日志查询界面
        //    Form5 form5 = new Form5();
        //    form5.Show();
        //}

        private void systemButton_Click(object sender, EventArgs e)
        {
            // 打开系统设置界面
            Form6 form6 = new Form6();
            form6.Show();
        }
    }
}
