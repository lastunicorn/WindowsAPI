using System.Windows.Forms;

namespace DustInTheWind.WindowsApi.Demo.Examples
{
    public class GlobalMemoryStatusExample : IExample
    {
        private readonly GlobalMemoryStatusExampleView view = new GlobalMemoryStatusExampleView();

        public string Title { get; } = "GetSystemInfo";

        public UserControl View => view;

        public void Execute()
        {
            MEMORYSTATUS memorystatus = new MEMORYSTATUS();
            Kernel32.GlobalMemoryStatus(ref memorystatus);

            view.Memorystatus = memorystatus;
        }
    }
}