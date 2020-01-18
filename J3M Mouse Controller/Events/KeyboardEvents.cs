using DevExpress.XtraEditors;
using J3M.Business;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace J3M_Mouse_Controller.Events
{
    public class KeyboardEvents
    {
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();


        public void OnKeyDown(object sender, KeyEventArgs e)
        {
            CloseProcesser(e.KeyCode);
            NumpadProcesser(e.KeyCode);
        }

        public void NumpadProcesser(Keys key)
        {
            if (key.ToString().IndexOf("NumPad") > -1)
            {
                var guns = new GunService().GetGuns();

                var number = int.Parse(key.ToString().Substring(6, 1));

                var selectedGun = guns.Where(x => x.NumpadNo == number).FirstOrDefault();

                if (selectedGun != null)
                {
                    GlobalParameters.SelectedGun = selectedGun;
                    ApplicationActivated();
                }
            }
        }

        public void CloseProcesser(Keys key)
        {
            if (key == Keys.F2)
            {
                if (!GlobalParameters.ProgramActivated)
                    ApplicationActivated();

                else if (GlobalParameters.ProgramActivated)
                    ApplicationDeactivated();
            }

            if (key == Keys.D5 || key == Keys.G || key == Keys.NumPad9)
                ApplicationDeactivated();
        }



        #region Application Keyboard Event

        public void ApplicationActivated()
        {
            var label = (Application.OpenForms["J3M"].Controls["MainPanel"].Controls["InfoLabel"] as LabelControl);
            label.ForeColor = System.Drawing.Color.Green;
            label.Text = "Şuanda Aktif Kapatmak İçin F2'ye Basınız.";


            if (GlobalParameters.SelectedGun != null)
                SetApplicationText(GlobalParameters.SelectedGun.Name, $"({GlobalParameters.SelectedGun.Values.First().Y}) - ({GlobalParameters.SelectedGun.Values.First().X})", $"{ GlobalParameters.SelectedGun.WaitTime} ms");


            PlayActivePassiveSound("active.wav");
            GlobalParameters.ProgramActivated = true;
            GetForegroundWindow();
        }

        public void ApplicationDeactivated()
        {
            var label = (Application.OpenForms["J3M"].Controls["MainPanel"].Controls["InfoLabel"] as LabelControl);
            label.ForeColor = System.Drawing.Color.DarkRed;
            label.Text = "Aktifleştirmek için F2 'ye Basınız.";

            SetApplicationText("Makro Kapalı..", "Makro Kapalı..", "Makro Kapalı..");

            PlayActivePassiveSound("passive.wav");
            GlobalParameters.ProgramActivated = false;
        }


        public void SetApplicationText(string gunLabel, string infoLabel, string msLabel)
        {
            (Application.OpenForms["J3M"].Controls["LeftPanel"].Controls["gunLabel"] as LabelControl).Text = gunLabel;
            (Application.OpenForms["J3M"].Controls["LeftPanel"].Controls["infolbl"] as LabelControl).Text = infoLabel;
            (Application.OpenForms["J3M"].Controls["LeftPanel"].Controls["SettingMs"] as LabelControl).Text = msLabel;
        }

        public void PlayActivePassiveSound(string fileName)
        {
            if(!(Application.OpenForms["J3M"].Controls["LeftPanel"].Controls["SilentCheckBox"] as CheckBox).Checked)
                new SoundPlayer(Path.Combine("Sounds", fileName)).Play();
            
        }

        #endregion
    }
}
