using System;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Drawing;
using System.Reflection;

namespace EggForm
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            InitializeRoundedPanels();
            LoadMacAddresses();
            LoadCurrentSettings();
        }

        private void InitializeRoundedPanels()
        {
            // 为所有面板添加圆角效果
            SetRoundedPanel(userManagementPanel);
            SetRoundedPanel(macBindingPanel);
            SetRoundedPanel(interfaceConfigPanel);
        }

        private void SetRoundedPanel(Panel panel)
        {
            // 设置面板为双缓冲，减少闪烁
            typeof(Panel).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(panel, true, null);
            panel.Resize += (sender, e) => panel.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            // 绘制所有面板的圆角边框
            DrawRoundedPanel(userManagementPanel);
            DrawRoundedPanel(macBindingPanel);
            DrawRoundedPanel(interfaceConfigPanel);
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

        private void LoadMacAddresses()
        {
            // 模拟加载MAC地址绑定状态
            macListView.Items.Add(new ListViewItem(new string[] { "00:1B:44:11:3A:B7", "已绑定", "生产设备1", "2024-01-15" }));
            macListView.Items.Add(new ListViewItem(new string[] { "00:1B:44:11:3A:B8", "已绑定", "生产设备2", "2024-01-15" }));
            macListView.Items.Add(new ListViewItem(new string[] { "00:1B:44:11:3A:B9", "未绑定", "新设备", "-" }));
        }

        private void LoadCurrentSettings()
        {
            // 加载当前设置
            refreshRateComboBox.SelectedIndex = 1; // 默认1秒
            fontSizeComboBox.SelectedIndex = 1; // 默认12px
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            // 添加用户功能
            string username = usernameTextBox.Text;
            string role = roleComboBox.Text;
            string password = passwordTextBox.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("用户名和密码不能为空", "添加用户", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 模拟添加用户
            ListViewItem item = new ListViewItem(new string[] { username, role });
            userListView.Items.Add(item);

            // 清空输入框
            usernameTextBox.Clear();
            passwordTextBox.Clear();
            roleComboBox.SelectedIndex = 0;

            MessageBox.Show("用户添加成功", "添加用户", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            // 删除用户功能
            if (userListView.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("确定要删除选中的用户吗？", "删除用户", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    userListView.Items.Remove(userListView.SelectedItems[0]);
                    MessageBox.Show("用户删除成功", "删除用户", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("请先选择要删除的用户", "删除用户", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void saveSettingsButton_Click(object sender, EventArgs e)
        {
            // 保存设置功能
            int refreshRate = int.Parse(refreshRateComboBox.SelectedItem.ToString());
            int fontSize = int.Parse(fontSizeComboBox.SelectedItem.ToString());

            // 模拟保存设置
            MessageBox.Show($"设置已保存：\n刷新频率：{refreshRate}秒\n字体大小：{fontSize}px", 
                "保存设置", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}