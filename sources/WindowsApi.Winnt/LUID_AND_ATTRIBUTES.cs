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

namespace DustInTheWind.WindowsApi.Winnt
{
    /// <summary>
    /// An LUID_AND_ATTRIBUTES structure can represent an LUID whose attributes change frequently,
    /// such as when the LUID is used to represent privileges in the PRIVILEGE_SET structure.
    /// Privileges are represented by LUIDs and have attributes indicating whether they are
    /// currently enabled or disabled.
    /// </summary>
    ///
    /// <requirements>
    /// Minimum supported client 	Windows XP [desktop apps only]
    /// Minimum supported server 	Windows Server 2003 [desktop apps only]
    /// Header 	                    winnt.h (include Windows.h)
    /// </requirements>
    public struct LUID_AND_ATTRIBUTES
    {
        /// <summary>
        /// Specifies an LUID value.
        /// </summary>
        public LUID Luid;

        /// <summary>
        /// Specifies attributes of the LUID. This value contains up to 32 one-bit flags. Its meaning
        /// is dependent on the definition and use of the LUID.
        /// </summary>
        public int Attributes;
    }
}