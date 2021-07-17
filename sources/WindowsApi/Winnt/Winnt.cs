using System.Runtime.InteropServices;

namespace DustInTheWind.WindowsApi.Winnt
{
    public static class Winnt
    {
        [DllImport("kernel32.dll")]
        public static extern ulong VerSetConditionMask(ulong dwlConditionMask, uint dwTypeBitMask, byte dwConditionMask);
    }
}