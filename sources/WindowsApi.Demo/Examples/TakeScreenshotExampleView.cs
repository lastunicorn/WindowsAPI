using System.Drawing;
using System.Windows.Forms;

namespace DustInTheWind.WindowsApi.Demo.Examples
{
    public partial class TakeScreenshotExampleView : UserControl
    {
        public Image Image
        {
            get => pictureBox1.Image;
            set => pictureBox1.Image = value;
        }

        public TakeScreenshotExampleView()
        {
            InitializeComponent();
        }
    }
}