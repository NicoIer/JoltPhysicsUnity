using System;
using System.Runtime.CompilerServices;
using Jolt.Native;
using UnityEngine;

[assembly: InternalsVisibleTo("Jolt.Tests")]

namespace Jolt
{
    internal static partial class Bindings
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        internal static void Initialize()
        {
            NativeLibrary.LoadLibrary();
            InitializeBodyActivationListeners();
            InitializeContactListeners();
        }

        #if JOLT_DISABLE_SAFETY_CHECKS
        [Conditional("FALSE")]
        #endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void AssertInitialized()
        {
            if (!Jolt.Initialized)
            {
                throw new InvalidOperationException("The Jolt native plugin has not been initialized. You must call Jolt.Initialize() before using Jolt.");
            }
        }
    }
}
