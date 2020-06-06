using System;
using mveril.WinRT.InitializeWithWindow.Core.Natives;

namespace mveril.WinRT.InitializeWithWindow.Core
{
    /// <summary>
    /// Helper static class arownd <see cref="IInitializeWithWindow"/>
    /// </summary>
    public static class Helper
    {
        /// <summary>
        /// The Wvrapper arownd <see cref="IInitializeWithWindow.Initialize(IntPtr)"/> 
        /// </summary>
        /// <param name="Hwind">The Hwind of the owner Window</param>
        /// <param name="winRTObj">The WinRT object</param>
        public static void Initialize(IntPtr Hwind,object winRTObj)
        {
            IInitializeWithWindow initWithWindow = (IInitializeWithWindow)(object)winRTObj;
            initWithWindow.Initialize(Hwind);
        }
    }
}
