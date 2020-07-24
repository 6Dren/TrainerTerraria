using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;
using TerrariaTrainer.Cheats;

namespace TerrariaTrainer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Mem m = new Mem();
        private Godmode godmode;

        private void Form1_Load(object sender, EventArgs e)
        {
            checkStatus.Enabled = true;
        }

        //Run cheats
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            bool openProc = m.OpenProcess("Terraria");
            while (openProc)
            {
                godmode = new Godmode();
                Thread.Sleep(100);
                godmode.ScanAobs(m);

                lbStatus.Text = "Status: off";
                lbStatus.ForeColor = Color.Silver;

                while (openProc && godmode.addrsHit0 != 0)
                {
                    Thread.Sleep(100);
                    lbStatus.Text = "Status: on";
                    lbStatus.ForeColor = Color.DarkRed;
                    lbPid.Text = $"PID: {m.GetProcIdFromName("Terraria")}";

                    // GodMode

                    if (cbGodMode.Checked)
                    {
                        godmode.ActivateOrNot(m);
                        //cbGodMode.ForeColor = Color.Gold;
                    }
                    else
                    {
                        godmode.ActivateOrNot(m);
                        //cbGodMode.ForeColor = Color.White;
                    }
                }
            }
        }

        private void checkStatus_Tick(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }


        public static byte[] ConvertStringToAOB(string text)
        {
            string[] bts = text.Split(' ');
            byte[] aob = new byte[bts.Length];

            for (int i = 0; i < aob.Length; i++)
                aob[i] = Convert.ToByte(bts[i], 16);
            return aob;
        }
    }
}
