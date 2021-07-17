using System.Windows.Forms;
using DustInTheWind.WindowsApi.Winbase;

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
            Winbase.Winbase.GlobalMemoryStatus(ref memorystatus);

            view.Memorystatus = memorystatus;
        }
    }
}