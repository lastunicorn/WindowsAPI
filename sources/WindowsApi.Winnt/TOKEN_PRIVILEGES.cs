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
    /// The TOKEN_PRIVILEGES structure contains information about a set of privileges for an access token.
    /// </summary>
    ///
    /// <requirements>
    /// Minimum supported client 	Windows XP [desktop apps only]
    /// Minimum supported server 	Windows Server 2003 [desktop apps only]
    /// Header 	                    winnt.h (include Windows.h)
    /// </requirements>
    public struct TOKEN_PRIVILEGES
    {
        /// <summary>
        /// This must be set to the number of entries in the Privileges array.
        /// </summary>
        public int PrivilegeCount;

        /// <summary>
        /// Specifies an array of LUID_AND_ATTRIBUTES structures. Each structure contains the LUID
        /// and attributes of a privilege. To get the name of the privilege associated with a LUID,
        /// call the LookupPrivilegeName function, passing the address of the LUID as the value of
        /// the lpLuid parameter.
        /// </summary>
        public LUID_AND_ATTRIBUTES[] Privileges;
    }
}