using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace DustInTheWind.WindowsApi.Handleapi
{
    internal static class Handleapi
    {
        [DllImport("kernel32", SetLastError = true)]
        internal static extern int CloseHandle(SafeFileHandle hObject);
    }
}