namespace DustInTheWind.WindowsApi.ProcessEnv
{
    public enum StandardHandleType
    {
        /// <summary>
        /// The standard input device. Initially, this is the console input buffer, CONIN$.
        /// </summary>
        STD_INPUT_HANDLE = -10,

        /// <summary>
        /// The standard output device. Initially, this is the active console screen buffer, CONOUT$.
        /// </summary>
        STD_OUTPUT_HANDLE = -11,

        /// <summary>
        /// The standard error device. Initially, this is the active console screen buffer, CONOUT$.
        /// </summary>
        STD_ERROR_HANDLE = -12
    }
}