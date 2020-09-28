using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace DustInTheWind.WindowsApi.Demo
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : Form
    {
        private Button buttonInformation;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private readonly Container components = null;

        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonInformation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonInformation
            // 
            this.buttonInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInformation.Location = new System.Drawing.Point(12, 12);
            this.buttonInformation.Name = "buttonInformation";
            this.buttonInformation.Size = new System.Drawing.Size(268, 249);
            this.buttonInformation.TabIndex = 1;
            this.buttonInformation.Text = "Informatii";
            this.buttonInformation.Click += new System.EventHandler(this.buttonInformation_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.buttonInformation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private void buttonInformation_Click(object sender, EventArgs e)
        {
            DisplaySystemInfo();
            DisplayMemoryStatus();
        }

        private static void DisplaySystemInfo()
        {
            try
            {
                SYSTEM_INFO systemInfo = new SYSTEM_INFO();
                Kernel32.GetSystemInfo(ref systemInfo);

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

                MessageBox.Show(sb.ToString());
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private static void DisplayMemoryStatus()
        {
            try
            {
                MEMORYSTATUS memorystatus = new MEMORYSTATUS();
                Kernel32.GlobalMemoryStatus(ref memorystatus);

                StringBuilder sb = new StringBuilder();

                sb.AppendLine(string.Format("Length :		{0}", memorystatus.dwLength));
                sb.AppendLine(string.Format("Memory Load :			{0}", memorystatus.dwMemoryLoad));

                sb.AppendLine(string.Format("Total Physical :	{0}", memorystatus.dwTotalPhys.ToDetailedString()));
                sb.AppendLine(string.Format("Available Physical :	{0}", memorystatus.dwAvailPhys.ToDetailedString()));

                sb.AppendLine(string.Format("Total Page File :		{0}", memorystatus.dwTotalPageFile.ToDetailedString()));
                sb.AppendLine(string.Format("Available Page File :		{0}", memorystatus.dwAvailPageFile.ToDetailedString()));

                sb.AppendLine(string.Format("Total Virtual :		{0}", memorystatus.dwTotalVirtual.ToDetailedString()));
                sb.AppendLine(string.Format("Available Virtual :		{0}", memorystatus.dwAvailVirtual.ToDetailedString()));

                MessageBox.Show(sb.ToString());
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}