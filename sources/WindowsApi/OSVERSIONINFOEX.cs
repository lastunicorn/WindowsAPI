using System.Runtime.InteropServices;

namespace DustInTheWind.WindowsApi
{
#pragma warning disable S101 // Types should be named in camel case
#pragma warning disable S3459 // Unassigned members should be removed

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public struct OSVERSIONINFOEX
    {
        public readonly int dwBuildNumber;

        public readonly int dwMajorVersion;

        public readonly int dwMinorVersion;

        public readonly int dwPlatformId;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public readonly string szCSDVersion;

        public readonly byte wProductType;

        public readonly byte wReserved;

        public readonly short wServicePackMajor;

        public readonly short wServicePackMinor;

        public readonly short wSuiteMask;

        public int dwOSVersionInfoSize;
    }

#pragma warning restore S101 // Types should be named in camel case
#pragma warning restore S3459 // Unassigned members should be removed
}