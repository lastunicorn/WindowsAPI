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

namespace DustInTheWind.WindowsApi.Sysinfoapi
{
    public enum ProcessorArchitecture : ushort
    {
        /// <summary>
        /// x86
        /// </summary>
        Intel = 0,

        /// <summary>
        /// ARM
        /// </summary>
        Arm = 5,

        /// <summary>
        /// Intel Itanium-based
        /// </summary>
        Ia64 = 6,

        /// <summary>
        /// x64(AMD or Intel)
        /// </summary>
        Amd64 = 9,

        /// <summary>
        /// ARM64
        /// </summary>
        Arm64 = 12,

        /// <summary>
        /// Unknown architecture
        /// </summary>
        Unknown = 0xffff
    }
}