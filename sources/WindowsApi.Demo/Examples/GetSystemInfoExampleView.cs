using System.Text;
using System.Windows.Forms;

namespace DustInTheWind.WindowsApi.Demo.Examples
{
    public partial class GetSystemInfoExampleView : UserControl
    {
        private SYSTEM_INFO systemInfo;

        public SYSTEM_INFO SystemInfo
        {
            get => systemInfo;
            set
            {
                systemInfo = value;
                UpdateDisplayedData();
            }
        }

        private void UpdateDisplayedData()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("wProcessorArchitecture :		{0} ({1})", systemInfo.wProcessorArchitecture, (ushort)systemInfo.wProcessorArchitecture));
            sb.AppendLine(string.Format("wReserved :		{0}", systemInfo.wReserved));
            sb.AppendLine(string.Format("Page Size :			{0}", systemInfo.dwPageSize));
            sb.AppendLine(string.Format("Minimum Application Address :	{0}", systemInfo.lpMinimumApplicationAddress));
            sb.AppendLine(string.Format("Maximum Application Address :	{0}", systemInfo.lpMaximumApplicationAddress));
            sb.AppendLine(string.Format("Active Processor Mask :		{0}", systemInfo.dwActiveProcessorMask));
            sb.AppendLine(string.Format("Number Of Processors :		{0}", systemInfo.dwNumberOfProcessors));
            sb.AppendLine(string.Format("dwProcessorType :      {0} ({1})", systemInfo.dwProcessorType, (uint)systemInfo.dwProcessorType));
            sb.AppendLine(string.Format("Allocation Granularity :		{0}", systemInfo.dwAllocationGranularity));
            sb.AppendLine(string.Format("Processor Level Value :		{0}", systemInfo.wProcessorLevel));
            sb.AppendLine(string.Format("Processor Revision :		{0}", systemInfo.wProcessorRevision));

            label1.Text = sb.ToString();
        }

        public GetSystemInfoExampleView()
        {
            InitializeComponent();
        }
    }
}