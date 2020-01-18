using DevExpress.Utils.Layout;
using DevExpress.XtraEditors;
using J3M.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace J3M_Mouse_Controller.FormComponents
{
    public class GunComponentBuilder
    {
        private GunComponent _gunComponent;
        private Gun _gun;
        private GunComponentEvents _gunComponentEvents;

        public GunComponentBuilder(Gun gun)
        {
            _gun = gun;
            _gunComponent = new GunComponent();
            _gunComponentEvents = new GunComponentEvents();
        }

        private GunComponentBuilder()
        {

        }

        public GunComponentBuilder CreateUseButton()
        {
            _gunComponent.UseButton = new SimpleButton()
            {
                Name = _gun.NumpadNo + "-" + Guid.NewGuid(),
                Text = " Kullan",
                Tag = _gun,
                Width = 150,
                Height = 40,

            };
            _gunComponent.UseButton.Click += _gunComponentEvents.UseButton_Click;

            return this;
        }

        public GunComponentBuilder CreateSettingButton()
        {
            _gunComponent.SettingButton = new SimpleButton()
            {
                Name = _gun.NumpadNo + "-" + Guid.NewGuid(),
                Text = "Silahı Ayarla",
                Tag = _gun,
                Width = 150,
                Height = 40,

            };
            _gunComponent.SettingButton.Click += _gunComponentEvents.SettingButton_Click;

            return this;
        }
        public GunComponentBuilder CreateStackPanel()
        {
            _gunComponent.StackPanel = new StackPanel
            {
                 Name=_gun.NumpadNo+"-StackPanel-"+Guid.NewGuid(),
                 Margin=new System.Windows.Forms.Padding { Bottom=10,Left=10,Right=10,Top=10},
                 LayoutDirection=StackPanelLayoutDirection.LeftToRight,
                 Width=700,
                 Height=80,
            };

            return this;
        }

        public GunComponentBuilder CreateGunName()
        {
            _gunComponent.GunNameLabel = new System.Windows.Forms.Label
            {
                ForeColor = Color.White,
                Font = new Font("Arial", 22, FontStyle.Bold),
                Name = _gun.NumpadNo + "-Label",
                Text = _gun.Name,
                Height = 50,
            };

            return this;
        }
        public GunComponentBuilder CreateGunSpecifications()
        {
            _gunComponent.GunSpecificationsLabel = new Label
            {
                ForeColor = Color.White,
                Font = new Font("Arial", 12, FontStyle.Bold),
                Name = _gun.NumpadNo + "-SpecificationsLabel",
                Text = $"Numpad No : {_gun.NumpadNo}  Sıra No : {_gun.OrderNo}",
                Height=50,
                Width=250,
            };

            return this;
        }

        public StackPanel Build()
        {
            

            _gunComponent.StackPanel.Controls.Add(_gunComponent.GunNameLabel);
            _gunComponent.StackPanel.Controls.Add(_gunComponent.GunSpecificationsLabel);
            _gunComponent.StackPanel.Controls.Add(_gunComponent.SettingButton);
            _gunComponent.StackPanel.Controls.Add(_gunComponent.UseButton);

            return _gunComponent.StackPanel;
        }

    
    }
}
