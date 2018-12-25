using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Eze.IO.Workspace
{
    /// <summary>
    /// Class for key information
    /// </summary>
    [ComVisible(true)]
    [ProgId("Eze.IO.Workspace.LoggedKeys")]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    public class LoggedKeys : IDisposable
    {
        /// <summary>
        /// Returns the virtual key type
        /// </summary>
        [ComVisible(true)]
        public VirtualKeys Key { get; internal set; }
        /// <summary>
        /// Returns key name
        /// </summary>
        [ComVisible(true)]
        public String KeyName { get; internal set; }
        /// <summary>
        /// Dispose
        /// </summary>
        [ComVisible(true)]
        public void Dispose() { KeyName = null; Key = 0; }
    }

    public delegate void KeyPressedHandler(LoggedKeys keys);
}
