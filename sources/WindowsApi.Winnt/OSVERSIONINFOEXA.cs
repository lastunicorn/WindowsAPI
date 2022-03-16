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