using System.Runtime.InteropServices;

namespace DustInTheWind.WindowsApi.Winnt
{
#pragma warning disable S101 // Types should be named in camel case
#pragma warning disable S3459 // Unassigned members should be removed

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct OSVERSIONINFOEXA
    {
        public int dwOSVersionInfoSize;

        public int dwMajorVersion;

        public int dwMinorVersion;

        public readonly int dwBuildNumber;

        public readonly int dwPlatformId;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public readonly string szCSDVersion;

        public ushort wServicePackMajor;

        public readonly ushort wServicePackMinor;

        public readonly ushort wSuiteMask;

        public readonly byte wProductType;

        public readonly byte wReserved;
    }

#pragma warning restore S101 // Types should be named in camel case
#pragma warning restore S3459 // Unassigned members should be removed
}