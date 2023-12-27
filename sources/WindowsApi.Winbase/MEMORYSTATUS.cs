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
using DustInTheWind.WindowsApi.Core;

namespace DustInTheWind.WindowsApi.Winbase
{
    /// <summary>
    /// Contains information about the current state of both physical and virtual memory.
    /// The <see cref="Winbase.GlobalMemoryStatus"/> function stores information in a <see cref="MEMORYSTATUS"/> structure.
    /// 
    /// Minimum supported client:   Windows XP [desktop apps only]
    /// Minimum supported server:   Windows Server 2003 [desktop apps only]
    /// 
    /// see also: https://docs.microsoft.com/en-us/windows/win32/api/winbase/ns-winbase-memorystatus
    /// </summary>
    ///
    /// <remarks>
    /// <para>
    /// <see cref="MEMORYSTATUS"/> reflects the state of memory at the time of the call.
    /// It also reflects the size of the paging file at that time.
    /// The operating system can enlarge the paging file up to the
    /// maximum size set by the administrator.
    /// </para>
    /// <para>
    /// On computers with more than 4 GB of memory,
    /// the <see cref="MEMORYSTATUS"/> structure can return incorrect information,
    /// reporting a value of –1 to indicate an overflow.
    /// If your application is at risk for this behavior, use the <see cref="Sysinfoapi.Sysinfoapi.GlobalMemoryStatusEx"/>
    /// function instead of the <see cref="Winbase.GlobalMemoryStatus"/> function.
    /// </para>
    /// </remarks>
    ///
    /// <requirements>
    /// Minimum supported client    Windows XP [desktop apps only]
    /// Minimum supported server    Windows Server 2003 [desktop apps only]
    /// Header                      winbase.h(include Windows.h)
    /// </requirements>
    [StructLayout(LayoutKind.Sequential)]
    public struct MEMORYSTATUS
    {
        /// <summary>
        /// The size of the <see cref="MEMORYSTATUS"/> data structure, in bytes.
        /// You do not need to set this member before calling the GlobalMemoryStatus
        /// function; the function sets it.
        /// </summary>
        public uint dwLength;

        /// <summary>
        /// A number between 0 and 100 that specifies the approximate percentage of
        /// physical memory that is in use (0 indicates no memory use and 100 indicates full memory use).
        /// </summary>
        public uint dwMemoryLoad;

        /// <summary>
        /// The amount of actual physical memory, in bytes.
        /// </summary>
        public DataSize dwTotalPhys;

        /// <summary>
        /// The amount of physical memory currently available, in bytes.
        /// This is the amount of physical memory that can be immediately reused without having
        /// to write its contents to disk first. It is the sum of the size of the standby, free, and zero lists.
        /// </summary>
        public DataSize dwAvailPhys;

        /// <summary>
        /// The current size of the committed memory limit, in bytes.
        /// This is physical memory plus the size of the page file, minus a small overhead.
        /// </summary>
        public DataSize dwTotalPageFile;

        /// <summary>
        /// The maximum amount of memory the current process can commit, in bytes.
        /// This value should be smaller than the system-wide available commit.
        /// To calculate this value, call GetPerformanceInfo and subtract the value of CommitTotal from CommitLimit.
        /// </summary>
        public DataSize dwAvailPageFile;

        /// <summary>
        /// The size of the user-mode portion of the virtual address space of the calling process, in bytes.
        /// This value depends on the type of process, the type of processor, and the configuration
        /// of the operating system. For example, this value is approximately 2 GB for most 32-bit processes
        /// on an x86 processor and approximately 3 GB for 32-bit processes that are large address aware running
        /// on a system with 4 GT RAM Tuning enabled.
        /// </summary>
        public DataSize dwTotalVirtual;

        /// <summary>
        /// The amount of unreserved and uncommitted memory currently in the user-mode portion of the virtual
        /// address space of the calling process, in bytes.
        /// </summary>
        public DataSize dwAvailVirtual;
    }
}