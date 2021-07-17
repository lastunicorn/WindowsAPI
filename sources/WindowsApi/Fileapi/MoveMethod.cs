namespace DustInTheWind.WindowsApi.Fileapi
{
    public enum MoveMethod : uint
    {
        /// <summary>
        /// The starting point is zero or the beginning of the file.
        /// </summary>
        FILE_BEGIN = 0,

        /// <summary>
        /// The starting point is the current value of the file pointer.
        /// </summary>
        FILE_CURRENT = 1,

        /// <summary>
        /// The starting point is the current end-of-file position.
        /// </summary>
        FILE_END = 2
    }
}