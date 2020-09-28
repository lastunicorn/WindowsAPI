using System.Windows.Forms;

namespace DustInTheWind.WindowsApi.Demo.Examples
{
    internal interface IExample
    {
        string Title { get; }

        UserControl View { get; }
        
        void Execute();
    }
}