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