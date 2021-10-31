using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace DustInTheWind.WindowsApi.Handleapi
{
    public static class Handleapi
    {
        [DllImport("kernel32", SetLastError = true)]
        public static extern int CloseHandle(SafeFileHandle hObject);
    }
}