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