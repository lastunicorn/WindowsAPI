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

using System;

namespace DustInTheWind.WindowsApi.Winuser
{
    [Flags]
    public enum SystemShutdownReason : uint
    {
        // ----------------------------------------------------------------------------------------------------
        // Major Reasons
        // ----------------------------------------------------------------------------------------------------

        /// <summary>
        /// Application issue.
        /// </summary>
        SHTDN_REASON_MAJOR_APPLICATION = 0x00040000,

        /// <summary>
        /// Hardware issue.
        /// </summary>
        SHTDN_REASON_MAJOR_HARDWARE = 0x00010000,

        /// <summary>
        /// The InitiateSystemShutdown function was used instead of InitiateSystemShutdownEx.
        /// </summary>
        SHTDN_REASON_MAJOR_LEGACY_API = 0x00070000,

        /// <summary>
        /// Operating system issue.
        /// </summary>
        SHTDN_REASON_MAJOR_OPERATINGSYSTEM = 0x00020000,

        /// <summary>
        /// Other issue.
        /// </summary>
        SHTDN_REASON_MAJOR_OTHER = 0x00000000,

        /// <summary>
        /// Power failure.
        /// </summary>
        SHTDN_REASON_MAJOR_POWER = 0x00060000,

        /// <summary>
        /// Software issue.
        /// </summary>
        SHTDN_REASON_MAJOR_SOFTWARE = 0x00030000,

        /// <summary>
        /// System failure.
        /// </summary>
        SHTDN_REASON_MAJOR_SYSTEM = 0x00050000,

        // ----------------------------------------------------------------------------------------------------
        // Minor Reasons
        // ----------------------------------------------------------------------------------------------------

        /// <summary>
        /// Blue screen crash event.
        /// </summary>
        SHTDN_REASON_MINOR_BLUESCREEN = 0x0000000F,

        /// <summary>
        /// Unplugged.
        /// </summary>
        SHTDN_REASON_MINOR_CORDUNPLUGGED = 0x0000000b,

        /// <summary>
        /// Disk.
        /// </summary>
        SHTDN_REASON_MINOR_DISK = 0x00000007,

        /// <summary>
        /// Environment.
        /// </summary>
        SHTDN_REASON_MINOR_ENVIRONMENT = 0x0000000c,

        /// <summary>
        /// Driver.
        /// </summary>
        SHTDN_REASON_MINOR_HARDWARE_DRIVER = 0x0000000d,

        /// <summary>
        /// Hot fix.
        /// </summary>
        SHTDN_REASON_MINOR_HOTFIX = 0x00000011,

        /// <summary>
        /// Hot fix uninstallation.
        /// </summary>
        SHTDN_REASON_MINOR_HOTFIX_UNINSTALL = 0x00000017,

        /// <summary>
        /// Unresponsive.
        /// </summary>
        SHTDN_REASON_MINOR_HUNG = 0x00000005,

        /// <summary>
        /// Installation.
        /// </summary>
        SHTDN_REASON_MINOR_INSTALLATION = 0x00000002,

        /// <summary>
        /// Maintenance.
        /// </summary>
        SHTDN_REASON_MINOR_MAINTENANCE = 0x00000001,

        /// <summary>
        /// MMC issue.
        /// </summary>
        SHTDN_REASON_MINOR_MMC = 0x00000019,

        /// <summary>
        /// Network connectivity.
        /// </summary>
        SHTDN_REASON_MINOR_NETWORK_CONNECTIVITY = 0x00000014,

        /// <summary>
        /// Network card.
        /// </summary>
        SHTDN_REASON_MINOR_NETWORKCARD = 0x00000009,

        /// <summary>
        /// Other issue.
        /// </summary>
        SHTDN_REASON_MINOR_OTHER = 0x00000000,

        /// <summary>
        /// Other driver event.
        /// </summary>
        SHTDN_REASON_MINOR_OTHERDRIVER = 0x0000000e,

        /// <summary>
        /// Power supply.
        /// </summary>
        SHTDN_REASON_MINOR_POWER_SUPPLY = 0x0000000a,

        /// <summary>
        /// Processor.
        /// </summary>
        SHTDN_REASON_MINOR_PROCESSOR = 0x00000008,

        /// <summary>
        /// Reconfigure.
        /// </summary>
        SHTDN_REASON_MINOR_RECONFIG = 0x00000004,

        /// <summary>
        /// Security issue.
        /// </summary>
        SHTDN_REASON_MINOR_SECURITY = 0x00000013,

        /// <summary>
        /// Security patch.
        /// </summary>
        SHTDN_REASON_MINOR_SECURITYFIX = 0x00000012,

        /// <summary>
        /// Security patch uninstallation.
        /// </summary>
        SHTDN_REASON_MINOR_SECURITYFIX_UNINSTALL = 0x00000018,

        /// <summary>
        /// Service pack.
        /// </summary>
        SHTDN_REASON_MINOR_SERVICEPACK = 0x00000010,

        /// <summary>
        /// Service pack uninstallation.
        /// </summary>
        SHTDN_REASON_MINOR_SERVICEPACK_UNINSTALL = 0x00000016,

        /// <summary>
        /// Terminal Services.
        /// </summary>
        SHTDN_REASON_MINOR_TERMSRV = 0x00000020,

        /// <summary>
        /// Unstable.
        /// </summary>
        SHTDN_REASON_MINOR_UNSTABLE = 0x00000006,

        /// <summary>
        /// Upgrade.
        /// </summary>
        SHTDN_REASON_MINOR_UPGRADE = 0x00000003,

        /// <summary>
        /// WMI issue.
        /// </summary>
        SHTDN_REASON_MINOR_WMI = 0x00000015,

        // ----------------------------------------------------------------------------------------------------
        // Optional Flags
        // ----------------------------------------------------------------------------------------------------

        /// <summary>
        /// The reason code is defined by the user. For more information, see Defining a Custom Reason Code.
        /// If this flag is not present, the reason code is defined by the system.
        /// </summary>
        SHTDN_REASON_FLAG_USER_DEFINED = 0x40000000,

        /// <summary>
        /// The shutdown was planned. The system generates a System State Data (SSD) file. This file contains
        /// system state information such as the processes, threads, memory usage, and configuration.
        /// If this flag is not present, the shutdown was unplanned. Notification and reporting options are
        /// controlled by a set of policies. For example, after logging in, the system displays a dialog box
        /// reporting the unplanned shutdown if the policy has been enabled. An SSD file is created only if the
        /// SSD policy is enabled on the system. The administrator can use Windows Error Reporting to send the
        /// SSD data to a central location, or to Microsoft.
        /// </summary>
        SHTDN_REASON_FLAG_PLANNED = 0x80000000
    }
}