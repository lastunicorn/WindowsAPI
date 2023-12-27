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

namespace DustInTheWind.WindowsApi.Errhandlingapi
{
    public class Errhandlingapi
    {
        /// <summary>
        /// Retrieves the calling thread's last-error code value. The last-error code is maintained on a per-thread basis. Multiple threads do not overwrite each other's last-error code.
        /// Visual Basic:  Applications should call err.LastDllError instead of GetLastError.
        /// </summary>
        /// 
        /// <returns>
        /// <para>
        /// The return value is the calling thread's last-error code.
        /// </para>
        /// <para>
        /// The Return Value section of the documentation for each function that sets the last-error code
        /// notes the conditions under which the function sets the last-error code.
        /// Most functions that set the thread's last-error code set it when they fail.
        /// However, some functions also set the last-error code when they succeed.
        /// If the function is not documented to set the last-error code, the value returned by this function
        /// is simply the most recent last-error code to have been set; some functions set the last-error code
        /// to 0 on success and others do not.
        /// </para>
        /// </returns>
        ///
        /// <remarks>
        /// Functions executed by the calling thread set this value by calling the <see cref="SetLastError"/> function.
        /// You should call the <see cref="GetLastError"/> function immediately when a function's return value indicates
        /// that such a call will return useful data. That is because some functions call <see cref="SetLastError"/> with
        /// a zero when they succeed, wiping out the error code set by the most recently failed function.
        ///
        /// To obtain an error string for system error codes, use the <see cref="FormatMessage"/> function.
        /// For a complete list of error codes provided by the operating system, see System Error Codes.
        ///
        /// The error codes returned by a function are not part of the Windows API specification and can vary
        /// by operating system or device driver. For this reason, we cannot provide the complete list of error codes
        /// that can be returned by each function. There are also many functions whose documentation does not include
        /// even a partial list of error codes that can be returned.
        ///
        /// Error codes are 32-bit values (bit 31 is the most significant bit). Bit 29 is reserved for
        /// application-defined error codes; no system error code has this bit set. If you are defining an error code
        /// for your application, set this bit to one. That indicates that the error code has been defined by an
        /// application, and ensures that your error code does not conflict with any error codes defined by the system.
        ///
        /// To convert a system error into an HRESULT value, use the HRESULT_FROM_WIN32 macro.
        /// </remarks>
        ///
        /// <requirements>
        /// Minimum supported client    Windows XP [desktop apps | UWP apps]
        /// Minimum supported server    Windows Server 2003 [desktop apps | UWP apps]
        /// Target Platform             Windows
        /// Header                      errhandlingapi.h(include Windows.h)
        /// Library                     Kernel32.lib
        /// DLL                         Kernel32.dll
        /// </requirements>
        [DllImport("kernel32.dll")]
        public static extern uint GetLastError();
    }
}