using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Macro.Events
{
    public class TimerEvent:IEvent
    {
        public void speedTimerEvent(int yCoordinate)
        {
            MouseEvents.MouseMoves(0, yCoordinate);
        }

        public void increaseTimerEvent(J3m_Macro form)
        {
            var recoil = form.recoilModel;

            recoil.Loops++;
            if (recoil.Loops < 25)
            {
                recoil.CurrentRecoil += recoil.FromIncrease;
            }
            else if (recoil.Loops <= 50)
            {
                recoil.CurrentRecoil+= recoil.ToIncrease;
            }
            else if (recoil.Loops > 50)
            {
                recoil.CurrentRecoil = recoil.DefaultRecoil;
            }
        }

        public void mouseClickEvent()
        {
            MouseEvents.OnMouseClick();
        }
    }
}
