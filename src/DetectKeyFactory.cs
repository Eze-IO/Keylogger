using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Eze.IO.Workspace
{
    /// <summary>
    /// Managing class for use of the DetectKey class in COM Objects
    /// </summary>
    [ComVisible(true)]
    [ProgId("Eze.IO.Workspace.DetectKeyFactory")]
    [ComSourceInterfaces(typeof(IKey))]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    public sealed class DetectKeyFactory
    {
        /// <summary>
        /// Set or get if key presses are being detected
        /// </summary>
        [ComVisible(true)]
        public Boolean Detect
        {
            get
            {
                try
                {
                    return DetectKey.IsDetecting;
                }
                catch
                {
                    return false;
                }
            }
            set
            {
                if (value)
                {
                    DetectKey.OnKeyPressed += (l) => this.OnKeyPressed?.Invoke(l);
                }
                else
                {
                    DetectKey.OnKeyPressed -= (l) => this.OnKeyPressed?.Invoke(l);
                }
            }
        }

        /// <summary>
        /// Event triggered when keyboard key is pressed
        /// </summary>
        public event KeyPressedHandler OnKeyPressed;
    }
}
