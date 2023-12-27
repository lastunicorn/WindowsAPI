// WindowsApi
// Copyright (C) 2020-2023 Dust in the Wind
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System.Runtime.InteropServices;
using DustInTheWind.WindowsApi.Winnt;

namespace DustInTheWind.WindowsApi.Sysinfoapi
{
    public static class Sysinfoapi
    {
        /// <summary>
        /// Retrieves the amount of RAM that is physically installed on the computer.
        /// see also: https://docs.microsoft.com/en-us/windows/win32/api/sysinfoapi/nf-sysinfoapi-getphysicallyinstalledsystemmemory
        /// </summary>
        /// 
        /// <param name="TotalMemoryInKilobytes">
        /// A pointer to a variable that receives the amount of physically installed RAM, in kilobytes.
        /// </param>
        /// 
        /// <returns>
        /// <para>
        /// If the function succeeds, it returns TRUE and sets the TotalMemoryInKilobytes parameter to a nonzero value.
        /// </para>
        /// <para>
        /// If the function fails, it returns FALSE and does not modify the TotalMemoryInKilobytes parameter.
        /// To get extended error information, use the <see cref="Kernel32.GetLastError"/> function.
        /// Common errors are listed in the following table. 
        /// </para>
        /// Return code                Description
        /// ERROR_INVALID_PARAMETER    The TotalMemoryInKilobytes parameter is NULL.
        /// ERROR_INVALID_DATA         The System Management BIOS(SMBIOS) data is malformed.
        /// </returns>
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GetPhysicallyInstalledSystemMemory(out long TotalMemoryInKilobytes);

        /// <summary>
        /// Retrieves information about the system's current usage of both physical and virtual memory.
        ///  see also: https://docs.microsoft.com/en-us/windows/win32/api/sysinfoapi/nf-sysinfoapi-globalmemorystatusex
        /// </summary>
        /// 
        /// <param name="lpBuffer">
        /// A pointer to a <see cref="MEMORYSTATUSEX"/> structure that receives information about current memory availability.
        /// Note that classes require being marked as [In, Out] while value types must be passed as ref parameters.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero.
        /// If the function fails, the return value is zero. To get extended error information, call <see cref="Kernel32.GetLastError"/>.
        /// </returns>
        /// 
        /// <remarks>
        /// <para>
        /// You can use the GlobalMemoryStatusEx function to determine how much memory your application
        /// can allocate without severely impacting other applications.
        /// </para>
        /// <para>
        /// The information returned by the GlobalMemoryStatusEx function is volatile.
        /// There is no guarantee that two sequential calls to this function will return the same information.
        /// </para>
        /// <para>
        /// The ullAvailPhys member of the <see cref="MEMORYSTATUSEX"/> structure at lpBuffer includes memory for all NUMA nodes.
        /// </para>
        /// </remarks>
        /// 
        /// <requirements>
        /// Minimum supported client:    Windows XP [desktop apps | UWP apps]
        /// Minimum supported server:    Windows Server 2003 [desktop apps | UWP apps]
        /// Target Platform:             Windows
        /// Header:                      sysinfoapi.h(include Windows.h)
        /// Library:                     Kernel32.lib
        /// DLL:                         Kernel32.dll
        /// </requirements>
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool GlobalMemoryStatusEx([In, Out] MEMORYSTATUSEX lpBuffer);

        /// <summary>
        /// Retrieves information about the current system.
        ///
        /// To retrieve accurate information for an application running on WOW64,
        /// call the <see cref="GetNativeSystemInfo"/> function.
        /// </summary>
        /// <param name="lpSystemInfo">
        /// A pointer to a <see cref="SYSTEM_INFO"/> structure that receives the information.
        /// </param>
        ///
        /// <requirements>
        /// Minimum supported client    Windows 2000 Professional [desktop apps | UWP apps]
        /// Minimum supported server    Windows 2000 Server[desktop apps | UWP apps]
        /// Target Platform             Windows
        /// Header                      sysinfoapi.h(include Windows.h)
        /// Library                     Kernel32.lib
        /// DLL                         Kernel32.dll
        /// </requirements>
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern void GetSystemInfo(ref SYSTEM_INFO lpSystemInfo);

        [DllImport("kernel32.Dll", CharSet = CharSet.Auto)]
        public static extern short GetVersionEx(ref OSVERSIONINFOEX o);
    }
}