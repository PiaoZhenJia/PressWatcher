using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PressWatcher
{

    public partial class ChildForm : Form
    {

        [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
        public static extern long GetWindowLong(IntPtr hwnd, int nIndex);
        [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
        public static extern long SetWindowLong(IntPtr hwnd, int nIndex, long dwNewLong);
        [DllImport("user32", EntryPoint = "SetLayeredWindowAttributes")]
        public static extern int SetLayeredWindowAttributes(IntPtr Handle, int crKey, byte bAlpha, int dwFlags);


        const int GWL_EXSTYLE = -20;
        const int WS_EX_TRANSPARENT = 0x20;
        const int WS_EX_LAYERED = 0x80000;
        const int LWA_ALPHA = 2;


        [DllImport("user32", EntryPoint = "SetWindowPos")]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndlnsertAfter, int X, int Y, int cx, int cy, int flags);

        [DllImport("user32.dll")]
        public static extern IntPtr GetActiveWindow();//获得当前活动窗体         
        [DllImport("user32.dll")]
        public static extern IntPtr SetActiveWindow(IntPtr hwnd);//设置活动窗体

        public ChildForm(String showText)
        {
            InitializeComponent();
            //set area
            Point point = Cursor.Position;
            StartPosition = FormStartPosition.Manual;
            Location = point;
            //鼠标穿透
            //SetWindowLong(Handle, GWL_EXSTYLE, GetWindowLong(Handle, GWL_EXSTYLE) | WS_EX_TRANSPARENT | WS_EX_LAYERED);
            //SetLayeredWindowAttributes(Handle, 0, 128, LWA_ALPHA);
            IntPtr activeForm = GetActiveWindow();//A弹出窗口前获得当前活动窗口
            Show();
            SetWindowPos(Handle, new IntPtr(-1), Location.X, Location.Y, 300, 50, 0);
            SetActiveWindow(activeForm);//B换回活动窗口

            label.Text = showText;
        }

    }

}