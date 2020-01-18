
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static J3M_Mouse_Controller.Events.MouseEventModel;

namespace J3M_Mouse_Controller.Events
{
    public class MouseEvents:IEvent
    {
        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint SendInput(uint nInputs, ref INPUT pInputs, int cbSize);


        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);



        public void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (!IsProcessable(e))
                return;

            if ((Application.OpenForms["J3M"].Controls["LeftPanel"].Controls["SingleBurst"] as CheckBox).Checked)
                GlobalParameters.ClickTimer.Enabled = true;

            if(GlobalParameters.SelectedGun!=null)
                GlobalParameters.RecoilTimer.Interval = GlobalParameters.SelectedGun.WaitTime;

            GlobalParameters.RecoilTimer.Enabled = true;
        }

        public void OnMouseUp(object sender, MouseEventArgs e)
        {
            if (!IsProcessable(e))
                return;

            if(GlobalParameters.SelectedGun!=null)
                GlobalParameters.MouseParams = (0, GlobalParameters.SelectedGun.Values.First().X, GlobalParameters.SelectedGun.Values.First().Y);

            GlobalParameters.ClickTimer.Enabled = false;
            GlobalParameters.RecoilTimer.Enabled = false;
        }


        public bool IsProcessable(MouseEventArgs e)
        {
            if (!GlobalParameters.ProgramActivated || e.Button == MouseButtons.Right)
                return false;

            return true;
        }

        public void MouseMove(int xCoord,int yCoord)
        {
            var currentMouseParams = GlobalParameters.SelectedGun.Values.Skip(GlobalParameters.MouseParams.recoilIndex).FirstOrDefault();
            GlobalParameters.MouseParams = ((GlobalParameters.MouseParams.recoilIndex + 1)%24, currentMouseParams.X, currentMouseParams.Y);


            var input = new INPUT()
            {
                type = SendInputEventType.InputMouse,
                mkhi = {
                       mi = {
                         dx = xCoord,
                         dy = yCoord,
                         dwFlags = MouseEventFlags.MOUSEEVENTF_MOVE
                       }
                     }
            };
            int num = (int)SendInput(1U, ref input, Marshal.SizeOf((object)new INPUT()));
        }

        public void MouseClick()
        {
            INPUT mouseDownInput = new INPUT();
            mouseDownInput.type = SendInputEventType.InputMouse;
            mouseDownInput.mkhi.mi.dwFlags = MouseEventFlags.MOUSEEVENTF_LEFTDOWN;
            SendInput(1, ref mouseDownInput, Marshal.SizeOf(new INPUT()));
        }


    }
}
