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

namespace DustInTheWind.WindowsApi.ConsoleApi
{
    public static class ConsoleApi
    {
        /// <summary>
        /// Sets the input mode of a console's input buffer or the output mode of a console screen buffer.
        /// see also: https://docs.microsoft.com/en-us/windows/console/setconsolemode
        /// </summary>
        /// 
        /// <param name="hConsoleHandle">
        /// A handle to the console input buffer or a console screen buffer. The handle must have the GENERIC_READ access right.
        /// For more information, see Console Buffer Security and Access Rights.
        /// </param>
        /// 
        /// <param name="dwMode">
        /// The input or output mode to be set.
        /// 
        /// If the hConsoleHandle parameter is an input handle, the mode can be one or more of the values from InputHandleMode enum.
        /// When a console is created, all input modes except ENABLE_WINDOW_INPUT and ENABLE_VIRTUAL_TERMINAL_INPUT
        /// are enabled by default.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero.
        /// If the function fails, the return value is zero.To get extended error information, call GetLastError.
        /// </returns>
        ///
        /// <requirements>
        /// Minimum supported client:   Windows 2000 Professional [desktop apps only]
        /// Minimum supported server:   Windows 2000 Server[desktop apps only]
        /// Header:                     ConsoleApi.h(via WinCon.h, include Windows.h)
        /// Library:                    Kernel32.lib
        /// DLL:                        Kernel32.dll
        /// </requirements>
        [DllImport("kernel32.dll", EntryPoint = "SetConsoleMode", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetConsoleModeForInputHandle(IntPtr hConsoleHandle, InputHandleMode dwMode);

        /// <summary>
        /// Sets the input mode of a console's input buffer or the output mode of a console screen buffer.
        /// see also: https://docs.microsoft.com/en-us/windows/console/setconsolemode
        /// </summary>
        /// 
        /// <param name="hConsoleHandle">
        /// A handle to the console input buffer or a console screen buffer. The handle must have the GENERIC_READ access right.
        /// For more information, see Console Buffer Security and Access Rights.
        /// </param>
        /// 
        /// <param name="dwMode">
        /// The input or output mode to be set.
        /// 
        /// If the hConsoleHandle parameter is an input handle, the mode can be one or more of the values from BufferHandleMode enum.
        /// When a screen buffer is created, both output modes are enabled by default.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero.
        /// If the function fails, the return value is zero.To get extended error information, call GetLastError.
        /// </returns>
        ///
        /// <requirements>
        /// Minimum supported client:   Windows 2000 Professional [desktop apps only]
        /// Minimum supported server:   Windows 2000 Server[desktop apps only]
        /// Header:                     ConsoleApi.h(via WinCon.h, include Windows.h)
        /// Library:                    Kernel32.lib
        /// DLL:                        Kernel32.dll
        /// </requirements>
        [DllImport("kernel32.dll", EntryPoint = "SetConsoleMode", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetConsoleModeForBufferHandle(IntPtr hConsoleHandle, BufferHandleMode dwMode);

        /// <summary>
        /// Retrieves the current input mode of a console's input buffer or the current output mode of a console screen buffer.
        /// see also: https://docs.microsoft.com/en-us/windows/console/getconsolemode
        /// </summary>
        /// 
        /// <param name="hConsoleHandle">
        /// A handle to the console input buffer or the console screen buffer. The handle must have the GENERIC_READ access right. For more information, see Console Buffer Security and Access Rights.
        /// </param>
        /// 
        /// <param name="dwMode">
        /// If the hConsoleHandle parameter is an input handle, the mode can be one or more of the values from InputHandleMode enum.
        /// When a console is created, all input modes except ENABLE_WINDOW_INPUT and ENABLE_VIRTUAL_TERMINAL_INPUT are enabled by default.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero.
        /// If the function fails, the return value is zero.To get extended error information, call GetLastError.
        /// </returns>
        ///
        /// <requirements>
        /// Minimum supported client:   Windows 2000 Professional [desktop apps only]
        /// Minimum supported server:   Windows 2000 Server[desktop apps only]
        /// Header:                     ConsoleApi.h(via WinCon.h, include Windows.h)
        /// Library:                    Kernel32.lib
        /// DLL:                        Kernel32.dll
        /// </requirements>
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleMode", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetConsoleModeForInputHandle(IntPtr hConsoleHandle, ref InputHandleMode dwMode);

        /// <summary>
        /// Retrieves the current input mode of a console's input buffer or the current output mode of a console screen buffer.
        /// see also: https://docs.microsoft.com/en-us/windows/console/getconsolemode
        /// </summary>
        /// 
        /// <param name="hConsoleHandle">
        /// A handle to the console input buffer or the console screen buffer. The handle must have the GENERIC_READ access right. For more information, see Console Buffer Security and Access Rights.
        /// </param>
        /// 
        /// <param name="dwMode">
        /// If the hConsoleHandle parameter is a screen buffer handle, the mode can be one or more of the values from BufferHandleMode enum.
        /// When a screen buffer is created, both output modes are enabled by default.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is nonzero.
        /// If the function fails, the return value is zero.To get extended error information, call GetLastError.
        /// </returns>
        ///
        /// <requirements>
        /// Minimum supported client:   Windows 2000 Professional [desktop apps only]
        /// Minimum supported server:   Windows 2000 Server[desktop apps only]
        /// Header:                     ConsoleApi.h(via WinCon.h, include Windows.h)
        /// Library:                    Kernel32.lib
        /// DLL:                        Kernel32.dll
        /// </requirements>
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleMode", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetConsoleModeForBufferHandle(IntPtr hConsoleHandle, ref BufferHandleMode dwMode);
    }
}