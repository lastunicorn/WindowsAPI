using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace DustInTheWind.WindowsApi
{
    public partial class Kernel32
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern SafeFileHandle CreateFile(string lpFileName, DesiredAccess dwDesiredAccess, ShareMode dwShareMode, IntPtr lpSecurityAttributes, CreationDisposition dwCreationDisposition, FlagsAndAttributes dwFlagsAndAttributes, IntPtr hTemplateFile);

        [DllImport("kernel32", SetLastError = true)]
        internal static extern int CloseHandle(SafeFileHandle hObject);

        [DllImport("kernel32", SetLastError = true)]
        public static extern bool ReadFile(SafeFileHandle hFile, byte[] aBuffer, uint cbToRead, ref uint cbThatWereRead, IntPtr pOverlapped);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool WriteFile(SafeFileHandle hFile, byte[] aBuffer, uint cbToWrite, ref uint cbThatWereWritten, IntPtr pOverlapped);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern uint SetFilePointer(SafeFileHandle hFile, int lDistanceToMove, IntPtr lpDistanceToMoveHigh, MoveMethod dwMoveMethod);
    }
}