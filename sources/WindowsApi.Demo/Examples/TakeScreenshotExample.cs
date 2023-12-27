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

using System.Drawing;
using System.Windows.Forms;

namespace DustInTheWind.WindowsApi.Demo.Examples
{
    internal class TakeScreenshotExample : IExample
    {
        private readonly TakeScreenshotExampleView view = new TakeScreenshotExampleView();

        public string Title { get; } = "TakeScreenshot";

        public UserControl View => view;

        public void Execute()
        {
            Image image = CaptureScreen();
            view.Image = image;
        }
        private static Image CaptureScreen()
        {
            ScreenCapture screenCapture = new ScreenCapture();
            return screenCapture.CaptureScreen();
        }
    }
}