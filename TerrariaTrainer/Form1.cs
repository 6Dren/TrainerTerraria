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

namespace TerrariaTrainer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Mem m = new Mem();


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
                Thread.Sleep(100);
                // Scan aob ghost hit = Hit0

                string aobStartHit00 = "80 B9 1D 06 00 00 00 74 67"; //cmp
                string aobStartHit0 = "C6 81 1D 06 00 00 00";

                byte[] aobOnHit00 = ConvertStringToAOB("80 B9 1D 06 00 00 02");
                byte[] aobOnHit0 = ConvertStringToAOB("C6 81 1D 06 00 00 02");

                byte[] aobOffHit00 = ConvertStringToAOB(aobStartHit00);
                byte[] aobOffHit0 = ConvertStringToAOB(aobStartHit0);

                long addrsHit00;
                long addrsHit0;

                string addressHit00;
                string addressHit0;

                if (m.AoBScan(0x01000000, 0xf10000000, "C6 81 1D 06 00 00 02").Result.ToList().Count >= 1)
                {
                    addrsHit0 = m.AoBScan(0x01000000, 0xf10000000, "C6 81 1D 06 00 00 02").Result.LastOrDefault();
                    addrsHit00 = m.AoBScan(0x01000000, 0xf10000000, "80 B9 1D 06 00 00 02").Result.LastOrDefault();

                    addressHit0 = "0x" + addrsHit0.ToString("x8");
                    addressHit00 = "0x" + addrsHit00.ToString("x8");

                    cbGodMode.Checked = true;
                }
                else
                {
                    cbGodMode.Checked = false;
                    addrsHit0 = m.AoBScan(0x01000000, 0xf10000000, "C6 81 1D 06 00 00 00").Result.FirstOrDefault();
                    addrsHit00 = m.AoBScan(0x01000000, 0xf10000000, "80 B9 1D 06 00 00 00 74 67").Result.LastOrDefault();

                    addressHit0 = "0x" + addrsHit0.ToString("x8");
                    addressHit00 = "0x" + addrsHit00.ToString("x8");
                }


                // Scan aob Road of Discord hit = Hit1
                string aobStartHit1 = "29 86 98 03 00 00";
                byte[] aobOnHit1 = ConvertStringToAOB("01 86 98 03 00 00");
                byte[] aobOffHit1 = ConvertStringToAOB(aobStartHit1);
                long addrsHit1;
                string addressHit1;

                if (m.AoBScan(0x01000000, 0xf10000000, "01 86 98 03 00 00").Result.ToList().Count > 1)
                {
                    addrsHit1 = m.AoBScan(0x01000000, 0xf10000000, "01 86 98 03 00 00").Result.LastOrDefault();
                    addressHit1 = "0x" + addrsHit1.ToString("x8");
                    cbGodMode.Checked = true;
                }
                else
                {
                    cbGodMode.Checked = false;
                    addrsHit1 = m.AoBScan(0x01000000, 0xf10000000, "29 86 98 03 00 00").Result.FirstOrDefault();
                    addressHit1 = "0x" + addrsHit1.ToString("x8");
                }

                // Scan sand hit = Hit2
                string aobStartHit2 = "83 83 98 03 00 00 FB";
                byte[] aobOnHit2 = ConvertStringToAOB("83 83 98 03 00 00 05");
                byte[] aobOffHit2 = ConvertStringToAOB(aobStartHit2);
                long addrsHit2;
                string addressHit2;

                if (m.AoBScan(0x01000000, 0xf10000000, "83 83 98 03 00 00 05").Result.ToList().Count >= 1)
                {
                    addrsHit2 = m.AoBScan(0x01000000, 0xf10000000, "83 83 98 03 00 00 05").Result.FirstOrDefault();
                    addressHit2 = "0x" + addrsHit2.ToString("x8");

                    cbGodMode.Checked = true;
                }
                else
                {
                    cbGodMode.Checked = false;
                    addrsHit2 = m.AoBScan(0x01000000, 0xf10000000, "83 83 98 03 00 00 FB").Result.FirstOrDefault();
                    addressHit2 = "0x" + addrsHit2.ToString("x8");
                }

                // Scan aob normal hit = Hit3
                string aobStartHit3 = "29 82 98 03 00 00";
                byte[] aobOnHit3 = ConvertStringToAOB("01 82 98 03 00 00");
                byte[] aobOffHit3 = ConvertStringToAOB(aobStartHit3);
                long addrsHit3;
                string addressHit3;

                if (m.AoBScan(0x01000000, 0xf10000000, "01 82 98 03 00 00").Result.ToList().Count > 1)
                {
                    addrsHit3 = m.AoBScan(0x01000000, 0xf10000000, "01 82 98 03 00 00").Result.LastOrDefault();
                    addressHit3 = "0x" + addrsHit3.ToString("x8");
                    cbGodMode.Checked = true;
                }
                else
                {
                    cbGodMode.Checked = false;
                    addrsHit3 = m.AoBScan(0x01000000, 0xf10000000, "29 82 98 03 00 00").Result.FirstOrDefault();
                    addressHit3 = "0x" + addrsHit3.ToString("x8");
                }

                // Scan aob breathless hit = Hit4
                string aobStartHit4 = "83 80 98 03 00 00 FE";
                byte[] aobOnHit4 = ConvertStringToAOB("83 80 98 03 00 00 06");
                byte[] aobOffHit4 = ConvertStringToAOB(aobStartHit4);
                long addrsHit4;
                string addressHit4;

                if (m.AoBScan(0x01000000, 0xf10000000, "83 80 98 03 00 00 06").Result.ToList().Count >= 1)
                {
                    addrsHit4 = m.AoBScan(0x01000000, 0xf10000000, "83 80 98 03 00 00 06").Result.FirstOrDefault();
                    addressHit4 = "0x" + addrsHit4.ToString("x8");
                    cbGodMode.Checked = true;
                }
                else
                {
                    cbGodMode.Checked = false;
                    addrsHit4 = m.AoBScan(0x01000000, 0xf10000000, "83 80 98 03 00 00 FE").Result.FirstOrDefault();
                    addressHit4 = "0x" + addrsHit4.ToString("x8");
                }

                // Scan meteor = Hit5  = -4
                string aobStartHit5 = "83 83 98 03 00 00 FC";
                byte[] aobOnHit5 = ConvertStringToAOB("83 83 98 03 00 00 21");
                byte[] aobOffHit5 = ConvertStringToAOB(aobStartHit5);
                long addrsHit5;
                string addressHit5;

                if (m.AoBScan(0x01000000, 0xf10000000, "83 83 98 03 00 00 21").Result.ToList().Count >= 1)
                {
                    addrsHit5 = m.AoBScan(0x01000000, 0xf10000000, "83 83 98 03 00 00 21").Result.FirstOrDefault();
                    addressHit5 = "0x" + addrsHit5.ToString("x8");
                    cbGodMode.Checked = true;
                }
                else
                {
                    cbGodMode.Checked = false;
                    addrsHit5 = m.AoBScan(0x01000000, 0xf10000000, "83 83 98 03 00 00 FC").Result.FirstOrDefault();
                    addressHit5 = "0x" + addrsHit5.ToString("x8");
                }

                // Scan meteor = Hit6  = -5
                string aobStartHit6 = "83 83 98 03 00 00 FB";
                byte[] aobOnHit6 = ConvertStringToAOB("83 83 98 03 00 00 22");
                byte[] aobOffHit6 = ConvertStringToAOB(aobStartHit6);
                long addrsHit6;
                string addressHit6;

                if (m.AoBScan(0x01000000, 0xf10000000, "83 83 98 03 00 00 22").Result.ToList().Count >= 1)
                {
                    addrsHit6 = m.AoBScan(0x01000000, 0xf10000000, "83 83 98 03 00 00 22").Result.FirstOrDefault();
                    addressHit6 = "0x" + addrsHit6.ToString("x8");
                    cbGodMode.Checked = true;
                }
                else
                {
                    cbGodMode.Checked = false;
                    addrsHit6 = m.AoBScan(0x01000000, 0xf10000000, "83 83 98 03 00 00 22").Result.FirstOrDefault();
                    addressHit6 = "0x" + addrsHit6.ToString("x8");
                }

                // Scan meteor = Hit7  = -3
                string aobStartHit7 = "83 83 98 03 00 00 FD";
                byte[] aobOnHit7 = ConvertStringToAOB("83 83 98 03 00 00 23");
                byte[] aobOffHit7 = ConvertStringToAOB(aobStartHit7);
                long addrsHit7;
                string addressHit7;

                if (m.AoBScan(0x01000000, 0xf10000000, "83 83 98 03 00 00 23").Result.ToList().Count >= 1)
                {
                    addrsHit7 = m.AoBScan(0x01000000, 0xf10000000, "83 83 98 03 00 00 23").Result.FirstOrDefault();
                    addressHit7 = "0x" + addrsHit7.ToString("x8");
                    cbGodMode.Checked = true;
                }
                else
                {
                    cbGodMode.Checked = false;
                    addrsHit7 = m.AoBScan(0x01000000, 0xf10000000, "83 83 98 03 00 00 FD").Result.FirstOrDefault();
                    addressHit7 = "0x" + addrsHit7.ToString("x8");
                }

                // Scan meteor = Hit8  = -2
                string aobStartHit8 = "83 83 98 03 00 00 FE";
                byte[] aobOnHit8 = ConvertStringToAOB("83 83 98 03 00 00 24");
                byte[] aobOffHit8 = ConvertStringToAOB(aobStartHit8);
                long addrsHit8;
                string addressHit8;

                if (m.AoBScan(0x01000000, 0xf10000000, "83 83 98 03 00 00 24").Result.ToList().Count >= 1)
                {
                    addrsHit8 = m.AoBScan(0x01000000, 0xf10000000, "83 83 98 03 00 00 24").Result.FirstOrDefault();
                    addressHit8 = "0x" + addrsHit8.ToString("x8");
                    cbGodMode.Checked = true;
                }
                else
                {
                    cbGodMode.Checked = false;
                    addrsHit8 = m.AoBScan(0x01000000, 0xf10000000, "83 83 98 03 00 00 FE").Result.FirstOrDefault();
                    addressHit8 = "0x" + addrsHit8.ToString("x8");
                }

                // Scan meteor = Hit9  = -1
                string aobStartHit9 = "FF 8B 98 03 00 00 8D";
                byte[] aobOnHit9 = ConvertStringToAOB("0F 1F 83 98 03 00 00");
                byte[] aobOffHit9 = ConvertStringToAOB(aobStartHit9);
                long addrsHit9;
                string addressHit9;

                if (m.AoBScan(0x01000000, 0xf10000000, "0F 1F 83 98 03 00 00").Result.ToList().Count >= 1)
                {
                    addrsHit9 = m.AoBScan(0x01000000, 0xf10000000, "0F 1F 83 98 03 00 00").Result.FirstOrDefault();
                    addressHit9 = "0x" + addrsHit9.ToString("x8");
                    cbGodMode.Checked = true;
                }
                else
                {
                    cbGodMode.Checked = false;
                    addrsHit9 = m.AoBScan(0x01000000, 0xf10000000, "FF 8B 98 03 00 00 8D").Result.FirstOrDefault();
                    addressHit9 = "0x" + addrsHit9.ToString("x8");
                }

                status.Text = "Status: off";
                status.ForeColor = Color.Silver;

                while (openProc && addrsHit0 != 0)
                {
                    Thread.Sleep(100);
                    status.Text = "Status: on";
                    status.ForeColor = Color.DarkRed;
                    lbPid.Text = $"PID: {m.GetProcIdFromName("Terraria")}";

                    // GodMode


                    if (cbGodMode.Checked)
                    {
                        m.WriteBytes(addressHit00, aobOnHit00);
                        m.WriteBytes(addressHit0, aobOnHit0);
                        m.WriteBytes(addressHit1, aobOnHit1);
                        m.WriteBytes(addressHit2, aobOnHit2);
                        m.WriteBytes(addressHit3, aobOnHit3);
                        m.WriteBytes(addressHit4, aobOnHit4);
                        m.WriteBytes(addressHit5, aobOnHit5);
                        m.WriteBytes(addressHit6, aobOnHit6);
                        m.WriteBytes(addressHit7, aobOnHit7);
                        m.WriteBytes(addressHit8, aobOnHit8);
                        m.WriteBytes(addressHit9, aobOnHit9);

                        cbGodMode.ForeColor = Color.Gold;
                    }
                    else
                    {
                        m.WriteBytes(addressHit00, aobOffHit00);
                        m.WriteBytes(addressHit0, aobOffHit0);
                        m.WriteBytes(addressHit1, aobOffHit1);
                        m.WriteBytes(addressHit2, aobOffHit2);
                        m.WriteBytes(addressHit3, aobOffHit3);
                        m.WriteBytes(addressHit4, aobOffHit4);
                        m.WriteBytes(addressHit5, aobOffHit5);
                        m.WriteBytes(addressHit6, aobOffHit6);
                        m.WriteBytes(addressHit7, aobOffHit7);
                        m.WriteBytes(addressHit8, aobOffHit8);
                        m.WriteBytes(addressHit9, aobOffHit9);

                        cbGodMode.ForeColor = Color.White;
                    }
                }
            }
        }

        private void checkStatus_Tick(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }


        private byte[] ConvertStringToAOB(string text)
        {
            string[] bts = text.Split(' ');
            byte[] aob = new byte[bts.Length];

            for (int i = 0; i < aob.Length; i++)
                aob[i] = Convert.ToByte(bts[i], 16);
            return aob;
        }
    }
}
