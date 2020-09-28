using System.Runtime.InteropServices;

namespace DustInTheWind.WindowsApi
{
    /// <summary>
    /// see also: https://referencesource.microsoft.com/#mscorlib
    /// </summary>
    public class Kernel32
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern void GetSystemInfo(ref SYSTEM_INFO systemInfo);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern void GlobalMemoryStatus(ref MEMORYSTATUS buffer);

        [DllImport("kernel32.dll")]
        public static extern ulong VerSetConditionMask(ulong dwlConditionMask, uint dwTypeBitMask, byte dwConditionMask);

        [DllImport("kernel32.dll")]
        public static extern bool VerifyVersionInfo([In] ref OSVERSIONINFOEXA lpVersionInfo, uint dwTypeMask, ulong dwlConditionMask);

        [DllImport("kernel32.Dll", CharSet = CharSet.Auto)]
        public static extern short GetVersionEx(ref OSVERSIONINFOEX o);

        /// <summary>
        /// see also: https://docs.microsoft.com/en-us/windows/win32/api/sysinfoapi/nf-sysinfoapi-globalmemorystatusex
        /// </summary>
        /// <param name="lpBuffer">Note that classes require being marked as [In, Out] while value types must be passed as ref parameters.</param>
        /// <returns></returns>
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GlobalMemoryStatusEx([In, Out] MEMORYSTATUSEX lpBuffer);

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern bool GetDiskFreeSpace(string lpRootPathName, out uint lpSectorsPerCluster, out uint lpBytesPerSector, out uint lpNumberOfFreeClusters, out uint lpTotalNumberOfClusters);
    }
}