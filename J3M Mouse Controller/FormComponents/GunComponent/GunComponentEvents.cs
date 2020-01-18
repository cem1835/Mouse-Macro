using DevExpress.XtraEditors;
using J3M.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace J3M_Mouse_Controller.FormComponents
{
    public class GunComponentEvents
    {
        public void SettingButton_Click(object sender, EventArgs e)
        {
            var gunForm = new AddGun();
            gunForm.Show();

            var gun = (Gun)((SimpleButton)sender).Tag;

            foreach (var item in gun.Values.Select((value, i) => new { i, value }))
            {
                gunForm.Controls["textBox" + (item.i + 26)].Text = item.value.X.ToString();
                gunForm.Controls["textBox" + (item.i + 1)].Text = item.value.Y.ToString();
            }

            gunForm.gunNameTextBox.Text = gun.Name;
            gunForm.waitTimeTextBox.Text = gun.WaitTime.ToString();
            gunForm.NumpadNoTextBox.Text = gun.NumpadNo.ToString();

        }

        public void UseButton_Click(object sender, EventArgs e)
        {
            // TODO: Selected Gun Button Name
            //Application.OpenForms["J3M"].Controls

            var button = ((SimpleButton)sender);

            var gun = ((Gun)button.Tag);

            GlobalParameters.SelectedGun = gun;
        }
    }
}
