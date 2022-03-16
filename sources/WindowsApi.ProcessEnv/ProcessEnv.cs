using System;
using System.Runtime.InteropServices;

namespace DustInTheWind.WindowsApi.ProcessEnv
{
    public static class ProcessEnv
    {
        /// <summary>
        /// Retrieves a handle to the specified standard device (standard input, standard output, or standard error).
        /// see als: https://docs.microsoft.com/en-us/windows/console/getstdhandle
        /// </summary>
        /// <param name="nStdHandle">
        /// The standard device. This parameter can be one of the following values.
        /// </param>
        /// <returns>
        /// If the function succeeds, the return value is a handle to the specified device, or a redirected handle
        /// set by a previous call to SetStdHandle. The handle has GENERIC_READ and GENERIC_WRITE access rights,
        /// unless the application has used SetStdHandle to set a standard handle with lesser access.
        /// 
        /// Tip: It is not required to dispose of this handle with CloseHandle when done.
        ///
        /// If the function fails, the return value is INVALID_HANDLE_VALUE. To get extended error information,
        /// call GetLastError.
        ///
        /// If an application does not have associated standard handles, such as a service running on an interactive
        /// desktop, and has not redirected them, the return value is NULL.
        /// </returns>
        ///
        /// <requirements>
        /// Minimum supported client:   Windows 2000 Professional [desktop apps only]
        /// Minimum supported server:   Windows 2000 Server[desktop apps only]
        /// Header:                     ProcessEnv.h(via Winbase.h, include Windows.h)
        /// Library:                    Kernel32.lib
        /// DLL:                        Kernel32.dll
        /// </requirements>
        [DllImport("kernel32.dll", EntryPoint = "GetStdHandle", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetStdHandle(StandardHandleType nStdHandle);
    }
}