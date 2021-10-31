using System.Runtime.InteropServices;

namespace DustInTheWind.WindowsApi.Windef
{
    [StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
        public readonly int left;
        public readonly int top;
        public readonly int right;
        public readonly int bottom;
    }
}
