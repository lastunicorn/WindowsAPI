// WindowsApi
// Copyright (C) 2020-2023 Dust in the Wind
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

namespace DustInTheWind.WindowsApi.Demo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.buttonGetSystemInfo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonGlobalMemoryStatus = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelAll = new System.Windows.Forms.Panel();
            this.buttonTakeScreenshot = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGetSystemInfo
            // 
            this.buttonGetSystemInfo.Location = new System.Drawing.Point(3, 3);
            this.buttonGetSystemInfo.Name = "buttonGetSystemInfo";
            this.buttonGetSystemInfo.Size = new System.Drawing.Size(150, 23);
            this.buttonGetSystemInfo.TabIndex = 0;
            this.buttonGetSystemInfo.Text = "GetSystemInfo";
            this.buttonGetSystemInfo.UseVisualStyleBackColor = true;
            this.buttonGetSystemInfo.Click += new System.EventHandler(this.buttonGetSystemInfoExample_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 393);
            this.panel1.TabIndex = 1;
            // 
            // buttonGlobalMemoryStatus
            // 
            this.buttonGlobalMemoryStatus.Location = new System.Drawing.Point(159, 3);
            this.buttonGlobalMemoryStatus.Name = "buttonGlobalMemoryStatus";
            this.buttonGlobalMemoryStatus.Size = new System.Drawing.Size(150, 23);
            this.buttonGlobalMemoryStatus.TabIndex = 2;
            this.buttonGlobalMemoryStatus.Text = "GlobalMemoryStatus";
            this.buttonGlobalMemoryStatus.UseVisualStyleBackColor = true;
            this.buttonGlobalMemoryStatus.Click += new System.EventHandler(this.buttonGlobalMemoryStatus_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.buttonGetSystemInfo);
            this.flowLayoutPanel1.Controls.Add(this.buttonGlobalMemoryStatus);
            this.flowLayoutPanel1.Controls.Add(this.buttonTakeScreenshot);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(468, 29);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 434);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panelAll
            // 
            this.panelAll.Controls.Add(this.tableLayoutPanel1);
            this.panelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAll.Location = new System.Drawing.Point(0, 0);
            this.panelAll.Name = "panelAll";
            this.panelAll.Padding = new System.Windows.Forms.Padding(8);
            this.panelAll.Size = new System.Drawing.Size(800, 450);
            this.panelAll.TabIndex = 5;
            // 
            // buttonTakeScreenshot
            // 
            this.buttonTakeScreenshot.Location = new System.Drawing.Point(315, 3);
            this.buttonTakeScreenshot.Name = "buttonTakeScreenshot";
            this.buttonTakeScreenshot.Size = new System.Drawing.Size(150, 23);
            this.buttonTakeScreenshot.TabIndex = 2;
            this.buttonTakeScreenshot.Text = "Take Screenshot";
            this.buttonTakeScreenshot.UseVisualStyleBackColor = true;
            this.buttonTakeScreenshot.Click += new System.EventHandler(this.buttonTakeScreenshot_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelAll);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelAll.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGetSystemInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonGlobalMemoryStatus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelAll;
        private System.Windows.Forms.Button buttonTakeScreenshot;
    }
}