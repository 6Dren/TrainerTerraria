using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace TerrariaTrainer.Cheats
{
    class UnlimitedMana
    {

        // Scan Mana1 = Mana  = sub[esi+39C],eax

        string aobStartMana0 = "";
        byte[] aobOnMana0 = { 0 };
        byte[] aobOffMana0 = { 0 };
        long addrsMana0 = 0;
        string addressMana0 = "";

        // Scan Mana1 = Mana  = sub[esi+39C],edi

        string aobStartMana1 = "";
        byte[] aobOnMana1 = { 0 };
        byte[] aobOffMana1 = { 0 };
        long addrsMana1 = 0;
        string addressMana1 = "";

        public void ScanAobs(Mem m)
        {
            // -Mana1

            aobStartMana0 = "29 86 9C 03 00 00 EB 33 80";
            aobOnMana0 = Form1.ConvertStringToAOB("83 86 9C 03 00 00 32 EB 32");
            aobOffMana0 = Form1.ConvertStringToAOB(aobStartMana0);

            if (m.AoBScan(0x01000000, 0xf10000000, "83 86 9C 03 00 00 32 EB 32").Result.ToList().Count >= 1)
            {
                addrsMana0 = m.AoBScan(0x01000000, 0xf10000000, "83 86 9C 03 00 00 32 EB 32").Result.FirstOrDefault();

                addressMana0 = "0x" + addrsMana0.ToString("x8");

                Form1.cbUM.Checked = true;
            }
            else
            {
                Form1.cbUM.Checked = false;
                addrsMana0 = m.AoBScan(0x01000000, 0xf10000000, "29 86 9C 03 00 00 EB 33 80").Result.FirstOrDefault();
                addressMana0 = "0x" + addrsMana0.ToString("x8");
            }

            // -Mana2

            aobStartMana1 = "29 BE 9C 03 00 00 B8";
            aobOnMana1 = Form1.ConvertStringToAOB("01 BE 9C 03 00 00 B8");
            aobOffMana1 = Form1.ConvertStringToAOB(aobStartMana1);

            if (m.AoBScan(0x01000000, 0xf10000000, "01 BE 9C 03 00 00 B8").Result.ToList().Count >= 1)
            {
                addrsMana1 = m.AoBScan(0x01000000, 0xf10000000, "01 BE 9C 03 00 00 B8").Result.FirstOrDefault();

                addressMana1 = "0x" + addrsMana1.ToString("x8");

                Form1.cbUM.Checked = true;
            }
            else
            {
                Form1.cbUM.Checked = false;
                addrsMana1 = m.AoBScan(0x01000000, 0xf10000000, "29 BE 9C 03 00 00 B8").Result.FirstOrDefault();
                addressMana1 = "0x" + addrsMana1.ToString("x8");
            }
        }

        public void ActivateOrNot(Mem me)
        {
            if (Form1.cbUM.Checked)
            {
                me.WriteBytes(addressMana0, aobOnMana0);
                me.WriteBytes(addressMana1, aobOnMana1);

                Form1.cbUM.ForeColor = Color.Gold;
            }
            else
            {
                me.WriteBytes(addressMana0, aobOffMana0);
                me.WriteBytes(addressMana1, aobOffMana1);

                Form1.cbUM.ForeColor = Color.White;
            }
        }
    }
}
