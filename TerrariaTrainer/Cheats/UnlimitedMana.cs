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

        public void ScanAobs(Mem m)
        {
            // Scan aob set Mana to C8 = freezes Mana: 200

            //aobStartMana0 = "8B 87 AC 03 00 00 89 06 8B 87 B0 03 00 00";
            //aobOnMana0 = Form1.ConvertStringToAOB("C7 87 B0 03 00 00 C8 00 00 00 90 90 90 90");
            //aobOffMana0 = Form1.ConvertStringToAOB(aobStartMana0);

            //MessageBox.Show((Form1.ConvertAOBToString(m.ReadBytes(Form1.godMode.addressHit0, 25)).ToUpper() == "8B 87 B4 03 00 00 89 06 8B 87 B8 03 00 00 89 46 10 8B 87 B0 03 00 00 89 46 ").ToString());

            if (Form1.cbGodMode.Enabled & (
                Form1.ConvertAOBToString(m.ReadBytes(Form1.godMode.addressHit0, 25)).ToUpper() == "8B 87 B4 03 00 00 89 06 C7 82 B8 03 00 00 C8 00 00 00 90 90 90 90 90 89 46 "
                || Form1.ConvertAOBToString(m.ReadBytes(Form1.godMode.addressHit0, 25)).ToUpper() == "C7 82 B4 03 00 00 FF FF FF 7F C7 82 B8 03 00 00 C8 00 00 00 90 90 90 89 46 "))
            {
                addressMana0 = Form1.godMode.addressHit0;
                Form1.cbUnlimitedMana.Invoke((MethodInvoker)(() => Form1.cbUnlimitedMana.Checked = true)); // Checkbox = true
                Form1.cbUnlimitedMana.ForeColor = Color.Gold;
                Form1.cbUnlimitedMana.Invoke((MethodInvoker)(() => Form1.cbUnlimitedMana.Enabled = true));
            }
            else if (Form1.cbGodMode.Enabled & (
                Form1.ConvertAOBToString(m.ReadBytes(Form1.godMode.addressHit0, 25)).ToUpper() == "8B 87 B4 03 00 00 89 06 8B 87 B8 03 00 00 89 46 10 8B 87 B0 03 00 00 89 46 "
                || Form1.ConvertAOBToString(m.ReadBytes(Form1.godMode.addressHit0, 25)).ToUpper() == "C7 82 B4 03 00 00 FF FF FF 7F 90 90 90 90 89 46 10 8B 87 B0 03 00 00 89 46 "))
            {
                addressMana0 = Form1.godMode.addressHit0;
                Form1.cbUnlimitedMana.Invoke((MethodInvoker)(() => Form1.cbUnlimitedMana.Checked = false)); // Checkbox = false
                Form1.cbUnlimitedMana.ForeColor = Color.FromArgb(227, 227, 234);
                Form1.cbUnlimitedMana.Invoke((MethodInvoker)(() => Form1.cbUnlimitedMana.Enabled = true));
            }
        }

        public void OnOrOff(Mem me)
        {
            if (Form1.cbUnlimitedMana.Checked)
            {
                if (Form1.cbGodMode.Checked)
                    me.WriteBytes(addressMana0, Form1.ConvertStringToAOB("C7 82 B4 03 00 00 FF FF FF 7F C7 82 B8 03 00 00 C8 00 00 00 90 90 90 89 46"));
                else
                    me.WriteBytes(addressMana0, Form1.ConvertStringToAOB("8B 87 B4 03 00 00 89 06 C7 82 B8 03 00 00 C8 00 00 00 90 90 90 90 90 89 46"));

                Form1.cbUnlimitedMana.ForeColor = Color.Gold;
            }
            else
            {
                if (Form1.cbGodMode.Checked)
                    me.WriteBytes(addressMana0, Form1.ConvertStringToAOB("C7 82 B4 03 00 00 FF FF FF 7F 90 90 90 90 89 46 10 8B 87 B0 03 00 00 89 46"));
                else
                    me.WriteBytes(addressMana0, Form1.ConvertStringToAOB("8B 87 B4 03 00 00 89 06 8B 87 B8 03 00 00 89 46 10 8B 87 B0 03 00 00 89 46"));

                Form1.cbUnlimitedMana.ForeColor = Color.FromArgb(227, 227, 234);
            }
        }
    }
}
