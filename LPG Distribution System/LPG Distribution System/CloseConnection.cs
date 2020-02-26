﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPG_Distribution_System
{
    public partial class CloseConnection : Form
    {
        List<StockMgntRef.Stove> stoves = null;
        public CloseConnection()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message message)
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
        }

        private void RemoveCustomer_Load(object sender, EventArgs e)
        {
            Location = new Point(-7, 50);
            int w = SystemInformation.VirtualScreen.Width + 14;
            int h = SystemInformation.VirtualScreen.Height - 43;
            Size = new Size(w, h);
            AutoCompleteStringCollection acsc = new AutoCompleteStringCollection();
            using (StockMgntRef.StockMgntClient client = new StockMgntRef.StockMgntClient())
            {
                stoves = client.GetStoves().ToList();
                string[] stoveTypes = stoves.Where(x => x.Price != 0).Select(x => x.Product).ToArray();
                acsc.AddRange(stoveTypes);
                textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
                textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                textBox1.AutoCompleteCustomSource = acsc;

            }

        }
    }
}
