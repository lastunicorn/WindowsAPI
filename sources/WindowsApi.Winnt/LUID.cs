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
    /// This structure is used by the ID3D12Device::GetAdapterLuid and GetSharedResourceAdapterLuid methods.
    /// </summary>
    ///
    /// <requirements>
    /// Header 	winnt.h
    /// </requirements>
    public struct LUID
    {
        /// <summary>
        /// Specifies a DWORD that contains the unsigned lower numbers of the id.
        /// </summary>
        public int LowPart;

        /// <summary>
        /// Specifies a LONG that contains the signed high numbers of the id.
        /// </summary>
        public int HighPart;
    }
}