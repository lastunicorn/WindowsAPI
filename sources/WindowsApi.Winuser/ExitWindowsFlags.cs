using System;

namespace DustInTheWind.WindowsApi.Winuser
{
    [Flags]
    public enum ExitWindowsFlags : int
    {
        /// <summary>
        /// EWX_HYBRID_SHUTDOWN
        /// Beginning with Windows 8:  You can prepare the system for a faster startup by combining
        /// the EWX_HYBRID_SHUTDOWN flag with the EWX_SHUTDOWN flag. 
        /// </summary>
        HybridShutdown = 0x00400000,

        /// <summary>
        /// EWX_LOGOFF
        /// Shuts down all processes running in the logon session of the process that called the
        /// ExitWindowsEx function. Then it logs the user off.
        /// 
        /// This flag can be used only by processes running in an interactive user's logon session.
        /// </summary>
        LogOff = 0,

        /// <summary>
        /// EWX_POWEROFF
        /// Shuts down the system and turns off the power. The system must support the power-off feature.
        /// 
        /// The calling process must have the SE_SHUTDOWN_NAME privilege. For more information, see the
        /// following Remarks section.
        /// </summary>
        PowerOff = 0x00000008,

        /// <summary>
        /// EWX_REBOOT
        /// Shuts down the system and then restarts the system.
        /// 
        /// The calling process must have the SE_SHUTDOWN_NAME privilege. For more information,
        /// see the following Remarks section.
        /// </summary>
        Reboot = 0x00000002,

        /// <summary>
        /// EWX_RESTARTAPPS
        /// Shuts down the system and then restarts it, as well as any applications that have been
        /// registered for restart using the RegisterApplicationRestart function. These application
        /// receive the WM_QUERYENDSESSION message with lParam set to the ENDSESSION_CLOSEAPP value.
        /// For more information, see Guidelines for Applications. 
        /// </summary>
        RestartApps = 0x00000040,

        /// <summary>
        /// EWX_SHUTDOWN
        /// Shuts down the system to a point at which it is safe to turn off the power.
        /// All file buffers have been flushed to disk, and all running processes have stopped.
        /// 
        /// The calling process must have the SE_SHUTDOWN_NAME privilege. For more information,
        /// see the following Remarks section.
        /// 
        /// Specifying this flag will not turn off the power even if the system supports the power-off
        /// feature. You must specify EWX_POWEROFF to do this.Windows XP with SP1:  If the system supports
        /// the power-off feature, specifying this flag turns off the power.
        /// </summary>
        Shutdown = 0x00000001,

        // ----------------------------------------------------------------------------------------------------
        // Optional Parameters
        // ----------------------------------------------------------------------------------------------------

        /// <summary>
        /// EWX_FORCE
        /// This flag has no effect if terminal services is enabled. Otherwise, the system does not send the
        /// WM_QUERYENDSESSION message. This can cause applications to lose data. Therefore, you should only
        /// use this flag in an emergency. 
        /// </summary>
        Force = 0x00000004,

        /// <summary>
        /// EWX_FORCEIFHUNG
        /// Forces processes to terminate if they do not respond to the WM_QUERYENDSESSION or WM_ENDSESSION
        /// message within the timeout interval. For more information, see the Remarks. 
        /// </summary>
        ForceIfHung = 0x00000010
    }
}