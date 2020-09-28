using System.Text;
using System.Windows.Forms;

namespace DustInTheWind.WindowsApi.Demo.Examples
{
    public partial class GlobalMemoryStatusExampleView : UserControl
    {
        private MEMORYSTATUS memorystatus;

        public MEMORYSTATUS Memorystatus
        {
            get => memorystatus;
            set
            {
                memorystatus = value;

                UpdateDisplayedData();
            }
        }

        public GlobalMemoryStatusExampleView()
        {
            InitializeComponent();
        }

        private void UpdateDisplayedData()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("Length :		{0}", memorystatus.dwLength));
            sb.AppendLine(string.Format("Memory Load :			{0}", memorystatus.dwMemoryLoad));

            sb.AppendLine(string.Format("Total Physical :	{0}", memorystatus.dwTotalPhys.ToDetailedString()));
            sb.AppendLine(string.Format("Available Physical :	{0}", memorystatus.dwAvailPhys.ToDetailedString()));

            sb.AppendLine(string.Format("Total Page File :		{0}", memorystatus.dwTotalPageFile.ToDetailedString()));
            sb.AppendLine(string.Format("Available Page File :		{0}", memorystatus.dwAvailPageFile.ToDetailedString()));

            sb.AppendLine(string.Format("Total Virtual :		{0}", memorystatus.dwTotalVirtual.ToDetailedString()));
            sb.AppendLine(string.Format("Available Virtual :		{0}", memorystatus.dwAvailVirtual.ToDetailedString()));

            label1.Text = sb.ToString();
        }
    }
}