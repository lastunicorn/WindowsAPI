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
using DustInTheWind.WindowsApi.Windef;

namespace DustInTheWind.WindowsApi.Winuser
{
    public static class Winuser
    {
        [DllImport("user32.dll")]
        public static extern IntPtr GetDesktopWindow();

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowDC(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowRect(IntPtr hWnd, ref RECT rect);

        /// <summary>
        /// Locks the workstation's display. Locking a workstation protects it from unauthorized use.
        /// </summary>
        /// 
        /// <returns>
        /// <para>
        /// If the function succeeds, the return value is nonzero. Because the function executes
        /// asynchronously, a nonzero return value indicates that the operation has been initiated.
        /// It does not indicate whether the workstation has been successfully locked.
        /// </para>
        /// <para>
        /// If the function fails, the return value is zero.
        /// To get extended error information, call GetLastError.
        /// </para>
        /// </returns>
        ///
        /// <requirements>
        /// Minimum supported client 	Windows XP [desktop apps | UWP apps]
        /// Minimum supported server 	Windows Server 2003 [desktop apps | UWP apps]
        /// Target Platform 	        Windows
        /// Header 	                    winuser.h (include Windows.h)
        /// Library 	                User32.lib
        /// DLL 	                    User32.dll
        /// API set 	                ext-ms-win-ntuser-misc-l1-5-1 (introduced in Windows 10, version 10.0.14393)
        /// </requirements>
        [DllImport("user32.dll")]
        public static extern bool LockWorkStation();

        /// <summary>
        /// Logs off the interactive user, shuts down the system, or shuts down and restarts the system.
        /// It sends the WM_QUERYENDSESSION message to all applications to determine if they can be terminated.
        /// </summary>
        /// 
        /// <param name="uFlags">The shutdown type.</param>
        /// 
        /// <param name="dwReason">
        /// The reason for initiating the shutdown.
        /// On Windows 2000 this parameter is ignored.
        /// </param>
        /// 
        /// <returns>
        /// <para>
        /// If the function succeeds, the return value is nonzero. Because the function executes
        /// asynchronously, a nonzero return value indicates that the shutdown has been initiated.
        /// It does not indicate whether the shutdown will succeed. It is possible that the system,
        /// the user, or another application will abort the shutdown.
        /// </para>
        /// <para>
        /// If the function fails, the return value is zero.
        /// To get extended error information, call GetLastError.
        /// </para>
        /// </returns>
        /// 
        [DllImport("user32.dll")]
        public static extern bool ExitWindowsEx(ExitWindowsFlags uFlags, SystemShutdownReason dwReason);
    }
}