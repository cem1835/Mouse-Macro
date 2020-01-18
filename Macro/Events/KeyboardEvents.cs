using Macro.Helper;
using Macro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Macro.Events
{
    public class KeyboardEvents : IEvent
    {

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        private J3m_Macro mainForm { get; set; }

        private KeyboardEvents()
        {

        }

        public KeyboardEvents(J3m_Macro j3M_Macro)
        {
            this.mainForm = j3M_Macro;
        }

        public void OnKeyDown(object sender, KeyEventArgs e)
        {
            CloseProcesser(e.KeyCode);
            NumpadProcesser(e.KeyCode);
        }


        public void NumpadProcesser(Keys key)
        {
            if (key.ToString().IndexOf("NumPad") > -1)
            {
                var guns = JsonData.GetGuns();

                var number = int.Parse(key.ToString().Substring(6, 1));

                var selectedGun = guns.Where(x => x.NumpadNo == number).FirstOrDefault();

                if (selectedGun != null)
                {
                    new Recoil().SetRecoilParameters(this.mainForm, selectedGun);
                    ApplicationActivated();
                }
            }
        }

        public void CloseProcesser(Keys key)
        {
            if (key == Keys.F2)
            {
                if (!mainForm.activated)
                    ApplicationActivated();

                else if (mainForm.activated)
                    ApplicationDeactivated();
            }

            if (key == Keys.D5 || key == Keys.G || key == Keys.NumPad9)
                ApplicationDeactivated();
        }



        #region Application Keyboard Event

        public void ApplicationActivated()
        {
            mainForm.InfoLabel.ForeColor = System.Drawing.Color.Green;

            mainForm.InfoLabel.Text = "Şuanda Aktif Kapatmak İçin F2'ye Basınız.";
            mainForm.activated = true;
            GetForegroundWindow();
        }

        public void ApplicationDeactivated()
        {
            mainForm.InfoLabel.ForeColor = System.Drawing.Color.DarkRed;
            mainForm.InfoLabel.Text = "Aktifleştirmek için F2 'ye Basınız.";
            mainForm.activated = false;
        }
        #endregion
    }
}
