// WindowsApi
// Copyright (C) 2020-2022 Dust in the Wind
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