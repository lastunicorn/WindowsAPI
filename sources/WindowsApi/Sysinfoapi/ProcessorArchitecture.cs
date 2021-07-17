namespace DustInTheWind.WindowsApi.Sysinfoapi
{
    public enum ProcessorArchitecture : ushort
    {
        /// <summary>
        /// x86
        /// </summary>
        Intel = 0,

        /// <summary>
        /// ARM
        /// </summary>
        Arm = 5,

        /// <summary>
        /// Intel Itanium-based
        /// </summary>
        Ia64 = 6,

        /// <summary>
        /// x64(AMD or Intel)
        /// </summary>
        Amd64 = 9,

        /// <summary>
        /// ARM64
        /// </summary>
        Arm64 = 12,

        /// <summary>
        /// Unknown architecture
        /// </summary>
        Unknown = 0xffff
    }
}