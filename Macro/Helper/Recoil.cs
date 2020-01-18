using Macro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macro.Helper
{
    public class Recoil
    {
        public void SetRecoilParameters(J3m_Macro mainFrm, Guns gun)
        {
            var recoil = mainFrm.recoilModel;

            recoil.CurrentRecoil= gun.Value;
            recoil.DefaultRecoil= gun.Value;
            recoil.FromIncrease = gun.FromIncrease;
            recoil.ToIncrease = gun.ToIncrease;

            mainFrm.gunLabel.Text = gun.Name;
            mainFrm.infolbl.Text = gun.Value + "-" + gun.FromIncrease + " - " + gun.ToIncrease;
        }
    }
}
