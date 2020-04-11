using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PressWatcher
{
    public partial class MainForm : Form
    {
        HookKeeper hookKeeper = new HookKeeper();
        private bool dutyNeedOpen = true;

        public MainForm()
        {
            InitializeComponent();
        }

        private void DutyBtn_Click(object sender, EventArgs e)
        {
            
            if (dutyNeedOpen)
            {
                hookKeeper.Init();
                IsStartLabel.Text = "Listing keys...";
                DutyBtn.Text = "停止监听";
            }
            else
            {
                hookKeeper.Stop();
                IsStartLabel.Text = "Stop...";
                DutyBtn.Text = "继续监听";
            }
            dutyNeedOpen = !dutyNeedOpen;
        }
        
    }
}
