﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPG_Distribution_System.CustomerTx
{
    public partial class PrintBillFroCylinder : Form
    {
        public PrintBillFroCylinder()
        {
            InitializeComponent();
        }

        private void PrintBillFroCylinder_Load(object sender, EventArgs e)
        {
            Location = new System.Drawing.Point(-7, 50);
            int w = SystemInformation.VirtualScreen.Width + 14;
            int h = SystemInformation.VirtualScreen.Height - 43;
            Size = new Size(w, h);
        }

        /*protected override void WndProc(ref Message message)
       {
           const int WM_SYSCOMMAND = 0x0112;
           const int SC_MOVE = 0xF010;

           switch (message.Msg)
           {
               case WM_SYSCOMMAND:
                   int command = message.WParam.ToInt32() & 0xfff0;
                   if (command == SC_MOVE)
                       return;
                   break;
           }

           base.WndProc(ref message);
       }*/
    }
}
