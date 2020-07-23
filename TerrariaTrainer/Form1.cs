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
            godmode = new Godmode();
            while (openProc)
            {
                Thread newthread = new Thread(() =>
                {
                    this.BeginInvoke((Action)delegate ()
                    {
                        Thread.Sleep(100);
                        godmode.ScanAobs(m);

                        status.Text = "Status: off";
                        status.ForeColor = Color.Silver;

                        while (openProc && godmode.addrsHit0 != 0)
                        {
                            Thread.Sleep(100);
                            status.Text = "Status: on";
                            status.ForeColor = Color.DarkRed;
                            lbPid.Text = $"PID: {m.GetProcIdFromName("Terraria")}";

                            // GodMode

                            if (cbGodMode.Checked)
                            {
                                godmode.ActivateOrNot();
                            }
                            else
                            {
                                godmode.ActivateOrNot();
                            }
                        }
                    });
                });
                Thread.Sleep(100);
                if (!(newthread.IsAlive))
                    newthread.Start();
                else newthread.Abort();
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
