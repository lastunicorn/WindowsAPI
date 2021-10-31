using System.Runtime.InteropServices;
using DustInTheWind.WindowsApi.Winnt;

namespace DustInTheWind.WindowsApi.Winbase
{
    public static class Winbase
    {
        /// <summary>
        /// [GlobalMemoryStatus can return incorrect information. Use the <see cref="GlobalMemoryStatusEx"/> function instead.]
        /// Retrieves information about the system's current usage of both physical and virtual memory.
        /// </summary>
        /// 
        /// <param name="lpBuffer">
        /// A pointer to a <see cref="MEMORYSTATUS"/> structure.
        /// The GlobalMemoryStatus function stores information about current memory availability into this structure.
        /// </param>
        ///
        /// <remarks>
        /// On computers with more than 4 GB of memory, the GlobalMemoryStatus function can return incorrect information,
        /// reporting a value of –1 to indicate an overflow. For this reason, applications should use
        /// the <see cref="Sysinfoapi.Sysinfoapi.GlobalMemoryStatusEx"/> function instead.
        ///
        /// On Intel x86 computers with more than 2 GB and less than 4 GB of memory, the <see cref="GlobalMemoryStatus"/>
        /// function will always return 2 GB in the dwTotalPhys member of the <see cref="MEMORYSTATUS"/> structure.
        /// Similarly, if the total available memory is between 2 and 4 GB, the dwAvailPhys member of the
        /// <see cref="MEMORYSTATUS"/> structure will be rounded down to 2 GB. If the executable is linked using
        /// the /LARGEADDRESSAWARE linker option, then the <see cref="GlobalMemoryStatus"/> function will return
        /// the correct amount of physical memory in both members.
        ///
        /// The information returned by the <see cref="GlobalMemoryStatus"/> function is volatile.
        /// There is no guarantee that two sequential calls to this function will return the same information.
        /// </remarks>
        ///
        /// <requirements>
        /// Minimum supported client    Windows XP [desktop apps only]
        /// Minimum supported server    Windows Server 2003 [desktop apps only]
        /// Target Platform             Windows
        /// Header                      winbase.h(include Windows.h)
        /// Library                     Kernel32.lib
        /// DLL                         Kernel32.dll
        /// </requirements>
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern void GlobalMemoryStatus(ref MEMORYSTATUS lpBuffer);

        /// <summary>
        /// Enables an application to inform the system that it is in use,
        /// thereby preventing the system from entering sleep or turning off
        /// the display while the application is running.
        /// </summary>
        /// 
        /// <param name="esFlags">
        /// The thread's execution requirements. This parameter can be one or more of the following values.
        /// </param>
        /// 
        /// <returns>
        /// If the function succeeds, the return value is the previous thread execution state.
        /// If the function fails, the return value is NULL.
        /// </returns>
        ///
        /// <remarks>
        /// More details here: https://docs.microsoft.com/en-us/windows/win32/api/winbase/nf-winbase-setthreadexecutionstate
        /// </remarks>
        ///
        /// <requirements>
        /// Minimum supported client    Windows XP [desktop apps only]
        /// Minimum supported server    Windows Server 2003 [desktop apps only]
        /// Target Platform             Windows
        /// Header                      winbase.h(include Windows.h)
        /// Library                     Kernel32.lib
        /// DLL                         Kernel32.dll
        /// </requirements>
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);

        [DllImport("kernel32.dll")]
        public static extern bool VerifyVersionInfo([In] ref OSVERSIONINFOEXA lpVersionInfo, uint dwTypeMask, ulong dwlConditionMask);
    }
}