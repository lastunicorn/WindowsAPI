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

namespace DustInTheWind.WindowsApi.Fileapi
{
    [Flags]
    public enum ShareMode : uint
    {
        /// <summary>
        /// Prevents other processes from opening a file or device if they request delete, read, or write access.
        /// </summary>
        FILE_SHARE_NONE = 0x0,

        /// <summary>
        /// Enables subsequent open operations on a file or device to request read access.
        /// Otherwise, other processes cannot open the file or device if they request read access.
        /// If this flag is not specified, but the file or device has been opened for read access, the function fails.
        /// </summary>
        FILE_SHARE_READ = 0x1,

        /// <summary>
        /// Enables subsequent open operations on a file or device to request write access.
        /// Otherwise, other processes cannot open the file or device if they request write access.
        /// If this flag is not specified, but the file or device has been opened for write access or has a file mapping with write access, the function fails.
        /// </summary>
        FILE_SHARE_WRITE = 0x2,

        /// <summary>
        /// Enables subsequent open operations on a file or device to request delete access.
        /// Otherwise, other processes cannot open the file or device if they request delete access.
        ///
        /// If this flag is not specified, but the file or device has been opened for delete access, the function fails.
        /// Note  Delete access allows both delete and rename operations.
        /// </summary>
        FILE_SHARE_DELETE = 0x4
    }
}