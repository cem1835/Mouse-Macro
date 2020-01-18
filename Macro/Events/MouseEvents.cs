using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Macro.Events.MouseEventModel;

namespace Macro.Events
{
    public class MouseEvents : IEvent
    {
        public J3m_Macro macroMainForm { get; set; }

        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint SendInput(uint nInputs, ref INPUT pInputs, int cbSize);


        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);

        private MouseEvents()
        {

        }

        public MouseEvents(J3m_Macro j3M_Macro)
        {
            this.macroMainForm = j3M_Macro;
        }

        public void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (!macroMainForm.activated || e.Button == MouseButtons.Right)
                return;

            macroMainForm.recoilModel.Loops = 0;

            if (macroMainForm.SingleMode.Checked)
                macroMainForm.mouseClickTimer.Enabled = true;
           
                macroMainForm.speedTimer.Enabled = true;
                macroMainForm.increaseTimer.Enabled = true;
            

        }

        public void OnMouseUp(object sender, MouseEventArgs e)
        {
            if (!macroMainForm.activated || e.Button == MouseButtons.Right)
                return;

            macroMainForm.recoilModel.Loops = 0;
            macroMainForm.speedTimer.Enabled = false;
            macroMainForm.increaseTimer.Enabled = false;

            if (macroMainForm.SingleMode.Checked)
                macroMainForm.mouseClickTimer.Enabled = false;

            macroMainForm.recoilModel.CurrentRecoil = macroMainForm.recoilModel.DefaultRecoil;
        }

        public static void MouseMoves(int x, int y)
        {
            var input = new INPUT()
            {
                type = SendInputEventType.InputMouse,
                mkhi = {
                       mi = {
                         dx = x,
                         dy = y,
                         dwFlags = MouseEventFlags.MOUSEEVENTF_MOVE
                       }
                     }
            };

            int num = (int)SendInput(1U, ref input, Marshal.SizeOf((object)new INPUT()));
        }

        public static void OnMouseClick()
        {

            INPUT mouseDownInput = new INPUT();
            mouseDownInput.type = SendInputEventType.InputMouse;
            mouseDownInput.mkhi.mi.dwFlags = MouseEventFlags.MOUSEEVENTF_LEFTDOWN;
            SendInput(1, ref mouseDownInput, Marshal.SizeOf(new INPUT()));

            //INPUT mouseUpInput = new INPUT();
            //mouseUpInput.type = SendInputEventType.InputMouse;
            //mouseUpInput.mkhi.mi.dwFlags = MouseEventFlags.MOUSEEVENTF_LEFTUP;
            //SendInput(1, ref mouseUpInput, Marshal.SizeOf(new INPUT()));
        }
    }
}
