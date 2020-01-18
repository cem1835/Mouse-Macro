using DevExpress.Utils.Layout;
using DevExpress.XtraEditors;
using J3M.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace J3M_Mouse_Controller
{
    public  class GunComponent
    {
        public SimpleButton UseButton { get; set; }

        public SimpleButton SettingButton { get; set; }

        public StackPanel StackPanel { get; set; }

        public Label GunNameLabel { get; set; }

        public Label GunSpecificationsLabel { get; set; }

    }
}
