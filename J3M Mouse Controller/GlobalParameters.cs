using J3M.Entities;
using J3M_Mouse_Controller.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace J3M_Mouse_Controller
{
    public static class GlobalParameters
    {
        public static bool ProgramActivated { get; set; }

        public static Timer RecoilTimer { get; set; }

        public static (int recoilIndex,int X,int Y) MouseParams { get; set; }

        public static Timer ClickTimer { get; set; }

        public static Gun SelectedGun { get; set; }

        public static void Initialize()
        {
            InitializeClickTimer();
            InitializeRecoilTimer();
            
            MouseParams=(0,0,0);
        }

        private static void InitializeRecoilTimer()
        {
            RecoilTimer = new Timer() { AutoReset = true, Enabled = false };
            RecoilTimer.Elapsed += new ElapsedEventHandler((object source, ElapsedEventArgs myElapsedEventArgs) => new MouseEvents().MouseMove(MouseParams.X,MouseParams.Y) );
        }

        private static void InitializeClickTimer()
        {
            ClickTimer = new Timer() { AutoReset = true, Enabled = false,Interval=100 };
            ClickTimer.Elapsed += new ElapsedEventHandler((object source, ElapsedEventArgs myElapsedEventArgs) => new MouseEvents().MouseClick());

        }

    }
}
