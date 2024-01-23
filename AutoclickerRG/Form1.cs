using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoclickerRG
{
    public partial class Form1 : Form
    {
        private MainController Controller;
        public Form1()
        {
            InitializeComponent();
            Controller = new MainController(new RGModel(), new Validator());
            HotKeyManager.RegisterHotKey(Keys.J, KeyModifiers.Alt);
            HotKeyManager.RegisterHotKey(Keys.G, KeyModifiers.Alt);
            HotKeyManager.HotKeyPressed += new EventHandler<HotKeyEventArgs>(HotKeyManager_IsRunning);
        }

        void HotKeyManager_IsRunning(object sender, HotKeyEventArgs e)
        {
            if (e.Key == Keys.J)
            {
                RunStateMark.Checked = !RunStateMark.Checked;
                Controller.SetRunState(RunStateMark.Checked);
            }
            else if (e.Key == Keys.G)
            {
                ShowFrameOverlay.Checked = !ShowFrameOverlay.Checked;
                Controller.SetFrameVisible(ShowFrameOverlay.Checked);
            }
            else { 
                // Do nothing
            }

        }

        private void CPSSetButton_Click(object sender, EventArgs e)
        {
            Controller.SetCPS(CPSValue.Text);
        }
        private void FocusFrame_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RunStateMark_CheckedChanged(object sender, EventArgs e)
        {
            Controller.SetRunState(RunStateMark.Checked);
        }

        private void FrameSetButton_Click(object sender, EventArgs e)
        {
            Controller.SetFrame(new string[] { LeftUpX.Text, LeftUpY.Text, RightDownX.Text, RightDownY.Text });
        }

        private void ShowFrameOverlay_CheckedChanged(object sender, EventArgs e)
        {
            Controller.SetFrameVisible(ShowFrameOverlay.Checked);
        }
    }
}
