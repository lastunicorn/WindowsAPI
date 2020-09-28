using System.Windows.Forms;

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
            Kernel32.GetSystemInfo(ref systemInfo);

            view.SystemInfo = systemInfo;
        }
    }
}