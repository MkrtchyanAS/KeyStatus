using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Application.Idle += Application_Idle_Num;
            Application.Idle += Application_Idle_Caps;
            Application.Idle += Application_Idle_Scroll;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public static bool NumLockActive()
        {
            return Control.IsKeyLocked(Keys.NumLock);
        }
        public static bool CapsLockActive()
        {
            return Control.IsKeyLocked(Keys.CapsLock);
        }
        public static bool ScrollLockActive()
        {
            return Control.IsKeyLocked(Keys.Scroll);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        void Application_Idle_Num(object sender, EventArgs e)
        {
            if (NumLockActive())
            {
                label1.ForeColor = Color.Green;
            }
            else
            {
                label1.ForeColor = Color.Gray;
            }
        }
        void Application_Idle_Caps(object sender, EventArgs e)
        {
            if (CapsLockActive())
            {
                label2.ForeColor = Color.Green;
            }
            else
            {
                label2.ForeColor = Color.Gray;
            }
        }
        void Application_Idle_Scroll(object sender, EventArgs e)
        {
            if (ScrollLockActive())
            {
                label3.ForeColor = Color.Green;
            }
            else
            {
                label3.ForeColor = Color.Gray;
            }
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            Application.Idle -= Application_Idle_Num;
            Application.Idle -= Application_Idle_Scroll;
            Application.Idle -= Application_Idle_Caps;
            base.OnFormClosed(e);
        }
    }

}
