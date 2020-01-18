using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace J3M_Mouse_Controller.Events
{
    public static class EventRegisters
    {
        private static IKeyboardMouseEvents _keyboardMouseEvents;
        private static MouseEvents _mouseEvents;
        private static KeyboardEvents _keyboardEvents;


        private static void Initialize()
        {
            _keyboardMouseEvents = Hook.GlobalEvents();
            _mouseEvents = new MouseEvents();
            _keyboardEvents = new KeyboardEvents();
        }

        public static void RegisterAllEvents()
        {
            Initialize();

            _keyboardMouseEvents.KeyDown += new KeyEventHandler(_keyboardEvents.OnKeyDown);
            _keyboardMouseEvents.MouseDown += new MouseEventHandler(_mouseEvents.OnMouseDown);
            _keyboardMouseEvents.MouseUp += new MouseEventHandler(_mouseEvents.OnMouseUp);
        }

    }
}
