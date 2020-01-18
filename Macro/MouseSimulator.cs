using Gma.System.MouseKeyHook;
using InputClass;
using Macro.Events;
using Macro.Helper;
using Macro.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Forms;

namespace Macro
{
    public partial class J3m_Macro : Form
    {
        public IKeyboardMouseEvents m_Events;

        public bool activated = false;
        public System.Timers.Timer speedTimer;
        public System.Timers.Timer increaseTimer;

        public System.Timers.Timer mouseClickTimer;

        public RecoilModel recoilModel = new RecoilModel();

        public J3m_Macro()
        {
            InitializeComponent();

            this.Unsubscribe();
            this.Subscribe(Hook.GlobalEvents());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            speedTimer = new System.Timers.Timer();
            speedTimer.Interval = 40.0;
            speedTimer.Enabled = false;
            speedTimer.AutoReset = true;

            speedTimer.Elapsed += new ElapsedEventHandler(
                        (object source, ElapsedEventArgs myElapsedEventArgs) => new TimerEvent().speedTimerEvent(recoilModel.CurrentRecoil));
            
            increaseTimer = new System.Timers.Timer();
            increaseTimer.Interval = 40.0;
            increaseTimer.Enabled = false;
            increaseTimer.AutoReset = true;

            increaseTimer.Elapsed += new ElapsedEventHandler(
                        (object source, ElapsedEventArgs myElapsedEventArgs) => new TimerEvent().increaseTimerEvent(this));


            mouseClickTimer = new System.Timers.Timer();
            mouseClickTimer.Interval = 100.0;
            mouseClickTimer.Enabled = false;
            mouseClickTimer.AutoReset = true;
            mouseClickTimer.Elapsed += new ElapsedEventHandler((object source, ElapsedEventArgs myElapsedEventArgs) => new TimerEvent().mouseClickEvent());


            new FormCreator(this).CreateGunButtons();
        }


        private void Subscribe(IKeyboardMouseEvents events)
        {
            var mouseEvents = new MouseEvents(this);
            var keyboardEvents = new KeyboardEvents(this);

            this.m_Events = events;
            this.m_Events.KeyDown += new KeyEventHandler(keyboardEvents.OnKeyDown);
            this.m_Events.MouseDown += new MouseEventHandler(mouseEvents.OnMouseDown);
            this.m_Events.MouseUp += new MouseEventHandler(mouseEvents.OnMouseUp);
        }


        private void Unsubscribe()
        {
            bool bool_ = this.m_Events == null;
            if (bool_)
            {
                return;
            }
        }
    }
}
