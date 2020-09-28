using System;
using System.Runtime.InteropServices;

namespace DustInTheWind.WindowsApi
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SYSTEM_INFO
    {
        public ProcessorArchitecture wProcessorArchitecture;
        public ushort wReserved;
        public uint dwPageSize;
        public IntPtr lpMinimumApplicationAddress;
        public IntPtr lpMaximumApplicationAddress;
        public IntPtr dwActiveProcessorMask;
        public uint dwNumberOfProcessors;
        public Processor dwProcessorType;
        public uint dwAllocationGranularity;
        public ushort wProcessorLevel;
        public ushort wProcessorRevision;
    }
}