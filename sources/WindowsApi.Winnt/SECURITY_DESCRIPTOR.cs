using System;
using System.Runtime.InteropServices;

namespace DustInTheWind.WindowsApi.Winnt
{
    /// <summary>
    /// <para>
    /// The SECURITY_DESCRIPTOR structure contains the security information associated
    /// with an object. Applications use this structure to set and query an object's
    /// security status.
    /// </para>
    /// <para>
    /// Because the internal format of a security descriptor can vary, we recommend
    /// that applications not modify the SECURITY_DESCRIPTOR structure directly.</para> 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct SECURITY_DESCRIPTOR
    {
        public byte revision;
        public byte size;
        public short control;
        public IntPtr owner;
        public IntPtr group;
        public IntPtr sacl;
        public IntPtr dacl;
    }
}