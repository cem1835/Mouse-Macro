using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using J3M.Entities;
using Point = J3M.Entities.Point;
using J3M.Business;

namespace J3M_Mouse_Controller
{
    public partial class AddGun : XtraForm
    {
        private GunService _gunService;

        public AddGun()
        {
            InitializeComponent();
            _gunService = new GunService();
        }

        private void GunCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; 
        }

        private void GunOkButton_Click(object sender, EventArgs e)
        {
            Func<int, int> GetValue = (index) => 
            { 
                var value = this.Controls["textBox" + index].Text; 
                return string.IsNullOrEmpty(value) ? 0 : Convert.ToInt32(value); 
            };

            var gun = new Gun
            {
                Name = gunNameTextBox.Text,
                NumpadNo = Convert.ToInt32(NumpadNoTextBox.Text),
                OrderNo=Convert.ToInt32(NumpadNoTextBox.Text),
                WaitTime=Convert.ToInt32(waitTimeTextBox.Text),
                Values= Enumerable.Range(1, 25).Select(index => new Point { X = GetValue(index+25), Y = GetValue(index) })
            };

            var res = _gunService.AddOrUpdateGun(gun);

            if (!res.result)
            {
                MessageBox.Show("İşlemde Hata.");
                return;
            }

            Application.OpenForms["J3M"].GetType().GetMethod("LoadGunPanel").Invoke(Application.OpenForms["J3M"],null);
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Enumerable.Range(26, 25).ToList().ForEach(index=> { this.Controls["textBox" + index].Text = FillXTextBox.Text; });
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Enumerable.Range(1, 25).ToList().ForEach(index => { this.Controls["textBox" + index].Text = FillYTextBox.Text; });
        }
    }
}