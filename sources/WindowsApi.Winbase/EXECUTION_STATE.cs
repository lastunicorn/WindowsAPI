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

namespace DustInTheWind.WindowsApi.Winbase
{
    [Flags]
    public enum EXECUTION_STATE : uint
    {
        /// <summary>
        /// Forces the system to be in the working state by resetting the system idle timer. 
        /// </summary>
        ES_SYSTEM_REQUIRED = 0x00000001,

        /// <summary>
        /// Forces the display to be on by resetting the display idle timer.
        /// </summary>
        ES_DISPLAY_REQUIRED = 0x00000002,

        /// <summary>
        /// This value is not supported.
        /// If ES_USER_PRESENT is combined with other esFlags values,
        /// the call will fail and none of the specified states will be set. 
        /// </summary>
        ES_USER_PRESENT = 0x00000004,

        /// <summary>
        /// Enables away mode.This value must be specified with ES_CONTINUOUS.
        /// Away mode should be used only by media-recording and media-distribution applications
        /// that must perform critical background processing on desktop computers while
        /// the computer appears to be sleeping.See Remarks.
        /// </summary>
        ES_AWAYMODE_REQUIRED = 0x00000040,

        /// <summary>
        /// Informs the system that the state being set should remain in effect
        /// until the next call that uses ES_CONTINUOUS and one of the other state flags is cleared.
        /// </summary>
        ES_CONTINUOUS = 0x80000000
    }
}