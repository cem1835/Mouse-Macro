using Macro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Macro.Helper
{
    public class FormCreator
    {
        private J3m_Macro mainForm { get; set; }

        private FormCreator()
        {

        }

        public FormCreator(J3m_Macro j3M_Macro)
        {
            this.mainForm = j3M_Macro;
        }


        public void CreateGunButtons()
        {
            var guns = JsonData.GetGuns();
            Func<string, string, string> getGunByName = (gunName, property) => guns.Where(x => x.Name == gunName).Select(x => x.GetType().GetProperty(property).GetValue(x).ToString()).FirstOrDefault();

            guns.OrderBy(x=>x.NumpadNo).ToList().ForEach(gun =>
            {
                var button = new Button { Text = gun.Name, Width = 100, Tag = gun };
                button.Click += Gun_Click;
                mainForm.stackPanel1.Controls.Add(button);



                var valueInput = new TextBox { Name = gun.Name + "_Value", Text = getGunByName(gun.Name, "Value") };
                valueInput.TextChanged += IncreaseText_Changed;
                mainForm.ValuePanel.Controls.Add(valueInput);



                var minInput = new TextBox { Name = gun.Name + "_FromIncrease", Text = getGunByName(gun.Name, "FromIncrease") };
                minInput.TextChanged += IncreaseText_Changed;
                mainForm.FromIncreasePanel.Controls.Add(minInput);



                var maxInput = new TextBox { Name = gun.Name + "_ToIncrease", Text = getGunByName(gun.Name, "ToIncrease") };
                maxInput.TextChanged += IncreaseText_Changed;
                mainForm.ToIncreasePanel.Controls.Add(maxInput);
            });
        }

        private void Gun_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            var gun = JsonData.GetGuns().Where(x => x.Name == button.Text).FirstOrDefault();

            new Recoil().SetRecoilParameters(mainForm, gun);
        }

        private void IncreaseText_Changed(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;

            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, @"^(-?[1-9]+\d*([.]\d+)?)$|^(-?0[.]\d*[1-9]+)$|^0$|^0.0$"))
            {
                //MessageBox.Show("Sadece Rakam Giriniz..");
                return;
            }

            SaveChangedData(textBox);
        }

        public void SaveChangedData(TextBox textBox)
        {
            var nameInfo = textBox.Name.Split('_');

            var guns = JsonData.GetGuns();

            var gun = guns.Where(x => x.Name == nameInfo[0]).FirstOrDefault();

            gun.GetType().GetProperty(nameInfo[1]).SetValue(gun, int.Parse(textBox.Text == "" ? "0" : textBox.Text));

            JsonData.SaveGun(gun);
        }
    }
}
