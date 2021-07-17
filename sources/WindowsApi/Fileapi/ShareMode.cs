using System;

namespace DustInTheWind.WindowsApi.Fileapi
{
    [Flags]
    public enum ShareMode : uint
    {
        /// <summary>
        /// Prevents other processes from opening a file or device if they request delete, read, or write access.
        /// </summary>
        FILE_SHARE_NONE = 0x0,

        /// <summary>
        /// Enables subsequent open operations on a file or device to request read access.
        /// Otherwise, other processes cannot open the file or device if they request read access.
        /// If this flag is not specified, but the file or device has been opened for read access, the function fails.
        /// </summary>
        FILE_SHARE_READ = 0x1,

        /// <summary>
        /// Enables subsequent open operations on a file or device to request write access.
        /// Otherwise, other processes cannot open the file or device if they request write access.
        /// If this flag is not specified, but the file or device has been opened for write access or has a file mapping with write access, the function fails.
        /// </summary>
        FILE_SHARE_WRITE = 0x2,

        /// <summary>
        /// Enables subsequent open operations on a file or device to request delete access.
        /// Otherwise, other processes cannot open the file or device if they request delete access.
        ///
        /// If this flag is not specified, but the file or device has been opened for delete access, the function fails.
        /// Note  Delete access allows both delete and rename operations.
        /// </summary>
        FILE_SHARE_DELETE = 0x4
    }
}