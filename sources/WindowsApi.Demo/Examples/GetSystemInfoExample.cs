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

using System.Windows.Forms;
using DustInTheWind.WindowsApi.Sysinfoapi;

namespace DustInTheWind.WindowsApi.Demo.Examples
{
    internal class GetSystemInfoExample : IExample
    {
        private readonly GetSystemInfoExampleView view = new GetSystemInfoExampleView();

        public string Title { get; } = "GetSystemInfo";

        public UserControl View => view;

        public void Execute()
        {
            SYSTEM_INFO systemInfo = new SYSTEM_INFO();
            Sysinfoapi.Sysinfoapi.GetSystemInfo(ref systemInfo);

            view.SystemInfo = systemInfo;
        }
    }
}