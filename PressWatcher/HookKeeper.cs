using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices; //调用WINDOWS API函数时要用到 
using Microsoft.Win32; //写入注册表时要用到
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace PressWatcher
{
    class HookKeeper
    {

        private KeyboardHook k_hook;

        public void Init()
        {
            k_hook = new KeyboardHook();
            k_hook.KeyDownEvent += new KeyEventHandler(Hook_KeyDown);//钩住键按下
            k_hook.Start();//安装键盘钩子
        }

        public void Stop()
        {
            k_hook.Stop();
        }

        private void Hook_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.None)
            {
                //one key press
            }
             else if(e.KeyCode == Keys.ControlKey)
            {
                //only one modifier key down
            }
            else if (
                Control.ModifierKeys == Keys.Control &&( e.KeyCode == Keys.LControlKey || e.KeyCode == Keys.RControlKey) ||
                Control.ModifierKeys == Keys.Alt && (e.KeyCode == Keys.LMenu || e.KeyCode == Keys.RMenu) ||
                Control.ModifierKeys == Keys.Shift && (e.KeyCode == Keys.LShiftKey|| e.KeyCode == Keys.RShiftKey) ||
                e.KeyCode == Keys.LControlKey ||
                e.KeyCode == Keys.RControlKey ||
                e.KeyCode == Keys.LMenu ||
                e.KeyCode == Keys.RMenu ||
                e.KeyCode == Keys.LShiftKey ||
                e.KeyCode == Keys.RShiftKey
                )
            {
                //only modifier keys down
            }
            else
            {
                ShowFormIfNeed(e);
            }
            
        }

        private void ThreadMethod(Object keys)
        {
            ChildForm childForm = new ChildForm((string)keys);
            Thread.Sleep(2000);
            childForm.Close();
        }

        private void ShowFormIfNeed(KeyEventArgs e)
        {
            string keys = Control.ModifierKeys.ToString().Replace(",", " + ") + " + " + e.KeyCode;
            Console.WriteLine("Modifier:"+ Control.ModifierKeys + " base:"+e.KeyCode);
            Thread thread = new Thread(new ParameterizedThreadStart(ThreadMethod));
            thread.Start(keys);
        }
    }
}
