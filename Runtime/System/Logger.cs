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
        public static void Debug(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
        {
            //Get class name
            var className = System.IO.Path.GetFileNameWithoutExtension(filePath);

            //Construct message
            message = $"<color={"#82f3ff"}>{className}.{memberName} (Line {lineNumber}): {message}</color>";

            //Display message
            //ReSharper disable once Unity.PerformanceCriticalCodeInvocation
            UnityEngine.Debug.Log(message);
        }
        
        [SuppressMessage("ReSharper", "Unity.PerformanceCriticalCodeInvocation")]
        [Conditional("KLAZAPP_ENABLE_LOGS")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void DebugError(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
        {
            //Get class name
            var className = System.IO.Path.GetFileNameWithoutExtension(filePath);

            //Construct message
            message = $"<color={"#f01b98"}>{className}.{memberName} (Line {lineNumber}): {message}</color>";

            //Display message
            //ReSharper disable once Unity.PerformanceCriticalCodeInvocation
            UnityEngine.Debug.LogError(message);
            
            //ReSharper disable once Unity.PerformanceCriticalCodeInvocation
            UnityEngine.Debug.Break();
        }
        
        [SuppressMessage("ReSharper", "Unity.PerformanceCriticalCodeInvocation")]
        [Conditional("KLAZAPP_ENABLE_LOGS")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void DebugWarning(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
        {
            //Get class name
            var className = System.IO.Path.GetFileNameWithoutExtension(filePath);

            //Construct message
            message = $"<color={"#ffb418"}>{className}.{memberName} (Line {lineNumber}): {message}</color>";

            //Display message
            //ReSharper disable once Unity.PerformanceCriticalCodeInvocation
            UnityEngine.Debug.LogWarning(message);
        }
    }
}
