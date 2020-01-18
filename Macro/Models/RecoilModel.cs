using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macro.Models
{
    public class RecoilModel
    {
        public int CurrentRecoil { get; set; }
        public int DefaultRecoil { get; set; }
        public int Loops { get; set; }
        public int FromIncrease { get; set; }
        public int ToIncrease { get; set; }

        public RecoilModel()
        {
            this.CurrentRecoil = 15;
            this.DefaultRecoil = 15;
        }
    }

 
}
