using Foundation;

namespace NativeLibrary.Binding
{
    [Static]
    interface Constants
    {
        // extern NSString * PLCrashReporterException;
        [Field("PLCrashReporterException", "__Internal")]
        NSString PLCrashReporterException { get; }
    }
}