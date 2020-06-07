using System;
#if CSWinRT
using mveril.WinRT.InitializeWithWindow.Core.CSWinRT;
#endif
using mveril.WinRT.InitializeWithWindow.Core.Natives;

namespace mveril.WinRT.InitializeWithWindow.Core
{
    /// <summary>
    /// Helper static class arownd <see cref="IInitializeWithWindow"/>
    /// </summary>
    public static class Helper
    {
#if CSWinRT
        /// <summary>
        /// The Wvrapper arownd <see cref="IInitializeWithWindow.Initialize(IntPtr)"/> 
        /// </summary>
        /// <param name="Hwind">The Hwind of the owner Window</param>
        /// <param name="winRTPtr">The <see cref="IntPtr"/> for the WinRT object</param>
        public static void Initialize(IntPtr Hwind, IntPtr winRTPtr)
        {
            InitializeWithWindowWrapper initWithWindow = InitializeWithWindowWrapper.FromAbi(winRTPtr);
            initWithWindow.Initialize(Hwind);
        }
#else
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
#endif
    }
}
