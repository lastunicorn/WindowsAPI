using System;
using System.Windows.Forms;
using DustInTheWind.WindowsApi.Demo.Examples;

namespace DustInTheWind.WindowsApi.Demo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonGetSystemInfoExample_Click(object sender, EventArgs e)
        {
            GetSystemInfoExample getSystemInfoExample = new GetSystemInfoExample();
            ExecuteExample(getSystemInfoExample);
        }

        private void buttonGlobalMemoryStatus_Click(object sender, EventArgs e)
        {
            GlobalMemoryStatusExample globalMemoryStatusExample = new GlobalMemoryStatusExample();
            ExecuteExample(globalMemoryStatusExample);
        }

        private void buttonTakeScreenshot_Click(object sender, EventArgs e)
        {
            TakeScreenshotExample takeScreenshotExample = new TakeScreenshotExample();
            ExecuteExample(takeScreenshotExample);
        }

        private void ExecuteExample(IExample example)
        {
            try
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(example.View);
                example.Execute();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}