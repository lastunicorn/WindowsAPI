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
using System.Drawing;
using DustInTheWind.WindowsApi.Windef;
using DustInTheWind.WindowsApi.Wingdi;

namespace DustInTheWind.WindowsApi.Demo.Examples
{
    /// <summary>
    /// Provides functions to capture the entire screen, or a particular window.
    /// </summary>
    public class ScreenCapture
    {
        /// <summary>
        /// Creates an Image object containing a screen shot of the entire desktop
        /// </summary>
        /// <returns></returns>
        public Image CaptureScreen()
        {
            IntPtr desktopWindow = Winuser.Winuser.GetDesktopWindow();
            return CaptureWindow(desktopWindow);
        }

        /// <summary>
        /// Creates an Image object containing a screen shot of a specific window
        /// </summary>
        /// <param name="handle">The handle to the window. (In windows forms, this is obtained by the Handle property)</param>
        /// <returns></returns>
        public Image CaptureWindow(IntPtr handle)
        {
            // get te hDC of the target window
            IntPtr hdcSrc = Winuser.Winuser.GetWindowDC(handle);

            // get the size
            RECT windowRect = new RECT();
            Winuser.Winuser.GetWindowRect(handle, ref windowRect);
            int width = windowRect.right - windowRect.left;
            int height = windowRect.bottom - windowRect.top;

            // create a device context we can copy to
            IntPtr hdcDest = Wingdi.Wingdi.CreateCompatibleDC(hdcSrc);

            // create a bitmap we can copy it to,
            // using GetDeviceCaps to get the width/height
            IntPtr hBitmap = Wingdi.Wingdi.CreateCompatibleBitmap(hdcSrc, width, height);

            // select the bitmap object
            IntPtr hOld = Wingdi.Wingdi.SelectObject(hdcDest, hBitmap);

            // bitblt over
            Wingdi.Wingdi.BitBlt(hdcDest, 0, 0, width, height, hdcSrc, 0, 0, RasterOperationCodes.SRCCOPY);

            // restore selection
            Wingdi.Wingdi.SelectObject(hdcDest, hOld);

            // clean up
            Wingdi.Wingdi.DeleteDC(hdcDest);
            Winuser.Winuser.ReleaseDC(handle, hdcSrc);

            // get a .NET image object for it
            Image img = Image.FromHbitmap(hBitmap);

            // free up the Bitmap object
            Wingdi.Wingdi.DeleteObject(hBitmap);

            return img;
        }
    }
}