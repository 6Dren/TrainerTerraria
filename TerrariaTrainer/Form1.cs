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
        public static GodMode godMode;
        private UnlimitedMana unlimitedMana;

        private void Form1_Load(object sender, EventArgs e)
        {
            checkStatus.Enabled = true;
        }

        //Run cheats
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            bool openProc = m.OpenProcess("Terraria");

            clickScan(sender, e);

            while (openProc)
            {
                Thread.Sleep(100);
                //unlimitedMana = new UnlimitedMana();

                //unlimitedMana.ScanAobs(m);

                lbStatus.Invoke((MethodInvoker)(() => lbStatus.Text = $"Status: load | Please play some map and click scan!"));
                lbStatus.ForeColor = Color.Silver;
                lbPid.Invoke((MethodInvoker)(() => lbPid.Text = $"PID: {m.GetProcIdFromName("Terraria")}"));

                while (openProc && godMode.addrsHit0 != 0)
                {
                    Thread.Sleep(100);
                    lbStatus.Invoke((MethodInvoker)(() => lbStatus.Text = "Status: on"));
                    lbStatus.ForeColor = Color.DarkRed;

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
            //if (text == "")
            //    return new byte[] { 0 };
            string[] bts = text.Split(' ');
            byte[] aob = new byte[bts.Length];

            for (int i = 0; i < aob.Length; i++)
                aob[i] = Convert.ToByte(bts[i], 16);
            return aob;
        }

        public static string ConvertAOBToString(byte[] bts)
        {
            if (bts == null)
                bts = new byte[] { 0 };
            string text = "";

            foreach (var bt in bts)
                text += bt.ToString("x2") + " ";
            return text;
        }

        private void clickScan(object sender, EventArgs e)
        {
            Thread.Sleep(100);

            // GodMode Scan
            godMode = new GodMode();
            godMode.ScanAobs(m);

            // Unlimited Mana Scan
            unlimitedMana = new UnlimitedMana();
            unlimitedMana.ScanAobs(m);

        }

        private void clickCB(object sender, EventArgs e)
        {
            switch (((CheckBox)sender).Name)
            {
                // GodMode  
                case "cbGodMode":
                    godMode.OnOrOff(m);
                    if (cbGodMode.Checked)
                        cbUntouch.Visible = true;
                    else cbUntouch.Visible = false;
                    break;

                // cbUntouch
                case "cbUntouch":
                    godMode.OnOrOff(m);
                    if (cbGodMode.Checked)
                        cbUntouch.Visible = true;
                    else cbUntouch.Visible = false;
                    break;

                // cbUnlimitedMana
                case "cbUnlimitedMana":
                    unlimitedMana.OnOrOff(m);
                    break;
            }
        }
    }
}

