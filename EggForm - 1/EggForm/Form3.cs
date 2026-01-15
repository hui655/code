using System;
using System.IO;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Drawing;

namespace EggForm
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            InitializeCommunicationConfig();
            InitializeRoundedPanels();
        }

        private void InitializeRoundedPanels()
        {
            // 为所有面板添加圆角效果
            SetRoundedPanel(modbusPanel);
            SetRoundedPanel(dlcPanel);
            SetRoundedPanel(actionPanel);
            SetRoundedPanel(logPanel);
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
            DrawRoundedPanel(modbusPanel);
            DrawRoundedPanel(dlcPanel);
            DrawRoundedPanel(actionPanel);
            DrawRoundedPanel(logPanel);
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

        private void InitializeCommunicationConfig()
        {
            // 设置初始配置值
            this.modbusIpTextBox.Text = "192.168.1.100";
            this.modbusPortTextBox.Text = "502";
            this.modbusSlaveIdTextBox.Text = "1";
            this.modbusTimeoutTextBox.Text = "1000";
            this.dlcChannelTextBox.Text = "1";
            this.dlcBaudRateTextBox.Text = "9600";
            this.dlcParityComboBox.SelectedIndex = 0;
            this.dlcDataBitsTextBox.Text = "8";
            this.dlcStopBitsComboBox.SelectedIndex = 0;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // 保存配置逻辑
            MessageBox.Show("通信配置已保存", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private enum LogType
        {
            Info,
            Success,
            Warning,
            Error
        }

        private void AddLog(string message, LogType type)
        {
            string time = DateTime.Now.ToString("HH:mm:ss");
            string typeStr = type.ToString();
            string logEntry = $"[{time}] {typeStr}: {message}";
            
            logListView.Items.Add(new ListViewItem(new string[] { time, typeStr, message }));
            // 自动滚动到最后一条日志
            if (logListView.Items.Count > 0)
            {
                logListView.Items[logListView.Items.Count - 1].EnsureVisible();
            }
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            // 测试Modbus连接功能
            AddLog("正在测试Modbus TCP连接...", LogType.Info);
            // 模拟测试结果
            System.Threading.Thread.Sleep(1000);
            AddLog("Modbus TCP连接测试成功！", LogType.Success);
        }

        private void plcTestButton_Click(object sender, EventArgs e)
        {
            // 测试PLC/算力板连接功能
            AddLog("正在测试PLC/算力板通信...", LogType.Info);
            // 模拟测试结果
            System.Threading.Thread.Sleep(1500);
            AddLog("PLC/算力板通信测试成功！", LogType.Success);
        }

        private void exportLogButton_Click(object sender, EventArgs e)
        {
            // 导出日志功能
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "文本文件|*.txt|CSV文件|*.csv";
            saveDialog.Title = "导出通信日志";
            saveDialog.FileName = $"通信日志_{DateTime.Now:yyyyMMdd_HHmmss}";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                AddLog("正在导出日志...", LogType.Info);
                try
                {
                    // 生成日志内容
                    string logContent = "时间,类型,消息\n";
                    foreach (ListViewItem item in logListView.Items)
                    {
                        logContent += $"{item.SubItems[0].Text},{item.SubItems[1].Text},{item.SubItems[2].Text}\n";
                    }
                    
                    File.WriteAllText(saveDialog.FileName, logContent);
                    AddLog($"日志导出成功: {saveDialog.FileName}", LogType.Success);
                }
                catch (Exception ex)
                {
                    AddLog($"日志导出失败: {ex.Message}", LogType.Error);
                }
            }
        }

        private void diagReportButton_Click(object sender, EventArgs e)
        {
            // 生成异常诊断报告功能
            AddLog("正在生成异常诊断报告...", LogType.Info);
            // 模拟生成报告
            System.Threading.Thread.Sleep(2000);
            AddLog("异常诊断报告生成成功！", LogType.Success);
            
            // 显示诊断报告
            string report = "=== 通信异常诊断报告 ===\n\n" +
                           "1. 通信参数设置\n" +
                           $"   - Modbus IP: {modbusIpTextBox.Text}:{modbusPortTextBox.Text}\n" +
                           $"   - 从站地址: {modbusSlaveIdTextBox.Text}\n" +
                           $"   - 超时时间: {modbusTimeoutTextBox.Text}ms\n\n" +
                           "2. 连接状态\n" +
                           "   - Modbus TCP: 正常\n" +
                           "   - PLC/算力板: 正常\n\n" +
                           "3. 异常统计\n" +
                           "   - 连接失败次数: 0\n" +
                           "   - 超时次数: 0\n" +
                           "   - 数据错误次数: 0\n\n" +
                           "4. 诊断结论\n" +
                           "   - 通信系统运行正常\n" +
                           "   - 建议: 定期检查网络连接\n";
            
            MessageBox.Show(report, "异常诊断报告", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}