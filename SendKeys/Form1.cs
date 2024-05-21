using SendKeys.BLL;
using SendKeys.BLL.ActiveWindow;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendKeys
{
    public partial class Form1 : Form
    {
        private ActiveWindowWatcher activeWindowWatcher;
        private ActiveWindowModel activeWindow = ActiveWindowModel.CreateEmpty();
        private IDictionary<IntPtr, string> windowHandles;
        public Form1()
        {
            InitializeComponent();
            activeWindowWatcher = new ActiveWindowWatcher(TimeSpan.FromSeconds(1));
            activeWindowWatcher.ActiveWindowChanged += ActiveWindowWatcher_ActiveWindowChanged;
            activeWindowWatcher.Start();
            RefreshWindowList();
        }

        private void RefreshWindowList()
        {
            windowHandles = WindowAPI.GetOpenWindows();
            windowHandles.Add(System.IntPtr.Zero, string.Empty);
            cboWindows.DataSource = new BindingSource(windowHandles, null);
            cboWindows.DisplayMember = "Value";
            cboWindows.ValueMember = "Key";
        }

        private void ActiveWindowWatcher_ActiveWindowChanged(object sender, ActiveWindowChangedEventArgs e)
        {
            activeWindow = ActiveWindowModel.Create(e.WindowHandle, e.WindowTitle);
            lblCurrentlyActiveWindow.Text = $"Active Window: {e.WindowTitle}";
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            activeWindowWatcher.Stop();
            txtActiveWindow.Text = activeWindow.WindowTitle;
            txtWindowHandle.Text = activeWindow.WindowHandle.ToString();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // WindowAPI.SendKeys(activeWindow.WindowHandle, rbtCTRL.Checked, rbtALT.Checked, cboLetter.Text);
            KeyValuePair<IntPtr, string> selected = (KeyValuePair<IntPtr, string>)(cboWindows.SelectedItem);
            WindowAPI.SendKeys(selected.Key, rbtCTRL.Checked, rbtALT.Checked, cboLetter.Text);
        }

        private void txtText_KeyPress(object sender, KeyPressEventArgs e)
        {
            // WindowAPI.SendKeys(activeWindow.WindowHandle, e.KeyChar.ToString());
            // WindowAPI.SetActiveWindow(Process.GetCurrentProcess().MainWindowHandle);
            KeyValuePair<IntPtr, string> selected = (KeyValuePair<IntPtr, string>)(cboWindows.SelectedItem);
            WindowAPI.SendKeys(selected.Key, e.KeyChar.ToString());
        }

        private void btnSendQueue_Click(object sender, EventArgs e)
        {
            // WindowAPI.SendKeys(activeWindow.WindowHandle, txtQueue.Text);
            KeyValuePair<IntPtr, string> selected = (KeyValuePair<IntPtr, string>)(cboWindows.SelectedItem);
            WindowAPI.SendKeys(selected.Key, txtQueue.Text);
        }

        private async void btnAutomate_ClickAsync(object sender, EventArgs e)
        {
            KeyValuePair<IntPtr, string> selected = (KeyValuePair<IntPtr, string>)(cboWindows.SelectedItem);
            string[] toSend =
            {
                "5/16/2024{TAB}",
                "{TAB}11{TAB}{TAB}97153{TAB}hm{TAB}{TAB}{TAB}{TAB}1{TAB}110.72{TAB}17{TAB}{TAB}1130{TAB}a{TAB}330{TAB}p{TAB}{TAB}{TAB} ",
                "+{TAB}+{TAB}+{TAB}Jacques{TAB}Cousteau{TAB}11110000",
            };
            foreach (string s in toSend)
            {
                // WindowAPI.SendKeys(activeWindow.WindowHandle, s);
                WindowAPI.SendKeys(selected.Key, s);
                await Task.Delay(1000);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshWindowList();
        }

        private void cboWindows_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyValuePair<IntPtr, string> selected = (KeyValuePair<IntPtr, string>)(cboWindows.SelectedItem);
            txtActiveWindow.Text = selected.Value;
            txtWindowHandle.Text = selected.Key.ToString();
        }
    }
}
