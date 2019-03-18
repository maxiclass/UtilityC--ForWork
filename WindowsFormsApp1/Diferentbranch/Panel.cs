using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diferentbranch
{  
    // Note the second parameter in SetState, 1 = normal(green); 2 = error(red); 3 = warning(yellow).
    public static class ModifyProgressBarColor
        {
            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
            static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
            public static void SetState(this ProgressBar pBar, int state)
            {
                SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
            }
        }
    }

