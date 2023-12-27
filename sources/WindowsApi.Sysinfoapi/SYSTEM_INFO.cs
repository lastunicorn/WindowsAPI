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

using System;
using System.Runtime.InteropServices;

namespace DustInTheWind.WindowsApi.Sysinfoapi
{
    /// <summary>
    /// Contains information about the current computer system. This includes the architecture
    /// and type of the processor, the number of processors in the system, the page size,
    /// and other such information.
    /// </summary>
    ///
    /// <requirements>
    /// Minimum supported client    Windows 2000 Professional [desktop apps | UWP apps]
    /// Minimum supported server    Windows 2000 Server[desktop apps | UWP apps]
    /// Header                      sysinfoapi.h(include Windows.h)
    /// </requirements>
    [StructLayout(LayoutKind.Sequential)]
    public struct SYSTEM_INFO
    {
        /// <summary>
        /// The processor architecture of the installed operating system. This member can be one of the following values.
        /// </summary>
        public ProcessorArchitecture wProcessorArchitecture;

        /// <summary>
        /// This member is reserved for future use.
        /// </summary>
        public ushort wReserved;

        /// <summary>
        /// The page size and the granularity of page protection and commitment.
        /// This is the page size used by the <see cref="VirtualAlloc"/> function.
        /// </summary>
        public uint dwPageSize;

        /// <summary>
        /// A pointer to the lowest memory address accessible to applications and dynamic-link libraries (DLLs).
        /// </summary>
        public IntPtr lpMinimumApplicationAddress;

        /// <summary>
        /// A pointer to the highest memory address accessible to applications and DLLs.
        /// </summary>
        public IntPtr lpMaximumApplicationAddress;

        /// <summary>
        /// A mask representing the set of processors configured into the system.
        /// Bit 0 is processor 0; bit 31 is processor 31.
        /// </summary>
        public IntPtr dwActiveProcessorMask;

        /// <summary>
        /// The number of logical processors in the current group.
        /// To retrieve this value, use the GetLogicalProcessorInformation function.
        ///
        /// Note  For information about the physical processors shared by logical processors,
        /// call GetLogicalProcessorInformationEx with the RelationshipType parameter set to RelationProcessorPackage (3).
        /// </summary>
        public uint dwNumberOfProcessors;

        /// <summary>
        /// An obsolete member that is retained for compatibility.
        /// Use the wProcessorArchitecture, wProcessorLevel, and wProcessorRevision members
        /// to determine the type of processor.
        /// </summary>
        public Processor dwProcessorType;

        /// <summary>
        /// The granularity for the starting address at which virtual memory can be allocated.
        /// For more information, see <see cref="VirtualAlloc"/>.
        /// </summary>
        public uint dwAllocationGranularity;

        /// <summary>
        /// The architecture-dependent processor level. It should be used only for display purposes.
        /// To determine the feature set of a processor, use the <see cref="IsProcessorFeaturePresent"/> function.
        ///
        /// If wProcessorArchitecture is PROCESSOR_ARCHITECTURE_INTEL, wProcessorLevel is defined by the CPU vendor.
        ///
        /// If wProcessorArchitecture is PROCESSOR_ARCHITECTURE_IA64, wProcessorLevel is set to 1.
        /// </summary>
        public ushort wProcessorLevel;

        /// <summary>
        /// The architecture-dependent processor revision. The following table shows how the revision
        /// value is assembled for each type of processor architecture.
        ///
        /// Processor                               Value
        /// 
        /// Intel Pentium, Cyrix, or NextGen 586    The high byte is the model and the low byte is the stepping.For example, if the value is xxyy, the model number and stepping can be displayed as follows:
        ///                                         Model xx, Stepping yy
        /// 
        /// Intel 80386 or 80486                    A value of the form xxyz.
        ///                                         If xx is equal to 0xFF, y - 0xA is the model number, and z is the stepping identifier.
        ///                                         If xx is not equal to 0xFF, xx + 'A' is the stepping letter and yz is the minor stepping.
        /// 
        /// ARM                                     Reserved.
        /// </summary>
        public ushort wProcessorRevision;
    }
}