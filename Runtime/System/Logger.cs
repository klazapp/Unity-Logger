using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace com.Klazapp.Utility
{
    //Logger allows for a simple on/off switch to enable/disable all logs in app
    //Instead of manually commenting/adding them in each individual scripts
    public static class LogMessage 
    {
        [SuppressMessage("ReSharper", "Unity.PerformanceCriticalCodeInvocation")]
        [Conditional("KLAZAPP_ENABLE_LOGS")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Debug(string message)
        {
            //ReSharper disable once Unity.PerformanceCriticalCodeInvocation
            UnityEngine.Debug.Log("<color=#82f3ff>" + message + "</color>");
        }
        
        [SuppressMessage("ReSharper", "Unity.PerformanceCriticalCodeInvocation")]
        [Conditional("KLAZAPP_ENABLE_LOGS")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void DebugError(string message)
        {
            //ReSharper disable once Unity.PerformanceCriticalCodeInvocation
            UnityEngine.Debug.LogError("<color=red>" + message + "</color>");
            //ReSharper disable once Unity.PerformanceCriticalCodeInvocation
            UnityEngine.Debug.Break();
        }
        
        [SuppressMessage("ReSharper", "Unity.PerformanceCriticalCodeInvocation")]
        [Conditional("KLAZAPP_ENABLE_LOGS")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void DebugWarning(string message)
        {
            //ReSharper disable once Unity.PerformanceCriticalCodeInvocation
            UnityEngine.Debug.LogWarning("<color=yellow>" + message + "</color>");
        }
    }
}