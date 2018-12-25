using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Eze.IO.Workspace
{
    /// <summary>
    /// Interface for the key pressed event
    /// </summary>
    [ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IKey
    {
        /// <summary>
        /// Event triggered when keyboard key is pressed
        /// </summary>
        [DispId(1)]
        void OnKeyPressed(LoggedKeys k);
    }
}
