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
    public class Godmode //: Form1
    {
        // Scan aob ghost hit = Hit0

        string aobStartHit00 = ""; //cmp
        string aobStartHit0 = "";

        byte[] aobOnHit00 = { 0 };
        byte[] aobOnHit0 = { 0 };

        byte[] aobOffHit00 = { 0 };
        byte[] aobOffHit0 = { 0 };

        long addrsHit00 = 0;
        public long addrsHit0 = 0;

        string addressHit00 = "";
        string addressHit0 = "";

        // Scan aob Road of Discord hit = Hit1

        string aobStartHit1 = "";
        byte[] aobOnHit1 = { 0 };
        byte[] aobOffHit1 = { 0 };
        long addrsHit1 = 0;
        string addressHit1 = "";

        // Scan sand hit = Hit2

        string aobStartHit2 = "";
        byte[] aobOnHit2 = { 0 };
        byte[] aobOffHit2 = { 0 };
        long addrsHit2 = 0;
        string addressHit2 = "";

        // Scan aob normal hit = Hit3

        string aobStartHit3 = "";
        byte[] aobOnHit3 = { 0 };
        byte[] aobOffHit3 = { 0 };
        long addrsHit3 = 0;
        string addressHit3 = "";

        // Scan aob breathless hit = Hit4

        string aobStartHit4 = "";
        byte[] aobOnHit4 = { 0 };
        byte[] aobOffHit4 = { 0 };
        long addrsHit4 = 0;
        string addressHit4 = "";

        // Scan meteor = Hit5  = -4

        string aobStartHit5 = "";
        byte[] aobOnHit5 = { 0 };
        byte[] aobOffHit5 = { 0 };
        long addrsHit5 = 0;
        string addressHit5 = "";

        // Scan meteor = Hit6  = -5

        string aobStartHit6 = "";
        byte[] aobOnHit6 = { 0 };
        byte[] aobOffHit6 = { 0 };
        long addrsHit6 = 0;
        string addressHit6 = "";

        // Scan meteor = Hit7  = -3

        string aobStartHit7 = "";
        byte[] aobOnHit7 = { 0 };
        byte[] aobOffHit7 = { 0 };
        long addrsHit7 = 0;
        string addressHit7 = "";

        // Scan meteor = Hit8  = -2

        string aobStartHit8 = "";
        byte[] aobOnHit8 = { 0 };
        byte[] aobOffHit8 = { 0 };
        long addrsHit8 = 0;
        string addressHit8 = "";

        // Scan meteor = Hit9  = -1

        string aobStartHit9 = "";
        byte[] aobOnHit9 = { 0 };
        byte[] aobOffHit9 = { 0 };
        long addrsHit9 = 0;
        string addressHit9 = "";

        public void ScanAobs(Mem m)
        {
            // Scan aob ghost hit = Hit0

            aobStartHit00 = "80 B9 1D 06 00 00 00 74 67"; //cmp
            aobStartHit0 = "C6 81 1D 06 00 00 00";

            aobOnHit00 = Form1.ConvertStringToAOB("80 B9 1D 06 00 00 02");
            aobOnHit0 = Form1.ConvertStringToAOB("C6 81 1D 06 00 00 02");

            aobOffHit00 = Form1.ConvertStringToAOB(aobStartHit00);
            aobOffHit0 = Form1.ConvertStringToAOB(aobStartHit0);

            if (m.AoBScan(0x01000000, 0xf10000000, "C6 81 1D 06 00 00 02").Result.ToList().Count >= 1)
            {
                addrsHit0 = m.AoBScan(0x01000000, 0xf10000000, "C6 81 1D 06 00 00 02").Result.LastOrDefault();
                addrsHit00 = m.AoBScan(0x01000000, 0xf10000000, "80 B9 1D 06 00 00 02").Result.LastOrDefault();

                addressHit0 = "0x" + addrsHit0.ToString("x8");
                addressHit00 = "0x" + addrsHit00.ToString("x8");

                Form1.cbGm.Checked = true;
            }
            else
            {
                Form1.cbGm.Checked = false;
                addrsHit0 = m.AoBScan(0x01000000, 0xf10000000, "C6 81 1D 06 00 00 00").Result.FirstOrDefault();
                addrsHit00 = m.AoBScan(0x01000000, 0xf10000000, "80 B9 1D 06 00 00 00 74 67").Result.LastOrDefault();

                addressHit0 = "0x" + addrsHit0.ToString("x8");
                addressHit00 = "0x" + addrsHit00.ToString("x8");
            }


            // Scan aob Road of Discord hit = Hit1

            aobStartHit1 = "29 86 98 03 00 00";
            aobOnHit1 = Form1.ConvertStringToAOB("01 86 98 03 00 00");
            aobOffHit1 = Form1.ConvertStringToAOB(aobStartHit1);

            if (m.AoBScan(0x01000000, 0xf10000000, "01 86 98 03 00 00").Result.ToList().Count > 1)
            {
                addrsHit1 = m.AoBScan(0x01000000, 0xf10000000, "01 86 98 03 00 00").Result.LastOrDefault();
                addressHit1 = "0x" + addrsHit1.ToString("x8");
                Form1.cbGm.Checked = true;
            }
            else
            {
                Form1.cbGm.Checked = false;
                addrsHit1 = m.AoBScan(0x01000000, 0xf10000000, "29 86 98 03 00 00").Result.FirstOrDefault();
                addressHit1 = "0x" + addrsHit1.ToString("x8");
            }

            // Scan sand hit = Hit2

            aobStartHit2 = "83 83 98 03 00 00 FB";
            aobOnHit2 = Form1.ConvertStringToAOB("83 83 98 03 00 00 05");
            aobOffHit2 = Form1.ConvertStringToAOB(aobStartHit2);

            if (m.AoBScan(0x01000000, 0xf10000000, "83 83 98 03 00 00 05").Result.ToList().Count >= 1)
            {
                addrsHit2 = m.AoBScan(0x01000000, 0xf10000000, "83 83 98 03 00 00 05").Result.FirstOrDefault();
                addressHit2 = "0x" + addrsHit2.ToString("x8");

                Form1.cbGm.Checked = true;
            }
            else
            {
                Form1.cbGm.Checked = false;
                addrsHit2 = m.AoBScan(0x01000000, 0xf10000000, "83 83 98 03 00 00 FB").Result.FirstOrDefault();
                addressHit2 = "0x" + addrsHit2.ToString("x8");
            }

            // Scan aob normal hit = Hit3

            aobStartHit3 = "29 82 98 03 00 00";
            aobOnHit3 = Form1.ConvertStringToAOB("01 82 98 03 00 00");
            aobOffHit3 = Form1.ConvertStringToAOB(aobStartHit3);

            if (m.AoBScan(0x01000000, 0xf10000000, "01 82 98 03 00 00").Result.ToList().Count > 1)
            {
                addrsHit3 = m.AoBScan(0x01000000, 0xf10000000, "01 82 98 03 00 00").Result.LastOrDefault();
                addressHit3 = "0x" + addrsHit3.ToString("x8");
                Form1.cbGm.Checked = true;
            }
            else
            {
                Form1.cbGm.Checked = false;
                addrsHit3 = m.AoBScan(0x01000000, 0xf10000000, "29 82 98 03 00 00").Result.FirstOrDefault();
                addressHit3 = "0x" + addrsHit3.ToString("x8");
            }

            // Scan aob breathless hit = Hit4

            aobStartHit4 = "83 80 98 03 00 00 FE";
            aobOnHit4 = Form1.ConvertStringToAOB("83 80 98 03 00 00 06");
            aobOffHit4 = Form1.ConvertStringToAOB(aobStartHit4);

            if (m.AoBScan(0x01000000, 0xf10000000, "83 80 98 03 00 00 06").Result.ToList().Count >= 1)
            {
                addrsHit4 = m.AoBScan(0x01000000, 0xf10000000, "83 80 98 03 00 00 06").Result.FirstOrDefault();
                addressHit4 = "0x" + addrsHit4.ToString("x8");
                Form1.cbGm.Checked = true;
            }
            else
            {
                Form1.cbGm.Checked = false;
                addrsHit4 = m.AoBScan(0x01000000, 0xf10000000, "83 80 98 03 00 00 FE").Result.FirstOrDefault();
                addressHit4 = "0x" + addrsHit4.ToString("x8");
            }

            // Scan meteor = Hit5  = -4

            aobStartHit5 = "83 83 98 03 00 00 FC";
            aobOnHit5 = Form1.ConvertStringToAOB("83 83 98 03 00 00 21");
            aobOffHit5 = Form1.ConvertStringToAOB(aobStartHit5);

            if (m.AoBScan(0x01000000, 0xf10000000, "83 83 98 03 00 00 21").Result.ToList().Count >= 1)
            {
                addrsHit5 = m.AoBScan(0x01000000, 0xf10000000, "83 83 98 03 00 00 21").Result.FirstOrDefault();
                addressHit5 = "0x" + addrsHit5.ToString("x8");
                Form1.cbGm.Checked = true;
            }
            else
            {
                Form1.cbGm.Checked = false;
                addrsHit5 = m.AoBScan(0x01000000, 0xf10000000, "83 83 98 03 00 00 FC").Result.FirstOrDefault();
                addressHit5 = "0x" + addrsHit5.ToString("x8");
            }

            // Scan meteor = Hit6  = -5

            aobStartHit6 = "83 83 98 03 00 00 FB";
            aobOnHit6 = Form1.ConvertStringToAOB("83 83 98 03 00 00 22");
            aobOffHit6 = Form1.ConvertStringToAOB(aobStartHit6);

            if (m.AoBScan(0x01000000, 0xf10000000, "83 83 98 03 00 00 22").Result.ToList().Count >= 1)
            {
                addrsHit6 = m.AoBScan(0x01000000, 0xf10000000, "83 83 98 03 00 00 22").Result.FirstOrDefault();
                addressHit6 = "0x" + addrsHit6.ToString("x8");
                Form1.cbGm.Checked = true;
            }
            else
            {
                Form1.cbGm.Checked = false;
                addrsHit6 = m.AoBScan(0x01000000, 0xf10000000, "83 83 98 03 00 00 FB").Result.FirstOrDefault();
                addressHit6 = "0x" + addrsHit6.ToString("x8");
            }

            // Scan meteor = Hit7  = -3

            aobStartHit7 = "83 83 98 03 00 00 FD";
            aobOnHit7 = Form1.ConvertStringToAOB("83 83 98 03 00 00 23");
            aobOffHit7 = Form1.ConvertStringToAOB(aobStartHit7);

            if (m.AoBScan(0x01000000, 0xf10000000, "83 83 98 03 00 00 23").Result.ToList().Count >= 1)
            {
                addrsHit7 = m.AoBScan(0x01000000, 0xf10000000, "83 83 98 03 00 00 23").Result.FirstOrDefault();
                addressHit7 = "0x" + addrsHit7.ToString("x8");
                Form1.cbGm.Checked = true;
            }
            else
            {
                Form1.cbGm.Checked = false;
                addrsHit7 = m.AoBScan(0x01000000, 0xf10000000, "83 83 98 03 00 00 FD").Result.FirstOrDefault();
                addressHit7 = "0x" + addrsHit7.ToString("x8");
            }

            // Scan meteor = Hit8  = -2

            aobStartHit8 = "83 83 98 03 00 00 FE";
            aobOnHit8 = Form1.ConvertStringToAOB("83 83 98 03 00 00 24");
            aobOffHit8 = Form1.ConvertStringToAOB(aobStartHit8);

            if (m.AoBScan(0x01000000, 0xf10000000, "83 83 98 03 00 00 24").Result.ToList().Count >= 1)
            {
                addrsHit8 = m.AoBScan(0x01000000, 0xf10000000, "83 83 98 03 00 00 24").Result.FirstOrDefault();
                addressHit8 = "0x" + addrsHit8.ToString("x8");
                Form1.cbGm.Checked = true;
            }
            else
            {
                Form1.cbGm.Checked = false;
                addrsHit8 = m.AoBScan(0x01000000, 0xf10000000, "83 83 98 03 00 00 FE").Result.FirstOrDefault();
                addressHit8 = "0x" + addrsHit8.ToString("x8");
            }

            // Scan meteor = Hit9  = -1

            aobStartHit9 = "FF 8B 98 03 00 00 8D";
            aobOnHit9 = Form1.ConvertStringToAOB("0F 1F 83 98 03 00 00");
            aobOffHit9 = Form1.ConvertStringToAOB(aobStartHit9);

            if (m.AoBScan(0x01000000, 0xf10000000, "0F 1F 83 98 03 00 00").Result.ToList().Count >= 1)
            {
                addrsHit9 = m.AoBScan(0x01000000, 0xf10000000, "0F 1F 83 98 03 00 00").Result.FirstOrDefault();
                addressHit9 = "0x" + addrsHit9.ToString("x8");
                Form1.cbGm.Checked = true;
            }
            else
            {
                Form1.cbGm.Checked = false;
                addrsHit9 = m.AoBScan(0x01000000, 0xf10000000, "FF 8B 98 03 00 00 8D").Result.FirstOrDefault();
                addressHit9 = "0x" + addrsHit9.ToString("x8");
            }
        }

        public void ActivateOrNot(Mem me)
        {
            if (Form1.cbGm.Checked)
            {
                me.WriteBytes(addressHit00, aobOnHit00);
                me.WriteBytes(addressHit0, aobOnHit0);
                me.WriteBytes(addressHit1, aobOnHit1);
                me.WriteBytes(addressHit2, aobOnHit2);
                me.WriteBytes(addressHit3, aobOnHit3);
                me.WriteBytes(addressHit4, aobOnHit4);
                me.WriteBytes(addressHit5, aobOnHit5);
                me.WriteBytes(addressHit6, aobOnHit6);
                me.WriteBytes(addressHit7, aobOnHit7);
                me.WriteBytes(addressHit8, aobOnHit8);
                me.WriteBytes(addressHit9, aobOnHit9);

                Form1.cbGm.ForeColor = Color.Gold;
            }
            else
            {
                me.WriteBytes(addressHit00, aobOffHit00);
                me.WriteBytes(addressHit0, aobOffHit0);
                me.WriteBytes(addressHit1, aobOffHit1);
                me.WriteBytes(addressHit2, aobOffHit2);
                me.WriteBytes(addressHit3, aobOffHit3);
                me.WriteBytes(addressHit4, aobOffHit4);
                me.WriteBytes(addressHit5, aobOffHit5);
                me.WriteBytes(addressHit6, aobOffHit6);
                me.WriteBytes(addressHit7, aobOffHit7);
                me.WriteBytes(addressHit8, aobOffHit8);
                me.WriteBytes(addressHit9, aobOffHit9);

                Form1.cbGm.ForeColor = Color.White;
            }
        }

    }
}
