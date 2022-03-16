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

namespace DustInTheWind.WindowsApi.ConsoleApi
{
    [Flags]
    public enum InputHandleMode : uint
    {
        /// <summary>
        /// CTRL+C is processed by the system and is not placed in the input buffer. If the input buffer is being read by ReadFile or ReadConsole, other control keys are processed by the system and are not returned in the ReadFile or ReadConsole buffer. If the ENABLE_LINE_INPUT mode is also enabled, backspace, carriage return, and line feed characters are handled by the system.
        /// </summary>
        ENABLE_PROCESSED_INPUT = 0x0001,

        /// <summary>
        /// The ReadFile or ReadConsole function returns only when a carriage return character is read. If this mode is disabled, the functions return when one or more characters are available.
        /// </summary>
        ENABLE_LINE_INPUT = 0x0002,

        /// <summary>
        /// Characters read by the ReadFile or ReadConsole function are written to the active screen buffer as they are typed into the console. This mode can be used only if the ENABLE_LINE_INPUT mode is also enabled.
        /// </summary>
        ENABLE_ECHO_INPUT = 0x0004,

        /// <summary>
        /// User interactions that change the size of the console screen buffer are reported in the console's input buffer. Information about these events can be read from the input buffer by applications using the ReadConsoleInput function, but not by those using ReadFile or ReadConsole.
        /// </summary>
        ENABLE_WINDOW_INPUT = 0x0008,

        /// <summary>
        /// If the mouse pointer is within the borders of the console window and the window has the keyboard focus, mouse events generated by mouse movement and button presses are placed in the input buffer. These events are discarded by ReadFile or ReadConsole, even when this mode is enabled.
        /// </summary>
        ENABLE_MOUSE_INPUT = 0x0010,

        /// <summary>
        /// When enabled, text entered in a console window will be inserted at the current cursor location and all text following that location will not be overwritten. When disabled, all following text will be overwritten.
        /// </summary>
        ENABLE_INSERT_MODE = 0x0020,

        /// <summary>
        /// This flag enables the user to use the mouse to select and edit text. To enable this mode, use ENABLE_QUICK_EDIT_MODE | ENABLE_EXTENDED_FLAGS. To disable this mode, use ENABLE_EXTENDED_FLAGS without this flag.
        /// </summary>
        ENABLE_QUICK_EDIT_MODE = 0x0040,

        /// <summary>
        /// Setting this flag directs the Virtual Terminal processing engine to convert user input received by the console window into Console Virtual Terminal Sequences that can be retrieved by a supporting application through WriteFile or WriteConsole functions.
        ///
        /// The typical usage of this flag is intended in conjunction with ENABLE_VIRTUAL_TERMINAL_PROCESSING on the output handle to connect to an application that communicates exclusively via virtual terminal sequences.
        /// </summary>
        ENABLE_VIRTUAL_TERMINAL_INPUT = 0x0200
    }
}