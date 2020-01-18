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
using J3M.Business;
using J3M_Mouse_Controller.FormComponents;
using J3M_Mouse_Controller.Events;

namespace J3M_Mouse_Controller
{
    public partial class J3M : DevExpress.XtraEditors.XtraForm
    {
        private readonly IGunService _gunService = new GunService();

        public J3M()
        {
            InitializeComponent();

            LoadGunPanel();

            GlobalParameters.Initialize();
            EventRegisters.RegisterAllEvents();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            new AddGun().Show();
        }

        public void LoadGunPanel()
        {
            this.ScrollablePanel.Controls.Clear();

            var guns = _gunService.GetGuns().OrderBy(x => x.OrderNo);

            foreach (var gun in guns)
            {
                var gunBuilder = new GunComponentBuilder(gun);

                var gunPanel = gunBuilder.CreateSettingButton()
                                         .CreateUseButton()
                                         .CreateStackPanel()
                                         .CreateGunName()
                                         .CreateGunSpecifications()
                                         .Build();

                this.ScrollablePanel.Controls.Add(gunPanel);
                this.ScrollablePanel.Controls.Add(new SeparatorControl { Name = Guid.NewGuid().ToString(), Width = 700, Height = 35 });
            }

            
        }
    }
}