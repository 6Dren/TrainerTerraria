using Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerrariaTrainer;

namespace TerrariaTrainer.Cheats
{
    public class GodMode //: Form1
    {
        // Scan aob set health to 7FFFFFFF = health: 2,147,483,647

        string aobStartHit0 = "";

        byte[] aobOnHit0 = { 0 };

        byte[] aobOffHit0 = { 0 };

        public long addrsHit0 = 0;

        public string addressHit0 = "";

        // Scan aob detect hit

        string aobStartHit1 = "";
        byte[] aobOnHit1 = { 0 };
        byte[] aobOffHit1 = { 0 };
        long addrsHit1 = 0;
        string addressHit1 = "";

        public void ScanAobs(Mem m)
        {
            // Scan aob set health to 7FFFFFFF = freezes health: 2,147,483,647
            aobStartHit0 = "8B 87 B4 03 00 00 89 06 8B 87 B8 03 00 00"; // aob Start
            aobOnHit0 = Form1.ConvertStringToAOB("C7 82 B4 03 00 00 FF FF FF 7F 90 90 90 90"); // aob On
            aobOffHit0 = Form1.ConvertStringToAOB(aobStartHit0);

            System.Threading.Thread.Sleep(100);
            if (m.AoBScan(0x01000000, 0xf10000000, "C7 82 B4 03 00 00 FF FF FF 7F").Result.ToList().Count >= 1)
            {
                System.Threading.Thread.Sleep(100);
                addrsHit0 = m.AoBScan(0x01000000, 0xf10000000, "C7 82 B4 03 00 00 FF FF FF 7F").Result.FirstOrDefault();
                addressHit0 = "0x" + addrsHit0.ToString("x8");

                Form1.cbGodMode.Invoke((MethodInvoker)(() => Form1.cbGodMode.Checked = true));
                Form1.cbGodMode.ForeColor = Color.Gold;
                Form1.cbGodMode.Invoke((MethodInvoker)(() => Form1.cbGodMode.Enabled = true));
            }
            else if (m.AoBScan(0x01000000, 0xf10000000, "8B 87 B4 03 00 00 89 06 8B 87 B8 03 00 00").Result.ToList().Count >= 1)
            {
                System.Threading.Thread.Sleep(100);
                addrsHit0 = m.AoBScan(0x01000000, 0xf10000000, "8B 87 B4 03 00 00 89 06 8B 87 B8 03 00 00").Result.LastOrDefault();
                addressHit0 = "0x" + addrsHit0.ToString("x8");

                Form1.cbGodMode.Invoke((MethodInvoker)(() => Form1.cbGodMode.Checked = false));
                Form1.cbGodMode.ForeColor = Color.FromArgb(227, 227, 234);
                Form1.cbGodMode.Invoke((MethodInvoker)(() => Form1.cbGodMode.Enabled = true));
            }


            // Scan aob detect hit

            aobStartHit1 = "80 B8 C1 06 00 00 00 74 0D";
            aobOnHit1 = Form1.ConvertStringToAOB("80 B8 C1 06 00 00 02");
            aobOffHit1 = Form1.ConvertStringToAOB(aobStartHit1);

            if (m.AoBScan(0x01000000, 0xf10000000, "80 B8 C1 06 00 00 02").Result.ToList().Count >= 1)
            {
                addrsHit1 = m.AoBScan(0x01000000, 0xf10000000, "80 B8 C1 06 00 00 02").Result.FirstOrDefault();
                addressHit1 = "0x" + addrsHit1.ToString("x8");

                Form1.cbUntouch.Invoke((MethodInvoker)(() => Form1.cbUntouch.Checked = true));
                Form1.cbUntouch.ForeColor = Color.Gold;
                Form1.cbUntouch.Enabled = true;
            }
            else if (m.AoBScan(0x01000000, 0xf10000000, "80 B8 C1 06 00 00 00 74 0D").Result.ToList().Count >= 1)
            {
                addrsHit1 = m.AoBScan(0x01000000, 0xf10000000, "80 B8 C1 06 00 00 00 74 0D").Result.FirstOrDefault();
                addressHit1 = "0x" + addrsHit1.ToString("x8");

                Form1.cbUntouch.Invoke((MethodInvoker)(() => Form1.cbUntouch.Checked = false));
                Form1.cbUntouch.ForeColor = Color.FromArgb(227, 227, 234);
                Form1.cbUntouch.Enabled = true;
            }

            // Set visible untouchable checkbox to true
            if (Form1.cbGodMode.Checked)
                Form1.cbUntouch.Invoke((MethodInvoker)(() => Form1.cbUntouch.Visible = true));
        }

        public void OnOrOff(Mem me)
        {
            if (Form1.cbGodMode.Checked)
            {
                if (Form1.cbUnlimitedMana.Checked)
                    me.WriteBytes(addressHit0, Form1.ConvertStringToAOB("C7 82 B4 03 00 00 FF FF FF 7F C7 82 B8 03 00 00 C8 00 00 00 90 90 90 89 46"));
                else
                    me.WriteBytes(addressHit0, Form1.ConvertStringToAOB("C7 82 B4 03 00 00 FF FF FF 7F 90 90 90 90 89 46 10 8B 87 B0 03 00 00 89 46"));

                Form1.cbGodMode.ForeColor = Color.Gold;
            }
            else
            {
                if (Form1.cbUnlimitedMana.Checked)
                    me.WriteBytes(addressHit0, Form1.ConvertStringToAOB("8B 87 B4 03 00 00 89 06 C7 82 B8 03 00 00 C8 00 00 00 90 90 90 90 90 89 46"));
                else
                    me.WriteBytes(addressHit0, Form1.ConvertStringToAOB("8B 87 B4 03 00 00 89 06 8B 87 B8 03 00 00 89 46 10 8B 87 B0 03 00 00 89 46"));

                Form1.cbGodMode.ForeColor = Color.FromArgb(227, 227, 234);
                if (Form1.cbUntouch.Enabled)
                {
                    me.WriteBytes(addressHit1, aobOffHit1);
                    Form1.cbUntouch.Checked = false;
                    Form1.cbUntouch.ForeColor = Color.FromArgb(227, 227, 234);
                }
            }

            if (Form1.cbUntouch.Checked)
            {
                me.WriteBytes(addressHit1, aobOnHit1);
                Form1.cbUntouch.ForeColor = Color.Gold;
            }
            else
            {
                me.WriteBytes(addressHit1, aobOffHit1);
                Form1.cbUntouch.ForeColor = Color.FromArgb(227, 227, 234);
            }

        }

    }
}
