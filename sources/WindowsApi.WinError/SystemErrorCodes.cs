namespace DustInTheWind.WindowsApi.WinError
{
    /// <summary>
    /// The following list describes system error codes (errors 0 to 499). They are returned by the
    /// GetLastError function when many functions fail. To retrieve the description text for the
    /// error in your application, use the FormatMessage function with the
    /// FORMAT_MESSAGE_FROM_SYSTEM flag.
    /// </summary>
    ///
    /// <requirements>
    /// Minimum supported client    Windows XP [desktop apps only]
    /// Minimum supported server    Windows Server 2003 [desktop apps only]
    /// Header                      WinError.h (include Windows.h)
    /// </requirements>
    public enum SystemErrorCodes
    {
        /// <summary>
        /// ERROR_SUCCESS
        /// The operation completed successfully.
        /// </summary>
        Success = 0x0,

        /// <summary>
        /// ERROR_INVALID_FUNCTION
        /// Incorrect function.
        /// </summary>
        InvalidFunction = 0x1,

        /// <summary>
        /// ERROR_FILE_NOT_FOUND
        /// The system cannot find the file specified.
        /// </summary>
        FileNotFound = 0x2,

        /// <summary>
        /// ERROR_PATH_NOT_FOUND
        /// The system cannot find the path specified.
        /// </summary>
        PathNotFound = 0x3,

        /// <summary>
        /// ERROR_TOO_MANY_OPEN_FILES
        /// The system cannot open the file.
        /// </summary>
        TooManyOpenFiles = 0x4,

        /// <summary>
        /// ERROR_ACCESS_DENIED
        /// Access is denied.
        /// </summary>
        AccessDenied = 0x5,

        /// <summary>
        /// ERROR_INVALID_HANDLE
        /// The handle is invalid.
        /// </summary>
        InvalidHandle = 0x6,

        /// <summary>
        /// ERROR_ARENA_TRASHED
        /// The storage control blocks were destroyed.
        /// </summary>
        ArenaTrashed = 0x7,

        /// <summary>
        /// ERROR_NOT_ENOUGH_MEMORY
        /// Not enough memory resources are available to process this command.
        /// </summary>
        NotEnoughMemory = 0x8,

        /// <summary>
        /// ERROR_INVALID_BLOCK
        /// The storage control block address is invalid.
        /// </summary>
        InvalidBlock = 0x9,

        /// <summary>
        /// ERROR_BAD_ENVIRONMENT
        /// The environment is incorrect.
        /// </summary>
        BadEnvironment = 0xA,

        /// <summary>
        /// ERROR_BAD_FORMAT
        /// An attempt was made to load a program with an incorrect format.
        /// </summary>
        BadFormat = 0xB,

        /// <summary>
        /// ERROR_INVALID_ACCESS
        /// The access code is invalid.
        /// </summary>
        InvalidAccess = 0xC,

        /// <summary>
        /// ERROR_INVALID_DATA
        /// The data is invalid.
        /// </summary>
        InvalidData = 0xD,

        /// <summary>
        /// ERROR_OUTOFMEMORY
        /// Not enough storage is available to complete this operation.
        /// </summary>
        Outofmemory = 0xE,

        /// <summary>
        /// ERROR_INVALID_DRIVE
        /// The system cannot find the drive specified.
        /// </summary>
        InvalidDrive = 0xF,

        /// <summary>
        /// ERROR_CURRENT_DIRECTORY
        /// The directory cannot be removed.
        /// </summary>
        CurrentDirectory = 0x10,

        /// <summary>
        /// ERROR_NOT_SAME_DEVICE
        /// The system cannot move the file to a different disk drive.
        /// </summary>
        NotSameDevice = 0x11,

        /// <summary>
        /// ERROR_NO_MORE_FILES
        /// There are no more files.
        /// </summary>
        NoMoreFiles = 0x12,

        /// <summary>
        /// ERROR_WRITE_PROTECT
        /// The media is write protected.
        /// </summary>
        WriteProtect = 0x13,

        /// <summary>
        /// ERROR_BAD_UNIT
        /// The system cannot find the device specified.
        /// </summary>
        BadUnit = 0x14,

        /// <summary>
        /// ERROR_NOT_READY
        /// The device is not ready.
        /// </summary>
        NotReady = 0x15,

        /// <summary>
        /// ERROR_BAD_COMMAND
        /// The device does not recognize the command.
        /// </summary>
        BadCommand = 0x16,

        /// <summary>
        /// ERROR_CRC
        /// Data error (cyclic redundancy check).
        /// </summary>
        Crc = 0x17,

        /// <summary>
        /// ERROR_BAD_LENGTH
        /// The program issued a command but the command length is incorrect.
        /// </summary>
        BadLength = 0x18,

        /// <summary>
        /// ERROR_SEEK
        /// The drive cannot locate a specific area or track on the disk.
        /// </summary>
        Seek = 0x19,

        /// <summary>
        /// ERROR_NOT_DOS_DISK
        /// The specified disk or diskette cannot be accessed.
        /// </summary>
        NotDosDisk = 0x1A,

        /// <summary>
        /// ERROR_SECTOR_NOT_FOUND
        /// The drive cannot find the sector requested.
        /// </summary>
        SectorNotFound = 0x1B,

        /// <summary>
        /// ERROR_OUT_OF_PAPER
        /// The printer is out of paper.
        /// </summary>
        OutOfPaper = 0x1C,

        /// <summary>
        /// ERROR_WRITE_FAULT
        /// The system cannot write to the specified device.
        /// </summary>
        WriteFault = 0x1D,

        /// <summary>
        /// ERROR_READ_FAULT
        /// The system cannot read from the specified device.
        /// </summary>
        ReadFault = 0x1E,

        /// <summary>
        /// ERROR_GEN_FAILURE
        /// A device attached to the system is not functioning.
        /// </summary>
        GenFailure = 0x1F,

        /// <summary>
        /// ERROR_SHARING_VIOLATION
        /// The process cannot access the file because it is being used by another process.
        /// </summary>
        SharingViolation = 0x20,

        /// <summary>
        /// ERROR_LOCK_VIOLATION
        /// The process cannot access the file because another process has locked a portion of the file.
        /// </summary>
        LockViolation = 0x21,

        /// <summary>
        /// ERROR_WRONG_DISK
        /// The wrong diskette is in the drive. Insert %2 (Volume Serial Number: %3) into drive %1.
        /// </summary>
        WrongDisk = 0x22,

        /// <summary>
        /// ERROR_SHARING_BUFFER_EXCEEDED
        /// Too many files opened for sharing.
        /// </summary>
        SharingBufferExceeded = 0x24,

        /// <summary>
        /// ERROR_HANDLE_EOF
        /// Reached the end of the file.
        /// </summary>
        HandleEof = 0x26,

        /// <summary>
        /// ERROR_HANDLE_DISK_FULL
        /// The disk is full.
        /// </summary>
        HandleDiskFull = 0x27,

        /// <summary>
        /// ERROR_NOT_SUPPORTED
        /// The request is not supported.
        /// </summary>
        NotSupported = 0x32,

        /// <summary>
        /// ERROR_REM_NOT_LIST
        /// Windows cannot find the network path. Verify that the network path is correct and the destination computer is not busy or turned off. If Windows still cannot find the network path, contact your network administrator.
        /// </summary>
        RemNotList = 0x33,

        /// <summary>
        /// ERROR_DUP_NAME
        /// You were not connected because a duplicate name exists on the network. If joining a domain, go to System in Control Panel to change the computer name and try again. If joining a workgroup, choose another workgroup name.
        /// </summary>
        DupName = 0x34,

        /// <summary>
        /// ERROR_BAD_NETPATH
        /// The network path was not found.
        /// </summary>
        BadNetpath = 0x35,

        /// <summary>
        /// ERROR_NETWORK_BUSY
        /// The network is busy.
        /// </summary>
        NetworkBusy = 0x36,

        /// <summary>
        /// ERROR_DEV_NOT_EXIST
        /// The specified network resource or device is no longer available.
        /// </summary>
        DevNotExist = 0x37,

        /// <summary>
        /// ERROR_TOO_MANY_CMDS
        /// The network BIOS command limit has been reached.
        /// </summary>
        TooManyCmds = 0x38,

        /// <summary>
        /// ERROR_ADAP_HDW_ERR
        /// A network adapter hardware error occurred.
        /// </summary>
        AdapHdwErr = 0x39,

        /// <summary>
        /// ERROR_BAD_NET_RESP
        /// The specified server cannot perform the requested operation.
        /// </summary>
        BadNetResp = 0x3A,

        /// <summary>
        /// ERROR_UNEXP_NET_ERR
        /// An unexpected network error occurred.
        /// </summary>
        UnexpNetErr = 0x3B,

        /// <summary>
        /// ERROR_BAD_REM_ADAP
        /// The remote adapter is not compatible.
        /// </summary>
        BadRemAdap = 0x3C,

        /// <summary>
        /// ERROR_PRINTQ_FULL
        /// The printer queue is full.
        /// </summary>
        PrintqFull = 0x3D,

        /// <summary>
        /// ERROR_NO_SPOOL_SPACE
        /// Space to store the file waiting to be printed is not available on the server.
        /// </summary>
        NoSpoolSpace = 0x3E,

        /// <summary>
        /// ERROR_PRINT_CANCELLED
        /// Your file waiting to be printed was deleted.
        /// </summary>
        PrintCancelled = 0x3F,

        /// <summary>
        /// ERROR_NETNAME_DELETED
        /// The specified network name is no longer available.
        /// </summary>
        NetnameDeleted = 0x40,

        /// <summary>
        /// ERROR_NETWORK_ACCESS_DENIED
        /// Network access is denied.
        /// </summary>
        NetworkAccessDenied = 0x41,

        /// <summary>
        /// ERROR_BAD_DEV_TYPE
        /// The network resource type is not correct.
        /// </summary>
        BadDevType = 0x42,

        /// <summary>
        /// ERROR_BAD_NET_NAME
        /// The network name cannot be found.
        /// </summary>
        BadNetName = 0x43,

        /// <summary>
        /// ERROR_TOO_MANY_NAMES
        /// The name limit for the local computer network adapter card was exceeded.
        /// </summary>
        TooManyNames = 0x44,

        /// <summary>
        /// ERROR_TOO_MANY_SESS
        /// The network BIOS session limit was exceeded.
        /// </summary>
        TooManySess = 0x45,

        /// <summary>
        /// ERROR_SHARING_PAUSED
        /// The remote server has been paused or is in the process of being started.
        /// </summary>
        SharingPaused = 0x46,

        /// <summary>
        /// ERROR_REQ_NOT_ACCEP
        /// No more connections can be made to this remote computer at this time because there are already as many connections as the computer can accept.
        /// </summary>
        ReqNotAccep = 0x47,

        /// <summary>
        /// ERROR_REDIR_PAUSED
        /// The specified printer or disk device has been paused.
        /// </summary>
        RedirPaused = 0x48,

        /// <summary>
        /// ERROR_FILE_EXISTS
        /// The file exists.
        /// </summary>
        FileExists = 0x50,

        /// <summary>
        /// ERROR_CANNOT_MAKE
        /// The directory or file cannot be created.
        /// </summary>
        CannotMake = 0x52,

        /// <summary>
        /// ERROR_FAIL_I24
        /// Fail on INT 24.
        /// </summary>
        FailI24 = 0x53,

        /// <summary>
        /// ERROR_OUT_OF_STRUCTURES
        /// Storage to process this request is not available.
        /// </summary>
        OutOfStructures = 0x54,

        /// <summary>
        /// ERROR_ALREADY_ASSIGNED
        /// The local device name is already in use.
        /// </summary>
        AlreadyAssigned = 0x55,

        /// <summary>
        /// ERROR_INVALID_PASSWORD
        /// The specified network password is not correct.
        /// </summary>
        InvalidPassword = 0x56,

        /// <summary>
        /// ERROR_INVALID_PARAMETER
        /// The parameter is incorrect.
        /// </summary>
        InvalidParameter = 0x57,

        /// <summary>
        /// ERROR_NET_WRITE_FAULT
        /// A write fault occurred on the network.
        /// </summary>
        NetWriteFault = 0x58,

        /// <summary>
        /// ERROR_NO_PROC_SLOTS
        /// The system cannot start another process at this time.
        /// </summary>
        NoProcSlots = 0x59,

        /// <summary>
        /// ERROR_TOO_MANY_SEMAPHORES
        /// Cannot create another system semaphore.
        /// </summary>
        TooManySemaphores = 0x64,

        /// <summary>
        /// ERROR_EXCL_SEM_ALREADY_OWNED
        /// The exclusive semaphore is owned by another process.
        /// </summary>
        ExclSemAlreadyOwned = 0x65,

        /// <summary>
        /// ERROR_SEM_IS_SET
        /// The semaphore is set and cannot be closed.
        /// </summary>
        SemIsSet = 0x66,

        /// <summary>
        /// ERROR_TOO_MANY_SEM_REQUESTS
        /// The semaphore cannot be set again.
        /// </summary>
        TooManySemRequests = 0x67,

        /// <summary>
        /// ERROR_INVALID_AT_INTERRUPT_TIME
        /// Cannot request exclusive semaphores at interrupt time.
        /// </summary>
        InvalidAtInterruptTime = 0x68,

        /// <summary>
        /// ERROR_SEM_OWNER_DIED
        /// The previous ownership of this semaphore has ended.
        /// </summary>
        SemOwnerDied = 0x69,

        /// <summary>
        /// ERROR_SEM_USER_LIMIT
        /// Insert the diskette for drive %1.
        /// </summary>
        SemUserLimit = 0x6A,

        /// <summary>
        /// ERROR_DISK_CHANGE
        /// The program stopped because an alternate diskette was not inserted.
        /// </summary>
        DiskChange = 0x6B,

        /// <summary>
        /// ERROR_DRIVE_LOCKED
        /// The disk is in use or locked by another process.
        /// </summary>
        DriveLocked = 0x6C,

        /// <summary>
        /// ERROR_BROKEN_PIPE
        /// The pipe has been ended.
        /// </summary>
        BrokenPipe = 0x6D,

        /// <summary>
        /// ERROR_OPEN_FAILED
        /// The system cannot open the device or file specified.
        /// </summary>
        OpenFailed = 0x6E,

        /// <summary>
        /// ERROR_BUFFER_OVERFLOW
        /// The file name is too long.
        /// </summary>
        BufferOverflow = 0x6F,

        /// <summary>
        /// ERROR_DISK_FULL
        /// There is not enough space on the disk.
        /// </summary>
        DiskFull = 0x70,

        /// <summary>
        /// ERROR_NO_MORE_SEARCH_HANDLES
        /// No more internal file identifiers available.
        /// </summary>
        NoMoreSearchHandles = 0x71,

        /// <summary>
        /// ERROR_INVALID_TARGET_HANDLE
        /// The target internal file identifier is incorrect.
        /// </summary>
        InvalidTargetHandle = 0x72,

        /// <summary>
        /// ERROR_INVALID_CATEGORY
        /// The IOCTL call made by the application program is not correct.
        /// </summary>
        InvalidCategory = 0x75,

        /// <summary>
        /// ERROR_INVALID_VERIFY_SWITCH
        /// The verify-on-write switch parameter value is not correct.
        /// </summary>
        InvalidVerifySwitch = 0x76,

        /// <summary>
        /// ERROR_BAD_DRIVER_LEVEL
        /// The system does not support the command requested.
        /// </summary>
        BadDriverLevel = 0x77,

        /// <summary>
        /// ERROR_CALL_NOT_IMPLEMENTED
        /// This function is not supported on this system.
        /// </summary>
        CallNotImplemented = 0x78,

        /// <summary>
        /// ERROR_SEM_TIMEOUT
        /// The semaphore timeout period has expired.
        /// </summary>
        SemTimeout = 0x79,

        /// <summary>
        /// ERROR_INSUFFICIENT_BUFFER
        /// The data area passed to a system call is too small.
        /// </summary>
        InsufficientBuffer = 0x7A,

        /// <summary>
        /// ERROR_INVALID_NAME
        /// The filename, directory name, or volume label syntax is incorrect.
        /// </summary>
        InvalidName = 0x7B,

        /// <summary>
        /// ERROR_INVALID_LEVEL
        /// The system call level is not correct.
        /// </summary>
        InvalidLevel = 0x7C,

        /// <summary>
        /// ERROR_NO_VOLUME_LABEL
        /// The disk has no volume label.
        /// </summary>
        NoVolumeLabel = 0x7D,

        /// <summary>
        /// ERROR_MOD_NOT_FOUND
        /// The specified module could not be found.
        /// </summary>
        ModNotFound = 0x7E,

        /// <summary>
        /// ERROR_PROC_NOT_FOUND
        /// The specified procedure could not be found.
        /// </summary>
        ProcNotFound = 0x7F,

        /// <summary>
        /// ERROR_WAIT_NO_CHILDREN
        /// There are no child processes to wait for.
        /// </summary>
        WaitNoChildren = 0x80,

        /// <summary>
        /// ERROR_CHILD_NOT_COMPLETE
        /// The %1 application cannot be run in Win32 mode.
        /// </summary>
        ChildNotComplete = 0x81,

        /// <summary>
        /// ERROR_DIRECT_ACCESS_HANDLE
        /// Attempt to use a file handle to an open disk partition for an operation other than raw disk I/O.
        /// </summary>
        DirectAccessHandle = 0x82,

        /// <summary>
        /// ERROR_NEGATIVE_SEEK
        /// An attempt was made to move the file pointer before the beginning of the file.
        /// </summary>
        NegativeSeek = 0x83,

        /// <summary>
        /// ERROR_SEEK_ON_DEVICE
        /// The file pointer cannot be set on the specified device or file.
        /// </summary>
        SeekOnDevice = 0x84,

        /// <summary>
        /// ERROR_IS_JOIN_TARGET
        /// A JOIN or SUBST command cannot be used for a drive that contains previously joined drives.
        /// </summary>
        IsJoinTarget = 0x85,

        /// <summary>
        /// ERROR_IS_JOINED
        /// An attempt was made to use a JOIN or SUBST command on a drive that has already been joined.
        /// </summary>
        IsJoined = 0x86,

        /// <summary>
        /// ERROR_IS_SUBSTED
        /// An attempt was made to use a JOIN or SUBST command on a drive that has already been substituted.
        /// </summary>
        IsSubsted = 0x87,

        /// <summary>
        /// ERROR_NOT_JOINED
        /// The system tried to delete the JOIN of a drive that is not joined.
        /// </summary>
        NotJoined = 0x88,

        /// <summary>
        /// ERROR_NOT_SUBSTED
        /// The system tried to delete the substitution of a drive that is not substituted.
        /// </summary>
        NotSubsted = 0x89,

        /// <summary>
        /// ERROR_JOIN_TO_JOIN
        /// The system tried to join a drive to a directory on a joined drive.
        /// </summary>
        JoinToJoin = 0x8A,

        /// <summary>
        /// ERROR_SUBST_TO_SUBST
        /// The system tried to substitute a drive to a directory on a substituted drive.
        /// </summary>
        SubstToSubst = 0x8B,

        /// <summary>
        /// ERROR_JOIN_TO_SUBST
        /// The system tried to join a drive to a directory on a substituted drive.
        /// </summary>
        JoinToSubst = 0x8C,

        /// <summary>
        /// ERROR_SUBST_TO_JOIN
        /// The system tried to SUBST a drive to a directory on a joined drive.
        /// </summary>
        SubstToJoin = 0x8D,

        /// <summary>
        /// ERROR_BUSY_DRIVE
        /// The system cannot perform a JOIN or SUBST at this time.
        /// </summary>
        BusyDrive = 0x8E,

        /// <summary>
        /// ERROR_SAME_DRIVE
        /// The system cannot join or substitute a drive to or for a directory on the same drive.
        /// </summary>
        SameDrive = 0x8F,

        /// <summary>
        /// ERROR_DIR_NOT_ROOT
        /// The directory is not a subdirectory of the root directory.
        /// </summary>
        DirNotRoot = 0x90,

        /// <summary>
        /// ERROR_DIR_NOT_EMPTY
        /// The directory is not empty.
        /// </summary>
        DirNotEmpty = 0x91,

        /// <summary>
        /// ERROR_IS_SUBST_PATH
        /// The path specified is being used in a substitute.
        /// </summary>
        IsSubstPath = 0x92,

        /// <summary>
        /// ERROR_IS_JOIN_PATH
        /// Not enough resources are available to process this command.
        /// </summary>
        IsJoinPath = 0x93,

        /// <summary>
        /// ERROR_PATH_BUSY
        /// The path specified cannot be used at this time.
        /// </summary>
        PathBusy = 0x94,

        /// <summary>
        /// ERROR_IS_SUBST_TARGET
        /// An attempt was made to join or substitute a drive for which a directory on the drive is the target of a previous substitute.
        /// </summary>
        IsSubstTarget = 0x95,

        /// <summary>
        /// ERROR_SYSTEM_TRACE
        /// System trace information was not specified in your CONFIG.SYS file, or tracing is disallowed.
        /// </summary>
        SystemTrace = 0x96,

        /// <summary>
        /// ERROR_INVALID_EVENT_COUNT
        /// The number of specified semaphore events for DosMuxSemWait is not correct.
        /// </summary>
        InvalidEventCount = 0x97,

        /// <summary>
        /// ERROR_TOO_MANY_MUXWAITERS
        /// DosMuxSemWait did not execute; too many semaphores are already set.
        /// </summary>
        TooManyMuxwaiters = 0x98,

        /// <summary>
        /// ERROR_INVALID_LIST_FORMAT
        /// The DosMuxSemWait list is not correct.
        /// </summary>
        InvalidListFormat = 0x99,

        /// <summary>
        /// ERROR_LABEL_TOO_LONG
        /// The volume label you entered exceeds the label character limit of the target file system.
        /// </summary>
        LabelTooLong = 0x9A,

        /// <summary>
        /// ERROR_TOO_MANY_TCBS
        /// Cannot create another thread.
        /// </summary>
        TooManyTcbs = 0x9B,

        /// <summary>
        /// ERROR_SIGNAL_REFUSED
        /// The recipient process has refused the signal.
        /// </summary>
        SignalRefused = 0x9C,

        /// <summary>
        /// ERROR_DISCARDED
        /// The segment is already discarded and cannot be locked.
        /// </summary>
        Discarded = 0x9D,

        /// <summary>
        /// ERROR_NOT_LOCKED
        /// The segment is already unlocked.
        /// </summary>
        NotLocked = 0x9E,

        /// <summary>
        /// ERROR_BAD_THREADID_ADDR
        /// The address for the thread ID is not correct.
        /// </summary>
        BadThreadidAddr = 0x9F,

        /// <summary>
        /// ERROR_BAD_ARGUMENTS
        /// One or more arguments are not correct.
        /// </summary>
        BadArguments = 0xA0,

        /// <summary>
        /// ERROR_BAD_PATHNAME
        /// The specified path is invalid.
        /// </summary>
        BadPathname = 0xA1,

        /// <summary>
        /// ERROR_SIGNAL_PENDING
        /// A signal is already pending.
        /// </summary>
        SignalPending = 0xA2,

        /// <summary>
        /// ERROR_MAX_THRDS_REACHED
        /// No more threads can be created in the system.
        /// </summary>
        MaxThrdsReached = 0xA4,

        /// <summary>
        /// ERROR_LOCK_FAILED
        /// Unable to lock a region of a file.
        /// </summary>
        LockFailed = 0xA7,

        /// <summary>
        /// ERROR_BUSY
        /// The requested resource is in use.
        /// </summary>
        Busy = 0xAA,

        /// <summary>
        /// ERROR_DEVICE_SUPPORT_IN_PROGRESS
        /// Device's command support detection is in progress.
        /// </summary>
        DeviceSupportInProgress = 0xAB,

        /// <summary>
        /// ERROR_CANCEL_VIOLATION
        /// A lock request was not outstanding for the supplied cancel region.
        /// </summary>
        CancelViolation = 0xAD,

        /// <summary>
        /// ERROR_ATOMIC_LOCKS_NOT_SUPPORTED
        /// The file system does not support atomic changes to the lock type.
        /// </summary>
        AtomicLocksNotSupported = 0xAE,

        /// <summary>
        /// ERROR_INVALID_SEGMENT_NUMBER
        /// The system detected a segment number that was not correct.
        /// </summary>
        InvalidSegmentNumber = 0xB4,

        /// <summary>
        /// ERROR_INVALID_ORDINAL
        /// The operating system cannot run %1.
        /// </summary>
        InvalidOrdinal = 0xB6,

        /// <summary>
        /// ERROR_ALREADY_EXISTS
        /// Cannot create a file when that file already exists.
        /// </summary>
        AlreadyExists = 0xB7,

        /// <summary>
        /// ERROR_INVALID_FLAG_NUMBER
        /// The flag passed is not correct.
        /// </summary>
        InvalidFlagNumber = 0xBA,

        /// <summary>
        /// ERROR_SEM_NOT_FOUND
        /// The specified system semaphore name was not found.
        /// </summary>
        SemNotFound = 0xBB,

        /// <summary>
        /// ERROR_INVALID_STARTING_CODESEG
        /// The operating system cannot run %1.
        /// </summary>
        InvalidStartingCodeseg = 0xBC,

        /// <summary>
        /// ERROR_INVALID_STACKSEG
        /// The operating system cannot run %1.
        /// </summary>
        InvalidStackseg = 0xBD,

        /// <summary>
        /// ERROR_INVALID_MODULETYPE
        /// The operating system cannot run %1.
        /// </summary>
        InvalidModuletype = 0xBE,

        /// <summary>
        /// ERROR_INVALID_EXE_SIGNATURE
        /// Cannot run %1 in Win32 mode.
        /// </summary>
        InvalidExeSignature = 0xBF,

        /// <summary>
        /// ERROR_EXE_MARKED_INVALID
        /// The operating system cannot run %1.
        /// </summary>
        ExeMarkedInvalid = 0xC0,

        /// <summary>
        /// ERROR_BAD_EXE_FORMAT
        /// %1 is not a valid Win32 application.
        /// </summary>
        BadExeFormat = 0xC1,

        /// <summary>
        /// ERROR_ITERATED_DATA_EXCEEDS_64k
        /// The operating system cannot run %1.
        /// </summary>
        IteratedDataExceeds64k = 0xC2,

        /// <summary>
        /// ERROR_INVALID_MINALLOCSIZE
        /// The operating system cannot run %1.
        /// </summary>
        InvalidMinallocsize = 0xC3,

        /// <summary>
        /// ERROR_DYNLINK_FROM_INVALID_RING
        /// The operating system cannot run this application program.
        /// </summary>
        DynlinkFromInvalidRing = 0xC4,

        /// <summary>
        /// ERROR_IOPL_NOT_ENABLED
        /// The operating system is not presently configured to run this application.
        /// </summary>
        IoplNotEnabled = 0xC5,

        /// <summary>
        /// ERROR_INVALID_SEGDPL
        /// The operating system cannot run %1.
        /// </summary>
        InvalidSegdpl = 0xC6,

        /// <summary>
        /// ERROR_AUTODATASEG_EXCEEDS_64k
        /// The operating system cannot run this application program.
        /// </summary>
        AutodatasegExceeds64k = 0xC7,

        /// <summary>
        /// ERROR_RING2SEG_MUST_BE_MOVABLE
        /// The code segment cannot be greater than or equal to 64K.
        /// </summary>
        Ring2segMustBeMovable = 0xC8,

        /// <summary>
        /// ERROR_RELOC_CHAIN_XEEDS_SEGLIM
        /// The operating system cannot run %1.
        /// </summary>
        RelocChainXeedsSeglim = 0xC9,

        /// <summary>
        /// ERROR_INFLOOP_IN_RELOC_CHAIN
        /// The operating system cannot run %1.
        /// </summary>
        InfloopInRelocChain = 0xCA,

        /// <summary>
        /// ERROR_ENVVAR_NOT_FOUND
        /// The system could not find the environment option that was entered.
        /// </summary>
        EnvvarNotFound = 0xCB,

        /// <summary>
        /// ERROR_NO_SIGNAL_SENT
        /// No process in the command subtree has a signal handler.
        /// </summary>
        NoSignalSent = 0xCD,

        /// <summary>
        /// ERROR_FILENAME_EXCED_RANGE
        /// The filename or extension is too long.
        /// </summary>
        FilenameExcedRange = 0xCE,

        /// <summary>
        /// ERROR_RING2_STACK_IN_USE
        /// The ring 2 stack is in use.
        /// </summary>
        Ring2StackInUse = 0xCF,

        /// <summary>
        /// ERROR_META_EXPANSION_TOO_LONG
        /// The global filename characters, * or ?, are entered incorrectly or too many global filename characters are specified.
        /// </summary>
        MetaExpansionTooLong = 0xD0,

        /// <summary>
        /// ERROR_INVALID_SIGNAL_NUMBER
        /// The signal being posted is not correct.
        /// </summary>
        InvalidSignalNumber = 0xD1,

        /// <summary>
        /// ERROR_THREAD_1_INACTIVE
        /// The signal handler cannot be set.
        /// </summary>
        Thread1Inactive = 0xD2,

        /// <summary>
        /// ERROR_LOCKED
        /// The segment is locked and cannot be reallocated.
        /// </summary>
        Locked = 0xD4,

        /// <summary>
        /// ERROR_TOO_MANY_MODULES
        /// Too many dynamic-link modules are attached to this program or dynamic-link module.
        /// </summary>
        TooManyModules = 0xD6,

        /// <summary>
        /// ERROR_NESTING_NOT_ALLOWED
        /// Cannot nest calls to LoadModule.
        /// </summary>
        NestingNotAllowed = 0xD7,

        /// <summary>
        /// ERROR_EXE_MACHINE_TYPE_MISMATCH
        /// This version of %1 is not compatible with the version of Windows you're running. Check your computer's system information and then contact the software publisher.
        /// </summary>
        ExeMachineTypeMismatch = 0xD8,

        /// <summary>
        /// ERROR_EXE_CANNOT_MODIFY_SIGNED_BINARY
        /// The image file %1 is signed, unable to modify.
        /// </summary>
        ExeCannotModifySignedBinary = 0xD9,

        /// <summary>
        /// ERROR_EXE_CANNOT_MODIFY_STRONG_SIGNED_BINARY
        /// The image file %1 is strong signed, unable to modify.
        /// </summary>
        ExeCannotModifyStrongSignedBinary = 0xDA,

        /// <summary>
        /// ERROR_FILE_CHECKED_OUT
        /// This file is checked out or locked for editing by another user.
        /// </summary>
        FileCheckedOut = 0xDC,

        /// <summary>
        /// ERROR_CHECKOUT_REQUIRED
        /// The file must be checked out before saving changes.
        /// </summary>
        CheckoutRequired = 0xDD,

        /// <summary>
        /// ERROR_BAD_FILE_TYPE
        /// The file type being saved or retrieved has been blocked.
        /// </summary>
        BadFileType = 0xDE,

        /// <summary>
        /// ERROR_FILE_TOO_LARGE
        /// The file size exceeds the limit allowed and cannot be saved.
        /// </summary>
        FileTooLarge = 0xDF,

        /// <summary>
        /// ERROR_FORMS_AUTH_REQUIRED
        /// Access Denied. Before opening files in this location, you must first add the web site to your trusted sites list, browse to the web site, and select the option to login automatically.
        /// </summary>
        FormsAuthRequired = 0xE0,

        /// <summary>
        /// ERROR_VIRUS_INFECTED
        /// Operation did not complete successfully because the file contains a virus or potentially unwanted software.
        /// </summary>
        VirusInfected = 0xE1,

        /// <summary>
        /// ERROR_VIRUS_DELETED
        /// This file contains a virus or potentially unwanted software and cannot be opened. Due to the nature of this virus or potentially unwanted software, the file has been removed from this location.
        /// </summary>
        VirusDeleted = 0xE2,

        /// <summary>
        /// ERROR_PIPE_LOCAL
        /// The pipe is local.
        /// </summary>
        PipeLocal = 0xE5,

        /// <summary>
        /// ERROR_BAD_PIPE
        /// The pipe state is invalid.
        /// </summary>
        BadPipe = 0xE6,

        /// <summary>
        /// ERROR_PIPE_BUSY
        /// All pipe instances are busy.
        /// </summary>
        PipeBusy = 0xE7,

        /// <summary>
        /// ERROR_NO_DATA
        /// The pipe is being closed.
        /// </summary>
        NoData = 0xE8,

        /// <summary>
        /// ERROR_PIPE_NOT_CONNECTED
        /// No process is on the other end of the pipe.
        /// </summary>
        PipeNotConnected = 0xE9,

        /// <summary>
        /// ERROR_MORE_DATA
        /// More data is available.
        /// </summary>
        MoreData = 0xEA,

        /// <summary>
        /// ERROR_VC_DISCONNECTED
        /// The session was canceled.
        /// </summary>
        VcDisconnected = 0xF0,

        /// <summary>
        /// ERROR_INVALID_EA_NAME
        /// The specified extended attribute name was invalid.
        /// </summary>
        InvalidEaName = 0xFE,

        /// <summary>
        /// ERROR_EA_LIST_INCONSISTENT
        /// The extended attributes are inconsistent.
        /// </summary>
        EaListInconsistent = 0xFF,

        /// <summary>
        /// WAIT_TIMEOUT
        /// The wait operation timed out.
        /// </summary>
        WaitTimeout = 0x102,

        /// <summary>
        /// ERROR_NO_MORE_ITEMS
        /// No more data is available.
        /// </summary>
        NoMoreItems = 0x103,

        /// <summary>
        /// ERROR_CANNOT_COPY
        /// The copy functions cannot be used.
        /// </summary>
        CannotCopy = 0x10A,

        /// <summary>
        /// ERROR_DIRECTORY
        /// The directory name is invalid.
        /// </summary>
        Directory = 0x10B,

        /// <summary>
        /// ERROR_EAS_DIDNT_FIT
        /// The extended attributes did not fit in the buffer.
        /// </summary>
        EasDidntFit = 0x113,

        /// <summary>
        /// ERROR_EA_FILE_CORRUPT
        /// The extended attribute file on the mounted file system is corrupt.
        /// </summary>
        EaFileCorrupt = 0x114,

        /// <summary>
        /// ERROR_EA_TABLE_FULL
        /// The extended attribute table file is full.
        /// </summary>
        EaTableFull = 0x115,

        /// <summary>
        /// ERROR_INVALID_EA_HANDLE
        /// The specified extended attribute handle is invalid.
        /// </summary>
        InvalidEaHandle = 0x116,

        /// <summary>
        /// ERROR_EAS_NOT_SUPPORTED
        /// The mounted file system does not support extended attributes.
        /// </summary>
        EasNotSupported = 0x11A,

        /// <summary>
        /// ERROR_NOT_OWNER
        /// Attempt to release mutex not owned by caller.
        /// </summary>
        NotOwner = 0x120,

        /// <summary>
        /// ERROR_TOO_MANY_POSTS
        /// Too many posts were made to a semaphore.
        /// </summary>
        TooManyPosts = 0x12A,

        /// <summary>
        /// ERROR_PARTIAL_COPY
        /// Only part of a ReadProcessMemory or WriteProcessMemory request was completed.
        /// </summary>
        PartialCopy = 0x12B,

        /// <summary>
        /// ERROR_OPLOCK_NOT_GRANTED
        /// The oplock request is denied.
        /// </summary>
        OplockNotGranted = 0x12C,

        /// <summary>
        /// ERROR_INVALID_OPLOCK_PROTOCOL
        /// An invalid oplock acknowledgment was received by the system.
        /// </summary>
        InvalidOplockProtocol = 0x12D,

        /// <summary>
        /// ERROR_DISK_TOO_FRAGMENTED
        /// The volume is too fragmented to complete this operation.
        /// </summary>
        DiskTooFragmented = 0x12E,

        /// <summary>
        /// ERROR_DELETE_PENDING
        /// The file cannot be opened because it is in the process of being deleted.
        /// </summary>
        DeletePending = 0x12F,

        /// <summary>
        /// ERROR_INCOMPATIBLE_WITH_GLOBAL_SHORT_NAME_REGISTRY_SETTING
        /// Short name settings may not be changed on this volume due to the global registry setting.
        /// </summary>
        IncompatibleWithGlobalShortNameRegistrySetting = 0x130,

        /// <summary>
        /// ERROR_SHORT_NAMES_NOT_ENABLED_ON_VOLUME
        /// Short names are not enabled on this volume.
        /// </summary>
        ShortNamesNotEnabledOnVolume = 0x131,

        /// <summary>
        /// ERROR_SECURITY_STREAM_IS_INCONSISTENT
        /// The security stream for the given volume is in an inconsistent state. Please run CHKDSK on the volume.
        /// </summary>
        SecurityStreamIsInconsistent = 0x132,

        /// <summary>
        /// ERROR_INVALID_LOCK_RANGE
        /// A requested file lock operation cannot be processed due to an invalid byte range.
        /// </summary>
        InvalidLockRange = 0x133,

        /// <summary>
        /// ERROR_IMAGE_SUBSYSTEM_NOT_PRESENT
        /// The subsystem needed to support the image type is not present.
        /// </summary>
        ImageSubsystemNotPresent = 0x134,

        /// <summary>
        /// ERROR_NOTIFICATION_GUID_ALREADY_DEFINED
        /// The specified file already has a notification GUID associated with it.
        /// </summary>
        NotificationGuidAlreadyDefined = 0x135,

        /// <summary>
        /// ERROR_INVALID_EXCEPTION_HANDLER
        /// An invalid exception handler routine has been detected.
        /// </summary>
        InvalidExceptionHandler = 0x136,

        /// <summary>
        /// ERROR_DUPLICATE_PRIVILEGES
        /// Duplicate privileges were specified for the token.
        /// </summary>
        DuplicatePrivileges = 0x137,

        /// <summary>
        /// ERROR_NO_RANGES_PROCESSED
        /// No ranges for the specified operation were able to be processed.
        /// </summary>
        NoRangesProcessed = 0x138,

        /// <summary>
        /// ERROR_NOT_ALLOWED_ON_SYSTEM_FILE
        /// Operation is not allowed on a file system internal file.
        /// </summary>
        NotAllowedOnSystemFile = 0x139,

        /// <summary>
        /// ERROR_DISK_RESOURCES_EXHAUSTED
        /// The physical resources of this disk have been exhausted.
        /// </summary>
        DiskResourcesExhausted = 0x13A,

        /// <summary>
        /// ERROR_INVALID_TOKEN
        /// The token representing the data is invalid.
        /// </summary>
        InvalidToken = 0x13B,

        /// <summary>
        /// ERROR_DEVICE_FEATURE_NOT_SUPPORTED
        /// The device does not support the command feature.
        /// </summary>
        DeviceFeatureNotSupported = 0x13C,

        /// <summary>
        /// ERROR_MR_MID_NOT_FOUND
        /// The system cannot find message text for message number 0x%1 in the message file for %2.
        /// </summary>
        MrMidNotFound = 0x13D,

        /// <summary>
        /// ERROR_SCOPE_NOT_FOUND
        /// The scope specified was not found.
        /// </summary>
        ScopeNotFound = 0x13E,

        /// <summary>
        /// ERROR_UNDEFINED_SCOPE
        /// The Central Access Policy specified is not defined on the target machine.
        /// </summary>
        UndefinedScope = 0x13F,

        /// <summary>
        /// ERROR_INVALID_CAP
        /// The Central Access Policy obtained from Active Directory is invalid.
        /// </summary>
        InvalidCap = 0x140,

        /// <summary>
        /// ERROR_DEVICE_UNREACHABLE
        /// The device is unreachable.
        /// </summary>
        DeviceUnreachable = 0x141,

        /// <summary>
        /// ERROR_DEVICE_NO_RESOURCES
        /// The target device has insufficient resources to complete the operation.
        /// </summary>
        DeviceNoResources = 0x142,

        /// <summary>
        /// ERROR_DATA_CHECKSUM_ERROR
        /// A data integrity checksum error occurred. Data in the file stream is corrupt.
        /// </summary>
        DataChecksumError = 0x143,

        /// <summary>
        /// ERROR_INTERMIXED_KERNEL_EA_OPERATION
        /// An attempt was made to modify both a KERNEL and normal Extended Attribute (EA) in the same operation.
        /// </summary>
        IntermixedKernelEaOperation = 0x144,

        /// <summary>
        /// ERROR_FILE_LEVEL_TRIM_NOT_SUPPORTED
        /// Device does not support file-level TRIM.
        /// </summary>
        FileLevelTrimNotSupported = 0x146,

        /// <summary>
        /// ERROR_OFFSET_ALIGNMENT_VIOLATION
        /// The command specified a data offset that does not align to the device's granularity/alignment.
        /// </summary>
        OffsetAlignmentViolation = 0x147,

        /// <summary>
        /// ERROR_INVALID_FIELD_IN_PARAMETER_LIST
        /// The command specified an invalid field in its parameter list.
        /// </summary>
        InvalidFieldInParameterList = 0x148,

        /// <summary>
        /// ERROR_OPERATION_IN_PROGRESS
        /// An operation is currently in progress with the device.
        /// </summary>
        OperationInProgress = 0x149,

        /// <summary>
        /// ERROR_BAD_DEVICE_PATH
        /// An attempt was made to send down the command via an invalid path to the target device.
        /// </summary>
        BadDevicePath = 0x14A,

        /// <summary>
        /// ERROR_TOO_MANY_DESCRIPTORS
        /// The command specified a number of descriptors that exceeded the maximum supported by the device.
        /// </summary>
        TooManyDescriptors = 0x14B,

        /// <summary>
        /// ERROR_SCRUB_DATA_DISABLED
        /// Scrub is disabled on the specified file.
        /// </summary>
        ScrubDataDisabled = 0x14C,

        /// <summary>
        /// ERROR_NOT_REDUNDANT_STORAGE
        /// The storage device does not provide redundancy.
        /// </summary>
        NotRedundantStorage = 0x14D,

        /// <summary>
        /// ERROR_RESIDENT_FILE_NOT_SUPPORTED
        /// An operation is not supported on a resident file.
        /// </summary>
        ResidentFileNotSupported = 0x14E,

        /// <summary>
        /// ERROR_COMPRESSED_FILE_NOT_SUPPORTED
        /// An operation is not supported on a compressed file.
        /// </summary>
        CompressedFileNotSupported = 0x14F,

        /// <summary>
        /// ERROR_DIRECTORY_NOT_SUPPORTED
        /// An operation is not supported on a directory.
        /// </summary>
        DirectoryNotSupported = 0x150,

        /// <summary>
        /// ERROR_NOT_READ_FROM_COPY
        /// The specified copy of the requested data could not be read.
        /// </summary>
        NotReadFromCopy = 0x151,

        /// <summary>
        /// ERROR_FAIL_NOACTION_REBOOT
        /// No action was taken as a system reboot is required.
        /// </summary>
        FailNoactionReboot = 0x15E,

        /// <summary>
        /// ERROR_FAIL_SHUTDOWN
        /// The shutdown operation failed.
        /// </summary>
        FailShutdown = 0x15F,

        /// <summary>
        /// ERROR_FAIL_RESTART
        /// The restart operation failed.
        /// </summary>
        FailRestart = 0x160,

        /// <summary>
        /// ERROR_MAX_SESSIONS_REACHED
        /// The maximum number of sessions has been reached.
        /// </summary>
        MaxSessionsReached = 0x161,

        /// <summary>
        /// ERROR_THREAD_MODE_ALREADY_BACKGROUND
        /// The thread is already in background processing mode.
        /// </summary>
        ThreadModeAlreadyBackground = 0x190,

        /// <summary>
        /// ERROR_THREAD_MODE_NOT_BACKGROUND
        /// The thread is not in background processing mode.
        /// </summary>
        ThreadModeNotBackground = 0x191,

        /// <summary>
        /// ERROR_PROCESS_MODE_ALREADY_BACKGROUND
        /// The process is already in background processing mode.
        /// </summary>
        ProcessModeAlreadyBackground = 0x192,

        /// <summary>
        /// ERROR_PROCESS_MODE_NOT_BACKGROUND
        /// The process is not in background processing mode.
        /// </summary>
        ProcessModeNotBackground = 0x193,

        /// <summary>
        /// ERROR_INVALID_ADDRESS
        /// Attempt to access invalid address.
        /// </summary>
        InvalidAddress = 0x1E7,

        /// <summary>
        /// ERROR_USER_PROFILE_LOAD
        /// User profile cannot be loaded.
        /// </summary>
        UserProfileLoad = 0x1F4,

        /// <summary>
        /// ERROR_ARITHMETIC_OVERFLOW
        /// Arithmetic result exceeded 32 bits.
        /// </summary>
        ArithmeticOverflow = 0x216,

        /// <summary>
        /// ERROR_PIPE_CONNECTED
        /// There is a process on other end of the pipe.
        /// </summary>
        PipeConnected = 0x217,

        /// <summary>
        /// ERROR_PIPE_LISTENING
        /// Waiting for a process to open the other end of the pipe.
        /// </summary>
        PipeListening = 0x218,

        /// <summary>
        /// ERROR_VERIFIER_STOP
        /// Application verifier has found an error in the current process.
        /// </summary>
        VerifierStop = 0x219,

        /// <summary>
        /// ERROR_ABIOS_ERROR
        /// An error occurred in the ABIOS subsystem.
        /// </summary>
        AbiosError = 0x21A,

        /// <summary>
        /// ERROR_WX86_WARNING
        /// A warning occurred in the WX86 subsystem.
        /// </summary>
        Wx86Warning = 0x21B,

        /// <summary>
        /// ERROR_WX86_ERROR
        /// An error occurred in the WX86 subsystem.
        /// </summary>
        Wx86Error = 0x21C,

        /// <summary>
        /// ERROR_TIMER_NOT_CANCELED
        /// An attempt was made to cancel or set a timer that has an associated APC and the subject thread is not the thread that originally set the timer with an associated APC routine.
        /// </summary>
        TimerNotCanceled = 0x21D,

        /// <summary>
        /// ERROR_UNWIND
        /// Unwind exception code.
        /// </summary>
        Unwind = 0x21E,

        /// <summary>
        /// ERROR_BAD_STACK
        /// An invalid or unaligned stack was encountered during an unwind operation.
        /// </summary>
        BadStack = 0x21F,

        /// <summary>
        /// ERROR_INVALID_UNWIND_TARGET
        /// An invalid unwind target was encountered during an unwind operation.
        /// </summary>
        InvalidUnwindTarget = 0x220,

        /// <summary>
        /// ERROR_INVALID_PORT_ATTRIBUTES
        /// Invalid Object Attributes specified to NtCreatePort or invalid Port Attributes specified to NtConnectPort
        /// </summary>
        InvalidPortAttributes = 0x221,

        /// <summary>
        /// ERROR_PORT_MESSAGE_TOO_LONG
        /// Length of message passed to NtRequestPort or NtRequestWaitReplyPort was longer than the maximum message allowed by the port.
        /// </summary>
        PortMessageTooLong = 0x222,

        /// <summary>
        /// ERROR_INVALID_QUOTA_LOWER
        /// An attempt was made to lower a quota limit below the current usage.
        /// </summary>
        InvalidQuotaLower = 0x223,

        /// <summary>
        /// ERROR_DEVICE_ALREADY_ATTACHED
        /// An attempt was made to attach to a device that was already attached to another device.
        /// </summary>
        DeviceAlreadyAttached = 0x224,

        /// <summary>
        /// ERROR_INSTRUCTION_MISALIGNMENT
        /// An attempt was made to execute an instruction at an unaligned address and the host system does not support unaligned instruction references.
        /// </summary>
        InstructionMisalignment = 0x225,

        /// <summary>
        /// ERROR_PROFILING_NOT_STARTED
        /// Profiling not started.
        /// </summary>
        ProfilingNotStarted = 0x226,

        /// <summary>
        /// ERROR_PROFILING_NOT_STOPPED
        /// Profiling not stopped.
        /// </summary>
        ProfilingNotStopped = 0x227,

        /// <summary>
        /// ERROR_COULD_NOT_INTERPRET
        /// The passed ACL did not contain the minimum required information.
        /// </summary>
        CouldNotInterpret = 0x228,

        /// <summary>
        /// ERROR_PROFILING_AT_LIMIT
        /// The number of active profiling objects is at the maximum and no more may be started.
        /// </summary>
        ProfilingAtLimit = 0x229,

        /// <summary>
        /// ERROR_CANT_WAIT
        /// Used to indicate that an operation cannot continue without blocking for I/O.
        /// </summary>
        CantWait = 0x22A,

        /// <summary>
        /// ERROR_CANT_TERMINATE_SELF
        /// Indicates that a thread attempted to terminate itself by default (called NtTerminateThread with NULL) and it was the last thread in the current process.
        /// </summary>
        CantTerminateSelf = 0x22B,

        /// <summary>
        /// ERROR_UNEXPECTED_MM_CREATE_ERR
        /// If an MM error is returned which is not defined in the standard FsRtl filter, it is converted to one of the following errors which is guaranteed to be in the filter. In this case information is lost, however, the filter correctly handles the exception.
        /// </summary>
        UnexpectedMmCreateErr = 0x22C,

        /// <summary>
        /// ERROR_UNEXPECTED_MM_MAP_ERROR
        /// If an MM error is returned which is not defined in the standard FsRtl filter, it is converted to one of the following errors which is guaranteed to be in the filter. In this case information is lost, however, the filter correctly handles the exception.
        /// </summary>
        UnexpectedMmMapError = 0x22D,

        /// <summary>
        /// ERROR_UNEXPECTED_MM_EXTEND_ERR
        /// If an MM error is returned which is not defined in the standard FsRtl filter, it is converted to one of the following errors which is guaranteed to be in the filter. In this case information is lost, however, the filter correctly handles the exception.
        /// </summary>
        UnexpectedMmExtendErr = 0x22E,

        /// <summary>
        /// ERROR_BAD_FUNCTION_TABLE
        /// A malformed function table was encountered during an unwind operation.
        /// </summary>
        BadFunctionTable = 0x22F,

        /// <summary>
        /// ERROR_NO_GUID_TRANSLATION
        /// Indicates that an attempt was made to assign protection to a file system file or directory and one of the SIDs in the security descriptor could not be translated into a GUID that could be stored by the file system. This causes the protection attempt to fail, which may cause a file creation attempt to fail.
        /// </summary>
        NoGuidTranslation = 0x230,

        /// <summary>
        /// ERROR_INVALID_LDT_SIZE
        /// Indicates that an attempt was made to grow an LDT by setting its size, or that the size was not an even number of selectors.
        /// </summary>
        InvalidLdtSize = 0x231,

        /// <summary>
        /// ERROR_INVALID_LDT_OFFSET
        /// Indicates that the starting value for the LDT information was not an integral multiple of the selector size.
        /// </summary>
        InvalidLdtOffset = 0x233,

        /// <summary>
        /// ERROR_INVALID_LDT_DESCRIPTOR
        /// Indicates that the user supplied an invalid descriptor when trying to set up Ldt descriptors.
        /// </summary>
        InvalidLdtDescriptor = 0x234,

        /// <summary>
        /// ERROR_TOO_MANY_THREADS
        /// Indicates a process has too many threads to perform the requested action. For example, assignment of a primary token may only be performed when a process has zero or one threads.
        /// </summary>
        TooManyThreads = 0x235,

        /// <summary>
        /// ERROR_THREAD_NOT_IN_PROCESS
        /// An attempt was made to operate on a thread within a specific process, but the thread specified is not in the process specified.
        /// </summary>
        ThreadNotInProcess = 0x236,

        /// <summary>
        /// ERROR_PAGEFILE_QUOTA_EXCEEDED
        /// Page file quota was exceeded.
        /// </summary>
        PagefileQuotaExceeded = 0x237,

        /// <summary>
        /// ERROR_LOGON_SERVER_CONFLICT
        /// The Netlogon service cannot start because another Netlogon service running in the domain conflicts with the specified role.
        /// </summary>
        LogonServerConflict = 0x238,

        /// <summary>
        /// ERROR_SYNCHRONIZATION_REQUIRED
        /// The SAM database on a Windows Server is significantly out of synchronization with the copy on the Domain Controller. A complete synchronization is required.
        /// </summary>
        SynchronizationRequired = 0x239,

        /// <summary>
        /// ERROR_NET_OPEN_FAILED
        /// The NtCreateFile API failed. This error should never be returned to an application, it is a place holder for the Windows Lan Manager Redirector to use in its internal error mapping routines.
        /// </summary>
        NetOpenFailed = 0x23A,

        /// <summary>
        /// ERROR_IO_PRIVILEGE_FAILED
        /// {Privilege Failed} The I/O permissions for the process could not be changed.
        /// </summary>
        IoPrivilegeFailed = 0x23B,

        /// <summary>
        /// ERROR_CONTROL_C_EXIT
        /// {Application Exit by CTRL+C} The application terminated as a result of a CTRL+C.
        /// </summary>
        ControlCExit = 0x23C,

        /// <summary>
        /// ERROR_MISSING_SYSTEMFILE
        /// {Missing System File} The required system file %hs is bad or missing.
        /// </summary>
        MissingSystemfile = 0x23D,

        /// <summary>
        /// ERROR_UNHANDLED_EXCEPTION
        /// {Application Error} The exception %s (0x%08lx) occurred in the application at location 0x%08lx.
        /// </summary>
        UnhandledException = 0x23E,

        /// <summary>
        /// ERROR_APP_INIT_FAILURE
        /// {Application Error} The application was unable to start correctly (0x%lx). Click OK to close the application.
        /// </summary>
        AppInitFailure = 0x23F,

        /// <summary>
        /// ERROR_PAGEFILE_CREATE_FAILED
        /// {Unable to Create Paging File} The creation of the paging file %hs failed (%lx). The requested size was %ld.
        /// </summary>
        PagefileCreateFailed = 0x240,

        /// <summary>
        /// ERROR_INVALID_IMAGE_HASH
        /// Windows cannot verify the digital signature for this file. A recent hardware or software change might have installed a file that is signed incorrectly or damaged, or that might be malicious software from an unknown source.
        /// </summary>
        InvalidImageHash = 0x241,

        /// <summary>
        /// ERROR_NO_PAGEFILE
        /// {No Paging File Specified} No paging file was specified in the system configuration.
        /// </summary>
        NoPagefile = 0x242,

        /// <summary>
        /// ERROR_ILLEGAL_FLOAT_CONTEXT
        /// {EXCEPTION} A real-mode application issued a floating-point instruction and floating-point hardware is not present.
        /// </summary>
        IllegalFloatContext = 0x243,

        /// <summary>
        /// ERROR_NO_EVENT_PAIR
        /// An event pair synchronization operation was performed using the thread specific client/server event pair object, but no event pair object was associated with the thread.
        /// </summary>
        NoEventPair = 0x244,

        /// <summary>
        /// ERROR_DOMAIN_CTRLR_CONFIG_ERROR
        /// A Windows Server has an incorrect configuration.
        /// </summary>
        DomainCtrlrConfigError = 0x245,

        /// <summary>
        /// ERROR_ILLEGAL_CHARACTER
        /// An illegal character was encountered. For a multi-byte character set this includes a lead byte without a succeeding trail byte. For the Unicode character set this includes the characters 0xFFFF and 0xFFFE.
        /// </summary>
        IllegalCharacter = 0x246,

        /// <summary>
        /// ERROR_UNDEFINED_CHARACTER
        /// The Unicode character is not defined in the Unicode character set installed on the system.
        /// </summary>
        UndefinedCharacter = 0x247,

        /// <summary>
        /// ERROR_FLOPPY_VOLUME
        /// The paging file cannot be created on a floppy diskette.
        /// </summary>
        FloppyVolume = 0x248,

        /// <summary>
        /// ERROR_BIOS_FAILED_TO_CONNECT_INTERRUPT
        /// The system BIOS failed to connect a system interrupt to the device or bus for which the device is connected.
        /// </summary>
        BiosFailedToConnectInterrupt = 0x249,

        /// <summary>
        /// ERROR_BACKUP_CONTROLLER
        /// This operation is only allowed for the Primary Domain Controller of the domain.
        /// </summary>
        BackupController = 0x24A,

        /// <summary>
        /// ERROR_MUTANT_LIMIT_EXCEEDED
        /// An attempt was made to acquire a mutant such that its maximum count would have been exceeded.
        /// </summary>
        MutantLimitExceeded = 0x24B,

        /// <summary>
        /// ERROR_FS_DRIVER_REQUIRED
        /// A volume has been accessed for which a file system driver is required that has not yet been loaded.
        /// </summary>
        FsDriverRequired = 0x24C,

        /// <summary>
        /// ERROR_CANNOT_LOAD_REGISTRY_FILE
        /// {Registry File Failure} The registry cannot load the hive (file): %hs or its log or alternate. It is corrupt, absent, or not writable.
        /// </summary>
        CannotLoadRegistryFile = 0x24D,

        /// <summary>
        /// ERROR_DEBUG_ATTACH_FAILED
        /// {Unexpected Failure in DebugActiveProcess} An unexpected failure occurred while processing a DebugActiveProcess API request. You may choose OK to terminate the process, or Cancel to ignore the error.
        /// </summary>
        DebugAttachFailed = 0x24E,

        /// <summary>
        /// ERROR_SYSTEM_PROCESS_TERMINATED
        /// {Fatal System Error} The %hs system process terminated unexpectedly with a status of 0x%08x (0x%08x 0x%08x). The system has been shut down.
        /// </summary>
        SystemProcessTerminated = 0x24F,

        /// <summary>
        /// ERROR_DATA_NOT_ACCEPTED
        /// {Data Not Accepted} The TDI client could not handle the data received during an indication.
        /// </summary>
        DataNotAccepted = 0x250,

        /// <summary>
        /// ERROR_VDM_HARD_ERROR
        /// NTVDM encountered a hard error.
        /// </summary>
        VdmHardError = 0x251,

        /// <summary>
        /// ERROR_DRIVER_CANCEL_TIMEOUT
        /// {Cancel Timeout} The driver %hs failed to complete a cancelled I/O request in the allotted time.
        /// </summary>
        DriverCancelTimeout = 0x252,

        /// <summary>
        /// ERROR_REPLY_MESSAGE_MISMATCH
        /// {Reply Message Mismatch} An attempt was made to reply to an LPC message, but the thread specified by the client ID in the message was not waiting on that message.
        /// </summary>
        ReplyMessageMismatch = 0x253,

        /// <summary>
        /// ERROR_LOST_WRITEBEHIND_DATA
        /// {Delayed Write Failed} Windows was unable to save all the data for the file %hs. The data has been lost. This error may be caused by a failure of your computer hardware or network connection. Please try to save this file elsewhere.
        /// </summary>
        LostWritebehindData = 0x254,

        /// <summary>
        /// ERROR_CLIENT_SERVER_PARAMETERS_INVALID
        /// The parameter(s) passed to the server in the client/server shared memory window were invalid. Too much data may have been put in the shared memory window.
        /// </summary>
        ClientServerParametersInvalid = 0x255,

        /// <summary>
        /// ERROR_NOT_TINY_STREAM
        /// The stream is not a tiny stream.
        /// </summary>
        NotTinyStream = 0x256,

        /// <summary>
        /// ERROR_STACK_OVERFLOW_READ
        /// The request must be handled by the stack overflow code.
        /// </summary>
        StackOverflowRead = 0x257,

        /// <summary>
        /// ERROR_CONVERT_TO_LARGE
        /// Internal OFS status codes indicating how an allocation operation is handled. Either it is retried after the containing onode is moved or the extent stream is converted to a large stream.
        /// </summary>
        ConvertToLarge = 0x258,

        /// <summary>
        /// ERROR_FOUND_OUT_OF_SCOPE
        /// The attempt to find the object found an object matching by ID on the volume but it is out of the scope of the handle used for the operation.
        /// </summary>
        FoundOutOfScope = 0x259,

        /// <summary>
        /// ERROR_ALLOCATE_BUCKET
        /// The bucket array must be grown. Retry transaction after doing so.
        /// </summary>
        AllocateBucket = 0x25A,

        /// <summary>
        /// ERROR_MARSHALL_OVERFLOW
        /// The user/kernel marshalling buffer has overflowed.
        /// </summary>
        MarshallOverflow = 0x25B,

        /// <summary>
        /// ERROR_INVALID_VARIANT
        /// The supplied variant structure contains invalid data.
        /// </summary>
        InvalidVariant = 0x25C,

        /// <summary>
        /// ERROR_BAD_COMPRESSION_BUFFER
        /// The specified buffer contains ill-formed data.
        /// </summary>
        BadCompressionBuffer = 0x25D,

        /// <summary>
        /// ERROR_AUDIT_FAILED
        /// {Audit Failed} An attempt to generate a security audit failed.
        /// </summary>
        AuditFailed = 0x25E,

        /// <summary>
        /// ERROR_TIMER_RESOLUTION_NOT_SET
        /// The timer resolution was not previously set by the current process.
        /// </summary>
        TimerResolutionNotSet = 0x25F,

        /// <summary>
        /// ERROR_INSUFFICIENT_LOGON_INFO
        /// There is insufficient account information to log you on.
        /// </summary>
        InsufficientLogonInfo = 0x260,

        /// <summary>
        /// ERROR_BAD_DLL_ENTRYPOINT
        /// {Invalid DLL Entrypoint} The dynamic link library %hs is not written correctly. The stack pointer has been left in an inconsistent state. The entrypoint should be declared as WINAPI or STDCALL. Select YES to fail the DLL load. Select NO to continue execution. Selecting NO may cause the application to operate incorrectly.
        /// </summary>
        BadDllEntrypoint = 0x261,

        /// <summary>
        /// ERROR_BAD_SERVICE_ENTRYPOINT
        /// {Invalid Service Callback Entrypoint} The %hs service is not written correctly. The stack pointer has been left in an inconsistent state. The callback entrypoint should be declared as WINAPI or STDCALL. Selecting OK will cause the service to continue operation. However, the service process may operate incorrectly.
        /// </summary>
        BadServiceEntrypoint = 0x262,

        /// <summary>
        /// ERROR_IP_ADDRESS_CONFLICT1
        /// There is an IP address conflict with another system on the network.
        /// </summary>
        IpAddressConflict1 = 0x263,

        /// <summary>
        /// ERROR_IP_ADDRESS_CONFLICT2
        /// There is an IP address conflict with another system on the network.
        /// </summary>
        IpAddressConflict2 = 0x264,

        /// <summary>
        /// ERROR_REGISTRY_QUOTA_LIMIT
        /// {Low On Registry Space} The system has reached the maximum size allowed for the system part of the registry. Additional storage requests will be ignored.
        /// </summary>
        RegistryQuotaLimit = 0x265,

        /// <summary>
        /// ERROR_NO_CALLBACK_ACTIVE
        /// A callback return system service cannot be executed when no callback is active.
        /// </summary>
        NoCallbackActive = 0x266,

        /// <summary>
        /// ERROR_PWD_TOO_SHORT
        /// The password provided is too short to meet the policy of your user account. Please choose a longer password.
        /// </summary>
        PwdTooShort = 0x267,

        /// <summary>
        /// ERROR_PWD_TOO_RECENT
        /// The policy of your user account does not allow you to change passwords too frequently. This is done to prevent users from changing back to a familiar, but potentially discovered, password. If you feel your password has been compromised then please contact your administrator immediately to have a new one assigned.
        /// </summary>
        PwdTooRecent = 0x268,

        /// <summary>
        /// ERROR_PWD_HISTORY_CONFLICT
        /// You have attempted to change your password to one that you have used in the past. The policy of your user account does not allow this. Please select a password that you have not previously used.
        /// </summary>
        PwdHistoryConflict = 0x269,

        /// <summary>
        /// ERROR_UNSUPPORTED_COMPRESSION
        /// The specified compression format is unsupported.
        /// </summary>
        UnsupportedCompression = 0x26A,

        /// <summary>
        /// ERROR_INVALID_HW_PROFILE
        /// The specified hardware profile configuration is invalid.
        /// </summary>
        InvalidHwProfile = 0x26B,

        /// <summary>
        /// ERROR_INVALID_PLUGPLAY_DEVICE_PATH
        /// The specified Plug and Play registry device path is invalid.
        /// </summary>
        InvalidPlugplayDevicePath = 0x26C,

        /// <summary>
        /// ERROR_QUOTA_LIST_INCONSISTENT
        /// The specified quota list is internally inconsistent with its descriptor.
        /// </summary>
        QuotaListInconsistent = 0x26D,

        /// <summary>
        /// ERROR_EVALUATION_EXPIRATION
        /// {Windows Evaluation Notification} The evaluation period for this installation of Windows has expired. This system will shutdown in 1 hour. To restore access to this installation of Windows, please upgrade this installation using a licensed distribution of this product.
        /// </summary>
        EvaluationExpiration = 0x26E,

        /// <summary>
        /// ERROR_ILLEGAL_DLL_RELOCATION
        /// {Illegal System DLL Relocation} The system DLL %hs was relocated in memory. The application will not run properly. The relocation occurred because the DLL %hs occupied an address range reserved for Windows system DLLs. The vendor supplying the DLL should be contacted for a new DLL.
        /// </summary>
        IllegalDllRelocation = 0x26F,

        /// <summary>
        /// ERROR_DLL_INIT_FAILED_LOGOFF
        /// {DLL Initialization Failed} The application failed to initialize because the window station is shutting down.
        /// </summary>
        DllInitFailedLogoff = 0x270,

        /// <summary>
        /// ERROR_VALIDATE_CONTINUE
        /// The validation process needs to continue on to the next step.
        /// </summary>
        ValidateContinue = 0x271,

        /// <summary>
        /// ERROR_NO_MORE_MATCHES
        /// There are no more matches for the current index enumeration.
        /// </summary>
        NoMoreMatches = 0x272,

        /// <summary>
        /// ERROR_RANGE_LIST_CONFLICT
        /// The range could not be added to the range list because of a conflict.
        /// </summary>
        RangeListConflict = 0x273,

        /// <summary>
        /// ERROR_SERVER_SID_MISMATCH
        /// The server process is running under a SID different than that required by client.
        /// </summary>
        ServerSidMismatch = 0x274,

        /// <summary>
        /// ERROR_CANT_ENABLE_DENY_ONLY
        /// A group marked use for deny only cannot be enabled.
        /// </summary>
        CantEnableDenyOnly = 0x275,

        /// <summary>
        /// ERROR_FLOAT_MULTIPLE_FAULTS
        /// {EXCEPTION} Multiple floating point faults.
        /// </summary>
        FloatMultipleFaults = 0x276,

        /// <summary>
        /// ERROR_FLOAT_MULTIPLE_TRAPS
        /// {EXCEPTION} Multiple floating point traps.
        /// </summary>
        FloatMultipleTraps = 0x277,

        /// <summary>
        /// ERROR_NOINTERFACE
        /// The requested interface is not supported.
        /// </summary>
        Nointerface = 0x278,

        /// <summary>
        /// ERROR_DRIVER_FAILED_SLEEP
        /// {System Standby Failed} The driver %hs does not support standby mode. Updating this driver may allow the system to go to standby mode.
        /// </summary>
        DriverFailedSleep = 0x279,

        /// <summary>
        /// ERROR_CORRUPT_SYSTEM_FILE
        /// The system file %1 has become corrupt and has been replaced.
        /// </summary>
        CorruptSystemFile = 0x27A,

        /// <summary>
        /// ERROR_COMMITMENT_MINIMUM
        /// {Virtual Memory Minimum Too Low} Your system is low on virtual memory. Windows is increasing the size of your virtual memory paging file. During this process, memory requests for some applications may be denied. For more information, see Help.
        /// </summary>
        CommitmentMinimum = 0x27B,

        /// <summary>
        /// ERROR_PNP_RESTART_ENUMERATION
        /// A device was removed so enumeration must be restarted.
        /// </summary>
        PnpRestartEnumeration = 0x27C,

        /// <summary>
        /// ERROR_SYSTEM_IMAGE_BAD_SIGNATURE
        /// {Fatal System Error} The system image %s is not properly signed. The file has been replaced with the signed file. The system has been shut down.
        /// </summary>
        SystemImageBadSignature = 0x27D,

        /// <summary>
        /// ERROR_PNP_REBOOT_REQUIRED
        /// Device will not start without a reboot.
        /// </summary>
        PnpRebootRequired = 0x27E,

        /// <summary>
        /// ERROR_INSUFFICIENT_POWER
        /// There is not enough power to complete the requested operation.
        /// </summary>
        InsufficientPower = 0x27F,

        /// <summary>
        /// ERROR_MULTIPLE_FAULT_VIOLATION
        /// ERROR_MULTIPLE_FAULT_VIOLATION
        /// </summary>
        MultipleFaultViolation = 0x280,

        /// <summary>
        /// ERROR_SYSTEM_SHUTDOWN
        /// The system is in the process of shutting down.
        /// </summary>
        SystemShutdown = 0x281,

        /// <summary>
        /// ERROR_PORT_NOT_SET
        /// An attempt to remove a processes DebugPort was made, but a port was not already associated with the process.
        /// </summary>
        PortNotSet = 0x282,

        /// <summary>
        /// ERROR_DS_VERSION_CHECK_FAILURE
        /// This version of Windows is not compatible with the behavior version of directory forest, domain or domain controller.
        /// </summary>
        DsVersionCheckFailure = 0x283,

        /// <summary>
        /// ERROR_RANGE_NOT_FOUND
        /// The specified range could not be found in the range list.
        /// </summary>
        RangeNotFound = 0x284,

        /// <summary>
        /// ERROR_NOT_SAFE_MODE_DRIVER
        /// The driver was not loaded because the system is booting into safe mode.
        /// </summary>
        NotSafeModeDriver = 0x286,

        /// <summary>
        /// ERROR_FAILED_DRIVER_ENTRY
        /// The driver was not loaded because it failed its initialization call.
        /// </summary>
        FailedDriverEntry = 0x287,

        /// <summary>
        /// ERROR_DEVICE_ENUMERATION_ERROR
        /// The "%hs" encountered an error while applying power or reading the device configuration. This may be caused by a failure of your hardware or by a poor connection.
        /// </summary>
        DeviceEnumerationError = 0x288,

        /// <summary>
        /// ERROR_MOUNT_POINT_NOT_RESOLVED
        /// The create operation failed because the name contained at least one mount point which resolves to a volume to which the specified device object is not attached.
        /// </summary>
        MountPointNotResolved = 0x289,

        /// <summary>
        /// ERROR_INVALID_DEVICE_OBJECT_PARAMETER
        /// The device object parameter is either not a valid device object or is not attached to the volume specified by the file name.
        /// </summary>
        InvalidDeviceObjectParameter = 0x28A,

        /// <summary>
        /// ERROR_MCA_OCCURED
        /// A Machine Check Error has occurred. Please check the system eventlog for additional information.
        /// </summary>
        McaOccured = 0x28B,

        /// <summary>
        /// ERROR_DRIVER_DATABASE_ERROR
        /// There was error [%2] processing the driver database.
        /// </summary>
        DriverDatabaseError = 0x28C,

        /// <summary>
        /// ERROR_SYSTEM_HIVE_TOO_LARGE
        /// System hive size has exceeded its limit.
        /// </summary>
        SystemHiveTooLarge = 0x28D,

        /// <summary>
        /// ERROR_DRIVER_FAILED_PRIOR_UNLOAD
        /// The driver could not be loaded because a previous version of the driver is still in memory.
        /// </summary>
        DriverFailedPriorUnload = 0x28E,

        /// <summary>
        /// ERROR_VOLSNAP_PREPARE_HIBERNATE
        /// {Volume Shadow Copy Service} Please wait while the Volume Shadow Copy Service prepares volume %hs for hibernation.
        /// </summary>
        VolsnapPrepareHibernate = 0x28F,

        /// <summary>
        /// ERROR_HIBERNATION_FAILURE
        /// The system has failed to hibernate (The error code is %hs). Hibernation will be disabled until the system is restarted.
        /// </summary>
        HibernationFailure = 0x290,

        /// <summary>
        /// ERROR_PWD_TOO_LONG
        /// The password provided is too long to meet the policy of your user account. Please choose a shorter password.
        /// </summary>
        PwdTooLong = 0x291,

        /// <summary>
        /// ERROR_FILE_SYSTEM_LIMITATION
        /// The requested operation could not be completed due to a file system limitation.
        /// </summary>
        FileSystemLimitation = 0x299,

        /// <summary>
        /// ERROR_ASSERTION_FAILURE
        /// An assertion failure has occurred.
        /// </summary>
        AssertionFailure = 0x29C,

        /// <summary>
        /// ERROR_ACPI_ERROR
        /// An error occurred in the ACPI subsystem.
        /// </summary>
        AcpiError = 0x29D,

        /// <summary>
        /// ERROR_WOW_ASSERTION
        /// WOW Assertion Error.
        /// </summary>
        WowAssertion = 0x29E,

        /// <summary>
        /// ERROR_PNP_BAD_MPS_TABLE
        /// A device is missing in the system BIOS MPS table. This device will not be used. Please contact your system vendor for system BIOS update.
        /// </summary>
        PnpBadMpsTable = 0x29F,

        /// <summary>
        /// ERROR_PNP_TRANSLATION_FAILED
        /// A translator failed to translate resources.
        /// </summary>
        PnpTranslationFailed = 0x2A0,

        /// <summary>
        /// ERROR_PNP_IRQ_TRANSLATION_FAILED
        /// A IRQ translator failed to translate resources.
        /// </summary>
        PnpIrqTranslationFailed = 0x2A1,

        /// <summary>
        /// ERROR_PNP_INVALID_ID
        /// Driver %2 returned invalid ID for a child device (%3).
        /// </summary>
        PnpInvalidId = 0x2A2,

        /// <summary>
        /// ERROR_WAKE_SYSTEM_DEBUGGER
        /// {Kernel Debugger Awakened} the system debugger was awakened by an interrupt.
        /// </summary>
        WakeSystemDebugger = 0x2A3,

        /// <summary>
        /// ERROR_HANDLES_CLOSED
        /// {Handles Closed} Handles to objects have been automatically closed as a result of the requested operation.
        /// </summary>
        HandlesClosed = 0x2A4,

        /// <summary>
        /// ERROR_EXTRANEOUS_INFORMATION
        /// {Too Much Information} The specified access control list (ACL) contained more information than was expected.
        /// </summary>
        ExtraneousInformation = 0x2A5,

        /// <summary>
        /// ERROR_RXACT_COMMIT_NECESSARY
        /// This warning level status indicates that the transaction state already exists for the registry sub-tree, but that a transaction commit was previously aborted. The commit has NOT been completed, but has not been rolled back either (so it may still be committed if desired).
        /// </summary>
        RxactCommitNecessary = 0x2A6,

        /// <summary>
        /// ERROR_MEDIA_CHECK
        /// {Media Changed} The media may have changed.
        /// </summary>
        MediaCheck = 0x2A7,

        /// <summary>
        /// ERROR_GUID_SUBSTITUTION_MADE
        /// {GUID Substitution} During the translation of a global identifier (GUID) to a Windows security ID (SID), no administratively-defined GUID prefix was found. A substitute prefix was used, which will not compromise system security. However, this may provide a more restrictive access than intended.
        /// </summary>
        GuidSubstitutionMade = 0x2A8,

        /// <summary>
        /// ERROR_STOPPED_ON_SYMLINK
        /// The create operation stopped after reaching a symbolic link.
        /// </summary>
        StoppedOnSymlink = 0x2A9,

        /// <summary>
        /// ERROR_LONGJUMP
        /// A long jump has been executed.
        /// </summary>
        Longjump = 0x2AA,

        /// <summary>
        /// ERROR_PLUGPLAY_QUERY_VETOED
        /// The Plug and Play query operation was not successful.
        /// </summary>
        PlugplayQueryVetoed = 0x2AB,

        /// <summary>
        /// ERROR_UNWIND_CONSOLIDATE
        /// A frame consolidation has been executed.
        /// </summary>
        UnwindConsolidate = 0x2AC,

        /// <summary>
        /// ERROR_REGISTRY_HIVE_RECOVERED
        /// {Registry Hive Recovered} Registry hive (file): %hs was corrupted and it has been recovered. Some data might have been lost.
        /// </summary>
        RegistryHiveRecovered = 0x2AD,

        /// <summary>
        /// ERROR_DLL_MIGHT_BE_INSECURE
        /// The application is attempting to run executable code from the module %hs. This may be insecure. An alternative, %hs, is available. Should the application use the secure module %hs?
        /// </summary>
        DllMightBeInsecure = 0x2AE,

        /// <summary>
        /// ERROR_DLL_MIGHT_BE_INCOMPATIBLE
        /// The application is loading executable code from the module %hs. This is secure, but may be incompatible with previous releases of the operating system. An alternative, %hs, is available. Should the application use the secure module %hs?
        /// </summary>
        DllMightBeIncompatible = 0x2AF,

        /// <summary>
        /// ERROR_DBG_EXCEPTION_NOT_HANDLED
        /// Debugger did not handle the exception.
        /// </summary>
        DbgExceptionNotHandled = 0x2B0,

        /// <summary>
        /// ERROR_DBG_REPLY_LATER
        /// Debugger will reply later.
        /// </summary>
        DbgReplyLater = 0x2B1,

        /// <summary>
        /// ERROR_DBG_UNABLE_TO_PROVIDE_HANDLE
        /// Debugger cannot provide handle.
        /// </summary>
        DbgUnableToProvideHandle = 0x2B2,

        /// <summary>
        /// ERROR_DBG_TERMINATE_THREAD
        /// Debugger terminated thread.
        /// </summary>
        DbgTerminateThread = 0x2B3,

        /// <summary>
        /// ERROR_DBG_TERMINATE_PROCESS
        /// Debugger terminated process.
        /// </summary>
        DbgTerminateProcess = 0x2B4,

        /// <summary>
        /// ERROR_DBG_CONTROL_C
        /// Debugger got control C.
        /// </summary>
        DbgControlC = 0x2B5,

        /// <summary>
        /// ERROR_DBG_PRINTEXCEPTION_C
        /// Debugger printed exception on control C.
        /// </summary>
        DbgPrintexceptionC = 0x2B6,

        /// <summary>
        /// ERROR_DBG_RIPEXCEPTION
        /// Debugger received RIP exception.
        /// </summary>
        DbgRipexception = 0x2B7,

        /// <summary>
        /// ERROR_DBG_CONTROL_BREAK
        /// Debugger received control break.
        /// </summary>
        DbgControlBreak = 0x2B8,

        /// <summary>
        /// ERROR_DBG_COMMAND_EXCEPTION
        /// Debugger command communication exception.
        /// </summary>
        DbgCommandException = 0x2B9,

        /// <summary>
        /// ERROR_OBJECT_NAME_EXISTS
        /// {Object Exists} An attempt was made to create an object and the object name already existed.
        /// </summary>
        ObjectNameExists = 0x2BA,

        /// <summary>
        /// ERROR_THREAD_WAS_SUSPENDED
        /// {Thread Suspended} A thread termination occurred while the thread was suspended. The thread was resumed, and termination proceeded.
        /// </summary>
        ThreadWasSuspended = 0x2BB,

        /// <summary>
        /// ERROR_IMAGE_NOT_AT_BASE
        /// {Image Relocated} An image file could not be mapped at the address specified in the image file. Local fixups must be performed on this image.
        /// </summary>
        ImageNotAtBase = 0x2BC,

        /// <summary>
        /// ERROR_RXACT_STATE_CREATED
        /// This informational level status indicates that a specified registry sub-tree transaction state did not yet exist and had to be created.
        /// </summary>
        RxactStateCreated = 0x2BD,

        /// <summary>
        /// ERROR_SEGMENT_NOTIFICATION
        /// {Segment Load} A virtual DOS machine (VDM) is loading, unloading, or moving an MS-DOS or Win16 program segment image. An exception is raised so a debugger can load, unload or track symbols and breakpoints within these 16-bit segments.
        /// </summary>
        SegmentNotification = 0x2BE,

        /// <summary>
        /// ERROR_BAD_CURRENT_DIRECTORY
        /// {Invalid Current Directory} The process cannot switch to the startup current directory %hs. Select OK to set current directory to %hs, or select CANCEL to exit.
        /// </summary>
        BadCurrentDirectory = 0x2BF,

        /// <summary>
        /// ERROR_FT_READ_RECOVERY_FROM_BACKUP
        /// {Redundant Read} To satisfy a read request, the NT fault-tolerant file system successfully read the requested data from a redundant copy. This was done because the file system encountered a failure on a member of the fault-tolerant volume, but was unable to reassign the failing area of the device.
        /// </summary>
        FtReadRecoveryFromBackup = 0x2C0,

        /// <summary>
        /// ERROR_FT_WRITE_RECOVERY
        /// {Redundant Write} To satisfy a write request, the NT fault-tolerant file system successfully wrote a redundant copy of the information. This was done because the file system encountered a failure on a member of the fault-tolerant volume, but was not able to reassign the failing area of the device.
        /// </summary>
        FtWriteRecovery = 0x2C1,

        /// <summary>
        /// ERROR_IMAGE_MACHINE_TYPE_MISMATCH
        /// {Machine Type Mismatch} The image file %hs is valid, but is for a machine type other than the current machine. Select OK to continue, or CANCEL to fail the DLL load.
        /// </summary>
        ImageMachineTypeMismatch = 0x2C2,

        /// <summary>
        /// ERROR_RECEIVE_PARTIAL
        /// {Partial Data Received} The network transport returned partial data to its client. The remaining data will be sent later.
        /// </summary>
        ReceivePartial = 0x2C3,

        /// <summary>
        /// ERROR_RECEIVE_EXPEDITED
        /// {Expedited Data Received} The network transport returned data to its client that was marked as expedited by the remote system.
        /// </summary>
        ReceiveExpedited = 0x2C4,

        /// <summary>
        /// ERROR_RECEIVE_PARTIAL_EXPEDITED
        /// {Partial Expedited Data Received} The network transport returned partial data to its client and this data was marked as expedited by the remote system. The remaining data will be sent later.
        /// </summary>
        ReceivePartialExpedited = 0x2C5,

        /// <summary>
        /// ERROR_EVENT_DONE
        /// {TDI Event Done} The TDI indication has completed successfully.
        /// </summary>
        EventDone = 0x2C6,

        /// <summary>
        /// ERROR_EVENT_PENDING
        /// {TDI Event Pending} The TDI indication has entered the pending state.
        /// </summary>
        EventPending = 0x2C7,

        /// <summary>
        /// ERROR_CHECKING_FILE_SYSTEM
        /// Checking file system on %wZ.
        /// </summary>
        CheckingFileSystem = 0x2C8,

        /// <summary>
        /// ERROR_FATAL_APP_EXIT
        /// {Fatal Application Exit} %hs.
        /// </summary>
        FatalAppExit = 0x2C9,

        /// <summary>
        /// ERROR_PREDEFINED_HANDLE
        /// The specified registry key is referenced by a predefined handle.
        /// </summary>
        PredefinedHandle = 0x2CA,

        /// <summary>
        /// ERROR_WAS_UNLOCKED
        /// {Page Unlocked} The page protection of a locked page was changed to 'No Access' and the page was unlocked from memory and from the process.
        /// </summary>
        WasUnlocked = 0x2CB,

        /// <summary>
        /// ERROR_SERVICE_NOTIFICATION
        /// %hs
        /// </summary>
        ServiceNotification = 0x2CC,

        /// <summary>
        /// ERROR_WAS_LOCKED
        /// {Page Locked} One of the pages to lock was already locked.
        /// </summary>
        WasLocked = 0x2CD,

        /// <summary>
        /// ERROR_LOG_HARD_ERROR
        /// Application popup: %1 : %2
        /// </summary>
        LogHardError = 0x2CE,

        /// <summary>
        /// ERROR_ALREADY_WIN32
        /// ERROR_ALREADY_WIN32
        /// </summary>
        AlreadyWin32 = 0x2CF,

        /// <summary>
        /// ERROR_IMAGE_MACHINE_TYPE_MISMATCH_EXE
        /// {Machine Type Mismatch} The image file %hs is valid, but is for a machine type other than the current machine.
        /// </summary>
        ImageMachineTypeMismatchExe = 0x2D0,

        /// <summary>
        /// ERROR_NO_YIELD_PERFORMED
        /// A yield execution was performed and no thread was available to run.
        /// </summary>
        NoYieldPerformed = 0x2D1,

        /// <summary>
        /// ERROR_TIMER_RESUME_IGNORED
        /// The resumable flag to a timer API was ignored.
        /// </summary>
        TimerResumeIgnored = 0x2D2,

        /// <summary>
        /// ERROR_ARBITRATION_UNHANDLED
        /// The arbiter has deferred arbitration of these resources to its parent.
        /// </summary>
        ArbitrationUnhandled = 0x2D3,

        /// <summary>
        /// ERROR_CARDBUS_NOT_SUPPORTED
        /// The inserted CardBus device cannot be started because of a configuration error on "%hs".
        /// </summary>
        CardbusNotSupported = 0x2D4,

        /// <summary>
        /// ERROR_MP_PROCESSOR_MISMATCH
        /// The CPUs in this multiprocessor system are not all the same revision level. To use all processors the operating system restricts itself to the features of the least capable processor in the system. Should problems occur with this system, contact the CPU manufacturer to see if this mix of processors is supported.
        /// </summary>
        MpProcessorMismatch = 0x2D5,

        /// <summary>
        /// ERROR_HIBERNATED
        /// The system was put into hibernation.
        /// </summary>
        Hibernated = 0x2D6,

        /// <summary>
        /// ERROR_RESUME_HIBERNATION
        /// The system was resumed from hibernation.
        /// </summary>
        ResumeHibernation = 0x2D7,

        /// <summary>
        /// ERROR_FIRMWARE_UPDATED
        /// Windows has detected that the system firmware (BIOS) was updated [previous firmware date = %2, current firmware date %3].
        /// </summary>
        FirmwareUpdated = 0x2D8,

        /// <summary>
        /// ERROR_DRIVERS_LEAKING_LOCKED_PAGES
        /// A device driver is leaking locked I/O pages causing system degradation. The system has automatically enabled tracking code in order to try and catch the culprit.
        /// </summary>
        DriversLeakingLockedPages = 0x2D9,

        /// <summary>
        /// ERROR_WAKE_SYSTEM
        /// The system has awoken.
        /// </summary>
        WakeSystem = 0x2DA,

        /// <summary>
        /// ERROR_WAIT_1
        /// ERROR_WAIT_1
        /// </summary>
        Wait1 = 0x2DB,

        /// <summary>
        /// ERROR_WAIT_2
        /// ERROR_WAIT_2
        /// </summary>
        Wait2 = 0x2DC,

        /// <summary>
        /// ERROR_WAIT_3
        /// ERROR_WAIT_3
        /// </summary>
        Wait3 = 0x2DD,

        /// <summary>
        /// ERROR_WAIT_63
        /// ERROR_WAIT_63
        /// </summary>
        Wait63 = 0x2DE,

        /// <summary>
        /// ERROR_ABANDONED_WAIT_0
        /// ERROR_ABANDONED_WAIT_0
        /// </summary>
        AbandonedWait0 = 0x2DF,

        /// <summary>
        /// ERROR_ABANDONED_WAIT_63
        /// ERROR_ABANDONED_WAIT_63
        /// </summary>
        AbandonedWait63 = 0x2E0,

        /// <summary>
        /// ERROR_USER_APC
        /// ERROR_USER_APC
        /// </summary>
        UserApc = 0x2E1,

        /// <summary>
        /// ERROR_KERNEL_APC
        /// ERROR_KERNEL_APC
        /// </summary>
        KernelApc = 0x2E2,

        /// <summary>
        /// ERROR_ALERTED
        /// ERROR_ALERTED
        /// </summary>
        Alerted = 0x2E3,

        /// <summary>
        /// ERROR_ELEVATION_REQUIRED
        /// The requested operation requires elevation.
        /// </summary>
        ElevationRequired = 0x2E4,

        /// <summary>
        /// ERROR_REPARSE
        /// A reparse should be performed by the Object Manager since the name of the file resulted in a symbolic link.
        /// </summary>
        Reparse = 0x2E5,

        /// <summary>
        /// ERROR_OPLOCK_BREAK_IN_PROGRESS
        /// An open/create operation completed while an oplock break is underway.
        /// </summary>
        OplockBreakInProgress = 0x2E6,

        /// <summary>
        /// ERROR_VOLUME_MOUNTED
        /// A new volume has been mounted by a file system.
        /// </summary>
        VolumeMounted = 0x2E7,

        /// <summary>
        /// ERROR_RXACT_COMMITTED
        /// This success level status indicates that the transaction state already exists for the registry sub-tree, but that a transaction commit was previously aborted. The commit has now been completed.
        /// </summary>
        RxactCommitted = 0x2E8,

        /// <summary>
        /// ERROR_NOTIFY_CLEANUP
        /// This indicates that a notify change request has been completed due to closing the handle which made the notify change request.
        /// </summary>
        NotifyCleanup = 0x2E9,

        /// <summary>
        /// ERROR_PRIMARY_TRANSPORT_CONNECT_FAILED
        /// {Connect Failure on Primary Transport} An attempt was made to connect to the remote server %hs on the primary transport, but the connection failed. The computer WAS able to connect on a secondary transport.
        /// </summary>
        PrimaryTransportConnectFailed = 0x2EA,

        /// <summary>
        /// ERROR_PAGE_FAULT_TRANSITION
        /// Page fault was a transition fault.
        /// </summary>
        PageFaultTransition = 0x2EB,

        /// <summary>
        /// ERROR_PAGE_FAULT_DEMAND_ZERO
        /// Page fault was a demand zero fault.
        /// </summary>
        PageFaultDemandZero = 0x2EC,

        /// <summary>
        /// ERROR_PAGE_FAULT_COPY_ON_WRITE
        /// Page fault was a demand zero fault.
        /// </summary>
        PageFaultCopyOnWrite = 0x2ED,

        /// <summary>
        /// ERROR_PAGE_FAULT_GUARD_PAGE
        /// Page fault was a demand zero fault.
        /// </summary>
        PageFaultGuardPage = 0x2EE,

        /// <summary>
        /// ERROR_PAGE_FAULT_PAGING_FILE
        /// Page fault was satisfied by reading from a secondary storage device.
        /// </summary>
        PageFaultPagingFile = 0x2EF,

        /// <summary>
        /// ERROR_CACHE_PAGE_LOCKED
        /// Cached page was locked during operation.
        /// </summary>
        CachePageLocked = 0x2F0,

        /// <summary>
        /// ERROR_CRASH_DUMP
        /// Crash dump exists in paging file.
        /// </summary>
        CrashDump = 0x2F1,

        /// <summary>
        /// ERROR_BUFFER_ALL_ZEROS
        /// Specified buffer contains all zeros.
        /// </summary>
        BufferAllZeros = 0x2F2,

        /// <summary>
        /// ERROR_REPARSE_OBJECT
        /// A reparse should be performed by the Object Manager since the name of the file resulted in a symbolic link.
        /// </summary>
        ReparseObject = 0x2F3,

        /// <summary>
        /// ERROR_RESOURCE_REQUIREMENTS_CHANGED
        /// The device has succeeded a query-stop and its resource requirements have changed.
        /// </summary>
        ResourceRequirementsChanged = 0x2F4,

        /// <summary>
        /// ERROR_TRANSLATION_COMPLETE
        /// The translator has translated these resources into the global space and no further translations should be performed.
        /// </summary>
        TranslationComplete = 0x2F5,

        /// <summary>
        /// ERROR_NOTHING_TO_TERMINATE
        /// A process being terminated has no threads to terminate.
        /// </summary>
        NothingToTerminate = 0x2F6,

        /// <summary>
        /// ERROR_PROCESS_NOT_IN_JOB
        /// The specified process is not part of a job.
        /// </summary>
        ProcessNotInJob = 0x2F7,

        /// <summary>
        /// ERROR_PROCESS_IN_JOB
        /// The specified process is part of a job.
        /// </summary>
        ProcessInJob = 0x2F8,

        /// <summary>
        /// ERROR_VOLSNAP_HIBERNATE_READY
        /// {Volume Shadow Copy Service} The system is now ready for hibernation.
        /// </summary>
        VolsnapHibernateReady = 0x2F9,

        /// <summary>
        /// ERROR_FSFILTER_OP_COMPLETED_SUCCESSFULLY
        /// A file system or file system filter driver has successfully completed an FsFilter operation.
        /// </summary>
        FsfilterOpCompletedSuccessfully = 0x2FA,

        /// <summary>
        /// ERROR_INTERRUPT_VECTOR_ALREADY_CONNECTED
        /// The specified interrupt vector was already connected.
        /// </summary>
        InterruptVectorAlreadyConnected = 0x2FB,

        /// <summary>
        /// ERROR_INTERRUPT_STILL_CONNECTED
        /// The specified interrupt vector is still connected.
        /// </summary>
        InterruptStillConnected = 0x2FC,

        /// <summary>
        /// ERROR_WAIT_FOR_OPLOCK
        /// An operation is blocked waiting for an oplock.
        /// </summary>
        WaitForOplock = 0x2FD,

        /// <summary>
        /// ERROR_DBG_EXCEPTION_HANDLED
        /// Debugger handled exception.
        /// </summary>
        DbgExceptionHandled = 0x2FE,

        /// <summary>
        /// ERROR_DBG_CONTINUE
        /// Debugger continued.
        /// </summary>
        DbgContinue = 0x2FF,

        /// <summary>
        /// ERROR_CALLBACK_POP_STACK
        /// An exception occurred in a user mode callback and the kernel callback frame should be removed.
        /// </summary>
        CallbackPopStack = 0x300,

        /// <summary>
        /// ERROR_COMPRESSION_DISABLED
        /// Compression is disabled for this volume.
        /// </summary>
        CompressionDisabled = 0x301,

        /// <summary>
        /// ERROR_CANTFETCHBACKWARDS
        /// The data provider cannot fetch backwards through a result set.
        /// </summary>
        Cantfetchbackwards = 0x302,

        /// <summary>
        /// ERROR_CANTSCROLLBACKWARDS
        /// The data provider cannot scroll backwards through a result set.
        /// </summary>
        Cantscrollbackwards = 0x303,

        /// <summary>
        /// ERROR_ROWSNOTRELEASED
        /// The data provider requires that previously fetched data is released before asking for more data.
        /// </summary>
        Rowsnotreleased = 0x304,

        /// <summary>
        /// ERROR_BAD_ACCESSOR_FLAGS
        /// The data provider was not able to interpret the flags set for a column binding in an accessor.
        /// </summary>
        BadAccessorFlags = 0x305,

        /// <summary>
        /// ERROR_ERRORS_ENCOUNTERED
        /// One or more errors occurred while processing the request.
        /// </summary>
        ErrorsEncountered = 0x306,

        /// <summary>
        /// ERROR_NOT_CAPABLE
        /// The implementation is not capable of performing the request.
        /// </summary>
        NotCapable = 0x307,

        /// <summary>
        /// ERROR_REQUEST_OUT_OF_SEQUENCE
        /// The client of a component requested an operation which is not valid given the state of the component instance.
        /// </summary>
        RequestOutOfSequence = 0x308,

        /// <summary>
        /// ERROR_VERSION_PARSE_ERROR
        /// A version number could not be parsed.
        /// </summary>
        VersionParseError = 0x309,

        /// <summary>
        /// ERROR_BADSTARTPOSITION
        /// The iterator's start position is invalid.
        /// </summary>
        Badstartposition = 0x30A,

        /// <summary>
        /// ERROR_MEMORY_HARDWARE
        /// The hardware has reported an uncorrectable memory error.
        /// </summary>
        MemoryHardware = 0x30B,

        /// <summary>
        /// ERROR_DISK_REPAIR_DISABLED
        /// The attempted operation required self healing to be enabled.
        /// </summary>
        DiskRepairDisabled = 0x30C,

        /// <summary>
        /// ERROR_INSUFFICIENT_RESOURCE_FOR_SPECIFIED_SHARED_SECTION_SIZE
        /// The Desktop heap encountered an error while allocating session memory. There is more information in the system event log.
        /// </summary>
        InsufficientResourceForSpecifiedSharedSectionSize = 0x30D,

        /// <summary>
        /// ERROR_SYSTEM_POWERSTATE_TRANSITION
        /// The system power state is transitioning from %2 to %3.
        /// </summary>
        SystemPowerstateTransition = 0x30E,

        /// <summary>
        /// ERROR_SYSTEM_POWERSTATE_COMPLEX_TRANSITION
        /// The system power state is transitioning from %2 to %3 but could enter %4.
        /// </summary>
        SystemPowerstateComplexTransition = 0x30F,

        /// <summary>
        /// ERROR_MCA_EXCEPTION
        /// A thread is getting dispatched with MCA EXCEPTION because of MCA.
        /// </summary>
        McaException = 0x310,

        /// <summary>
        /// ERROR_ACCESS_AUDIT_BY_POLICY
        /// Access to %1 is monitored by policy rule %2.
        /// </summary>
        AccessAuditByPolicy = 0x311,

        /// <summary>
        /// ERROR_ACCESS_DISABLED_NO_SAFER_UI_BY_POLICY
        /// Access to %1 has been restricted by your Administrator by policy rule %2.
        /// </summary>
        AccessDisabledNoSaferUiByPolicy = 0x312,

        /// <summary>
        /// ERROR_ABANDON_HIBERFILE
        /// A valid hibernation file has been invalidated and should be abandoned.
        /// </summary>
        AbandonHiberfile = 0x313,

        /// <summary>
        /// ERROR_LOST_WRITEBEHIND_DATA_NETWORK_DISCONNECTED
        /// {Delayed Write Failed} Windows was unable to save all the data for the file %hs; the data has been lost. This error may be caused by network connectivity issues. Please try to save this file elsewhere.
        /// </summary>
        LostWritebehindDataNetworkDisconnected = 0x314,

        /// <summary>
        /// ERROR_LOST_WRITEBEHIND_DATA_NETWORK_SERVER_ERROR
        /// {Delayed Write Failed} Windows was unable to save all the data for the file %hs; the data has been lost. This error was returned by the server on which the file exists. Please try to save this file elsewhere.
        /// </summary>
        LostWritebehindDataNetworkServerError = 0x315,

        /// <summary>
        /// ERROR_LOST_WRITEBEHIND_DATA_LOCAL_DISK_ERROR
        /// {Delayed Write Failed} Windows was unable to save all the data for the file %hs; the data has been lost. This error may be caused if the device has been removed or the media is write-protected.
        /// </summary>
        LostWritebehindDataLocalDiskError = 0x316,

        /// <summary>
        /// ERROR_BAD_MCFG_TABLE
        /// The resources required for this device conflict with the MCFG table.
        /// </summary>
        BadMcfgTable = 0x317,

        /// <summary>
        /// ERROR_DISK_REPAIR_REDIRECTED
        /// The volume repair could not be performed while it is online. Please schedule to take the volume offline so that it can be repaired.
        /// </summary>
        DiskRepairRedirected = 0x318,

        /// <summary>
        /// ERROR_DISK_REPAIR_UNSUCCESSFUL
        /// The volume repair was not successful.
        /// </summary>
        DiskRepairUnsuccessful = 0x319,

        /// <summary>
        /// ERROR_CORRUPT_LOG_OVERFULL
        /// One of the volume corruption logs is full. Further corruptions that may be detected won't be logged.
        /// </summary>
        CorruptLogOverfull = 0x31A,

        /// <summary>
        /// ERROR_CORRUPT_LOG_CORRUPTED
        /// One of the volume corruption logs is internally corrupted and needs to be recreated. The volume may contain undetected corruptions and must be scanned.
        /// </summary>
        CorruptLogCorrupted = 0x31B,

        /// <summary>
        /// ERROR_CORRUPT_LOG_UNAVAILABLE
        /// One of the volume corruption logs is unavailable for being operated on.
        /// </summary>
        CorruptLogUnavailable = 0x31C,

        /// <summary>
        /// ERROR_CORRUPT_LOG_DELETED_FULL
        /// One of the volume corruption logs was deleted while still having corruption records in them. The volume contains detected corruptions and must be scanned.
        /// </summary>
        CorruptLogDeletedFull = 0x31D,

        /// <summary>
        /// ERROR_CORRUPT_LOG_CLEARED
        /// One of the volume corruption logs was cleared by chkdsk and no longer contains real corruptions.
        /// </summary>
        CorruptLogCleared = 0x31E,

        /// <summary>
        /// ERROR_ORPHAN_NAME_EXHAUSTED
        /// Orphaned files exist on the volume but could not be recovered because no more new names could be created in the recovery directory. Files must be moved from the recovery directory.
        /// </summary>
        OrphanNameExhausted = 0x31F,

        /// <summary>
        /// ERROR_OPLOCK_SWITCHED_TO_NEW_HANDLE
        /// The oplock that was associated with this handle is now associated with a different handle.
        /// </summary>
        OplockSwitchedToNewHandle = 0x320,

        /// <summary>
        /// ERROR_CANNOT_GRANT_REQUESTED_OPLOCK
        /// An oplock of the requested level cannot be granted. An oplock of a lower level may be available.
        /// </summary>
        CannotGrantRequestedOplock = 0x321,

        /// <summary>
        /// ERROR_CANNOT_BREAK_OPLOCK
        /// The operation did not complete successfully because it would cause an oplock to be broken. The caller has requested that existing oplocks not be broken.
        /// </summary>
        CannotBreakOplock = 0x322,

        /// <summary>
        /// ERROR_OPLOCK_HANDLE_CLOSED
        /// The handle with which this oplock was associated has been closed. The oplock is now broken.
        /// </summary>
        OplockHandleClosed = 0x323,

        /// <summary>
        /// ERROR_NO_ACE_CONDITION
        /// The specified access control entry (ACE) does not contain a condition.
        /// </summary>
        NoAceCondition = 0x324,

        /// <summary>
        /// ERROR_INVALID_ACE_CONDITION
        /// The specified access control entry (ACE) contains an invalid condition.
        /// </summary>
        InvalidAceCondition = 0x325,

        /// <summary>
        /// ERROR_FILE_HANDLE_REVOKED
        /// Access to the specified file handle has been revoked.
        /// </summary>
        FileHandleRevoked = 0x326,

        /// <summary>
        /// ERROR_IMAGE_AT_DIFFERENT_BASE
        /// An image file was mapped at a different address from the one specified in the image file but fixups will still be automatically performed on the image.
        /// </summary>
        ImageAtDifferentBase = 0x327,

        /// <summary>
        /// ERROR_EA_ACCESS_DENIED
        /// Access to the extended attribute was denied.
        /// </summary>
        EaAccessDenied = 0x3E2,

        /// <summary>
        /// ERROR_OPERATION_ABORTED
        /// The I/O operation has been aborted because of either a thread exit or an application request.
        /// </summary>
        OperationAborted = 0x3E3,

        /// <summary>
        /// ERROR_IO_INCOMPLETE
        /// Overlapped I/O event is not in a signaled state.
        /// </summary>
        IoIncomplete = 0x3E4,

        /// <summary>
        /// ERROR_IO_PENDING
        /// Overlapped I/O operation is in progress.
        /// </summary>
        IoPending = 0x3E5,

        /// <summary>
        /// ERROR_NOACCESS
        /// Invalid access to memory location.
        /// </summary>
        Noaccess = 0x3E6,

        /// <summary>
        /// ERROR_SWAPERROR
        /// Error performing inpage operation.
        /// </summary>
        Swaperror = 0x3E7,

        /// <summary>
        /// ERROR_STACK_OVERFLOW
        /// Recursion too deep; the stack overflowed.
        /// </summary>
        StackOverflow = 0x3E9,

        /// <summary>
        /// ERROR_INVALID_MESSAGE
        /// The window cannot act on the sent message.
        /// </summary>
        InvalidMessage = 0x3EA,

        /// <summary>
        /// ERROR_CAN_NOT_COMPLETE
        /// Cannot complete this function.
        /// </summary>
        CanNotComplete = 0x3EB,

        /// <summary>
        /// ERROR_INVALID_FLAGS
        /// Invalid flags.
        /// </summary>
        InvalidFlags = 0x3EC,

        /// <summary>
        /// ERROR_UNRECOGNIZED_VOLUME
        /// The volume does not contain a recognized file system. Please make sure that all required file system drivers are loaded and that the volume is not corrupted.
        /// </summary>
        UnrecognizedVolume = 0x3ED,

        /// <summary>
        /// ERROR_FILE_INVALID
        /// The volume for a file has been externally altered so that the opened file is no longer valid.
        /// </summary>
        FileInvalid = 0x3EE,

        /// <summary>
        /// ERROR_FULLSCREEN_MODE
        /// The requested operation cannot be performed in full-screen mode.
        /// </summary>
        FullscreenMode = 0x3EF,

        /// <summary>
        /// ERROR_NO_TOKEN
        /// An attempt was made to reference a token that does not exist.
        /// </summary>
        NoToken = 0x3F0,

        /// <summary>
        /// ERROR_BADDB
        /// The configuration registry database is corrupt.
        /// </summary>
        Baddb = 0x3F1,

        /// <summary>
        /// ERROR_BADKEY
        /// The configuration registry key is invalid.
        /// </summary>
        Badkey = 0x3F2,

        /// <summary>
        /// ERROR_CANTOPEN
        /// The configuration registry key could not be opened.
        /// </summary>
        Cantopen = 0x3F3,

        /// <summary>
        /// ERROR_CANTREAD
        /// The configuration registry key could not be read.
        /// </summary>
        Cantread = 0x3F4,

        /// <summary>
        /// ERROR_CANTWRITE
        /// The configuration registry key could not be written.
        /// </summary>
        Cantwrite = 0x3F5,

        /// <summary>
        /// ERROR_REGISTRY_RECOVERED
        /// One of the files in the registry database had to be recovered by use of a log or alternate copy. The recovery was successful.
        /// </summary>
        RegistryRecovered = 0x3F6,

        /// <summary>
        /// ERROR_REGISTRY_CORRUPT
        /// The registry is corrupted. The structure of one of the files containing registry data is corrupted, or the system's memory image of the file is corrupted, or the file could not be recovered because the alternate copy or log was absent or corrupted.
        /// </summary>
        RegistryCorrupt = 0x3F7,

        /// <summary>
        /// ERROR_REGISTRY_IO_FAILED
        /// An I/O operation initiated by the registry failed unrecoverably. The registry could not read in, or write out, or flush, one of the files that contain the system's image of the registry.
        /// </summary>
        RegistryIoFailed = 0x3F8,

        /// <summary>
        /// ERROR_NOT_REGISTRY_FILE
        /// The system has attempted to load or restore a file into the registry, but the specified file is not in a registry file format.
        /// </summary>
        NotRegistryFile = 0x3F9,

        /// <summary>
        /// ERROR_KEY_DELETED
        /// Illegal operation attempted on a registry key that has been marked for deletion.
        /// </summary>
        KeyDeleted = 0x3FA,

        /// <summary>
        /// ERROR_NO_LOG_SPACE
        /// System could not allocate the required space in a registry log.
        /// </summary>
        NoLogSpace = 0x3FB,

        /// <summary>
        /// ERROR_KEY_HAS_CHILDREN
        /// Cannot create a symbolic link in a registry key that already has subkeys or values.
        /// </summary>
        KeyHasChildren = 0x3FC,

        /// <summary>
        /// ERROR_CHILD_MUST_BE_VOLATILE
        /// Cannot create a stable subkey under a volatile parent key.
        /// </summary>
        ChildMustBeVolatile = 0x3FD,

        /// <summary>
        /// ERROR_NOTIFY_ENUM_DIR
        /// A notify change request is being completed and the information is not being returned in the caller's buffer. The caller now needs to enumerate the files to find the changes.
        /// </summary>
        NotifyEnumDir = 0x3FE,

        /// <summary>
        /// ERROR_DEPENDENT_SERVICES_RUNNING
        /// A stop control has been sent to a service that other running services are dependent on.
        /// </summary>
        DependentServicesRunning = 0x41B,

        /// <summary>
        /// ERROR_INVALID_SERVICE_CONTROL
        /// The requested control is not valid for this service.
        /// </summary>
        InvalidServiceControl = 0x41C,

        /// <summary>
        /// ERROR_SERVICE_REQUEST_TIMEOUT
        /// The service did not respond to the start or control request in a timely fashion.
        /// </summary>
        ServiceRequestTimeout = 0x41D,

        /// <summary>
        /// ERROR_SERVICE_NO_THREAD
        /// A thread could not be created for the service.
        /// </summary>
        ServiceNoThread = 0x41E,

        /// <summary>
        /// ERROR_SERVICE_DATABASE_LOCKED
        /// The service database is locked.
        /// </summary>
        ServiceDatabaseLocked = 0x41F,

        /// <summary>
        /// ERROR_SERVICE_ALREADY_RUNNING
        /// An instance of the service is already running.
        /// </summary>
        ServiceAlreadyRunning = 0x420,

        /// <summary>
        /// ERROR_INVALID_SERVICE_ACCOUNT
        /// The account name is invalid or does not exist, or the password is invalid for the account name specified.
        /// </summary>
        InvalidServiceAccount = 0x421,

        /// <summary>
        /// ERROR_SERVICE_DISABLED
        /// The service cannot be started, either because it is disabled or because it has no enabled devices associated with it.
        /// </summary>
        ServiceDisabled = 0x422,

        /// <summary>
        /// ERROR_CIRCULAR_DEPENDENCY
        /// Circular service dependency was specified.
        /// </summary>
        CircularDependency = 0x423,

        /// <summary>
        /// ERROR_SERVICE_DOES_NOT_EXIST
        /// The specified service does not exist as an installed service.
        /// </summary>
        ServiceDoesNotExist = 0x424,

        /// <summary>
        /// ERROR_SERVICE_CANNOT_ACCEPT_CTRL
        /// The service cannot accept control messages at this time.
        /// </summary>
        ServiceCannotAcceptCtrl = 0x425,

        /// <summary>
        /// ERROR_SERVICE_NOT_ACTIVE
        /// The service has not been started.
        /// </summary>
        ServiceNotActive = 0x426,

        /// <summary>
        /// ERROR_FAILED_SERVICE_CONTROLLER_CONNECT
        /// The service process could not connect to the service controller.
        /// </summary>
        FailedServiceControllerConnect = 0x427,

        /// <summary>
        /// ERROR_EXCEPTION_IN_SERVICE
        /// An exception occurred in the service when handling the control request.
        /// </summary>
        ExceptionInService = 0x428,

        /// <summary>
        /// ERROR_DATABASE_DOES_NOT_EXIST
        /// The database specified does not exist.
        /// </summary>
        DatabaseDoesNotExist = 0x429,

        /// <summary>
        /// ERROR_SERVICE_SPECIFIC_ERROR
        /// The service has returned a service-specific error code.
        /// </summary>
        ServiceSpecificError = 0x42A,

        /// <summary>
        /// ERROR_PROCESS_ABORTED
        /// The process terminated unexpectedly.
        /// </summary>
        ProcessAborted = 0x42B,

        /// <summary>
        /// ERROR_SERVICE_DEPENDENCY_FAIL
        /// The dependency service or group failed to start.
        /// </summary>
        ServiceDependencyFail = 0x42C,

        /// <summary>
        /// ERROR_SERVICE_LOGON_FAILED
        /// The service did not start due to a logon failure.
        /// </summary>
        ServiceLogonFailed = 0x42D,

        /// <summary>
        /// ERROR_SERVICE_START_HANG
        /// After starting, the service hung in a start-pending state.
        /// </summary>
        ServiceStartHang = 0x42E,

        /// <summary>
        /// ERROR_INVALID_SERVICE_LOCK
        /// The specified service database lock is invalid.
        /// </summary>
        InvalidServiceLock = 0x42F,

        /// <summary>
        /// ERROR_SERVICE_MARKED_FOR_DELETE
        /// The specified service has been marked for deletion.
        /// </summary>
        ServiceMarkedForDelete = 0x430,

        /// <summary>
        /// ERROR_SERVICE_EXISTS
        /// The specified service already exists.
        /// </summary>
        ServiceExists = 0x431,

        /// <summary>
        /// ERROR_ALREADY_RUNNING_LKG
        /// The system is currently running with the last-known-good configuration.
        /// </summary>
        AlreadyRunningLkg = 0x432,

        /// <summary>
        /// ERROR_SERVICE_DEPENDENCY_DELETED
        /// The dependency service does not exist or has been marked for deletion.
        /// </summary>
        ServiceDependencyDeleted = 0x433,

        /// <summary>
        /// ERROR_BOOT_ALREADY_ACCEPTED
        /// The current boot has already been accepted for use as the last-known-good control set.
        /// </summary>
        BootAlreadyAccepted = 0x434,

        /// <summary>
        /// ERROR_SERVICE_NEVER_STARTED
        /// No attempts to start the service have been made since the last boot.
        /// </summary>
        ServiceNeverStarted = 0x435,

        /// <summary>
        /// ERROR_DUPLICATE_SERVICE_NAME
        /// The name is already in use as either a service name or a service display name.
        /// </summary>
        DuplicateServiceName = 0x436,

        /// <summary>
        /// ERROR_DIFFERENT_SERVICE_ACCOUNT
        /// The account specified for this service is different from the account specified for other services running in the same process.
        /// </summary>
        DifferentServiceAccount = 0x437,

        /// <summary>
        /// ERROR_CANNOT_DETECT_DRIVER_FAILURE
        /// Failure actions can only be set for Win32 services, not for drivers.
        /// </summary>
        CannotDetectDriverFailure = 0x438,

        /// <summary>
        /// ERROR_CANNOT_DETECT_PROCESS_ABORT
        /// This service runs in the same process as the service control manager. Therefore, the service control manager cannot take action if this service's process terminates unexpectedly.
        /// </summary>
        CannotDetectProcessAbort = 0x439,

        /// <summary>
        /// ERROR_NO_RECOVERY_PROGRAM
        /// No recovery program has been configured for this service.
        /// </summary>
        NoRecoveryProgram = 0x43A,

        /// <summary>
        /// ERROR_SERVICE_NOT_IN_EXE
        /// The executable program that this service is configured to run in does not implement the service.
        /// </summary>
        ServiceNotInExe = 0x43B,

        /// <summary>
        /// ERROR_NOT_SAFEBOOT_SERVICE
        /// This service cannot be started in Safe Mode.
        /// </summary>
        NotSafebootService = 0x43C,

        /// <summary>
        /// ERROR_END_OF_MEDIA
        /// The physical end of the tape has been reached.
        /// </summary>
        EndOfMedia = 0x44C,

        /// <summary>
        /// ERROR_FILEMARK_DETECTED
        /// A tape access reached a filemark.
        /// </summary>
        FilemarkDetected = 0x44D,

        /// <summary>
        /// ERROR_BEGINNING_OF_MEDIA
        /// The beginning of the tape or a partition was encountered.
        /// </summary>
        BeginningOfMedia = 0x44E,

        /// <summary>
        /// ERROR_SETMARK_DETECTED
        /// A tape access reached the end of a set of files.
        /// </summary>
        SetmarkDetected = 0x44F,

        /// <summary>
        /// ERROR_NO_DATA_DETECTED
        /// No more data is on the tape.
        /// </summary>
        NoDataDetected = 0x450,

        /// <summary>
        /// ERROR_PARTITION_FAILURE
        /// Tape could not be partitioned.
        /// </summary>
        PartitionFailure = 0x451,

        /// <summary>
        /// ERROR_INVALID_BLOCK_LENGTH
        /// When accessing a new tape of a multivolume partition, the current block size is incorrect.
        /// </summary>
        InvalidBlockLength = 0x452,

        /// <summary>
        /// ERROR_DEVICE_NOT_PARTITIONED
        /// Tape partition information could not be found when loading a tape.
        /// </summary>
        DeviceNotPartitioned = 0x453,

        /// <summary>
        /// ERROR_UNABLE_TO_LOCK_MEDIA
        /// Unable to lock the media eject mechanism.
        /// </summary>
        UnableToLockMedia = 0x454,

        /// <summary>
        /// ERROR_UNABLE_TO_UNLOAD_MEDIA
        /// Unable to unload the media.
        /// </summary>
        UnableToUnloadMedia = 0x455,

        /// <summary>
        /// ERROR_MEDIA_CHANGED
        /// The media in the drive may have changed.
        /// </summary>
        MediaChanged = 0x456,

        /// <summary>
        /// ERROR_BUS_RESET
        /// The I/O bus was reset.
        /// </summary>
        BusReset = 0x457,

        /// <summary>
        /// ERROR_NO_MEDIA_IN_DRIVE
        /// No media in drive.
        /// </summary>
        NoMediaInDrive = 0x458,

        /// <summary>
        /// ERROR_NO_UNICODE_TRANSLATION
        /// No mapping for the Unicode character exists in the target multi-byte code page.
        /// </summary>
        NoUnicodeTranslation = 0x459,

        /// <summary>
        /// ERROR_DLL_INIT_FAILED
        /// A dynamic link library (DLL) initialization routine failed.
        /// </summary>
        DllInitFailed = 0x45A,

        /// <summary>
        /// ERROR_SHUTDOWN_IN_PROGRESS
        /// A system shutdown is in progress.
        /// </summary>
        ShutdownInProgress = 0x45B,

        /// <summary>
        /// ERROR_NO_SHUTDOWN_IN_PROGRESS
        /// Unable to abort the system shutdown because no shutdown was in progress.
        /// </summary>
        NoShutdownInProgress = 0x45C,

        /// <summary>
        /// ERROR_IO_DEVICE
        /// The request could not be performed because of an I/O device error.
        /// </summary>
        IoDevice = 0x45D,

        /// <summary>
        /// ERROR_SERIAL_NO_DEVICE
        /// No serial device was successfully initialized. The serial driver will unload.
        /// </summary>
        SerialNoDevice = 0x45E,

        /// <summary>
        /// ERROR_IRQ_BUSY
        /// Unable to open a device that was sharing an interrupt request (IRQ) with other devices. At least one other device that uses that IRQ was already opened.
        /// </summary>
        IrqBusy = 0x45F,

        /// <summary>
        /// ERROR_MORE_WRITES
        /// A serial I/O operation was completed by another write to the serial port. The IOCTL_SERIAL_XOFF_COUNTER reached zero.)
        /// </summary>
        MoreWrites = 0x460,

        /// <summary>
        /// ERROR_COUNTER_TIMEOUT
        /// A serial I/O operation completed because the timeout period expired. The IOCTL_SERIAL_XOFF_COUNTER did not reach zero.)
        /// </summary>
        CounterTimeout = 0x461,

        /// <summary>
        /// ERROR_FLOPPY_ID_MARK_NOT_FOUND
        /// No ID address mark was found on the floppy disk.
        /// </summary>
        FloppyIdMarkNotFound = 0x462,

        /// <summary>
        /// ERROR_FLOPPY_WRONG_CYLINDER
        /// Mismatch between the floppy disk sector ID field and the floppy disk controller track address.
        /// </summary>
        FloppyWrongCylinder = 0x463,

        /// <summary>
        /// ERROR_FLOPPY_UNKNOWN_ERROR
        /// The floppy disk controller reported an error that is not recognized by the floppy disk driver.
        /// </summary>
        FloppyUnknownError = 0x464,

        /// <summary>
        /// ERROR_FLOPPY_BAD_REGISTERS
        /// The floppy disk controller returned inconsistent results in its registers.
        /// </summary>
        FloppyBadRegisters = 0x465,

        /// <summary>
        /// ERROR_DISK_RECALIBRATE_FAILED
        /// While accessing the hard disk, a recalibrate operation failed, even after retries.
        /// </summary>
        DiskRecalibrateFailed = 0x466,

        /// <summary>
        /// ERROR_DISK_OPERATION_FAILED
        /// While accessing the hard disk, a disk operation failed even after retries.
        /// </summary>
        DiskOperationFailed = 0x467,

        /// <summary>
        /// ERROR_DISK_RESET_FAILED
        /// While accessing the hard disk, a disk controller reset was needed, but even that failed.
        /// </summary>
        DiskResetFailed = 0x468,

        /// <summary>
        /// ERROR_EOM_OVERFLOW
        /// Physical end of tape encountered.
        /// </summary>
        EomOverflow = 0x469,

        /// <summary>
        /// ERROR_NOT_ENOUGH_SERVER_MEMORY
        /// Not enough server storage is available to process this command.
        /// </summary>
        NotEnoughServerMemory = 0x46A,

        /// <summary>
        /// ERROR_POSSIBLE_DEADLOCK
        /// A potential deadlock condition has been detected.
        /// </summary>
        PossibleDeadlock = 0x46B,

        /// <summary>
        /// ERROR_MAPPED_ALIGNMENT
        /// The base address or the file offset specified does not have the proper alignment.
        /// </summary>
        MappedAlignment = 0x46C,

        /// <summary>
        /// ERROR_SET_POWER_STATE_VETOED
        /// An attempt to change the system power state was vetoed by another application or driver.
        /// </summary>
        SetPowerStateVetoed = 0x474,

        /// <summary>
        /// ERROR_SET_POWER_STATE_FAILED
        /// The system BIOS failed an attempt to change the system power state.
        /// </summary>
        SetPowerStateFailed = 0x475,

        /// <summary>
        /// ERROR_TOO_MANY_LINKS
        /// An attempt was made to create more links on a file than the file system supports.
        /// </summary>
        TooManyLinks = 0x476,

        /// <summary>
        /// ERROR_OLD_WIN_VERSION
        /// The specified program requires a newer version of Windows.
        /// </summary>
        OldWinVersion = 0x47E,

        /// <summary>
        /// ERROR_APP_WRONG_OS
        /// The specified program is not a Windows or MS-DOS program.
        /// </summary>
        AppWrongOs = 0x47F,

        /// <summary>
        /// ERROR_SINGLE_INSTANCE_APP
        /// Cannot start more than one instance of the specified program.
        /// </summary>
        SingleInstanceApp = 0x480,

        /// <summary>
        /// ERROR_RMODE_APP
        /// The specified program was written for an earlier version of Windows.
        /// </summary>
        RmodeApp = 0x481,

        /// <summary>
        /// ERROR_INVALID_DLL
        /// One of the library files needed to run this application is damaged.
        /// </summary>
        InvalidDll = 0x482,

        /// <summary>
        /// ERROR_NO_ASSOCIATION
        /// No application is associated with the specified file for this operation.
        /// </summary>
        NoAssociation = 0x483,

        /// <summary>
        /// ERROR_DDE_FAIL
        /// An error occurred in sending the command to the application.
        /// </summary>
        DdeFail = 0x484,

        /// <summary>
        /// ERROR_DLL_NOT_FOUND
        /// One of the library files needed to run this application cannot be found.
        /// </summary>
        DllNotFound = 0x485,

        /// <summary>
        /// ERROR_NO_MORE_USER_HANDLES
        /// The current process has used all of its system allowance of handles for Window Manager objects.
        /// </summary>
        NoMoreUserHandles = 0x486,

        /// <summary>
        /// ERROR_MESSAGE_SYNC_ONLY
        /// The message can be used only with synchronous operations.
        /// </summary>
        MessageSyncOnly = 0x487,

        /// <summary>
        /// ERROR_SOURCE_ELEMENT_EMPTY
        /// The indicated source element has no media.
        /// </summary>
        SourceElementEmpty = 0x488,

        /// <summary>
        /// ERROR_DESTINATION_ELEMENT_FULL
        /// The indicated destination element already contains media.
        /// </summary>
        DestinationElementFull = 0x489,

        /// <summary>
        /// ERROR_ILLEGAL_ELEMENT_ADDRESS
        /// The indicated element does not exist.
        /// </summary>
        IllegalElementAddress = 0x48A,

        /// <summary>
        /// ERROR_MAGAZINE_NOT_PRESENT
        /// The indicated element is part of a magazine that is not present.
        /// </summary>
        MagazineNotPresent = 0x48B,

        /// <summary>
        /// ERROR_DEVICE_REINITIALIZATION_NEEDED
        /// The indicated device requires reinitialization due to hardware errors.
        /// </summary>
        DeviceReinitializationNeeded = 0x48C,

        /// <summary>
        /// ERROR_DEVICE_REQUIRES_CLEANING
        /// The device has indicated that cleaning is required before further operations are attempted.
        /// </summary>
        DeviceRequiresCleaning = 0x48D,

        /// <summary>
        /// ERROR_DEVICE_DOOR_OPEN
        /// The device has indicated that its door is open.
        /// </summary>
        DeviceDoorOpen = 0x48E,

        /// <summary>
        /// ERROR_DEVICE_NOT_CONNECTED
        /// The device is not connected.
        /// </summary>
        DeviceNotConnected = 0x48F,

        /// <summary>
        /// ERROR_NOT_FOUND
        /// Element not found.
        /// </summary>
        NotFound = 0x490,

        /// <summary>
        /// ERROR_NO_MATCH
        /// There was no match for the specified key in the index.
        /// </summary>
        NoMatch = 0x491,

        /// <summary>
        /// ERROR_SET_NOT_FOUND
        /// The property set specified does not exist on the object.
        /// </summary>
        SetNotFound = 0x492,

        /// <summary>
        /// ERROR_POINT_NOT_FOUND
        /// The point passed to GetMouseMovePoints is not in the buffer.
        /// </summary>
        PointNotFound = 0x493,

        /// <summary>
        /// ERROR_NO_TRACKING_SERVICE
        /// The tracking (workstation) service is not running.
        /// </summary>
        NoTrackingService = 0x494,

        /// <summary>
        /// ERROR_NO_VOLUME_ID
        /// The Volume ID could not be found.
        /// </summary>
        NoVolumeId = 0x495,

        /// <summary>
        /// ERROR_UNABLE_TO_REMOVE_REPLACED
        /// Unable to remove the file to be replaced.
        /// </summary>
        UnableToRemoveReplaced = 0x497,

        /// <summary>
        /// ERROR_UNABLE_TO_MOVE_REPLACEMENT
        /// Unable to move the replacement file to the file to be replaced. The file to be replaced has retained its original name.
        /// </summary>
        UnableToMoveReplacement = 0x498,

        /// <summary>
        /// ERROR_UNABLE_TO_MOVE_REPLACEMENT_2
        /// Unable to move the replacement file to the file to be replaced. The file to be replaced has been renamed using the backup name.
        /// </summary>
        UnableToMoveReplacement2 = 0x499,

        /// <summary>
        /// ERROR_JOURNAL_DELETE_IN_PROGRESS
        /// The volume change journal is being deleted.
        /// </summary>
        JournalDeleteInProgress = 0x49A,

        /// <summary>
        /// ERROR_JOURNAL_NOT_ACTIVE
        /// The volume change journal is not active.
        /// </summary>
        JournalNotActive = 0x49B,

        /// <summary>
        /// ERROR_POTENTIAL_FILE_FOUND
        /// A file was found, but it may not be the correct file.
        /// </summary>
        PotentialFileFound = 0x49C,

        /// <summary>
        /// ERROR_JOURNAL_ENTRY_DELETED
        /// The journal entry has been deleted from the journal.
        /// </summary>
        JournalEntryDeleted = 0x49D,

        /// <summary>
        /// ERROR_SHUTDOWN_IS_SCHEDULED
        /// A system shutdown has already been scheduled.
        /// </summary>
        ShutdownIsScheduled = 0x4A6,

        /// <summary>
        /// ERROR_SHUTDOWN_USERS_LOGGED_ON
        /// The system shutdown cannot be initiated because there are other users logged on to the computer.
        /// </summary>
        ShutdownUsersLoggedOn = 0x4A7,

        /// <summary>
        /// ERROR_BAD_DEVICE
        /// The specified device name is invalid.
        /// </summary>
        BadDevice = 0x4B0,

        /// <summary>
        /// ERROR_CONNECTION_UNAVAIL
        /// The device is not currently connected but it is a remembered connection.
        /// </summary>
        ConnectionUnavail = 0x4B1,

        /// <summary>
        /// ERROR_DEVICE_ALREADY_REMEMBERED
        /// The local device name has a remembered connection to another network resource.
        /// </summary>
        DeviceAlreadyRemembered = 0x4B2,

        /// <summary>
        /// ERROR_NO_NET_OR_BAD_PATH
        /// The network path was either typed incorrectly, does not exist, or the network provider is not currently available. Please try retyping the path or contact your network administrator.
        /// </summary>
        NoNetOrBadPath = 0x4B3,

        /// <summary>
        /// ERROR_BAD_PROVIDER
        /// The specified network provider name is invalid.
        /// </summary>
        BadProvider = 0x4B4,

        /// <summary>
        /// ERROR_CANNOT_OPEN_PROFILE
        /// Unable to open the network connection profile.
        /// </summary>
        CannotOpenProfile = 0x4B5,

        /// <summary>
        /// ERROR_BAD_PROFILE
        /// The network connection profile is corrupted.
        /// </summary>
        BadProfile = 0x4B6,

        /// <summary>
        /// ERROR_NOT_CONTAINER
        /// Cannot enumerate a noncontainer.
        /// </summary>
        NotContainer = 0x4B7,

        /// <summary>
        /// ERROR_EXTENDED_ERROR
        /// An extended error has occurred.
        /// </summary>
        ExtendedError = 0x4B8,

        /// <summary>
        /// ERROR_INVALID_GROUPNAME
        /// The format of the specified group name is invalid.
        /// </summary>
        InvalidGroupname = 0x4B9,

        /// <summary>
        /// ERROR_INVALID_COMPUTERNAME
        /// The format of the specified computer name is invalid.
        /// </summary>
        InvalidComputername = 0x4BA,

        /// <summary>
        /// ERROR_INVALID_EVENTNAME
        /// The format of the specified event name is invalid.
        /// </summary>
        InvalidEventname = 0x4BB,

        /// <summary>
        /// ERROR_INVALID_DOMAINNAME
        /// The format of the specified domain name is invalid.
        /// </summary>
        InvalidDomainname = 0x4BC,

        /// <summary>
        /// ERROR_INVALID_SERVICENAME
        /// The format of the specified service name is invalid.
        /// </summary>
        InvalidServicename = 0x4BD,

        /// <summary>
        /// ERROR_INVALID_NETNAME
        /// The format of the specified network name is invalid.
        /// </summary>
        InvalidNetname = 0x4BE,

        /// <summary>
        /// ERROR_INVALID_SHARENAME
        /// The format of the specified share name is invalid.
        /// </summary>
        InvalidSharename = 0x4BF,

        /// <summary>
        /// ERROR_INVALID_PASSWORDNAME
        /// The format of the specified password is invalid.
        /// </summary>
        InvalidPasswordname = 0x4C0,

        /// <summary>
        /// ERROR_INVALID_MESSAGENAME
        /// The format of the specified message name is invalid.
        /// </summary>
        InvalidMessagename = 0x4C1,

        /// <summary>
        /// ERROR_INVALID_MESSAGEDEST
        /// The format of the specified message destination is invalid.
        /// </summary>
        InvalidMessagedest = 0x4C2,

        /// <summary>
        /// ERROR_SESSION_CREDENTIAL_CONFLICT
        /// Multiple connections to a server or shared resource by the same user, using more than one user name, are not allowed. Disconnect all previous connections to the server or shared resource and try again.
        /// </summary>
        SessionCredentialConflict = 0x4C3,

        /// <summary>
        /// ERROR_REMOTE_SESSION_LIMIT_EXCEEDED
        /// An attempt was made to establish a session to a network server, but there are already too many sessions established to that server.
        /// </summary>
        RemoteSessionLimitExceeded = 0x4C4,

        /// <summary>
        /// ERROR_DUP_DOMAINNAME
        /// The workgroup or domain name is already in use by another computer on the network.
        /// </summary>
        DupDomainname = 0x4C5,

        /// <summary>
        /// ERROR_NO_NETWORK
        /// The network is not present or not started.
        /// </summary>
        NoNetwork = 0x4C6,

        /// <summary>
        /// ERROR_CANCELLED
        /// The operation was canceled by the user.
        /// </summary>
        Cancelled = 0x4C7,

        /// <summary>
        /// ERROR_USER_MAPPED_FILE
        /// The requested operation cannot be performed on a file with a user-mapped section open.
        /// </summary>
        UserMappedFile = 0x4C8,

        /// <summary>
        /// ERROR_CONNECTION_REFUSED
        /// The remote computer refused the network connection.
        /// </summary>
        ConnectionRefused = 0x4C9,

        /// <summary>
        /// ERROR_GRACEFUL_DISCONNECT
        /// The network connection was gracefully closed.
        /// </summary>
        GracefulDisconnect = 0x4CA,

        /// <summary>
        /// ERROR_ADDRESS_ALREADY_ASSOCIATED
        /// The network transport endpoint already has an address associated with it.
        /// </summary>
        AddressAlreadyAssociated = 0x4CB,

        /// <summary>
        /// ERROR_ADDRESS_NOT_ASSOCIATED
        /// An address has not yet been associated with the network endpoint.
        /// </summary>
        AddressNotAssociated = 0x4CC,

        /// <summary>
        /// ERROR_CONNECTION_INVALID
        /// An operation was attempted on a nonexistent network connection.
        /// </summary>
        ConnectionInvalid = 0x4CD,

        /// <summary>
        /// ERROR_CONNECTION_ACTIVE
        /// An invalid operation was attempted on an active network connection.
        /// </summary>
        ConnectionActive = 0x4CE,

        /// <summary>
        /// ERROR_NETWORK_UNREACHABLE
        /// The network location cannot be reached. For information about network troubleshooting, see Windows Help.
        /// </summary>
        NetworkUnreachable = 0x4CF,

        /// <summary>
        /// ERROR_HOST_UNREACHABLE
        /// The network location cannot be reached. For information about network troubleshooting, see Windows Help.
        /// </summary>
        HostUnreachable = 0x4D0,

        /// <summary>
        /// ERROR_PROTOCOL_UNREACHABLE
        /// The network location cannot be reached. For information about network troubleshooting, see Windows Help.
        /// </summary>
        ProtocolUnreachable = 0x4D1,

        /// <summary>
        /// ERROR_PORT_UNREACHABLE
        /// No service is operating at the destination network endpoint on the remote system.
        /// </summary>
        PortUnreachable = 0x4D2,

        /// <summary>
        /// ERROR_REQUEST_ABORTED
        /// The request was aborted.
        /// </summary>
        RequestAborted = 0x4D3,

        /// <summary>
        /// ERROR_CONNECTION_ABORTED
        /// The network connection was aborted by the local system.
        /// </summary>
        ConnectionAborted = 0x4D4,

        /// <summary>
        /// ERROR_RETRY
        /// The operation could not be completed. A retry should be performed.
        /// </summary>
        Retry = 0x4D5,

        /// <summary>
        /// ERROR_CONNECTION_COUNT_LIMIT
        /// A connection to the server could not be made because the limit on the number of concurrent connections for this account has been reached.
        /// </summary>
        ConnectionCountLimit = 0x4D6,

        /// <summary>
        /// ERROR_LOGIN_TIME_RESTRICTION
        /// Attempting to log in during an unauthorized time of day for this account.
        /// </summary>
        LoginTimeRestriction = 0x4D7,

        /// <summary>
        /// ERROR_LOGIN_WKSTA_RESTRICTION
        /// The account is not authorized to log in from this station.
        /// </summary>
        LoginWkstaRestriction = 0x4D8,

        /// <summary>
        /// ERROR_INCORRECT_ADDRESS
        /// The network address could not be used for the operation requested.
        /// </summary>
        IncorrectAddress = 0x4D9,

        /// <summary>
        /// ERROR_ALREADY_REGISTERED
        /// The service is already registered.
        /// </summary>
        AlreadyRegistered = 0x4DA,

        /// <summary>
        /// ERROR_SERVICE_NOT_FOUND
        /// The specified service does not exist.
        /// </summary>
        ServiceNotFound = 0x4DB,

        /// <summary>
        /// ERROR_NOT_AUTHENTICATED
        /// The operation being requested was not performed because the user has not been authenticated.
        /// </summary>
        NotAuthenticated = 0x4DC,

        /// <summary>
        /// ERROR_NOT_LOGGED_ON
        /// The operation being requested was not performed because the user has not logged on to the network. The specified service does not exist.
        /// </summary>
        NotLoggedOn = 0x4DD,

        /// <summary>
        /// ERROR_CONTINUE
        /// Continue with work in progress.
        /// </summary>
        Continue = 0x4DE,

        /// <summary>
        /// ERROR_ALREADY_INITIALIZED
        /// An attempt was made to perform an initialization operation when initialization has already been completed.
        /// </summary>
        AlreadyInitialized = 0x4DF,

        /// <summary>
        /// ERROR_NO_MORE_DEVICES
        /// No more local devices.
        /// </summary>
        NoMoreDevices = 0x4E0,

        /// <summary>
        /// ERROR_NO_SUCH_SITE
        /// The specified site does not exist.
        /// </summary>
        NoSuchSite = 0x4E1,

        /// <summary>
        /// ERROR_DOMAIN_CONTROLLER_EXISTS
        /// A domain controller with the specified name already exists.
        /// </summary>
        DomainControllerExists = 0x4E2,

        /// <summary>
        /// ERROR_ONLY_IF_CONNECTED
        /// This operation is supported only when you are connected to the server.
        /// </summary>
        OnlyIfConnected = 0x4E3,

        /// <summary>
        /// ERROR_OVERRIDE_NOCHANGES
        /// The group policy framework should call the extension even if there are no changes.
        /// </summary>
        OverrideNochanges = 0x4E4,

        /// <summary>
        /// ERROR_BAD_USER_PROFILE
        /// The specified user does not have a valid profile.
        /// </summary>
        BadUserProfile = 0x4E5,

        /// <summary>
        /// ERROR_NOT_SUPPORTED_ON_SBS
        /// This operation is not supported on a computer running Windows Server 2003 for Small Business Server.
        /// </summary>
        NotSupportedOnSbs = 0x4E6,

        /// <summary>
        /// ERROR_SERVER_SHUTDOWN_IN_PROGRESS
        /// The server machine is shutting down.
        /// </summary>
        ServerShutdownInProgress = 0x4E7,

        /// <summary>
        /// ERROR_HOST_DOWN
        /// The remote system is not available. For information about network troubleshooting, see Windows Help.
        /// </summary>
        HostDown = 0x4E8,

        /// <summary>
        /// ERROR_NON_ACCOUNT_SID
        /// The security identifier provided is not from an account domain.
        /// </summary>
        NonAccountSid = 0x4E9,

        /// <summary>
        /// ERROR_NON_DOMAIN_SID
        /// The security identifier provided does not have a domain component.
        /// </summary>
        NonDomainSid = 0x4EA,

        /// <summary>
        /// ERROR_APPHELP_BLOCK
        /// AppHelp dialog canceled thus preventing the application from starting.
        /// </summary>
        ApphelpBlock = 0x4EB,

        /// <summary>
        /// ERROR_ACCESS_DISABLED_BY_POLICY
        /// This program is blocked by group policy. For more information, contact your system administrator.
        /// </summary>
        AccessDisabledByPolicy = 0x4EC,

        /// <summary>
        /// ERROR_REG_NAT_CONSUMPTION
        /// A program attempt to use an invalid register value. Normally caused by an uninitialized register. This error is Itanium specific.
        /// </summary>
        RegNatConsumption = 0x4ED,

        /// <summary>
        /// ERROR_CSCSHARE_OFFLINE
        /// The share is currently offline or does not exist.
        /// </summary>
        CscshareOffline = 0x4EE,

        /// <summary>
        /// ERROR_PKINIT_FAILURE
        /// The Kerberos protocol encountered an error while validating the KDC certificate during smartcard logon. There is more information in the system event log.
        /// </summary>
        PkinitFailure = 0x4EF,

        /// <summary>
        /// ERROR_SMARTCARD_SUBSYSTEM_FAILURE
        /// The Kerberos protocol encountered an error while attempting to utilize the smartcard subsystem.
        /// </summary>
        SmartcardSubsystemFailure = 0x4F0,

        /// <summary>
        /// ERROR_DOWNGRADE_DETECTED
        /// The system cannot contact a domain controller to service the authentication request. Please try again later.
        /// </summary>
        DowngradeDetected = 0x4F1,

        /// <summary>
        /// ERROR_MACHINE_LOCKED
        /// The machine is locked and cannot be shut down without the force option.
        /// </summary>
        MachineLocked = 0x4F7,

        /// <summary>
        /// ERROR_CALLBACK_SUPPLIED_INVALID_DATA
        /// An application-defined callback gave invalid data when called.
        /// </summary>
        CallbackSuppliedInvalidData = 0x4F9,

        /// <summary>
        /// ERROR_SYNC_FOREGROUND_REFRESH_REQUIRED
        /// The group policy framework should call the extension in the synchronous foreground policy refresh.
        /// </summary>
        SyncForegroundRefreshRequired = 0x4FA,

        /// <summary>
        /// ERROR_DRIVER_BLOCKED
        /// This driver has been blocked from loading.
        /// </summary>
        DriverBlocked = 0x4FB,

        /// <summary>
        /// ERROR_INVALID_IMPORT_OF_NON_DLL
        /// A dynamic link library (DLL) referenced a module that was neither a DLL nor the process's executable image.
        /// </summary>
        InvalidImportOfNonDll = 0x4FC,

        /// <summary>
        /// ERROR_ACCESS_DISABLED_WEBBLADE
        /// Windows cannot open this program since it has been disabled.
        /// </summary>
        AccessDisabledWebblade = 0x4FD,

        /// <summary>
        /// ERROR_ACCESS_DISABLED_WEBBLADE_TAMPER
        /// Windows cannot open this program because the license enforcement system has been tampered with or become corrupted.
        /// </summary>
        AccessDisabledWebbladeTamper = 0x4FE,

        /// <summary>
        /// ERROR_RECOVERY_FAILURE
        /// A transaction recover failed.
        /// </summary>
        RecoveryFailure = 0x4FF,

        /// <summary>
        /// ERROR_ALREADY_FIBER
        /// The current thread has already been converted to a fiber.
        /// </summary>
        AlreadyFiber = 0x500,

        /// <summary>
        /// ERROR_ALREADY_THREAD
        /// The current thread has already been converted from a fiber.
        /// </summary>
        AlreadyThread = 0x501,

        /// <summary>
        /// ERROR_STACK_BUFFER_OVERRUN
        /// The system detected an overrun of a stack-based buffer in this application. This overrun could potentially allow a malicious user to gain control of this application.
        /// </summary>
        StackBufferOverrun = 0x502,

        /// <summary>
        /// ERROR_PARAMETER_QUOTA_EXCEEDED
        /// Data present in one of the parameters is more than the function can operate on.
        /// </summary>
        ParameterQuotaExceeded = 0x503,

        /// <summary>
        /// ERROR_DEBUGGER_INACTIVE
        /// An attempt to do an operation on a debug object failed because the object is in the process of being deleted.
        /// </summary>
        DebuggerInactive = 0x504,

        /// <summary>
        /// ERROR_DELAY_LOAD_FAILED
        /// An attempt to delay-load a .dll or get a function address in a delay-loaded .dll failed.
        /// </summary>
        DelayLoadFailed = 0x505,

        /// <summary>
        /// ERROR_VDM_DISALLOWED
        /// %1 is a 16-bit application. You do not have permissions to execute 16-bit applications. Check your permissions with your system administrator.
        /// </summary>
        VdmDisallowed = 0x506,

        /// <summary>
        /// ERROR_UNIDENTIFIED_ERROR
        /// Insufficient information exists to identify the cause of failure.
        /// </summary>
        UnidentifiedError = 0x507,

        /// <summary>
        /// ERROR_INVALID_CRUNTIME_PARAMETER
        /// The parameter passed to a C runtime function is incorrect.
        /// </summary>
        InvalidCruntimeParameter = 0x508,

        /// <summary>
        /// ERROR_BEYOND_VDL
        /// The operation occurred beyond the valid data length of the file.
        /// </summary>
        BeyondVdl = 0x509,

        /// <summary>
        /// ERROR_INCOMPATIBLE_SERVICE_SID_TYPE
        /// The service start failed since one or more services in the same process have an incompatible service SID type setting. A service with restricted service SID type can only coexist in the same process with other services with a restricted SID type. If the service SID type for this service was just configured, the hosting process must be restarted in order to start this service.
        /// On Windows Server 2003 and Windows XP, an unrestricted service cannot coexist in the same process with other services. The service with the unrestricted service SID type must be moved to an owned process in order to start this service.
        /// </summary>
        IncompatibleServiceSidType = 0x50A,

        /// <summary>
        /// ERROR_DRIVER_PROCESS_TERMINATED
        /// The process hosting the driver for this device has been terminated.
        /// </summary>
        DriverProcessTerminated = 0x50B,

        /// <summary>
        /// ERROR_IMPLEMENTATION_LIMIT
        /// An operation attempted to exceed an implementation-defined limit.
        /// </summary>
        ImplementationLimit = 0x50C,

        /// <summary>
        /// ERROR_PROCESS_IS_PROTECTED
        /// Either the target process, or the target thread's containing process, is a protected process.
        /// </summary>
        ProcessIsProtected = 0x50D,

        /// <summary>
        /// ERROR_SERVICE_NOTIFY_CLIENT_LAGGING
        /// The service notification client is lagging too far behind the current state of services in the machine.
        /// </summary>
        ServiceNotifyClientLagging = 0x50E,

        /// <summary>
        /// ERROR_DISK_QUOTA_EXCEEDED
        /// The requested file operation failed because the storage quota was exceeded. To free up disk space, move files to a different location or delete unnecessary files. For more information, contact your system administrator.
        /// </summary>
        DiskQuotaExceeded = 0x50F,

        /// <summary>
        /// ERROR_CONTENT_BLOCKED
        /// The requested file operation failed because the storage policy blocks that type of file. For more information, contact your system administrator.
        /// </summary>
        ContentBlocked = 0x510,

        /// <summary>
        /// ERROR_INCOMPATIBLE_SERVICE_PRIVILEGE
        /// A privilege that the service requires to function properly does not exist in the service account configuration. You may use the Services Microsoft Management Console (MMC) snap-in (services.msc) and the Local Security Settings MMC snap-in (secpol.msc) to view the service configuration and the account configuration.
        /// </summary>
        IncompatibleServicePrivilege = 0x511,

        /// <summary>
        /// ERROR_APP_HANG
        /// A thread involved in this operation appears to be unresponsive.
        /// </summary>
        AppHang = 0x512,

        /// <summary>
        /// ERROR_INVALID_LABEL
        /// Indicates a particular Security ID may not be assigned as the label of an object.
        /// </summary>
        InvalidLabel = 0x513,

        /// <summary>
        /// ERROR_NOT_ALL_ASSIGNED
        /// Not all privileges or groups referenced are assigned to the caller.
        /// </summary>
        NotAllAssigned = 0x514,

        /// <summary>
        /// ERROR_SOME_NOT_MAPPED
        /// Some mapping between account names and security IDs was not done.
        /// </summary>
        SomeNotMapped = 0x515,

        /// <summary>
        /// ERROR_NO_QUOTAS_FOR_ACCOUNT
        /// No system quota limits are specifically set for this account.
        /// </summary>
        NoQuotasForAccount = 0x516,

        /// <summary>
        /// ERROR_LOCAL_USER_SESSION_KEY
        /// No encryption key is available. A well-known encryption key was returned.
        /// </summary>
        LocalUserSessionKey = 0x517,

        /// <summary>
        /// ERROR_NULL_LM_PASSWORD
        /// The password is too complex to be converted to a LAN Manager password. The LAN Manager password returned is a NULL string.
        /// </summary>
        NullLmPassword = 0x518,

        /// <summary>
        /// ERROR_UNKNOWN_REVISION
        /// The revision level is unknown.
        /// </summary>
        UnknownRevision = 0x519,

        /// <summary>
        /// ERROR_REVISION_MISMATCH
        /// Indicates two revision levels are incompatible.
        /// </summary>
        RevisionMismatch = 0x51A,

        /// <summary>
        /// ERROR_INVALID_OWNER
        /// This security ID may not be assigned as the owner of this object.
        /// </summary>
        InvalidOwner = 0x51B,

        /// <summary>
        /// ERROR_INVALID_PRIMARY_GROUP
        /// This security ID may not be assigned as the primary group of an object.
        /// </summary>
        InvalidPrimaryGroup = 0x51C,

        /// <summary>
        /// ERROR_NO_IMPERSONATION_TOKEN
        /// An attempt has been made to operate on an impersonation token by a thread that is not currently impersonating a client.
        /// </summary>
        NoImpersonationToken = 0x51D,

        /// <summary>
        /// ERROR_CANT_DISABLE_MANDATORY
        /// The group may not be disabled.
        /// </summary>
        CantDisableMandatory = 0x51E,

        /// <summary>
        /// ERROR_NO_LOGON_SERVERS
        /// There are currently no logon servers available to service the logon request.
        /// </summary>
        NoLogonServers = 0x51F,

        /// <summary>
        /// ERROR_NO_SUCH_LOGON_SESSION
        /// A specified logon session does not exist. It may already have been terminated.
        /// </summary>
        NoSuchLogonSession = 0x520,

        /// <summary>
        /// ERROR_NO_SUCH_PRIVILEGE
        /// A specified privilege does not exist.
        /// </summary>
        NoSuchPrivilege = 0x521,

        /// <summary>
        /// ERROR_PRIVILEGE_NOT_HELD
        /// A required privilege is not held by the client.
        /// </summary>
        PrivilegeNotHeld = 0x522,

        /// <summary>
        /// ERROR_INVALID_ACCOUNT_NAME
        /// The name provided is not a properly formed account name.
        /// </summary>
        InvalidAccountName = 0x523,

        /// <summary>
        /// ERROR_USER_EXISTS
        /// The specified account already exists.
        /// </summary>
        UserExists = 0x524,

        /// <summary>
        /// ERROR_NO_SUCH_USER
        /// The specified account does not exist.
        /// </summary>
        NoSuchUser = 0x525,

        /// <summary>
        /// ERROR_GROUP_EXISTS
        /// The specified group already exists.
        /// </summary>
        GroupExists = 0x526,

        /// <summary>
        /// ERROR_NO_SUCH_GROUP
        /// The specified group does not exist.
        /// </summary>
        NoSuchGroup = 0x527,

        /// <summary>
        /// ERROR_MEMBER_IN_GROUP
        /// Either the specified user account is already a member of the specified group, or the specified group cannot be deleted because it contains a member.
        /// </summary>
        MemberInGroup = 0x528,

        /// <summary>
        /// ERROR_MEMBER_NOT_IN_GROUP
        /// The specified user account is not a member of the specified group account.
        /// </summary>
        MemberNotInGroup = 0x529,

        /// <summary>
        /// ERROR_LAST_ADMIN
        /// This operation is disallowed as it could result in an administration account being disabled, deleted or unable to log on.
        /// </summary>
        LastAdmin = 0x52A,

        /// <summary>
        /// ERROR_WRONG_PASSWORD
        /// Unable to update the password. The value provided as the current password is incorrect.
        /// </summary>
        WrongPassword = 0x52B,

        /// <summary>
        /// ERROR_ILL_FORMED_PASSWORD
        /// Unable to update the password. The value provided for the new password contains values that are not allowed in passwords.
        /// </summary>
        IllFormedPassword = 0x52C,

        /// <summary>
        /// ERROR_PASSWORD_RESTRICTION
        /// Unable to update the password. The value provided for the new password does not meet the length, complexity, or history requirements of the domain.
        /// </summary>
        PasswordRestriction = 0x52D,

        /// <summary>
        /// ERROR_LOGON_FAILURE
        /// The user name or password is incorrect.
        /// </summary>
        LogonFailure = 0x52E,

        /// <summary>
        /// ERROR_ACCOUNT_RESTRICTION
        /// Account restrictions are preventing this user from signing in. For example: blank passwords aren't allowed, sign-in times are limited, or a policy restriction has been enforced.
        /// </summary>
        AccountRestriction = 0x52F,

        /// <summary>
        /// ERROR_INVALID_LOGON_HOURS
        /// Your account has time restrictions that keep you from signing in right now.
        /// </summary>
        InvalidLogonHours = 0x530,

        /// <summary>
        /// ERROR_INVALID_WORKSTATION
        /// This user isn't allowed to sign in to this computer.
        /// </summary>
        InvalidWorkstation = 0x531,

        /// <summary>
        /// ERROR_PASSWORD_EXPIRED
        /// The password for this account has expired.
        /// </summary>
        PasswordExpired = 0x532,

        /// <summary>
        /// ERROR_ACCOUNT_DISABLED
        /// This user can't sign in because this account is currently disabled.
        /// </summary>
        AccountDisabled = 0x533,

        /// <summary>
        /// ERROR_NONE_MAPPED
        /// No mapping between account names and security IDs was done.
        /// </summary>
        NoneMapped = 0x534,

        /// <summary>
        /// ERROR_TOO_MANY_LUIDS_REQUESTED
        /// Too many local user identifiers (LUIDs) were requested at one time.
        /// </summary>
        TooManyLuidsRequested = 0x535,

        /// <summary>
        /// ERROR_LUIDS_EXHAUSTED
        /// No more local user identifiers (LUIDs) are available.
        /// </summary>
        LuidsExhausted = 0x536,

        /// <summary>
        /// ERROR_INVALID_SUB_AUTHORITY
        /// The subauthority part of a security ID is invalid for this particular use.
        /// </summary>
        InvalidSubAuthority = 0x537,

        /// <summary>
        /// ERROR_INVALID_ACL
        /// The access control list (ACL) structure is invalid.
        /// </summary>
        InvalidAcl = 0x538,

        /// <summary>
        /// ERROR_INVALID_SID
        /// The security ID structure is invalid.
        /// </summary>
        InvalidSid = 0x539,

        /// <summary>
        /// ERROR_INVALID_SECURITY_DESCR
        /// The security descriptor structure is invalid.
        /// </summary>
        InvalidSecurityDescr = 0x53A,

        /// <summary>
        /// ERROR_BAD_INHERITANCE_ACL
        /// The inherited access control list (ACL) or access control entry (ACE) could not be built.
        /// </summary>
        BadInheritanceAcl = 0x53C,

        /// <summary>
        /// ERROR_SERVER_DISABLED
        /// The server is currently disabled.
        /// </summary>
        ServerDisabled = 0x53D,

        /// <summary>
        /// ERROR_SERVER_NOT_DISABLED
        /// The server is currently enabled.
        /// </summary>
        ServerNotDisabled = 0x53E,

        /// <summary>
        /// ERROR_INVALID_ID_AUTHORITY
        /// The value provided was an invalid value for an identifier authority.
        /// </summary>
        InvalidIdAuthority = 0x53F,

        /// <summary>
        /// ERROR_ALLOTTED_SPACE_EXCEEDED
        /// No more memory is available for security information updates.
        /// </summary>
        AllottedSpaceExceeded = 0x540,

        /// <summary>
        /// ERROR_INVALID_GROUP_ATTRIBUTES
        /// The specified attributes are invalid, or incompatible with the attributes for the group as a whole.
        /// </summary>
        InvalidGroupAttributes = 0x541,

        /// <summary>
        /// ERROR_BAD_IMPERSONATION_LEVEL
        /// Either a required impersonation level was not provided, or the provided impersonation level is invalid.
        /// </summary>
        BadImpersonationLevel = 0x542,

        /// <summary>
        /// ERROR_CANT_OPEN_ANONYMOUS
        /// Cannot open an anonymous level security token.
        /// </summary>
        CantOpenAnonymous = 0x543,

        /// <summary>
        /// ERROR_BAD_VALIDATION_CLASS
        /// The validation information class requested was invalid.
        /// </summary>
        BadValidationClass = 0x544,

        /// <summary>
        /// ERROR_BAD_TOKEN_TYPE
        /// The type of the token is inappropriate for its attempted use.
        /// </summary>
        BadTokenType = 0x545,

        /// <summary>
        /// ERROR_NO_SECURITY_ON_OBJECT
        /// Unable to perform a security operation on an object that has no associated security.
        /// </summary>
        NoSecurityOnObject = 0x546,

        /// <summary>
        /// ERROR_CANT_ACCESS_DOMAIN_INFO
        /// Configuration information could not be read from the domain controller, either because the machine is unavailable, or access has been denied.
        /// </summary>
        CantAccessDomainInfo = 0x547,

        /// <summary>
        /// ERROR_INVALID_SERVER_STATE
        /// The security account manager (SAM) or local security authority (LSA) server was in the wrong state to perform the security operation.
        /// </summary>
        InvalidServerState = 0x548,

        /// <summary>
        /// ERROR_INVALID_DOMAIN_STATE
        /// The domain was in the wrong state to perform the security operation.
        /// </summary>
        InvalidDomainState = 0x549,

        /// <summary>
        /// ERROR_INVALID_DOMAIN_ROLE
        /// This operation is only allowed for the Primary Domain Controller of the domain.
        /// </summary>
        InvalidDomainRole = 0x54A,

        /// <summary>
        /// ERROR_NO_SUCH_DOMAIN
        /// The specified domain either does not exist or could not be contacted.
        /// </summary>
        NoSuchDomain = 0x54B,

        /// <summary>
        /// ERROR_DOMAIN_EXISTS
        /// The specified domain already exists.
        /// </summary>
        DomainExists = 0x54C,

        /// <summary>
        /// ERROR_DOMAIN_LIMIT_EXCEEDED
        /// An attempt was made to exceed the limit on the number of domains per server.
        /// </summary>
        DomainLimitExceeded = 0x54D,

        /// <summary>
        /// ERROR_INTERNAL_DB_CORRUPTION
        /// Unable to complete the requested operation because of either a catastrophic media failure or a data structure corruption on the disk.
        /// </summary>
        InternalDbCorruption = 0x54E,

        /// <summary>
        /// ERROR_INTERNAL_ERROR
        /// An internal error occurred.
        /// </summary>
        InternalError = 0x54F,

        /// <summary>
        /// ERROR_GENERIC_NOT_MAPPED
        /// Generic access types were contained in an access mask which should already be mapped to nongeneric types.
        /// </summary>
        GenericNotMapped = 0x550,

        /// <summary>
        /// ERROR_BAD_DESCRIPTOR_FORMAT
        /// A security descriptor is not in the right format (absolute or self-relative).
        /// </summary>
        BadDescriptorFormat = 0x551,

        /// <summary>
        /// ERROR_NOT_LOGON_PROCESS
        /// The requested action is restricted for use by logon processes only. The calling process has not registered as a logon process.
        /// </summary>
        NotLogonProcess = 0x552,

        /// <summary>
        /// ERROR_LOGON_SESSION_EXISTS
        /// Cannot start a new logon session with an ID that is already in use.
        /// </summary>
        LogonSessionExists = 0x553,

        /// <summary>
        /// ERROR_NO_SUCH_PACKAGE
        /// A specified authentication package is unknown.
        /// </summary>
        NoSuchPackage = 0x554,

        /// <summary>
        /// ERROR_BAD_LOGON_SESSION_STATE
        /// The logon session is not in a state that is consistent with the requested operation.
        /// </summary>
        BadLogonSessionState = 0x555,

        /// <summary>
        /// ERROR_LOGON_SESSION_COLLISION
        /// The logon session ID is already in use.
        /// </summary>
        LogonSessionCollision = 0x556,

        /// <summary>
        /// ERROR_INVALID_LOGON_TYPE
        /// A logon request contained an invalid logon type value.
        /// </summary>
        InvalidLogonType = 0x557,

        /// <summary>
        /// ERROR_CANNOT_IMPERSONATE
        /// Unable to impersonate using a named pipe until data has been read from that pipe.
        /// </summary>
        CannotImpersonate = 0x558,

        /// <summary>
        /// ERROR_RXACT_INVALID_STATE
        /// The transaction state of a registry subtree is incompatible with the requested operation.
        /// </summary>
        RxactInvalidState = 0x559,

        /// <summary>
        /// ERROR_RXACT_COMMIT_FAILURE
        /// An internal security database corruption has been encountered.
        /// </summary>
        RxactCommitFailure = 0x55A,

        /// <summary>
        /// ERROR_SPECIAL_ACCOUNT
        /// Cannot perform this operation on built-in accounts.
        /// </summary>
        SpecialAccount = 0x55B,

        /// <summary>
        /// ERROR_SPECIAL_GROUP
        /// Cannot perform this operation on this built-in special group.
        /// </summary>
        SpecialGroup = 0x55C,

        /// <summary>
        /// ERROR_SPECIAL_USER
        /// Cannot perform this operation on this built-in special user.
        /// </summary>
        SpecialUser = 0x55D,

        /// <summary>
        /// ERROR_MEMBERS_PRIMARY_GROUP
        /// The user cannot be removed from a group because the group is currently the user's primary group.
        /// </summary>
        MembersPrimaryGroup = 0x55E,

        /// <summary>
        /// ERROR_TOKEN_ALREADY_IN_USE
        /// The token is already in use as a primary token.
        /// </summary>
        TokenAlreadyInUse = 0x55F,

        /// <summary>
        /// ERROR_NO_SUCH_ALIAS
        /// The specified local group does not exist.
        /// </summary>
        NoSuchAlias = 0x560,

        /// <summary>
        /// ERROR_MEMBER_NOT_IN_ALIAS
        /// The specified account name is not a member of the group.
        /// </summary>
        MemberNotInAlias = 0x561,

        /// <summary>
        /// ERROR_MEMBER_IN_ALIAS
        /// The specified account name is already a member of the group.
        /// </summary>
        MemberInAlias = 0x562,

        /// <summary>
        /// ERROR_ALIAS_EXISTS
        /// The specified local group already exists.
        /// </summary>
        AliasExists = 0x563,

        /// <summary>
        /// ERROR_LOGON_NOT_GRANTED
        /// Logon failure: the user has not been granted the requested logon type at this computer.
        /// </summary>
        LogonNotGranted = 0x564,

        /// <summary>
        /// ERROR_TOO_MANY_SECRETS
        /// The maximum number of secrets that may be stored in a single system has been exceeded.
        /// </summary>
        TooManySecrets = 0x565,

        /// <summary>
        /// ERROR_SECRET_TOO_LONG
        /// The length of a secret exceeds the maximum length allowed.
        /// </summary>
        SecretTooLong = 0x566,

        /// <summary>
        /// ERROR_INTERNAL_DB_ERROR
        /// The local security authority database contains an internal inconsistency.
        /// </summary>
        InternalDbError = 0x567,

        /// <summary>
        /// ERROR_TOO_MANY_CONTEXT_IDS
        /// During a logon attempt, the user's security context accumulated too many security IDs.
        /// </summary>
        TooManyContextIds = 0x568,

        /// <summary>
        /// ERROR_LOGON_TYPE_NOT_GRANTED
        /// Logon failure: the user has not been granted the requested logon type at this computer.
        /// </summary>
        LogonTypeNotGranted = 0x569,

        /// <summary>
        /// ERROR_NT_CROSS_ENCRYPTION_REQUIRED
        /// A cross-encrypted password is necessary to change a user password.
        /// </summary>
        NtCrossEncryptionRequired = 0x56A,

        /// <summary>
        /// ERROR_NO_SUCH_MEMBER
        /// A member could not be added to or removed from the local group because the member does not exist.
        /// </summary>
        NoSuchMember = 0x56B,

        /// <summary>
        /// ERROR_INVALID_MEMBER
        /// A new member could not be added to a local group because the member has the wrong account type.
        /// </summary>
        InvalidMember = 0x56C,

        /// <summary>
        /// ERROR_TOO_MANY_SIDS
        /// Too many security IDs have been specified.
        /// </summary>
        TooManySids = 0x56D,

        /// <summary>
        /// ERROR_LM_CROSS_ENCRYPTION_REQUIRED
        /// A cross-encrypted password is necessary to change this user password.
        /// </summary>
        LmCrossEncryptionRequired = 0x56E,

        /// <summary>
        /// ERROR_NO_INHERITANCE
        /// Indicates an ACL contains no inheritable components.
        /// </summary>
        NoInheritance = 0x56F,

        /// <summary>
        /// ERROR_FILE_CORRUPT
        /// The file or directory is corrupted and unreadable.
        /// </summary>
        FileCorrupt = 0x570,

        /// <summary>
        /// ERROR_DISK_CORRUPT
        /// The disk structure is corrupted and unreadable.
        /// </summary>
        DiskCorrupt = 0x571,

        /// <summary>
        /// ERROR_NO_USER_SESSION_KEY
        /// There is no user session key for the specified logon session.
        /// </summary>
        NoUserSessionKey = 0x572,

        /// <summary>
        /// ERROR_LICENSE_QUOTA_EXCEEDED
        /// The service being accessed is licensed for a particular number of connections. No more connections can be made to the service at this time because there are already as many connections as the service can accept.
        /// </summary>
        LicenseQuotaExceeded = 0x573,

        /// <summary>
        /// ERROR_WRONG_TARGET_NAME
        /// The target account name is incorrect.
        /// </summary>
        WrongTargetName = 0x574,

        /// <summary>
        /// ERROR_MUTUAL_AUTH_FAILED
        /// Mutual Authentication failed. The server's password is out of date at the domain controller.
        /// </summary>
        MutualAuthFailed = 0x575,

        /// <summary>
        /// ERROR_TIME_SKEW
        /// There is a time and/or date difference between the client and server.
        /// </summary>
        TimeSkew = 0x576,

        /// <summary>
        /// ERROR_CURRENT_DOMAIN_NOT_ALLOWED
        /// This operation cannot be performed on the current domain.
        /// </summary>
        CurrentDomainNotAllowed = 0x577,

        /// <summary>
        /// ERROR_INVALID_WINDOW_HANDLE
        /// Invalid window handle.
        /// </summary>
        InvalidWindowHandle = 0x578,

        /// <summary>
        /// ERROR_INVALID_MENU_HANDLE
        /// Invalid menu handle.
        /// </summary>
        InvalidMenuHandle = 0x579,

        /// <summary>
        /// ERROR_INVALID_CURSOR_HANDLE
        /// Invalid cursor handle.
        /// </summary>
        InvalidCursorHandle = 0x57A,

        /// <summary>
        /// ERROR_INVALID_ACCEL_HANDLE
        /// Invalid accelerator table handle.
        /// </summary>
        InvalidAccelHandle = 0x57B,

        /// <summary>
        /// ERROR_INVALID_HOOK_HANDLE
        /// Invalid hook handle.
        /// </summary>
        InvalidHookHandle = 0x57C,

        /// <summary>
        /// ERROR_INVALID_DWP_HANDLE
        /// Invalid handle to a multiple-window position structure.
        /// </summary>
        InvalidDwpHandle = 0x57D,

        /// <summary>
        /// ERROR_TLW_WITH_WSCHILD
        /// Cannot create a top-level child window.
        /// </summary>
        TlwWithWschild = 0x57E,

        /// <summary>
        /// ERROR_CANNOT_FIND_WND_CLASS
        /// Cannot find window class.
        /// </summary>
        CannotFindWndClass = 0x57F,

        /// <summary>
        /// ERROR_WINDOW_OF_OTHER_THREAD
        /// Invalid window; it belongs to other thread.
        /// </summary>
        WindowOfOtherThread = 0x580,

        /// <summary>
        /// ERROR_HOTKEY_ALREADY_REGISTERED
        /// Hot key is already registered.
        /// </summary>
        HotkeyAlreadyRegistered = 0x581,

        /// <summary>
        /// ERROR_CLASS_ALREADY_EXISTS
        /// Class already exists.
        /// </summary>
        ClassAlreadyExists = 0x582,

        /// <summary>
        /// ERROR_CLASS_DOES_NOT_EXIST
        /// Class does not exist.
        /// </summary>
        ClassDoesNotExist = 0x583,

        /// <summary>
        /// ERROR_CLASS_HAS_WINDOWS
        /// Class still has open windows.
        /// </summary>
        ClassHasWindows = 0x584,

        /// <summary>
        /// ERROR_INVALID_INDEX
        /// Invalid index.
        /// </summary>
        InvalidIndex = 0x585,

        /// <summary>
        /// ERROR_INVALID_ICON_HANDLE
        /// Invalid icon handle.
        /// </summary>
        InvalidIconHandle = 0x586,

        /// <summary>
        /// ERROR_PRIVATE_DIALOG_INDEX
        /// Using private DIALOG window words.
        /// </summary>
        PrivateDialogIndex = 0x587,

        /// <summary>
        /// ERROR_LISTBOX_ID_NOT_FOUND
        /// The list box identifier was not found.
        /// </summary>
        ListboxIdNotFound = 0x588,

        /// <summary>
        /// ERROR_NO_WILDCARD_CHARACTERS
        /// No wildcards were found.
        /// </summary>
        NoWildcardCharacters = 0x589,

        /// <summary>
        /// ERROR_CLIPBOARD_NOT_OPEN
        /// Thread does not have a clipboard open.
        /// </summary>
        ClipboardNotOpen = 0x58A,

        /// <summary>
        /// ERROR_HOTKEY_NOT_REGISTERED
        /// Hot key is not registered.
        /// </summary>
        HotkeyNotRegistered = 0x58B,

        /// <summary>
        /// ERROR_WINDOW_NOT_DIALOG
        /// The window is not a valid dialog window.
        /// </summary>
        WindowNotDialog = 0x58C,

        /// <summary>
        /// ERROR_CONTROL_ID_NOT_FOUND
        /// Control ID not found.
        /// </summary>
        ControlIdNotFound = 0x58D,

        /// <summary>
        /// ERROR_INVALID_COMBOBOX_MESSAGE
        /// Invalid message for a combo box because it does not have an edit control.
        /// </summary>
        InvalidComboboxMessage = 0x58E,

        /// <summary>
        /// ERROR_WINDOW_NOT_COMBOBOX
        /// The window is not a combo box.
        /// </summary>
        WindowNotCombobox = 0x58F,

        /// <summary>
        /// ERROR_INVALID_EDIT_HEIGHT
        /// Height must be less than 256.
        /// </summary>
        InvalidEditHeight = 0x590,

        /// <summary>
        /// ERROR_DC_NOT_FOUND
        /// Invalid device context (DC) handle.
        /// </summary>
        DcNotFound = 0x591,

        /// <summary>
        /// ERROR_INVALID_HOOK_FILTER
        /// Invalid hook procedure type.
        /// </summary>
        InvalidHookFilter = 0x592,

        /// <summary>
        /// ERROR_INVALID_FILTER_PROC
        /// Invalid hook procedure.
        /// </summary>
        InvalidFilterProc = 0x593,

        /// <summary>
        /// ERROR_HOOK_NEEDS_HMOD
        /// Cannot set nonlocal hook without a module handle.
        /// </summary>
        HookNeedsHmod = 0x594,

        /// <summary>
        /// ERROR_GLOBAL_ONLY_HOOK
        /// This hook procedure can only be set globally.
        /// </summary>
        GlobalOnlyHook = 0x595,

        /// <summary>
        /// ERROR_JOURNAL_HOOK_SET
        /// The journal hook procedure is already installed.
        /// </summary>
        JournalHookSet = 0x596,

        /// <summary>
        /// ERROR_HOOK_NOT_INSTALLED
        /// The hook procedure is not installed.
        /// </summary>
        HookNotInstalled = 0x597,

        /// <summary>
        /// ERROR_INVALID_LB_MESSAGE
        /// Invalid message for single-selection list box.
        /// </summary>
        InvalidLbMessage = 0x598,

        /// <summary>
        /// ERROR_SETCOUNT_ON_BAD_LB
        /// LB_SETCOUNT sent to non-lazy list box.
        /// </summary>
        SetcountOnBadLb = 0x599,

        /// <summary>
        /// ERROR_LB_WITHOUT_TABSTOPS
        /// This list box does not support tab stops.
        /// </summary>
        LbWithoutTabstops = 0x59A,

        /// <summary>
        /// ERROR_DESTROY_OBJECT_OF_OTHER_THREAD
        /// Cannot destroy object created by another thread.
        /// </summary>
        DestroyObjectOfOtherThread = 0x59B,

        /// <summary>
        /// ERROR_CHILD_WINDOW_MENU
        /// Child windows cannot have menus.
        /// </summary>
        ChildWindowMenu = 0x59C,

        /// <summary>
        /// ERROR_NO_SYSTEM_MENU
        /// The window does not have a system menu.
        /// </summary>
        NoSystemMenu = 0x59D,

        /// <summary>
        /// ERROR_INVALID_MSGBOX_STYLE
        /// Invalid message box style.
        /// </summary>
        InvalidMsgboxStyle = 0x59E,

        /// <summary>
        /// ERROR_INVALID_SPI_VALUE
        /// Invalid system-wide (SPI_*) parameter.
        /// </summary>
        InvalidSpiValue = 0x59F,

        /// <summary>
        /// ERROR_SCREEN_ALREADY_LOCKED
        /// Screen already locked.
        /// </summary>
        ScreenAlreadyLocked = 0x5A0,

        /// <summary>
        /// ERROR_HWNDS_HAVE_DIFF_PARENT
        /// All handles to windows in a multiple-window position structure must have the same parent.
        /// </summary>
        HwndsHaveDiffParent = 0x5A1,

        /// <summary>
        /// ERROR_NOT_CHILD_WINDOW
        /// The window is not a child window.
        /// </summary>
        NotChildWindow = 0x5A2,

        /// <summary>
        /// ERROR_INVALID_GW_COMMAND
        /// Invalid GW_* command.
        /// </summary>
        InvalidGwCommand = 0x5A3,

        /// <summary>
        /// ERROR_INVALID_THREAD_ID
        /// Invalid thread identifier.
        /// </summary>
        InvalidThreadId = 0x5A4,

        /// <summary>
        /// ERROR_NON_MDICHILD_WINDOW
        /// Cannot process a message from a window that is not a multiple document interface (MDI) window.
        /// </summary>
        NonMdichildWindow = 0x5A5,

        /// <summary>
        /// ERROR_POPUP_ALREADY_ACTIVE
        /// Popup menu already active.
        /// </summary>
        PopupAlreadyActive = 0x5A6,

        /// <summary>
        /// ERROR_NO_SCROLLBARS
        /// The window does not have scroll bars.
        /// </summary>
        NoScrollbars = 0x5A7,

        /// <summary>
        /// ERROR_INVALID_SCROLLBAR_RANGE
        /// Scroll bar range cannot be greater than MAXLONG.
        /// </summary>
        InvalidScrollbarRange = 0x5A8,

        /// <summary>
        /// ERROR_INVALID_SHOWWIN_COMMAND
        /// Cannot show or remove the window in the way specified.
        /// </summary>
        InvalidShowwinCommand = 0x5A9,

        /// <summary>
        /// ERROR_NO_SYSTEM_RESOURCES
        /// Insufficient system resources exist to complete the requested service.
        /// </summary>
        NoSystemResources = 0x5AA,

        /// <summary>
        /// ERROR_NONPAGED_SYSTEM_RESOURCES
        /// Insufficient system resources exist to complete the requested service.
        /// </summary>
        NonpagedSystemResources = 0x5AB,

        /// <summary>
        /// ERROR_PAGED_SYSTEM_RESOURCES
        /// Insufficient system resources exist to complete the requested service.
        /// </summary>
        PagedSystemResources = 0x5AC,

        /// <summary>
        /// ERROR_WORKING_SET_QUOTA
        /// Insufficient quota to complete the requested service.
        /// </summary>
        WorkingSetQuota = 0x5AD,

        /// <summary>
        /// ERROR_PAGEFILE_QUOTA
        /// Insufficient quota to complete the requested service.
        /// </summary>
        PagefileQuota = 0x5AE,

        /// <summary>
        /// ERROR_COMMITMENT_LIMIT
        /// The paging file is too small for this operation to complete.
        /// </summary>
        CommitmentLimit = 0x5AF,

        /// <summary>
        /// ERROR_MENU_ITEM_NOT_FOUND
        /// A menu item was not found.
        /// </summary>
        MenuItemNotFound = 0x5B0,

        /// <summary>
        /// ERROR_INVALID_KEYBOARD_HANDLE
        /// Invalid keyboard layout handle.
        /// </summary>
        InvalidKeyboardHandle = 0x5B1,

        /// <summary>
        /// ERROR_HOOK_TYPE_NOT_ALLOWED
        /// Hook type not allowed.
        /// </summary>
        HookTypeNotAllowed = 0x5B2,

        /// <summary>
        /// ERROR_REQUIRES_INTERACTIVE_WINDOWSTATION
        /// This operation requires an interactive window station.
        /// </summary>
        RequiresInteractiveWindowstation = 0x5B3,

        /// <summary>
        /// ERROR_TIMEOUT
        /// This operation returned because the timeout period expired.
        /// </summary>
        Timeout = 0x5B4,

        /// <summary>
        /// ERROR_INVALID_MONITOR_HANDLE
        /// Invalid monitor handle.
        /// </summary>
        InvalidMonitorHandle = 0x5B5,

        /// <summary>
        /// ERROR_INCORRECT_SIZE
        /// Incorrect size argument.
        /// </summary>
        IncorrectSize = 0x5B6,

        /// <summary>
        /// ERROR_SYMLINK_CLASS_DISABLED
        /// The symbolic link cannot be followed because its type is disabled.
        /// </summary>
        SymlinkClassDisabled = 0x5B7,

        /// <summary>
        /// ERROR_SYMLINK_NOT_SUPPORTED
        /// This application does not support the current operation on symbolic links.
        /// </summary>
        SymlinkNotSupported = 0x5B8,

        /// <summary>
        /// ERROR_XML_PARSE_ERROR
        /// Windows was unable to parse the requested XML data.
        /// </summary>
        XmlParseError = 0x5B9,

        /// <summary>
        /// ERROR_XMLDSIG_ERROR
        /// An error was encountered while processing an XML digital signature.
        /// </summary>
        XmldsigError = 0x5BA,

        /// <summary>
        /// ERROR_RESTART_APPLICATION
        /// This application must be restarted.
        /// </summary>
        RestartApplication = 0x5BB,

        /// <summary>
        /// ERROR_WRONG_COMPARTMENT
        /// The caller made the connection request in the wrong routing compartment.
        /// </summary>
        WrongCompartment = 0x5BC,

        /// <summary>
        /// ERROR_AUTHIP_FAILURE
        /// There was an AuthIP failure when attempting to connect to the remote host.
        /// </summary>
        AuthipFailure = 0x5BD,

        /// <summary>
        /// ERROR_NO_NVRAM_RESOURCES
        /// Insufficient NVRAM resources exist to complete the requested service. A reboot might be required.
        /// </summary>
        NoNvramResources = 0x5BE,

        /// <summary>
        /// ERROR_NOT_GUI_PROCESS
        /// Unable to finish the requested operation because the specified process is not a GUI process.
        /// </summary>
        NotGuiProcess = 0x5BF,

        /// <summary>
        /// ERROR_EVENTLOG_FILE_CORRUPT
        /// The event log file is corrupted.
        /// </summary>
        EventlogFileCorrupt = 0x5DC,

        /// <summary>
        /// ERROR_EVENTLOG_CANT_START
        /// No event log file could be opened, so the event logging service did not start.
        /// </summary>
        EventlogCantStart = 0x5DD,

        /// <summary>
        /// ERROR_LOG_FILE_FULL
        /// The event log file is full.
        /// </summary>
        LogFileFull = 0x5DE,

        /// <summary>
        /// ERROR_EVENTLOG_FILE_CHANGED
        /// The event log file has changed between read operations.
        /// </summary>
        EventlogFileChanged = 0x5DF,

        /// <summary>
        /// ERROR_INVALID_TASK_NAME
        /// The specified task name is invalid.
        /// </summary>
        InvalidTaskName = 0x60E,

        /// <summary>
        /// ERROR_INVALID_TASK_INDEX
        /// The specified task index is invalid.
        /// </summary>
        InvalidTaskIndex = 0x60F,

        /// <summary>
        /// ERROR_THREAD_ALREADY_IN_TASK
        /// The specified thread is already joining a task.
        /// </summary>
        ThreadAlreadyInTask = 0x610,

        /// <summary>
        /// ERROR_INSTALL_SERVICE_FAILURE
        /// The Windows Installer Service could not be accessed. This can occur if the Windows Installer is not correctly installed. Contact your support personnel for assistance.
        /// </summary>
        InstallServiceFailure = 0x641,

        /// <summary>
        /// ERROR_INSTALL_USEREXIT
        /// User cancelled installation.
        /// </summary>
        InstallUserexit = 0x642,

        /// <summary>
        /// ERROR_INSTALL_FAILURE
        /// Fatal error during installation.
        /// </summary>
        InstallFailure = 0x643,

        /// <summary>
        /// ERROR_INSTALL_SUSPEND
        /// Installation suspended, incomplete.
        /// </summary>
        InstallSuspend = 0x644,

        /// <summary>
        /// ERROR_UNKNOWN_PRODUCT
        /// This action is only valid for products that are currently installed.
        /// </summary>
        UnknownProduct = 0x645,

        /// <summary>
        /// ERROR_UNKNOWN_FEATURE
        /// Feature ID not registered.
        /// </summary>
        UnknownFeature = 0x646,

        /// <summary>
        /// ERROR_UNKNOWN_COMPONENT
        /// Component ID not registered.
        /// </summary>
        UnknownComponent = 0x647,

        /// <summary>
        /// ERROR_UNKNOWN_PROPERTY
        /// Unknown property.
        /// </summary>
        UnknownProperty = 0x648,

        /// <summary>
        /// ERROR_INVALID_HANDLE_STATE
        /// Handle is in an invalid state.
        /// </summary>
        InvalidHandleState = 0x649,

        /// <summary>
        /// ERROR_BAD_CONFIGURATION
        /// The configuration data for this product is corrupt. Contact your support personnel.
        /// </summary>
        BadConfiguration = 0x64A,

        /// <summary>
        /// ERROR_INDEX_ABSENT
        /// Component qualifier not present.
        /// </summary>
        IndexAbsent = 0x64B,

        /// <summary>
        /// ERROR_INSTALL_SOURCE_ABSENT
        /// The installation source for this product is not available. Verify that the source exists and that you can access it.
        /// </summary>
        InstallSourceAbsent = 0x64C,

        /// <summary>
        /// ERROR_INSTALL_PACKAGE_VERSION
        /// This installation package cannot be installed by the Windows Installer service. You must install a Windows service pack that contains a newer version of the Windows Installer service.
        /// </summary>
        InstallPackageVersion = 0x64D,

        /// <summary>
        /// ERROR_PRODUCT_UNINSTALLED
        /// Product is uninstalled.
        /// </summary>
        ProductUninstalled = 0x64E,

        /// <summary>
        /// ERROR_BAD_QUERY_SYNTAX
        /// SQL query syntax invalid or unsupported.
        /// </summary>
        BadQuerySyntax = 0x64F,

        /// <summary>
        /// ERROR_INVALID_FIELD
        /// Record field does not exist.
        /// </summary>
        InvalidField = 0x650,

        /// <summary>
        /// ERROR_DEVICE_REMOVED
        /// The device has been removed.
        /// </summary>
        DeviceRemoved = 0x651,

        /// <summary>
        /// ERROR_INSTALL_ALREADY_RUNNING
        /// Another installation is already in progress. Complete that installation before proceeding with this install.
        /// </summary>
        InstallAlreadyRunning = 0x652,

        /// <summary>
        /// ERROR_INSTALL_PACKAGE_OPEN_FAILED
        /// This installation package could not be opened. Verify that the package exists and that you can access it, or contact the application vendor to verify that this is a valid Windows Installer package.
        /// </summary>
        InstallPackageOpenFailed = 0x653,

        /// <summary>
        /// ERROR_INSTALL_PACKAGE_INVALID
        /// This installation package could not be opened. Contact the application vendor to verify that this is a valid Windows Installer package.
        /// </summary>
        InstallPackageInvalid = 0x654,

        /// <summary>
        /// ERROR_INSTALL_UI_FAILURE
        /// There was an error starting the Windows Installer service user interface. Contact your support personnel.
        /// </summary>
        InstallUiFailure = 0x655,

        /// <summary>
        /// ERROR_INSTALL_LOG_FAILURE
        /// Error opening installation log file. Verify that the specified log file location exists and that you can write to it.
        /// </summary>
        InstallLogFailure = 0x656,

        /// <summary>
        /// ERROR_INSTALL_LANGUAGE_UNSUPPORTED
        /// The language of this installation package is not supported by your system.
        /// </summary>
        InstallLanguageUnsupported = 0x657,

        /// <summary>
        /// ERROR_INSTALL_TRANSFORM_FAILURE
        /// Error applying transforms. Verify that the specified transform paths are valid.
        /// </summary>
        InstallTransformFailure = 0x658,

        /// <summary>
        /// ERROR_INSTALL_PACKAGE_REJECTED
        /// This installation is forbidden by system policy. Contact your system administrator.
        /// </summary>
        InstallPackageRejected = 0x659,

        /// <summary>
        /// ERROR_FUNCTION_NOT_CALLED
        /// Function could not be executed.
        /// </summary>
        FunctionNotCalled = 0x65A,

        /// <summary>
        /// ERROR_FUNCTION_FAILED
        /// Function failed during execution.
        /// </summary>
        FunctionFailed = 0x65B,

        /// <summary>
        /// ERROR_INVALID_TABLE
        /// Invalid or unknown table specified.
        /// </summary>
        InvalidTable = 0x65C,

        /// <summary>
        /// ERROR_DATATYPE_MISMATCH
        /// Data supplied is of wrong type.
        /// </summary>
        DatatypeMismatch = 0x65D,

        /// <summary>
        /// ERROR_UNSUPPORTED_TYPE
        /// Data of this type is not supported.
        /// </summary>
        UnsupportedType = 0x65E,

        /// <summary>
        /// ERROR_CREATE_FAILED
        /// The Windows Installer service failed to start. Contact your support personnel.
        /// </summary>
        CreateFailed = 0x65F,

        /// <summary>
        /// ERROR_INSTALL_TEMP_UNWRITABLE
        /// The Temp folder is on a drive that is full or is inaccessible. Free up space on the drive or verify that you have write permission on the Temp folder.
        /// </summary>
        InstallTempUnwritable = 0x660,

        /// <summary>
        /// ERROR_INSTALL_PLATFORM_UNSUPPORTED
        /// This installation package is not supported by this processor type. Contact your product vendor.
        /// </summary>
        InstallPlatformUnsupported = 0x661,

        /// <summary>
        /// ERROR_INSTALL_NOTUSED
        /// Component not used on this computer.
        /// </summary>
        InstallNotused = 0x662,

        /// <summary>
        /// ERROR_PATCH_PACKAGE_OPEN_FAILED
        /// This update package could not be opened. Verify that the update package exists and that you can access it, or contact the application vendor to verify that this is a valid Windows Installer update package.
        /// </summary>
        PatchPackageOpenFailed = 0x663,

        /// <summary>
        /// ERROR_PATCH_PACKAGE_INVALID
        /// This update package could not be opened. Contact the application vendor to verify that this is a valid Windows Installer update package.
        /// </summary>
        PatchPackageInvalid = 0x664,

        /// <summary>
        /// ERROR_PATCH_PACKAGE_UNSUPPORTED
        /// This update package cannot be processed by the Windows Installer service. You must install a Windows service pack that contains a newer version of the Windows Installer service.
        /// </summary>
        PatchPackageUnsupported = 0x665,

        /// <summary>
        /// ERROR_PRODUCT_VERSION
        /// Another version of this product is already installed. Installation of this version cannot continue. To configure or remove the existing version of this product, use Add/Remove Programs on the Control Panel.
        /// </summary>
        ProductVersion = 0x666,

        /// <summary>
        /// ERROR_INVALID_COMMAND_LINE
        /// Invalid command line argument. Consult the Windows Installer SDK for detailed command line help.
        /// </summary>
        InvalidCommandLine = 0x667,

        /// <summary>
        /// ERROR_INSTALL_REMOTE_DISALLOWED
        /// Only administrators have permission to add, remove, or configure server software during a Terminal services remote session. If you want to install or configure software on the server, contact your network administrator.
        /// </summary>
        InstallRemoteDisallowed = 0x668,

        /// <summary>
        /// ERROR_SUCCESS_REBOOT_INITIATED
        /// The requested operation completed successfully. The system will be restarted so the changes can take effect.
        /// </summary>
        SuccessRebootInitiated = 0x669,

        /// <summary>
        /// ERROR_PATCH_TARGET_NOT_FOUND
        /// The upgrade cannot be installed by the Windows Installer service because the program to be upgraded may be missing, or the upgrade may update a different version of the program. Verify that the program to be upgraded exists on your computer and that you have the correct upgrade.
        /// </summary>
        PatchTargetNotFound = 0x66A,

        /// <summary>
        /// ERROR_PATCH_PACKAGE_REJECTED
        /// The update package is not permitted by software restriction policy.
        /// </summary>
        PatchPackageRejected = 0x66B,

        /// <summary>
        /// ERROR_INSTALL_TRANSFORM_REJECTED
        /// One or more customizations are not permitted by software restriction policy.
        /// </summary>
        InstallTransformRejected = 0x66C,

        /// <summary>
        /// ERROR_INSTALL_REMOTE_PROHIBITED
        /// The Windows Installer does not permit installation from a Remote Desktop Connection.
        /// </summary>
        InstallRemoteProhibited = 0x66D,

        /// <summary>
        /// ERROR_PATCH_REMOVAL_UNSUPPORTED
        /// Uninstallation of the update package is not supported.
        /// </summary>
        PatchRemovalUnsupported = 0x66E,

        /// <summary>
        /// ERROR_UNKNOWN_PATCH
        /// The update is not applied to this product.
        /// </summary>
        UnknownPatch = 0x66F,

        /// <summary>
        /// ERROR_PATCH_NO_SEQUENCE
        /// No valid sequence could be found for the set of updates.
        /// </summary>
        PatchNoSequence = 0x670,

        /// <summary>
        /// ERROR_PATCH_REMOVAL_DISALLOWED
        /// Update removal was disallowed by policy.
        /// </summary>
        PatchRemovalDisallowed = 0x671,

        /// <summary>
        /// ERROR_INVALID_PATCH_XML
        /// The XML update data is invalid.
        /// </summary>
        InvalidPatchXml = 0x672,

        /// <summary>
        /// ERROR_PATCH_MANAGED_ADVERTISED_PRODUCT
        /// Windows Installer does not permit updating of managed advertised products. At least one feature of the product must be installed before applying the update.
        /// </summary>
        PatchManagedAdvertisedProduct = 0x673,

        /// <summary>
        /// ERROR_INSTALL_SERVICE_SAFEBOOT
        /// The Windows Installer service is not accessible in Safe Mode. Please try again when your computer is not in Safe Mode or you can use System Restore to return your machine to a previous good state.
        /// </summary>
        InstallServiceSafeboot = 0x674,

        /// <summary>
        /// ERROR_FAIL_FAST_EXCEPTION
        /// A fail fast exception occurred. Exception handlers will not be invoked and the process will be terminated immediately.
        /// </summary>
        FailFastException = 0x675,

        /// <summary>
        /// ERROR_INSTALL_REJECTED
        /// The app that you are trying to run is not supported on this version of Windows.
        /// </summary>
        InstallRejected = 0x676,

        /// <summary>
        /// RPC_S_INVALID_STRING_BINDING
        /// The string binding is invalid.
        /// </summary>
        RpcSInvalidStringBinding = 0x6A4,

        /// <summary>
        /// RPC_S_WRONG_KIND_OF_BINDING
        /// The binding handle is not the correct type.
        /// </summary>
        RpcSWrongKindOfBinding = 0x6A5,

        /// <summary>
        /// RPC_S_INVALID_BINDING
        /// The binding handle is invalid.
        /// </summary>
        RpcSInvalidBinding = 0x6A6,

        /// <summary>
        /// RPC_S_PROTSEQ_NOT_SUPPORTED
        /// The RPC protocol sequence is not supported.
        /// </summary>
        RpcSProtseqNotSupported = 0x6A7,

        /// <summary>
        /// RPC_S_INVALID_RPC_PROTSEQ
        /// The RPC protocol sequence is invalid.
        /// </summary>
        RpcSInvalidRpcProtseq = 0x6A8,

        /// <summary>
        /// RPC_S_INVALID_STRING_UUID
        /// The string universal unique identifier (UUID) is invalid.
        /// </summary>
        RpcSInvalidStringUuid = 0x6A9,

        /// <summary>
        /// RPC_S_INVALID_ENDPOINT_FORMAT
        /// The endpoint format is invalid.
        /// </summary>
        RpcSInvalidEndpointFormat = 0x6AA,

        /// <summary>
        /// RPC_S_INVALID_NET_ADDR
        /// The network address is invalid.
        /// </summary>
        RpcSInvalidNetAddr = 0x6AB,

        /// <summary>
        /// RPC_S_NO_ENDPOINT_FOUND
        /// No endpoint was found.
        /// </summary>
        RpcSNoEndpointFound = 0x6AC,

        /// <summary>
        /// RPC_S_INVALID_TIMEOUT
        /// The timeout value is invalid.
        /// </summary>
        RpcSInvalidTimeout = 0x6AD,

        /// <summary>
        /// RPC_S_OBJECT_NOT_FOUND
        /// The object universal unique identifier (UUID) was not found.
        /// </summary>
        RpcSObjectNotFound = 0x6AE,

        /// <summary>
        /// RPC_S_ALREADY_REGISTERED
        /// The object universal unique identifier (UUID) has already been registered.
        /// </summary>
        RpcSAlreadyRegistered = 0x6AF,

        /// <summary>
        /// RPC_S_TYPE_ALREADY_REGISTERED
        /// The type universal unique identifier (UUID) has already been registered.
        /// </summary>
        RpcSTypeAlreadyRegistered = 0x6B0,

        /// <summary>
        /// RPC_S_ALREADY_LISTENING
        /// The RPC server is already listening.
        /// </summary>
        RpcSAlreadyListening = 0x6B1,

        /// <summary>
        /// RPC_S_NO_PROTSEQS_REGISTERED
        /// No protocol sequences have been registered.
        /// </summary>
        RpcSNoProtseqsRegistered = 0x6B2,

        /// <summary>
        /// RPC_S_NOT_LISTENING
        /// The RPC server is not listening.
        /// </summary>
        RpcSNotListening = 0x6B3,

        /// <summary>
        /// RPC_S_UNKNOWN_MGR_TYPE
        /// The manager type is unknown.
        /// </summary>
        RpcSUnknownMgrType = 0x6B4,

        /// <summary>
        /// RPC_S_UNKNOWN_IF
        /// The interface is unknown.
        /// </summary>
        RpcSUnknownIf = 0x6B5,

        /// <summary>
        /// RPC_S_NO_BINDINGS
        /// There are no bindings.
        /// </summary>
        RpcSNoBindings = 0x6B6,

        /// <summary>
        /// RPC_S_NO_PROTSEQS
        /// There are no protocol sequences.
        /// </summary>
        RpcSNoProtseqs = 0x6B7,

        /// <summary>
        /// RPC_S_CANT_CREATE_ENDPOINT
        /// The endpoint cannot be created.
        /// </summary>
        RpcSCantCreateEndpoint = 0x6B8,

        /// <summary>
        /// RPC_S_OUT_OF_RESOURCES
        /// Not enough resources are available to complete this operation.
        /// </summary>
        RpcSOutOfResources = 0x6B9,

        /// <summary>
        /// RPC_S_SERVER_UNAVAILABLE
        /// The RPC server is unavailable.
        /// </summary>
        RpcSServerUnavailable = 0x6BA,

        /// <summary>
        /// RPC_S_SERVER_TOO_BUSY
        /// The RPC server is too busy to complete this operation.
        /// </summary>
        RpcSServerTooBusy = 0x6BB,

        /// <summary>
        /// RPC_S_INVALID_NETWORK_OPTIONS
        /// The network options are invalid.
        /// </summary>
        RpcSInvalidNetworkOptions = 0x6BC,

        /// <summary>
        /// RPC_S_NO_CALL_ACTIVE
        /// There are no remote procedure calls active on this thread.
        /// </summary>
        RpcSNoCallActive = 0x6BD,

        /// <summary>
        /// RPC_S_CALL_FAILED
        /// The remote procedure call failed.
        /// </summary>
        RpcSCallFailed = 0x6BE,

        /// <summary>
        /// RPC_S_CALL_FAILED_DNE
        /// The remote procedure call failed and did not execute.
        /// </summary>
        RpcSCallFailedDne = 0x6BF,

        /// <summary>
        /// RPC_S_PROTOCOL_ERROR
        /// A remote procedure call (RPC) protocol error occurred.
        /// </summary>
        RpcSProtocolError = 0x6C0,

        /// <summary>
        /// RPC_S_PROXY_ACCESS_DENIED
        /// Access to the HTTP proxy is denied.
        /// </summary>
        RpcSProxyAccessDenied = 0x6C1,

        /// <summary>
        /// RPC_S_UNSUPPORTED_TRANS_SYN
        /// The transfer syntax is not supported by the RPC server.
        /// </summary>
        RpcSUnsupportedTransSyn = 0x6C2,

        /// <summary>
        /// RPC_S_UNSUPPORTED_TYPE
        /// The universal unique identifier (UUID) type is not supported.
        /// </summary>
        RpcSUnsupportedType = 0x6C4,

        /// <summary>
        /// RPC_S_INVALID_TAG
        /// The tag is invalid.
        /// </summary>
        RpcSInvalidTag = 0x6C5,

        /// <summary>
        /// RPC_S_INVALID_BOUND
        /// The array bounds are invalid.
        /// </summary>
        RpcSInvalidBound = 0x6C6,

        /// <summary>
        /// RPC_S_NO_ENTRY_NAME
        /// The binding does not contain an entry name.
        /// </summary>
        RpcSNoEntryName = 0x6C7,

        /// <summary>
        /// RPC_S_INVALID_NAME_SYNTAX
        /// The name syntax is invalid.
        /// </summary>
        RpcSInvalidNameSyntax = 0x6C8,

        /// <summary>
        /// RPC_S_UNSUPPORTED_NAME_SYNTAX
        /// The name syntax is not supported.
        /// </summary>
        RpcSUnsupportedNameSyntax = 0x6C9,

        /// <summary>
        /// RPC_S_UUID_NO_ADDRESS
        /// No network address is available to use to construct a universal unique identifier (UUID).
        /// </summary>
        RpcSUuidNoAddress = 0x6CB,

        /// <summary>
        /// RPC_S_DUPLICATE_ENDPOINT
        /// The endpoint is a duplicate.
        /// </summary>
        RpcSDuplicateEndpoint = 0x6CC,

        /// <summary>
        /// RPC_S_UNKNOWN_AUTHN_TYPE
        /// The authentication type is unknown.
        /// </summary>
        RpcSUnknownAuthnType = 0x6CD,

        /// <summary>
        /// RPC_S_MAX_CALLS_TOO_SMALL
        /// The maximum number of calls is too small.
        /// </summary>
        RpcSMaxCallsTooSmall = 0x6CE,

        /// <summary>
        /// RPC_S_STRING_TOO_LONG
        /// The string is too long.
        /// </summary>
        RpcSStringTooLong = 0x6CF,

        /// <summary>
        /// RPC_S_PROTSEQ_NOT_FOUND
        /// The RPC protocol sequence was not found.
        /// </summary>
        RpcSProtseqNotFound = 0x6D0,

        /// <summary>
        /// RPC_S_PROCNUM_OUT_OF_RANGE
        /// The procedure number is out of range.
        /// </summary>
        RpcSProcnumOutOfRange = 0x6D1,

        /// <summary>
        /// RPC_S_BINDING_HAS_NO_AUTH
        /// The binding does not contain any authentication information.
        /// </summary>
        RpcSBindingHasNoAuth = 0x6D2,

        /// <summary>
        /// RPC_S_UNKNOWN_AUTHN_SERVICE
        /// The authentication service is unknown.
        /// </summary>
        RpcSUnknownAuthnService = 0x6D3,

        /// <summary>
        /// RPC_S_UNKNOWN_AUTHN_LEVEL
        /// The authentication level is unknown.
        /// </summary>
        RpcSUnknownAuthnLevel = 0x6D4,

        /// <summary>
        /// RPC_S_INVALID_AUTH_IDENTITY
        /// The security context is invalid.
        /// </summary>
        RpcSInvalidAuthIdentity = 0x6D5,

        /// <summary>
        /// RPC_S_UNKNOWN_AUTHZ_SERVICE
        /// The authorization service is unknown.
        /// </summary>
        RpcSUnknownAuthzService = 0x6D6,

        /// <summary>
        /// EPT_S_INVALID_ENTRY
        /// The entry is invalid.
        /// </summary>
        EptSInvalidEntry = 0x6D7,

        /// <summary>
        /// EPT_S_CANT_PERFORM_OP
        /// The server endpoint cannot perform the operation.
        /// </summary>
        EptSCantPerformOp = 0x6D8,

        /// <summary>
        /// EPT_S_NOT_REGISTERED
        /// There are no more endpoints available from the endpoint mapper.
        /// </summary>
        EptSNotRegistered = 0x6D9,

        /// <summary>
        /// RPC_S_NOTHING_TO_EXPORT
        /// No interfaces have been exported.
        /// </summary>
        RpcSNothingToExport = 0x6DA,

        /// <summary>
        /// RPC_S_INCOMPLETE_NAME
        /// The entry name is incomplete.
        /// </summary>
        RpcSIncompleteName = 0x6DB,

        /// <summary>
        /// RPC_S_INVALID_VERS_OPTION
        /// The version option is invalid.
        /// </summary>
        RpcSInvalidVersOption = 0x6DC,

        /// <summary>
        /// RPC_S_NO_MORE_MEMBERS
        /// There are no more members.
        /// </summary>
        RpcSNoMoreMembers = 0x6DD,

        /// <summary>
        /// RPC_S_NOT_ALL_OBJS_UNEXPORTED
        /// There is nothing to unexport.
        /// </summary>
        RpcSNotAllObjsUnexported = 0x6DE,

        /// <summary>
        /// RPC_S_INTERFACE_NOT_FOUND
        /// The interface was not found.
        /// </summary>
        RpcSInterfaceNotFound = 0x6DF,

        /// <summary>
        /// RPC_S_ENTRY_ALREADY_EXISTS
        /// The entry already exists.
        /// </summary>
        RpcSEntryAlreadyExists = 0x6E0,

        /// <summary>
        /// RPC_S_ENTRY_NOT_FOUND
        /// The entry is not found.
        /// </summary>
        RpcSEntryNotFound = 0x6E1,

        /// <summary>
        /// RPC_S_NAME_SERVICE_UNAVAILABLE
        /// The name service is unavailable.
        /// </summary>
        RpcSNameServiceUnavailable = 0x6E2,

        /// <summary>
        /// RPC_S_INVALID_NAF_ID
        /// The network address family is invalid.
        /// </summary>
        RpcSInvalidNafId = 0x6E3,

        /// <summary>
        /// RPC_S_CANNOT_SUPPORT
        /// The requested operation is not supported.
        /// </summary>
        RpcSCannotSupport = 0x6E4,

        /// <summary>
        /// RPC_S_NO_CONTEXT_AVAILABLE
        /// No security context is available to allow impersonation.
        /// </summary>
        RpcSNoContextAvailable = 0x6E5,

        /// <summary>
        /// RPC_S_INTERNAL_ERROR
        /// An internal error occurred in a remote procedure call (RPC).
        /// </summary>
        RpcSInternalError = 0x6E6,

        /// <summary>
        /// RPC_S_ZERO_DIVIDE
        /// The RPC server attempted an integer division by zero.
        /// </summary>
        RpcSZeroDivide = 0x6E7,

        /// <summary>
        /// RPC_S_ADDRESS_ERROR
        /// An addressing error occurred in the RPC server.
        /// </summary>
        RpcSAddressError = 0x6E8,

        /// <summary>
        /// RPC_S_FP_DIV_ZERO
        /// A floating-point operation at the RPC server caused a division by zero.
        /// </summary>
        RpcSFpDivZero = 0x6E9,

        /// <summary>
        /// RPC_S_FP_UNDERFLOW
        /// A floating-point underflow occurred at the RPC server.
        /// </summary>
        RpcSFpUnderflow = 0x6EA,

        /// <summary>
        /// RPC_S_FP_OVERFLOW
        /// A floating-point overflow occurred at the RPC server.
        /// </summary>
        RpcSFpOverflow = 0x6EB,

        /// <summary>
        /// RPC_X_NO_MORE_ENTRIES
        /// The list of RPC servers available for the binding of auto handles has been exhausted.
        /// </summary>
        RpcXNoMoreEntries = 0x6EC,

        /// <summary>
        /// RPC_X_SS_CHAR_TRANS_OPEN_FAIL
        /// Unable to open the character translation table file.
        /// </summary>
        RpcXSsCharTransOpenFail = 0x6ED,

        /// <summary>
        /// RPC_X_SS_CHAR_TRANS_SHORT_FILE
        /// The file containing the character translation table has fewer than 512 bytes.
        /// </summary>
        RpcXSsCharTransShortFile = 0x6EE,

        /// <summary>
        /// RPC_X_SS_IN_NULL_CONTEXT
        /// A null context handle was passed from the client to the host during a remote procedure call.
        /// </summary>
        RpcXSsInNullContext = 0x6EF,

        /// <summary>
        /// RPC_X_SS_CONTEXT_DAMAGED
        /// The context handle changed during a remote procedure call.
        /// </summary>
        RpcXSsContextDamaged = 0x6F1,

        /// <summary>
        /// RPC_X_SS_HANDLES_MISMATCH
        /// The binding handles passed to a remote procedure call do not match.
        /// </summary>
        RpcXSsHandlesMismatch = 0x6F2,

        /// <summary>
        /// RPC_X_SS_CANNOT_GET_CALL_HANDLE
        /// The stub is unable to get the remote procedure call handle.
        /// </summary>
        RpcXSsCannotGetCallHandle = 0x6F3,

        /// <summary>
        /// RPC_X_NULL_REF_POINTER
        /// A null reference pointer was passed to the stub.
        /// </summary>
        RpcXNullRefPointer = 0x6F4,

        /// <summary>
        /// RPC_X_ENUM_VALUE_OUT_OF_RANGE
        /// The enumeration value is out of range.
        /// </summary>
        RpcXEnumValueOutOfRange = 0x6F5,

        /// <summary>
        /// RPC_X_BYTE_COUNT_TOO_SMALL
        /// The byte count is too small.
        /// </summary>
        RpcXByteCountTooSmall = 0x6F6,

        /// <summary>
        /// RPC_X_BAD_STUB_DATA
        /// The stub received bad data.
        /// </summary>
        RpcXBadStubData = 0x6F7,

        /// <summary>
        /// ERROR_INVALID_USER_BUFFER
        /// The supplied user buffer is not valid for the requested operation.
        /// </summary>
        InvalidUserBuffer = 0x6F8,

        /// <summary>
        /// ERROR_UNRECOGNIZED_MEDIA
        /// The disk media is not recognized. It may not be formatted.
        /// </summary>
        UnrecognizedMedia = 0x6F9,

        /// <summary>
        /// ERROR_NO_TRUST_LSA_SECRET
        /// The workstation does not have a trust secret.
        /// </summary>
        NoTrustLsaSecret = 0x6FA,

        /// <summary>
        /// ERROR_NO_TRUST_SAM_ACCOUNT
        /// The security database on the server does not have a computer account for this workstation trust relationship.
        /// </summary>
        NoTrustSamAccount = 0x6FB,

        /// <summary>
        /// ERROR_TRUSTED_DOMAIN_FAILURE
        /// The trust relationship between the primary domain and the trusted domain failed.
        /// </summary>
        TrustedDomainFailure = 0x6FC,

        /// <summary>
        /// ERROR_TRUSTED_RELATIONSHIP_FAILURE
        /// The trust relationship between this workstation and the primary domain failed.
        /// </summary>
        TrustedRelationshipFailure = 0x6FD,

        /// <summary>
        /// ERROR_TRUST_FAILURE
        /// The network logon failed.
        /// </summary>
        TrustFailure = 0x6FE,

        /// <summary>
        /// RPC_S_CALL_IN_PROGRESS
        /// A remote procedure call is already in progress for this thread.
        /// </summary>
        RpcSCallInProgress = 0x6FF,

        /// <summary>
        /// ERROR_NETLOGON_NOT_STARTED
        /// An attempt was made to logon, but the network logon service was not started.
        /// </summary>
        NetlogonNotStarted = 0x700,

        /// <summary>
        /// ERROR_ACCOUNT_EXPIRED
        /// The user's account has expired.
        /// </summary>
        AccountExpired = 0x701,

        /// <summary>
        /// ERROR_REDIRECTOR_HAS_OPEN_HANDLES
        /// The redirector is in use and cannot be unloaded.
        /// </summary>
        RedirectorHasOpenHandles = 0x702,

        /// <summary>
        /// ERROR_PRINTER_DRIVER_ALREADY_INSTALLED
        /// The specified printer driver is already installed.
        /// </summary>
        PrinterDriverAlreadyInstalled = 0x703,

        /// <summary>
        /// ERROR_UNKNOWN_PORT
        /// The specified port is unknown.
        /// </summary>
        UnknownPort = 0x704,

        /// <summary>
        /// ERROR_UNKNOWN_PRINTER_DRIVER
        /// The printer driver is unknown.
        /// </summary>
        UnknownPrinterDriver = 0x705,

        /// <summary>
        /// ERROR_UNKNOWN_PRINTPROCESSOR
        /// The print processor is unknown.
        /// </summary>
        UnknownPrintprocessor = 0x706,

        /// <summary>
        /// ERROR_INVALID_SEPARATOR_FILE
        /// The specified separator file is invalid.
        /// </summary>
        InvalidSeparatorFile = 0x707,

        /// <summary>
        /// ERROR_INVALID_PRIORITY
        /// The specified priority is invalid.
        /// </summary>
        InvalidPriority = 0x708,

        /// <summary>
        /// ERROR_INVALID_PRINTER_NAME
        /// The printer name is invalid.
        /// </summary>
        InvalidPrinterName = 0x709,

        /// <summary>
        /// ERROR_PRINTER_ALREADY_EXISTS
        /// The printer already exists.
        /// </summary>
        PrinterAlreadyExists = 0x70A,

        /// <summary>
        /// ERROR_INVALID_PRINTER_COMMAND
        /// The printer command is invalid.
        /// </summary>
        InvalidPrinterCommand = 0x70B,

        /// <summary>
        /// ERROR_INVALID_DATATYPE
        /// The specified datatype is invalid.
        /// </summary>
        InvalidDatatype = 0x70C,

        /// <summary>
        /// ERROR_INVALID_ENVIRONMENT
        /// The environment specified is invalid.
        /// </summary>
        InvalidEnvironment = 0x70D,

        /// <summary>
        /// RPC_S_NO_MORE_BINDINGS
        /// There are no more bindings.
        /// </summary>
        RpcSNoMoreBindings = 0x70E,

        /// <summary>
        /// ERROR_NOLOGON_INTERDOMAIN_TRUST_ACCOUNT
        /// The account used is an interdomain trust account. Use your global user account or local user account to access this server.
        /// </summary>
        NologonInterdomainTrustAccount = 0x70F,

        /// <summary>
        /// ERROR_NOLOGON_WORKSTATION_TRUST_ACCOUNT
        /// The account used is a computer account. Use your global user account or local user account to access this server.
        /// </summary>
        NologonWorkstationTrustAccount = 0x710,

        /// <summary>
        /// ERROR_NOLOGON_SERVER_TRUST_ACCOUNT
        /// The account used is a server trust account. Use your global user account or local user account to access this server.
        /// </summary>
        NologonServerTrustAccount = 0x711,

        /// <summary>
        /// ERROR_DOMAIN_TRUST_INCONSISTENT
        /// The name or security ID (SID) of the domain specified is inconsistent with the trust information for that domain.
        /// </summary>
        DomainTrustInconsistent = 0x712,

        /// <summary>
        /// ERROR_SERVER_HAS_OPEN_HANDLES
        /// The server is in use and cannot be unloaded.
        /// </summary>
        ServerHasOpenHandles = 0x713,

        /// <summary>
        /// ERROR_RESOURCE_DATA_NOT_FOUND
        /// The specified image file did not contain a resource section.
        /// </summary>
        ResourceDataNotFound = 0x714,

        /// <summary>
        /// ERROR_RESOURCE_TYPE_NOT_FOUND
        /// The specified resource type cannot be found in the image file.
        /// </summary>
        ResourceTypeNotFound = 0x715,

        /// <summary>
        /// ERROR_RESOURCE_NAME_NOT_FOUND
        /// The specified resource name cannot be found in the image file.
        /// </summary>
        ResourceNameNotFound = 0x716,

        /// <summary>
        /// ERROR_RESOURCE_LANG_NOT_FOUND
        /// The specified resource language ID cannot be found in the image file.
        /// </summary>
        ResourceLangNotFound = 0x717,

        /// <summary>
        /// ERROR_NOT_ENOUGH_QUOTA
        /// Not enough quota is available to process this command.
        /// </summary>
        NotEnoughQuota = 0x718,

        /// <summary>
        /// RPC_S_NO_INTERFACES
        /// No interfaces have been registered.
        /// </summary>
        RpcSNoInterfaces = 0x719,

        /// <summary>
        /// RPC_S_CALL_CANCELLED
        /// The remote procedure call was cancelled.
        /// </summary>
        RpcSCallCancelled = 0x71A,

        /// <summary>
        /// RPC_S_BINDING_INCOMPLETE
        /// The binding handle does not contain all required information.
        /// </summary>
        RpcSBindingIncomplete = 0x71B,

        /// <summary>
        /// RPC_S_COMM_FAILURE
        /// A communications failure occurred during a remote procedure call.
        /// </summary>
        RpcSCommFailure = 0x71C,

        /// <summary>
        /// RPC_S_UNSUPPORTED_AUTHN_LEVEL
        /// The requested authentication level is not supported.
        /// </summary>
        RpcSUnsupportedAuthnLevel = 0x71D,

        /// <summary>
        /// RPC_S_NO_PRINC_NAME
        /// No principal name registered.
        /// </summary>
        RpcSNoPrincName = 0x71E,

        /// <summary>
        /// RPC_S_NOT_RPC_ERROR
        /// The error specified is not a valid Windows RPC error code.
        /// </summary>
        RpcSNotRpcError = 0x71F,

        /// <summary>
        /// RPC_S_UUID_LOCAL_ONLY
        /// A UUID that is valid only on this computer has been allocated.
        /// </summary>
        RpcSUuidLocalOnly = 0x720,

        /// <summary>
        /// RPC_S_SEC_PKG_ERROR
        /// A security package specific error occurred.
        /// </summary>
        RpcSSecPkgError = 0x721,

        /// <summary>
        /// RPC_S_NOT_CANCELLED
        /// Thread is not canceled.
        /// </summary>
        RpcSNotCancelled = 0x722,

        /// <summary>
        /// RPC_X_INVALID_ES_ACTION
        /// Invalid operation on the encoding/decoding handle.
        /// </summary>
        RpcXInvalidEsAction = 0x723,

        /// <summary>
        /// RPC_X_WRONG_ES_VERSION
        /// Incompatible version of the serializing package.
        /// </summary>
        RpcXWrongEsVersion = 0x724,

        /// <summary>
        /// RPC_X_WRONG_STUB_VERSION
        /// Incompatible version of the RPC stub.
        /// </summary>
        RpcXWrongStubVersion = 0x725,

        /// <summary>
        /// RPC_X_INVALID_PIPE_OBJECT
        /// The RPC pipe object is invalid or corrupted.
        /// </summary>
        RpcXInvalidPipeObject = 0x726,

        /// <summary>
        /// RPC_X_WRONG_PIPE_ORDER
        /// An invalid operation was attempted on an RPC pipe object.
        /// </summary>
        RpcXWrongPipeOrder = 0x727,

        /// <summary>
        /// RPC_X_WRONG_PIPE_VERSION
        /// Unsupported RPC pipe version.
        /// </summary>
        RpcXWrongPipeVersion = 0x728,

        /// <summary>
        /// RPC_S_COOKIE_AUTH_FAILED
        /// HTTP proxy server rejected the connection because the cookie authentication failed.
        /// </summary>
        RpcSCookieAuthFailed = 0x729,

        /// <summary>
        /// RPC_S_GROUP_MEMBER_NOT_FOUND
        /// The group member was not found.
        /// </summary>
        RpcSGroupMemberNotFound = 0x76A,

        /// <summary>
        /// EPT_S_CANT_CREATE
        /// The endpoint mapper database entry could not be created.
        /// </summary>
        EptSCantCreate = 0x76B,

        /// <summary>
        /// RPC_S_INVALID_OBJECT
        /// The object universal unique identifier (UUID) is the nil UUID.
        /// </summary>
        RpcSInvalidObject = 0x76C,

        /// <summary>
        /// ERROR_INVALID_TIME
        /// The specified time is invalid.
        /// </summary>
        InvalidTime = 0x76D,

        /// <summary>
        /// ERROR_INVALID_FORM_NAME
        /// The specified form name is invalid.
        /// </summary>
        InvalidFormName = 0x76E,

        /// <summary>
        /// ERROR_INVALID_FORM_SIZE
        /// The specified form size is invalid.
        /// </summary>
        InvalidFormSize = 0x76F,

        /// <summary>
        /// ERROR_ALREADY_WAITING
        /// The specified printer handle is already being waited on.
        /// </summary>
        AlreadyWaiting = 0x770,

        /// <summary>
        /// ERROR_PRINTER_DELETED
        /// The specified printer has been deleted.
        /// </summary>
        PrinterDeleted = 0x771,

        /// <summary>
        /// ERROR_INVALID_PRINTER_STATE
        /// The state of the printer is invalid.
        /// </summary>
        InvalidPrinterState = 0x772,

        /// <summary>
        /// ERROR_PASSWORD_MUST_CHANGE
        /// The user's password must be changed before signing in.
        /// </summary>
        PasswordMustChange = 0x773,

        /// <summary>
        /// ERROR_DOMAIN_CONTROLLER_NOT_FOUND
        /// Could not find the domain controller for this domain.
        /// </summary>
        DomainControllerNotFound = 0x774,

        /// <summary>
        /// ERROR_ACCOUNT_LOCKED_OUT
        /// The referenced account is currently locked out and may not be logged on to.
        /// </summary>
        AccountLockedOut = 0x775,

        /// <summary>
        /// OR_INVALID_OXID
        /// The object exporter specified was not found.
        /// </summary>
        OrInvalidOxid = 0x776,

        /// <summary>
        /// OR_INVALID_OID
        /// The object specified was not found.
        /// </summary>
        OrInvalidOid = 0x777,

        /// <summary>
        /// OR_INVALID_SET
        /// The object resolver set specified was not found.
        /// </summary>
        OrInvalidSet = 0x778,

        /// <summary>
        /// RPC_S_SEND_INCOMPLETE
        /// Some data remains to be sent in the request buffer.
        /// </summary>
        RpcSSendIncomplete = 0x779,

        /// <summary>
        /// RPC_S_INVALID_ASYNC_HANDLE
        /// Invalid asynchronous remote procedure call handle.
        /// </summary>
        RpcSInvalidAsyncHandle = 0x77A,

        /// <summary>
        /// RPC_S_INVALID_ASYNC_CALL
        /// Invalid asynchronous RPC call handle for this operation.
        /// </summary>
        RpcSInvalidAsyncCall = 0x77B,

        /// <summary>
        /// RPC_X_PIPE_CLOSED
        /// The RPC pipe object has already been closed.
        /// </summary>
        RpcXPipeClosed = 0x77C,

        /// <summary>
        /// RPC_X_PIPE_DISCIPLINE_ERROR
        /// The RPC call completed before all pipes were processed.
        /// </summary>
        RpcXPipeDisciplineError = 0x77D,

        /// <summary>
        /// RPC_X_PIPE_EMPTY
        /// No more data is available from the RPC pipe.
        /// </summary>
        RpcXPipeEmpty = 0x77E,

        /// <summary>
        /// ERROR_NO_SITENAME
        /// No site name is available for this machine.
        /// </summary>
        NoSitename = 0x77F,

        /// <summary>
        /// ERROR_CANT_ACCESS_FILE
        /// The file cannot be accessed by the system.
        /// </summary>
        CantAccessFile = 0x780,

        /// <summary>
        /// ERROR_CANT_RESOLVE_FILENAME
        /// The name of the file cannot be resolved by the system.
        /// </summary>
        CantResolveFilename = 0x781,

        /// <summary>
        /// RPC_S_ENTRY_TYPE_MISMATCH
        /// The entry is not of the expected type.
        /// </summary>
        RpcSEntryTypeMismatch = 0x782,

        /// <summary>
        /// RPC_S_NOT_ALL_OBJS_EXPORTED
        /// Not all object UUIDs could be exported to the specified entry.
        /// </summary>
        RpcSNotAllObjsExported = 0x783,

        /// <summary>
        /// RPC_S_INTERFACE_NOT_EXPORTED
        /// Interface could not be exported to the specified entry.
        /// </summary>
        RpcSInterfaceNotExported = 0x784,

        /// <summary>
        /// RPC_S_PROFILE_NOT_ADDED
        /// The specified profile entry could not be added.
        /// </summary>
        RpcSProfileNotAdded = 0x785,

        /// <summary>
        /// RPC_S_PRF_ELT_NOT_ADDED
        /// The specified profile element could not be added.
        /// </summary>
        RpcSPrfEltNotAdded = 0x786,

        /// <summary>
        /// RPC_S_PRF_ELT_NOT_REMOVED
        /// The specified profile element could not be removed.
        /// </summary>
        RpcSPrfEltNotRemoved = 0x787,

        /// <summary>
        /// RPC_S_GRP_ELT_NOT_ADDED
        /// The group element could not be added.
        /// </summary>
        RpcSGrpEltNotAdded = 0x788,

        /// <summary>
        /// RPC_S_GRP_ELT_NOT_REMOVED
        /// The group element could not be removed.
        /// </summary>
        RpcSGrpEltNotRemoved = 0x789,

        /// <summary>
        /// ERROR_KM_DRIVER_BLOCKED
        /// The printer driver is not compatible with a policy enabled on your computer that blocks NT 4.0 drivers.
        /// </summary>
        KmDriverBlocked = 0x78A,

        /// <summary>
        /// ERROR_CONTEXT_EXPIRED
        /// The context has expired and can no longer be used.
        /// </summary>
        ContextExpired = 0x78B,

        /// <summary>
        /// ERROR_PER_USER_TRUST_QUOTA_EXCEEDED
        /// The current user's delegated trust creation quota has been exceeded.
        /// </summary>
        PerUserTrustQuotaExceeded = 0x78C,

        /// <summary>
        /// ERROR_ALL_USER_TRUST_QUOTA_EXCEEDED
        /// The total delegated trust creation quota has been exceeded.
        /// </summary>
        AllUserTrustQuotaExceeded = 0x78D,

        /// <summary>
        /// ERROR_USER_DELETE_TRUST_QUOTA_EXCEEDED
        /// The current user's delegated trust deletion quota has been exceeded.
        /// </summary>
        UserDeleteTrustQuotaExceeded = 0x78E,

        /// <summary>
        /// ERROR_AUTHENTICATION_FIREWALL_FAILED
        /// The computer you are signing into is protected by an authentication firewall. The specified account is not allowed to authenticate to the computer.
        /// </summary>
        AuthenticationFirewallFailed = 0x78F,

        /// <summary>
        /// ERROR_REMOTE_PRINT_CONNECTIONS_BLOCKED
        /// Remote connections to the Print Spooler are blocked by a policy set on your machine.
        /// </summary>
        RemotePrintConnectionsBlocked = 0x790,

        /// <summary>
        /// ERROR_NTLM_BLOCKED
        /// Authentication failed because NTLM authentication has been disabled.
        /// </summary>
        NtlmBlocked = 0x791,

        /// <summary>
        /// ERROR_PASSWORD_CHANGE_REQUIRED
        /// Logon Failure: EAS policy requires that the user change their password before this operation can be performed.
        /// </summary>
        PasswordChangeRequired = 0x792,

        /// <summary>
        /// ERROR_INVALID_PIXEL_FORMAT
        /// The pixel format is invalid.
        /// </summary>
        InvalidPixelFormat = 0x7D0,

        /// <summary>
        /// ERROR_BAD_DRIVER
        /// The specified driver is invalid.
        /// </summary>
        BadDriver = 0x7D1,

        /// <summary>
        /// ERROR_INVALID_WINDOW_STYLE
        /// The window style or class attribute is invalid for this operation.
        /// </summary>
        InvalidWindowStyle = 0x7D2,

        /// <summary>
        /// ERROR_METAFILE_NOT_SUPPORTED
        /// The requested metafile operation is not supported.
        /// </summary>
        MetafileNotSupported = 0x7D3,

        /// <summary>
        /// ERROR_TRANSFORM_NOT_SUPPORTED
        /// The requested transformation operation is not supported.
        /// </summary>
        TransformNotSupported = 0x7D4,

        /// <summary>
        /// ERROR_CLIPPING_NOT_SUPPORTED
        /// The requested clipping operation is not supported.
        /// </summary>
        ClippingNotSupported = 0x7D5,

        /// <summary>
        /// ERROR_INVALID_CMM
        /// The specified color management module is invalid.
        /// </summary>
        InvalidCmm = 0x7DA,

        /// <summary>
        /// ERROR_INVALID_PROFILE
        /// The specified color profile is invalid.
        /// </summary>
        InvalidProfile = 0x7DB,

        /// <summary>
        /// ERROR_TAG_NOT_FOUND
        /// The specified tag was not found.
        /// </summary>
        TagNotFound = 0x7DC,

        /// <summary>
        /// ERROR_TAG_NOT_PRESENT
        /// A required tag is not present.
        /// </summary>
        TagNotPresent = 0x7DD,

        /// <summary>
        /// ERROR_DUPLICATE_TAG
        /// The specified tag is already present.
        /// </summary>
        DuplicateTag = 0x7DE,

        /// <summary>
        /// ERROR_PROFILE_NOT_ASSOCIATED_WITH_DEVICE
        /// The specified color profile is not associated with the specified device.
        /// </summary>
        ProfileNotAssociatedWithDevice = 0x7DF,

        /// <summary>
        /// ERROR_PROFILE_NOT_FOUND
        /// The specified color profile was not found.
        /// </summary>
        ProfileNotFound = 0x7E0,

        /// <summary>
        /// ERROR_INVALID_COLORSPACE
        /// The specified color space is invalid.
        /// </summary>
        InvalidColorspace = 0x7E1,

        /// <summary>
        /// ERROR_ICM_NOT_ENABLED
        /// Image Color Management is not enabled.
        /// </summary>
        IcmNotEnabled = 0x7E2,

        /// <summary>
        /// ERROR_DELETING_ICM_XFORM
        /// There was an error while deleting the color transform.
        /// </summary>
        DeletingIcmXform = 0x7E3,

        /// <summary>
        /// ERROR_INVALID_TRANSFORM
        /// The specified color transform is invalid.
        /// </summary>
        InvalidTransform = 0x7E4,

        /// <summary>
        /// ERROR_COLORSPACE_MISMATCH
        /// The specified transform does not match the bitmap's color space.
        /// </summary>
        ColorspaceMismatch = 0x7E5,

        /// <summary>
        /// ERROR_INVALID_COLORINDEX
        /// The specified named color index is not present in the profile.
        /// </summary>
        InvalidColorindex = 0x7E6,

        /// <summary>
        /// ERROR_PROFILE_DOES_NOT_MATCH_DEVICE
        /// The specified profile is intended for a device of a different type than the specified device.
        /// </summary>
        ProfileDoesNotMatchDevice = 0x7E7,

        /// <summary>
        /// ERROR_CONNECTED_OTHER_PASSWORD
        /// The network connection was made successfully, but the user had to be prompted for a password other than the one originally specified.
        /// </summary>
        ConnectedOtherPassword = 0x83C,

        /// <summary>
        /// ERROR_CONNECTED_OTHER_PASSWORD_DEFAULT
        /// The network connection was made successfully using default credentials.
        /// </summary>
        ConnectedOtherPasswordDefault = 0x83D,

        /// <summary>
        /// ERROR_BAD_USERNAME
        /// The specified username is invalid.
        /// </summary>
        BadUsername = 0x89A,

        /// <summary>
        /// ERROR_NOT_CONNECTED
        /// This network connection does not exist.
        /// </summary>
        NotConnected = 0x8CA,

        /// <summary>
        /// ERROR_OPEN_FILES
        /// This network connection has files open or requests pending.
        /// </summary>
        OpenFiles = 0x961,

        /// <summary>
        /// ERROR_ACTIVE_CONNECTIONS
        /// Active connections still exist.
        /// </summary>
        ActiveConnections = 0x962,

        /// <summary>
        /// ERROR_DEVICE_IN_USE
        /// The device is in use by an active process and cannot be disconnected.
        /// </summary>
        DeviceInUse = 0x964,

        /// <summary>
        /// ERROR_UNKNOWN_PRINT_MONITOR
        /// The specified print monitor is unknown.
        /// </summary>
        UnknownPrintMonitor = 0xBB8,

        /// <summary>
        /// ERROR_PRINTER_DRIVER_IN_USE
        /// The specified printer driver is currently in use.
        /// </summary>
        PrinterDriverInUse = 0xBB9,

        /// <summary>
        /// ERROR_SPOOL_FILE_NOT_FOUND
        /// The spool file was not found.
        /// </summary>
        SpoolFileNotFound = 0xBBA,

        /// <summary>
        /// ERROR_SPL_NO_STARTDOC
        /// A StartDocPrinter call was not issued.
        /// </summary>
        SplNoStartdoc = 0xBBB,

        /// <summary>
        /// ERROR_SPL_NO_ADDJOB
        /// An AddJob call was not issued.
        /// </summary>
        SplNoAddjob = 0xBBC,

        /// <summary>
        /// ERROR_PRINT_PROCESSOR_ALREADY_INSTALLED
        /// The specified print processor has already been installed.
        /// </summary>
        PrintProcessorAlreadyInstalled = 0xBBD,

        /// <summary>
        /// ERROR_PRINT_MONITOR_ALREADY_INSTALLED
        /// The specified print monitor has already been installed.
        /// </summary>
        PrintMonitorAlreadyInstalled = 0xBBE,

        /// <summary>
        /// ERROR_INVALID_PRINT_MONITOR
        /// The specified print monitor does not have the required functions.
        /// </summary>
        InvalidPrintMonitor = 0xBBF,

        /// <summary>
        /// ERROR_PRINT_MONITOR_IN_USE
        /// The specified print monitor is currently in use.
        /// </summary>
        PrintMonitorInUse = 0xBC0,

        /// <summary>
        /// ERROR_PRINTER_HAS_JOBS_QUEUED
        /// The requested operation is not allowed when there are jobs queued to the printer.
        /// </summary>
        PrinterHasJobsQueued = 0xBC1,

        /// <summary>
        /// ERROR_SUCCESS_REBOOT_REQUIRED
        /// The requested operation is successful. Changes will not be effective until the system is rebooted.
        /// </summary>
        SuccessRebootRequired = 0xBC2,

        /// <summary>
        /// ERROR_SUCCESS_RESTART_REQUIRED
        /// The requested operation is successful. Changes will not be effective until the service is restarted.
        /// </summary>
        SuccessRestartRequired = 0xBC3,

        /// <summary>
        /// ERROR_PRINTER_NOT_FOUND
        /// No printers were found.
        /// </summary>
        PrinterNotFound = 0xBC4,

        /// <summary>
        /// ERROR_PRINTER_DRIVER_WARNED
        /// The printer driver is known to be unreliable.
        /// </summary>
        PrinterDriverWarned = 0xBC5,

        /// <summary>
        /// ERROR_PRINTER_DRIVER_BLOCKED
        /// The printer driver is known to harm the system.
        /// </summary>
        PrinterDriverBlocked = 0xBC6,

        /// <summary>
        /// ERROR_PRINTER_DRIVER_PACKAGE_IN_USE
        /// The specified printer driver package is currently in use.
        /// </summary>
        PrinterDriverPackageInUse = 0xBC7,

        /// <summary>
        /// ERROR_CORE_DRIVER_PACKAGE_NOT_FOUND
        /// Unable to find a core driver package that is required by the printer driver package.
        /// </summary>
        CoreDriverPackageNotFound = 0xBC8,

        /// <summary>
        /// ERROR_FAIL_REBOOT_REQUIRED
        /// The requested operation failed. A system reboot is required to roll back changes made.
        /// </summary>
        FailRebootRequired = 0xBC9,

        /// <summary>
        /// ERROR_FAIL_REBOOT_INITIATED
        /// The requested operation failed. A system reboot has been initiated to roll back changes made.
        /// </summary>
        FailRebootInitiated = 0xBCA,

        /// <summary>
        /// ERROR_PRINTER_DRIVER_DOWNLOAD_NEEDED
        /// The specified printer driver was not found on the system and needs to be downloaded.
        /// </summary>
        PrinterDriverDownloadNeeded = 0xBCB,

        /// <summary>
        /// ERROR_PRINT_JOB_RESTART_REQUIRED
        /// The requested print job has failed to print. A print system update requires the job to be resubmitted.
        /// </summary>
        PrintJobRestartRequired = 0xBCC,

        /// <summary>
        /// ERROR_INVALID_PRINTER_DRIVER_MANIFEST
        /// The printer driver does not contain a valid manifest, or contains too many manifests.
        /// </summary>
        InvalidPrinterDriverManifest = 0xBCD,

        /// <summary>
        /// ERROR_PRINTER_NOT_SHAREABLE
        /// The specified printer cannot be shared.
        /// </summary>
        PrinterNotShareable = 0xBCE,

        /// <summary>
        /// ERROR_REQUEST_PAUSED
        /// The operation was paused.
        /// </summary>
        RequestPaused = 0xBEA,

        /// <summary>
        /// ERROR_IO_REISSUE_AS_CACHED
        /// Reissue the given operation as a cached IO operation.
        /// </summary>
        IoReissueAsCached = 0xF6E,

        /// <summary>
        /// ERROR_WINS_INTERNAL
        /// WINS encountered an error while processing the command.
        /// </summary>
        WinsInternal = 0xFA0,

        /// <summary>
        /// ERROR_CAN_NOT_DEL_LOCAL_WINS
        /// The local WINS cannot be deleted.
        /// </summary>
        CanNotDelLocalWins = 0xFA1,

        /// <summary>
        /// ERROR_STATIC_INIT
        /// The importation from the file failed.
        /// </summary>
        StaticInit = 0xFA2,

        /// <summary>
        /// ERROR_INC_BACKUP
        /// The backup failed. Was a full backup done before?
        /// </summary>
        IncBackup = 0xFA3,

        /// <summary>
        /// ERROR_FULL_BACKUP
        /// The backup failed. Check the directory to which you are backing the database.
        /// </summary>
        FullBackup = 0xFA4,

        /// <summary>
        /// ERROR_REC_NON_EXISTENT
        /// The name does not exist in the WINS database.
        /// </summary>
        RecNonExistent = 0xFA5,

        /// <summary>
        /// ERROR_RPL_NOT_ALLOWED
        /// Replication with a nonconfigured partner is not allowed.
        /// </summary>
        RplNotAllowed = 0xFA6,

        /// <summary>
        /// PEERDIST_ERROR_CONTENTINFO_VERSION_UNSUPPORTED
        /// The version of the supplied content information is not supported.
        /// </summary>
        PeerdistErrorContentinfoVersionUnsupported = 0xFD2,

        /// <summary>
        /// PEERDIST_ERROR_CANNOT_PARSE_CONTENTINFO
        /// The supplied content information is malformed.
        /// </summary>
        PeerdistErrorCannotParseContentinfo = 0xFD3,

        /// <summary>
        /// PEERDIST_ERROR_MISSING_DATA
        /// The requested data cannot be found in local or peer caches.
        /// </summary>
        PeerdistErrorMissingData = 0xFD4,

        /// <summary>
        /// PEERDIST_ERROR_NO_MORE
        /// No more data is available or required.
        /// </summary>
        PeerdistErrorNoMore = 0xFD5,

        /// <summary>
        /// PEERDIST_ERROR_NOT_INITIALIZED
        /// The supplied object has not been initialized.
        /// </summary>
        PeerdistErrorNotInitialized = 0xFD6,

        /// <summary>
        /// PEERDIST_ERROR_ALREADY_INITIALIZED
        /// The supplied object has already been initialized.
        /// </summary>
        PeerdistErrorAlreadyInitialized = 0xFD7,

        /// <summary>
        /// PEERDIST_ERROR_SHUTDOWN_IN_PROGRESS
        /// A shutdown operation is already in progress.
        /// </summary>
        PeerdistErrorShutdownInProgress = 0xFD8,

        /// <summary>
        /// PEERDIST_ERROR_INVALIDATED
        /// The supplied object has already been invalidated.
        /// </summary>
        PeerdistErrorInvalidated = 0xFD9,

        /// <summary>
        /// PEERDIST_ERROR_ALREADY_EXISTS
        /// An element already exists and was not replaced.
        /// </summary>
        PeerdistErrorAlreadyExists = 0xFDA,

        /// <summary>
        /// PEERDIST_ERROR_OPERATION_NOTFOUND
        /// Cannot cancel the requested operation as it has already been completed.
        /// </summary>
        PeerdistErrorOperationNotfound = 0xFDB,

        /// <summary>
        /// PEERDIST_ERROR_ALREADY_COMPLETED
        /// Can not perform the reqested operation because it has already been carried out.
        /// </summary>
        PeerdistErrorAlreadyCompleted = 0xFDC,

        /// <summary>
        /// PEERDIST_ERROR_OUT_OF_BOUNDS
        /// An operation accessed data beyond the bounds of valid data.
        /// </summary>
        PeerdistErrorOutOfBounds = 0xFDD,

        /// <summary>
        /// PEERDIST_ERROR_VERSION_UNSUPPORTED
        /// The requested version is not supported.
        /// </summary>
        PeerdistErrorVersionUnsupported = 0xFDE,

        /// <summary>
        /// PEERDIST_ERROR_INVALID_CONFIGURATION
        /// A configuration value is invalid.
        /// </summary>
        PeerdistErrorInvalidConfiguration = 0xFDF,

        /// <summary>
        /// PEERDIST_ERROR_NOT_LICENSED
        /// The SKU is not licensed.
        /// </summary>
        PeerdistErrorNotLicensed = 0xFE0,

        /// <summary>
        /// PEERDIST_ERROR_SERVICE_UNAVAILABLE
        /// PeerDist Service is still initializing and will be available shortly.
        /// </summary>
        PeerdistErrorServiceUnavailable = 0xFE1,

        /// <summary>
        /// PEERDIST_ERROR_TRUST_FAILURE
        /// Communication with one or more computers will be temporarily blocked due to recent errors.
        /// </summary>
        PeerdistErrorTrustFailure = 0xFE2,

        /// <summary>
        /// ERROR_DHCP_ADDRESS_CONFLICT
        /// The DHCP client has obtained an IP address that is already in use on the network. The local interface will be disabled until the DHCP client can obtain a new address.
        /// </summary>
        DhcpAddressConflict = 0x1004,

        /// <summary>
        /// ERROR_WMI_GUID_NOT_FOUND
        /// The GUID passed was not recognized as valid by a WMI data provider.
        /// </summary>
        WmiGuidNotFound = 0x1068,

        /// <summary>
        /// ERROR_WMI_INSTANCE_NOT_FOUND
        /// The instance name passed was not recognized as valid by a WMI data provider.
        /// </summary>
        WmiInstanceNotFound = 0x1069,

        /// <summary>
        /// ERROR_WMI_ITEMID_NOT_FOUND
        /// The data item ID passed was not recognized as valid by a WMI data provider.
        /// </summary>
        WmiItemidNotFound = 0x106A,

        /// <summary>
        /// ERROR_WMI_TRY_AGAIN
        /// The WMI request could not be completed and should be retried.
        /// </summary>
        WmiTryAgain = 0x106B,

        /// <summary>
        /// ERROR_WMI_DP_NOT_FOUND
        /// The WMI data provider could not be located.
        /// </summary>
        WmiDpNotFound = 0x106C,

        /// <summary>
        /// ERROR_WMI_UNRESOLVED_INSTANCE_REF
        /// The WMI data provider references an instance set that has not been registered.
        /// </summary>
        WmiUnresolvedInstanceRef = 0x106D,

        /// <summary>
        /// ERROR_WMI_ALREADY_ENABLED
        /// The WMI data block or event notification has already been enabled.
        /// </summary>
        WmiAlreadyEnabled = 0x106E,

        /// <summary>
        /// ERROR_WMI_GUID_DISCONNECTED
        /// The WMI data block is no longer available.
        /// </summary>
        WmiGuidDisconnected = 0x106F,

        /// <summary>
        /// ERROR_WMI_SERVER_UNAVAILABLE
        /// The WMI data service is not available.
        /// </summary>
        WmiServerUnavailable = 0x1070,

        /// <summary>
        /// ERROR_WMI_DP_FAILED
        /// The WMI data provider failed to carry out the request.
        /// </summary>
        WmiDpFailed = 0x1071,

        /// <summary>
        /// ERROR_WMI_INVALID_MOF
        /// The WMI MOF information is not valid.
        /// </summary>
        WmiInvalidMof = 0x1072,

        /// <summary>
        /// ERROR_WMI_INVALID_REGINFO
        /// The WMI registration information is not valid.
        /// </summary>
        WmiInvalidReginfo = 0x1073,

        /// <summary>
        /// ERROR_WMI_ALREADY_DISABLED
        /// The WMI data block or event notification has already been disabled.
        /// </summary>
        WmiAlreadyDisabled = 0x1074,

        /// <summary>
        /// ERROR_WMI_READ_ONLY
        /// The WMI data item or data block is read only.
        /// </summary>
        WmiReadOnly = 0x1075,

        /// <summary>
        /// ERROR_WMI_SET_FAILURE
        /// The WMI data item or data block could not be changed.
        /// </summary>
        WmiSetFailure = 0x1076,

        /// <summary>
        /// ERROR_NOT_APPCONTAINER
        /// This operation is only valid in the context of an app container.
        /// </summary>
        NotAppcontainer = 0x109A,

        /// <summary>
        /// ERROR_APPCONTAINER_REQUIRED
        /// This application can only run in the context of an app container.
        /// </summary>
        AppcontainerRequired = 0x109B,

        /// <summary>
        /// ERROR_NOT_SUPPORTED_IN_APPCONTAINER
        /// This functionality is not supported in the context of an app container.
        /// </summary>
        NotSupportedInAppcontainer = 0x109C,

        /// <summary>
        /// ERROR_INVALID_PACKAGE_SID_LENGTH
        /// The length of the SID supplied is not a valid length for app container SIDs.
        /// </summary>
        InvalidPackageSidLength = 0x109D,

        /// <summary>
        /// ERROR_INVALID_MEDIA
        /// The media identifier does not represent a valid medium.
        /// </summary>
        InvalidMedia = 0x10CC,

        /// <summary>
        /// ERROR_INVALID_LIBRARY
        /// The library identifier does not represent a valid library.
        /// </summary>
        InvalidLibrary = 0x10CD,

        /// <summary>
        /// ERROR_INVALID_MEDIA_POOL
        /// The media pool identifier does not represent a valid media pool.
        /// </summary>
        InvalidMediaPool = 0x10CE,

        /// <summary>
        /// ERROR_DRIVE_MEDIA_MISMATCH
        /// The drive and medium are not compatible or exist in different libraries.
        /// </summary>
        DriveMediaMismatch = 0x10CF,

        /// <summary>
        /// ERROR_MEDIA_OFFLINE
        /// The medium currently exists in an offline library and must be online to perform this operation.
        /// </summary>
        MediaOffline = 0x10D0,

        /// <summary>
        /// ERROR_LIBRARY_OFFLINE
        /// The operation cannot be performed on an offline library.
        /// </summary>
        LibraryOffline = 0x10D1,

        /// <summary>
        /// ERROR_EMPTY
        /// The library, drive, or media pool is empty.
        /// </summary>
        Empty = 0x10D2,

        /// <summary>
        /// ERROR_NOT_EMPTY
        /// The library, drive, or media pool must be empty to perform this operation.
        /// </summary>
        NotEmpty = 0x10D3,

        /// <summary>
        /// ERROR_MEDIA_UNAVAILABLE
        /// No media is currently available in this media pool or library.
        /// </summary>
        MediaUnavailable = 0x10D4,

        /// <summary>
        /// ERROR_RESOURCE_DISABLED
        /// A resource required for this operation is disabled.
        /// </summary>
        ResourceDisabled = 0x10D5,

        /// <summary>
        /// ERROR_INVALID_CLEANER
        /// The media identifier does not represent a valid cleaner.
        /// </summary>
        InvalidCleaner = 0x10D6,

        /// <summary>
        /// ERROR_UNABLE_TO_CLEAN
        /// The drive cannot be cleaned or does not support cleaning.
        /// </summary>
        UnableToClean = 0x10D7,

        /// <summary>
        /// ERROR_OBJECT_NOT_FOUND
        /// The object identifier does not represent a valid object.
        /// </summary>
        ObjectNotFound = 0x10D8,

        /// <summary>
        /// ERROR_DATABASE_FAILURE
        /// Unable to read from or write to the database.
        /// </summary>
        DatabaseFailure = 0x10D9,

        /// <summary>
        /// ERROR_DATABASE_FULL
        /// The database is full.
        /// </summary>
        DatabaseFull = 0x10DA,

        /// <summary>
        /// ERROR_MEDIA_INCOMPATIBLE
        /// The medium is not compatible with the device or media pool.
        /// </summary>
        MediaIncompatible = 0x10DB,

        /// <summary>
        /// ERROR_RESOURCE_NOT_PRESENT
        /// The resource required for this operation does not exist.
        /// </summary>
        ResourceNotPresent = 0x10DC,

        /// <summary>
        /// ERROR_INVALID_OPERATION
        /// The operation identifier is not valid.
        /// </summary>
        InvalidOperation = 0x10DD,

        /// <summary>
        /// ERROR_MEDIA_NOT_AVAILABLE
        /// The media is not mounted or ready for use.
        /// </summary>
        MediaNotAvailable = 0x10DE,

        /// <summary>
        /// ERROR_DEVICE_NOT_AVAILABLE
        /// The device is not ready for use.
        /// </summary>
        DeviceNotAvailable = 0x10DF,

        /// <summary>
        /// ERROR_REQUEST_REFUSED
        /// The operator or administrator has refused the request.
        /// </summary>
        RequestRefused = 0x10E0,

        /// <summary>
        /// ERROR_INVALID_DRIVE_OBJECT
        /// The drive identifier does not represent a valid drive.
        /// </summary>
        InvalidDriveObject = 0x10E1,

        /// <summary>
        /// ERROR_LIBRARY_FULL
        /// Library is full. No slot is available for use.
        /// </summary>
        LibraryFull = 0x10E2,

        /// <summary>
        /// ERROR_MEDIUM_NOT_ACCESSIBLE
        /// The transport cannot access the medium.
        /// </summary>
        MediumNotAccessible = 0x10E3,

        /// <summary>
        /// ERROR_UNABLE_TO_LOAD_MEDIUM
        /// Unable to load the medium into the drive.
        /// </summary>
        UnableToLoadMedium = 0x10E4,

        /// <summary>
        /// ERROR_UNABLE_TO_INVENTORY_DRIVE
        /// Unable to retrieve the drive status.
        /// </summary>
        UnableToInventoryDrive = 0x10E5,

        /// <summary>
        /// ERROR_UNABLE_TO_INVENTORY_SLOT
        /// Unable to retrieve the slot status.
        /// </summary>
        UnableToInventorySlot = 0x10E6,

        /// <summary>
        /// ERROR_UNABLE_TO_INVENTORY_TRANSPORT
        /// Unable to retrieve status about the transport.
        /// </summary>
        UnableToInventoryTransport = 0x10E7,

        /// <summary>
        /// ERROR_TRANSPORT_FULL
        /// Cannot use the transport because it is already in use.
        /// </summary>
        TransportFull = 0x10E8,

        /// <summary>
        /// ERROR_CONTROLLING_IEPORT
        /// Unable to open or close the inject/eject port.
        /// </summary>
        ControllingIeport = 0x10E9,

        /// <summary>
        /// ERROR_UNABLE_TO_EJECT_MOUNTED_MEDIA
        /// Unable to eject the medium because it is in a drive.
        /// </summary>
        UnableToEjectMountedMedia = 0x10EA,

        /// <summary>
        /// ERROR_CLEANER_SLOT_SET
        /// A cleaner slot is already reserved.
        /// </summary>
        CleanerSlotSet = 0x10EB,

        /// <summary>
        /// ERROR_CLEANER_SLOT_NOT_SET
        /// A cleaner slot is not reserved.
        /// </summary>
        CleanerSlotNotSet = 0x10EC,

        /// <summary>
        /// ERROR_CLEANER_CARTRIDGE_SPENT
        /// The cleaner cartridge has performed the maximum number of drive cleanings.
        /// </summary>
        CleanerCartridgeSpent = 0x10ED,

        /// <summary>
        /// ERROR_UNEXPECTED_OMID
        /// Unexpected on-medium identifier.
        /// </summary>
        UnexpectedOmid = 0x10EE,

        /// <summary>
        /// ERROR_CANT_DELETE_LAST_ITEM
        /// The last remaining item in this group or resource cannot be deleted.
        /// </summary>
        CantDeleteLastItem = 0x10EF,

        /// <summary>
        /// ERROR_MESSAGE_EXCEEDS_MAX_SIZE
        /// The message provided exceeds the maximum size allowed for this parameter.
        /// </summary>
        MessageExceedsMaxSize = 0x10F0,

        /// <summary>
        /// ERROR_VOLUME_CONTAINS_SYS_FILES
        /// The volume contains system or paging files.
        /// </summary>
        VolumeContainsSysFiles = 0x10F1,

        /// <summary>
        /// ERROR_INDIGENOUS_TYPE
        /// The media type cannot be removed from this library since at least one drive in the library reports it can support this media type.
        /// </summary>
        IndigenousType = 0x10F2,

        /// <summary>
        /// ERROR_NO_SUPPORTING_DRIVES
        /// This offline media cannot be mounted on this system since no enabled drives are present which can be used.
        /// </summary>
        NoSupportingDrives = 0x10F3,

        /// <summary>
        /// ERROR_CLEANER_CARTRIDGE_INSTALLED
        /// A cleaner cartridge is present in the tape library.
        /// </summary>
        CleanerCartridgeInstalled = 0x10F4,

        /// <summary>
        /// ERROR_IEPORT_FULL
        /// Cannot use the inject/eject port because it is not empty.
        /// </summary>
        IeportFull = 0x10F5,

        /// <summary>
        /// ERROR_FILE_OFFLINE
        /// This file is currently not available for use on this computer.
        /// </summary>
        FileOffline = 0x10FE,

        /// <summary>
        /// ERROR_REMOTE_STORAGE_NOT_ACTIVE
        /// The remote storage service is not operational at this time.
        /// </summary>
        RemoteStorageNotActive = 0x10FF,

        /// <summary>
        /// ERROR_REMOTE_STORAGE_MEDIA_ERROR
        /// The remote storage service encountered a media error.
        /// </summary>
        RemoteStorageMediaError = 0x1100,

        /// <summary>
        /// ERROR_NOT_A_REPARSE_POINT
        /// The file or directory is not a reparse point.
        /// </summary>
        NotAReparsePoint = 0x1126,

        /// <summary>
        /// ERROR_REPARSE_ATTRIBUTE_CONFLICT
        /// The reparse point attribute cannot be set because it conflicts with an existing attribute.
        /// </summary>
        ReparseAttributeConflict = 0x1127,

        /// <summary>
        /// ERROR_INVALID_REPARSE_DATA
        /// The data present in the reparse point buffer is invalid.
        /// </summary>
        InvalidReparseData = 0x1128,

        /// <summary>
        /// ERROR_REPARSE_TAG_INVALID
        /// The tag present in the reparse point buffer is invalid.
        /// </summary>
        ReparseTagInvalid = 0x1129,

        /// <summary>
        /// ERROR_REPARSE_TAG_MISMATCH
        /// There is a mismatch between the tag specified in the request and the tag present in the reparse point.
        /// </summary>
        ReparseTagMismatch = 0x112A,

        /// <summary>
        /// ERROR_APP_DATA_NOT_FOUND
        /// Fast Cache data not found.
        /// </summary>
        AppDataNotFound = 0x1130,

        /// <summary>
        /// ERROR_APP_DATA_EXPIRED
        /// Fast Cache data expired.
        /// </summary>
        AppDataExpired = 0x1131,

        /// <summary>
        /// ERROR_APP_DATA_CORRUPT
        /// Fast Cache data corrupt.
        /// </summary>
        AppDataCorrupt = 0x1132,

        /// <summary>
        /// ERROR_APP_DATA_LIMIT_EXCEEDED
        /// Fast Cache data has exceeded its max size and cannot be updated.
        /// </summary>
        AppDataLimitExceeded = 0x1133,

        /// <summary>
        /// ERROR_APP_DATA_REBOOT_REQUIRED
        /// Fast Cache has been ReArmed and requires a reboot until it can be updated.
        /// </summary>
        AppDataRebootRequired = 0x1134,

        /// <summary>
        /// ERROR_SECUREBOOT_ROLLBACK_DETECTED
        /// Secure Boot detected that rollback of protected data has been attempted.
        /// </summary>
        SecurebootRollbackDetected = 0x1144,

        /// <summary>
        /// ERROR_SECUREBOOT_POLICY_VIOLATION
        /// The value is protected by Secure Boot policy and cannot be modified or deleted.
        /// </summary>
        SecurebootPolicyViolation = 0x1145,

        /// <summary>
        /// ERROR_SECUREBOOT_INVALID_POLICY
        /// The Secure Boot policy is invalid.
        /// </summary>
        SecurebootInvalidPolicy = 0x1146,

        /// <summary>
        /// ERROR_SECUREBOOT_POLICY_PUBLISHER_NOT_FOUND
        /// A new Secure Boot policy did not contain the current publisher on its update list.
        /// </summary>
        SecurebootPolicyPublisherNotFound = 0x1147,

        /// <summary>
        /// ERROR_SECUREBOOT_POLICY_NOT_SIGNED
        /// The Secure Boot policy is either not signed or is signed by a non-trusted signer.
        /// </summary>
        SecurebootPolicyNotSigned = 0x1148,

        /// <summary>
        /// ERROR_SECUREBOOT_NOT_ENABLED
        /// Secure Boot is not enabled on this machine.
        /// </summary>
        SecurebootNotEnabled = 0x1149,

        /// <summary>
        /// ERROR_SECUREBOOT_FILE_REPLACED
        /// Secure Boot requires that certain files and drivers are not replaced by other files or drivers.
        /// </summary>
        SecurebootFileReplaced = 0x114A,

        /// <summary>
        /// ERROR_OFFLOAD_READ_FLT_NOT_SUPPORTED
        /// The copy offload read operation is not supported by a filter.
        /// </summary>
        OffloadReadFltNotSupported = 0x1158,

        /// <summary>
        /// ERROR_OFFLOAD_WRITE_FLT_NOT_SUPPORTED
        /// The copy offload write operation is not supported by a filter.
        /// </summary>
        OffloadWriteFltNotSupported = 0x1159,

        /// <summary>
        /// ERROR_OFFLOAD_READ_FILE_NOT_SUPPORTED
        /// The copy offload read operation is not supported for the file.
        /// </summary>
        OffloadReadFileNotSupported = 0x115A,

        /// <summary>
        /// ERROR_OFFLOAD_WRITE_FILE_NOT_SUPPORTED
        /// The copy offload write operation is not supported for the file.
        /// </summary>
        OffloadWriteFileNotSupported = 0x115B,

        /// <summary>
        /// ERROR_VOLUME_NOT_SIS_ENABLED
        /// Single Instance Storage is not available on this volume.
        /// </summary>
        VolumeNotSisEnabled = 0x1194,

        /// <summary>
        /// ERROR_DEPENDENT_RESOURCE_EXISTS
        /// The operation cannot be completed because other resources are dependent on this resource.
        /// </summary>
        DependentResourceExists = 0x1389,

        /// <summary>
        /// ERROR_DEPENDENCY_NOT_FOUND
        /// The cluster resource dependency cannot be found.
        /// </summary>
        DependencyNotFound = 0x138A,

        /// <summary>
        /// ERROR_DEPENDENCY_ALREADY_EXISTS
        /// The cluster resource cannot be made dependent on the specified resource because it is already dependent.
        /// </summary>
        DependencyAlreadyExists = 0x138B,

        /// <summary>
        /// ERROR_RESOURCE_NOT_ONLINE
        /// The cluster resource is not online.
        /// </summary>
        ResourceNotOnline = 0x138C,

        /// <summary>
        /// ERROR_HOST_NODE_NOT_AVAILABLE
        /// A cluster node is not available for this operation.
        /// </summary>
        HostNodeNotAvailable = 0x138D,

        /// <summary>
        /// ERROR_RESOURCE_NOT_AVAILABLE
        /// The cluster resource is not available.
        /// </summary>
        ResourceNotAvailable = 0x138E,

        /// <summary>
        /// ERROR_RESOURCE_NOT_FOUND
        /// The cluster resource could not be found.
        /// </summary>
        ResourceNotFound = 0x138F,

        /// <summary>
        /// ERROR_SHUTDOWN_CLUSTER
        /// The cluster is being shut down.
        /// </summary>
        ShutdownCluster = 0x1390,

        /// <summary>
        /// ERROR_CANT_EVICT_ACTIVE_NODE
        /// A cluster node cannot be evicted from the cluster unless the node is down or it is the last node.
        /// </summary>
        CantEvictActiveNode = 0x1391,

        /// <summary>
        /// ERROR_OBJECT_ALREADY_EXISTS
        /// The object already exists.
        /// </summary>
        ObjectAlreadyExists = 0x1392,

        /// <summary>
        /// ERROR_OBJECT_IN_LIST
        /// The object is already in the list.
        /// </summary>
        ObjectInList = 0x1393,

        /// <summary>
        /// ERROR_GROUP_NOT_AVAILABLE
        /// The cluster group is not available for any new requests.
        /// </summary>
        GroupNotAvailable = 0x1394,

        /// <summary>
        /// ERROR_GROUP_NOT_FOUND
        /// The cluster group could not be found.
        /// </summary>
        GroupNotFound = 0x1395,

        /// <summary>
        /// ERROR_GROUP_NOT_ONLINE
        /// The operation could not be completed because the cluster group is not online.
        /// </summary>
        GroupNotOnline = 0x1396,

        /// <summary>
        /// ERROR_HOST_NODE_NOT_RESOURCE_OWNER
        /// The operation failed because either the specified cluster node is not the owner of the resource, or the node is not a possible owner of the resource.
        /// </summary>
        HostNodeNotResourceOwner = 0x1397,

        /// <summary>
        /// ERROR_HOST_NODE_NOT_GROUP_OWNER
        /// The operation failed because either the specified cluster node is not the owner of the group, or the node is not a possible owner of the group.
        /// </summary>
        HostNodeNotGroupOwner = 0x1398,

        /// <summary>
        /// ERROR_RESMON_CREATE_FAILED
        /// The cluster resource could not be created in the specified resource monitor.
        /// </summary>
        ResmonCreateFailed = 0x1399,

        /// <summary>
        /// ERROR_RESMON_ONLINE_FAILED
        /// The cluster resource could not be brought online by the resource monitor.
        /// </summary>
        ResmonOnlineFailed = 0x139A,

        /// <summary>
        /// ERROR_RESOURCE_ONLINE
        /// The operation could not be completed because the cluster resource is online.
        /// </summary>
        ResourceOnline = 0x139B,

        /// <summary>
        /// ERROR_QUORUM_RESOURCE
        /// The cluster resource could not be deleted or brought offline because it is the quorum resource.
        /// </summary>
        QuorumResource = 0x139C,

        /// <summary>
        /// ERROR_NOT_QUORUM_CAPABLE
        /// The cluster could not make the specified resource a quorum resource because it is not capable of being a quorum resource.
        /// </summary>
        NotQuorumCapable = 0x139D,

        /// <summary>
        /// ERROR_CLUSTER_SHUTTING_DOWN
        /// The cluster software is shutting down.
        /// </summary>
        ClusterShuttingDown = 0x139E,

        /// <summary>
        /// ERROR_INVALID_STATE
        /// The group or resource is not in the correct state to perform the requested operation.
        /// </summary>
        InvalidState = 0x139F,

        /// <summary>
        /// ERROR_RESOURCE_PROPERTIES_STORED
        /// The properties were stored but not all changes will take effect until the next time the resource is brought online.
        /// </summary>
        ResourcePropertiesStored = 0x13A0,

        /// <summary>
        /// ERROR_NOT_QUORUM_CLASS
        /// The cluster could not make the specified resource a quorum resource because it does not belong to a shared storage class.
        /// </summary>
        NotQuorumClass = 0x13A1,

        /// <summary>
        /// ERROR_CORE_RESOURCE
        /// The cluster resource could not be deleted since it is a core resource.
        /// </summary>
        CoreResource = 0x13A2,

        /// <summary>
        /// ERROR_QUORUM_RESOURCE_ONLINE_FAILED
        /// The quorum resource failed to come online.
        /// </summary>
        QuorumResourceOnlineFailed = 0x13A3,

        /// <summary>
        /// ERROR_QUORUMLOG_OPEN_FAILED
        /// The quorum log could not be created or mounted successfully.
        /// </summary>
        QuorumlogOpenFailed = 0x13A4,

        /// <summary>
        /// ERROR_CLUSTERLOG_CORRUPT
        /// The cluster log is corrupt.
        /// </summary>
        ClusterlogCorrupt = 0x13A5,

        /// <summary>
        /// ERROR_CLUSTERLOG_RECORD_EXCEEDS_MAXSIZE
        /// The record could not be written to the cluster log since it exceeds the maximum size.
        /// </summary>
        ClusterlogRecordExceedsMaxsize = 0x13A6,

        /// <summary>
        /// ERROR_CLUSTERLOG_EXCEEDS_MAXSIZE
        /// The cluster log exceeds its maximum size.
        /// </summary>
        ClusterlogExceedsMaxsize = 0x13A7,

        /// <summary>
        /// ERROR_CLUSTERLOG_CHKPOINT_NOT_FOUND
        /// No checkpoint record was found in the cluster log.
        /// </summary>
        ClusterlogChkpointNotFound = 0x13A8,

        /// <summary>
        /// ERROR_CLUSTERLOG_NOT_ENOUGH_SPACE
        /// The minimum required disk space needed for logging is not available.
        /// </summary>
        ClusterlogNotEnoughSpace = 0x13A9,

        /// <summary>
        /// ERROR_QUORUM_OWNER_ALIVE
        /// The cluster node failed to take control of the quorum resource because the resource is owned by another active node.
        /// </summary>
        QuorumOwnerAlive = 0x13AA,

        /// <summary>
        /// ERROR_NETWORK_NOT_AVAILABLE
        /// A cluster network is not available for this operation.
        /// </summary>
        NetworkNotAvailable = 0x13AB,

        /// <summary>
        /// ERROR_NODE_NOT_AVAILABLE
        /// A cluster node is not available for this operation.
        /// </summary>
        NodeNotAvailable = 0x13AC,

        /// <summary>
        /// ERROR_ALL_NODES_NOT_AVAILABLE
        /// All cluster nodes must be running to perform this operation.
        /// </summary>
        AllNodesNotAvailable = 0x13AD,

        /// <summary>
        /// ERROR_RESOURCE_FAILED
        /// A cluster resource failed.
        /// </summary>
        ResourceFailed = 0x13AE,

        /// <summary>
        /// ERROR_CLUSTER_INVALID_NODE
        /// The cluster node is not valid.
        /// </summary>
        ClusterInvalidNode = 0x13AF,

        /// <summary>
        /// ERROR_CLUSTER_NODE_EXISTS
        /// The cluster node already exists.
        /// </summary>
        ClusterNodeExists = 0x13B0,

        /// <summary>
        /// ERROR_CLUSTER_JOIN_IN_PROGRESS
        /// A node is in the process of joining the cluster.
        /// </summary>
        ClusterJoinInProgress = 0x13B1,

        /// <summary>
        /// ERROR_CLUSTER_NODE_NOT_FOUND
        /// The cluster node was not found.
        /// </summary>
        ClusterNodeNotFound = 0x13B2,

        /// <summary>
        /// ERROR_CLUSTER_LOCAL_NODE_NOT_FOUND
        /// The cluster local node information was not found.
        /// </summary>
        ClusterLocalNodeNotFound = 0x13B3,

        /// <summary>
        /// ERROR_CLUSTER_NETWORK_EXISTS
        /// The cluster network already exists.
        /// </summary>
        ClusterNetworkExists = 0x13B4,

        /// <summary>
        /// ERROR_CLUSTER_NETWORK_NOT_FOUND
        /// The cluster network was not found.
        /// </summary>
        ClusterNetworkNotFound = 0x13B5,

        /// <summary>
        /// ERROR_CLUSTER_NETINTERFACE_EXISTS
        /// The cluster network interface already exists.
        /// </summary>
        ClusterNetinterfaceExists = 0x13B6,

        /// <summary>
        /// ERROR_CLUSTER_NETINTERFACE_NOT_FOUND
        /// The cluster network interface was not found.
        /// </summary>
        ClusterNetinterfaceNotFound = 0x13B7,

        /// <summary>
        /// ERROR_CLUSTER_INVALID_REQUEST
        /// The cluster request is not valid for this object.
        /// </summary>
        ClusterInvalidRequest = 0x13B8,

        /// <summary>
        /// ERROR_CLUSTER_INVALID_NETWORK_PROVIDER
        /// The cluster network provider is not valid.
        /// </summary>
        ClusterInvalidNetworkProvider = 0x13B9,

        /// <summary>
        /// ERROR_CLUSTER_NODE_DOWN
        /// The cluster node is down.
        /// </summary>
        ClusterNodeDown = 0x13BA,

        /// <summary>
        /// ERROR_CLUSTER_NODE_UNREACHABLE
        /// The cluster node is not reachable.
        /// </summary>
        ClusterNodeUnreachable = 0x13BB,

        /// <summary>
        /// ERROR_CLUSTER_NODE_NOT_MEMBER
        /// The cluster node is not a member of the cluster.
        /// </summary>
        ClusterNodeNotMember = 0x13BC,

        /// <summary>
        /// ERROR_CLUSTER_JOIN_NOT_IN_PROGRESS
        /// A cluster join operation is not in progress.
        /// </summary>
        ClusterJoinNotInProgress = 0x13BD,

        /// <summary>
        /// ERROR_CLUSTER_INVALID_NETWORK
        /// The cluster network is not valid.
        /// </summary>
        ClusterInvalidNetwork = 0x13BE,

        /// <summary>
        /// ERROR_CLUSTER_NODE_UP
        /// The cluster node is up.
        /// </summary>
        ClusterNodeUp = 0x13C0,

        /// <summary>
        /// ERROR_CLUSTER_IPADDR_IN_USE
        /// The cluster IP address is already in use.
        /// </summary>
        ClusterIpaddrInUse = 0x13C1,

        /// <summary>
        /// ERROR_CLUSTER_NODE_NOT_PAUSED
        /// The cluster node is not paused.
        /// </summary>
        ClusterNodeNotPaused = 0x13C2,

        /// <summary>
        /// ERROR_CLUSTER_NO_SECURITY_CONTEXT
        /// No cluster security context is available.
        /// </summary>
        ClusterNoSecurityContext = 0x13C3,

        /// <summary>
        /// ERROR_CLUSTER_NETWORK_NOT_INTERNAL
        /// The cluster network is not configured for internal cluster communication.
        /// </summary>
        ClusterNetworkNotInternal = 0x13C4,

        /// <summary>
        /// ERROR_CLUSTER_NODE_ALREADY_UP
        /// The cluster node is already up.
        /// </summary>
        ClusterNodeAlreadyUp = 0x13C5,

        /// <summary>
        /// ERROR_CLUSTER_NODE_ALREADY_DOWN
        /// The cluster node is already down.
        /// </summary>
        ClusterNodeAlreadyDown = 0x13C6,

        /// <summary>
        /// ERROR_CLUSTER_NETWORK_ALREADY_ONLINE
        /// The cluster network is already online.
        /// </summary>
        ClusterNetworkAlreadyOnline = 0x13C7,

        /// <summary>
        /// ERROR_CLUSTER_NETWORK_ALREADY_OFFLINE
        /// The cluster network is already offline.
        /// </summary>
        ClusterNetworkAlreadyOffline = 0x13C8,

        /// <summary>
        /// ERROR_CLUSTER_NODE_ALREADY_MEMBER
        /// The cluster node is already a member of the cluster.
        /// </summary>
        ClusterNodeAlreadyMember = 0x13C9,

        /// <summary>
        /// ERROR_CLUSTER_LAST_INTERNAL_NETWORK
        /// The cluster network is the only one configured for internal cluster communication between two or more active cluster nodes. The internal communication capability cannot be removed from the network.
        /// </summary>
        ClusterLastInternalNetwork = 0x13CA,

        /// <summary>
        /// ERROR_CLUSTER_NETWORK_HAS_DEPENDENTS
        /// One or more cluster resources depend on the network to provide service to clients. The client access capability cannot be removed from the network.
        /// </summary>
        ClusterNetworkHasDependents = 0x13CB,

        /// <summary>
        /// ERROR_INVALID_OPERATION_ON_QUORUM
        /// This operation cannot be performed on the cluster resource as it the quorum resource. You may not bring the quorum resource offline or modify its possible owners list.
        /// </summary>
        InvalidOperationOnQuorum = 0x13CC,

        /// <summary>
        /// ERROR_DEPENDENCY_NOT_ALLOWED
        /// The cluster quorum resource is not allowed to have any dependencies.
        /// </summary>
        DependencyNotAllowed = 0x13CD,

        /// <summary>
        /// ERROR_CLUSTER_NODE_PAUSED
        /// The cluster node is paused.
        /// </summary>
        ClusterNodePaused = 0x13CE,

        /// <summary>
        /// ERROR_NODE_CANT_HOST_RESOURCE
        /// The cluster resource cannot be brought online. The owner node cannot run this resource.
        /// </summary>
        NodeCantHostResource = 0x13CF,

        /// <summary>
        /// ERROR_CLUSTER_NODE_NOT_READY
        /// The cluster node is not ready to perform the requested operation.
        /// </summary>
        ClusterNodeNotReady = 0x13D0,

        /// <summary>
        /// ERROR_CLUSTER_NODE_SHUTTING_DOWN
        /// The cluster node is shutting down.
        /// </summary>
        ClusterNodeShuttingDown = 0x13D1,

        /// <summary>
        /// ERROR_CLUSTER_JOIN_ABORTED
        /// The cluster join operation was aborted.
        /// </summary>
        ClusterJoinAborted = 0x13D2,

        /// <summary>
        /// ERROR_CLUSTER_INCOMPATIBLE_VERSIONS
        /// The cluster join operation failed due to incompatible software versions between the joining node and its sponsor.
        /// </summary>
        ClusterIncompatibleVersions = 0x13D3,

        /// <summary>
        /// ERROR_CLUSTER_MAXNUM_OF_RESOURCES_EXCEEDED
        /// This resource cannot be created because the cluster has reached the limit on the number of resources it can monitor.
        /// </summary>
        ClusterMaxnumOfResourcesExceeded = 0x13D4,

        /// <summary>
        /// ERROR_CLUSTER_SYSTEM_CONFIG_CHANGED
        /// The system configuration changed during the cluster join or form operation. The join or form operation was aborted.
        /// </summary>
        ClusterSystemConfigChanged = 0x13D5,

        /// <summary>
        /// ERROR_CLUSTER_RESOURCE_TYPE_NOT_FOUND
        /// The specified resource type was not found.
        /// </summary>
        ClusterResourceTypeNotFound = 0x13D6,

        /// <summary>
        /// ERROR_CLUSTER_RESTYPE_NOT_SUPPORTED
        /// The specified node does not support a resource of this type. This may be due to version inconsistencies or due to the absence of the resource DLL on this node.
        /// </summary>
        ClusterRestypeNotSupported = 0x13D7,

        /// <summary>
        /// ERROR_CLUSTER_RESNAME_NOT_FOUND
        /// The specified resource name is not supported by this resource DLL. This may be due to a bad (or changed) name supplied to the resource DLL.
        /// </summary>
        ClusterResnameNotFound = 0x13D8,

        /// <summary>
        /// ERROR_CLUSTER_NO_RPC_PACKAGES_REGISTERED
        /// No authentication package could be registered with the RPC server.
        /// </summary>
        ClusterNoRpcPackagesRegistered = 0x13D9,

        /// <summary>
        /// ERROR_CLUSTER_OWNER_NOT_IN_PREFLIST
        /// You cannot bring the group online because the owner of the group is not in the preferred list for the group. To change the owner node for the group, move the group.
        /// </summary>
        ClusterOwnerNotInPreflist = 0x13DA,

        /// <summary>
        /// ERROR_CLUSTER_DATABASE_SEQMISMATCH
        /// The join operation failed because the cluster database sequence number has changed or is incompatible with the locker node. This may happen during a join operation if the cluster database was changing during the join.
        /// </summary>
        ClusterDatabaseSeqmismatch = 0x13DB,

        /// <summary>
        /// ERROR_RESMON_INVALID_STATE
        /// The resource monitor will not allow the fail operation to be performed while the resource is in its current state. This may happen if the resource is in a pending state.
        /// </summary>
        ResmonInvalidState = 0x13DC,

        /// <summary>
        /// ERROR_CLUSTER_GUM_NOT_LOCKER
        /// A non locker code got a request to reserve the lock for making global updates.
        /// </summary>
        ClusterGumNotLocker = 0x13DD,

        /// <summary>
        /// ERROR_QUORUM_DISK_NOT_FOUND
        /// The quorum disk could not be located by the cluster service.
        /// </summary>
        QuorumDiskNotFound = 0x13DE,

        /// <summary>
        /// ERROR_DATABASE_BACKUP_CORRUPT
        /// The backed up cluster database is possibly corrupt.
        /// </summary>
        DatabaseBackupCorrupt = 0x13DF,

        /// <summary>
        /// ERROR_CLUSTER_NODE_ALREADY_HAS_DFS_ROOT
        /// A DFS root already exists in this cluster node.
        /// </summary>
        ClusterNodeAlreadyHasDfsRoot = 0x13E0,

        /// <summary>
        /// ERROR_RESOURCE_PROPERTY_UNCHANGEABLE
        /// An attempt to modify a resource property failed because it conflicts with another existing property.
        /// </summary>
        ResourcePropertyUnchangeable = 0x13E1,

        /// <summary>
        /// ERROR_CLUSTER_MEMBERSHIP_INVALID_STATE
        /// An operation was attempted that is incompatible with the current membership state of the node.
        /// </summary>
        ClusterMembershipInvalidState = 0x1702,

        /// <summary>
        /// ERROR_CLUSTER_QUORUMLOG_NOT_FOUND
        /// The quorum resource does not contain the quorum log.
        /// </summary>
        ClusterQuorumlogNotFound = 0x1703,

        /// <summary>
        /// ERROR_CLUSTER_MEMBERSHIP_HALT
        /// The membership engine requested shutdown of the cluster service on this node.
        /// </summary>
        ClusterMembershipHalt = 0x1704,

        /// <summary>
        /// ERROR_CLUSTER_INSTANCE_ID_MISMATCH
        /// The join operation failed because the cluster instance ID of the joining node does not match the cluster instance ID of the sponsor node.
        /// </summary>
        ClusterInstanceIdMismatch = 0x1705,

        /// <summary>
        /// ERROR_CLUSTER_NETWORK_NOT_FOUND_FOR_IP
        /// A matching cluster network for the specified IP address could not be found.
        /// </summary>
        ClusterNetworkNotFoundForIp = 0x1706,

        /// <summary>
        /// ERROR_CLUSTER_PROPERTY_DATA_TYPE_MISMATCH
        /// The actual data type of the property did not match the expected data type of the property.
        /// </summary>
        ClusterPropertyDataTypeMismatch = 0x1707,

        /// <summary>
        /// ERROR_CLUSTER_EVICT_WITHOUT_CLEANUP
        /// The cluster node was evicted from the cluster successfully, but the node was not cleaned up. To determine what cleanup steps failed and how to recover, see the Failover Clustering application event log using Event Viewer.
        /// </summary>
        ClusterEvictWithoutCleanup = 0x1708,

        /// <summary>
        /// ERROR_CLUSTER_PARAMETER_MISMATCH
        /// Two or more parameter values specified for a resource's properties are in conflict.
        /// </summary>
        ClusterParameterMismatch = 0x1709,

        /// <summary>
        /// ERROR_NODE_CANNOT_BE_CLUSTERED
        /// This computer cannot be made a member of a cluster.
        /// </summary>
        NodeCannotBeClustered = 0x170A,

        /// <summary>
        /// ERROR_CLUSTER_WRONG_OS_VERSION
        /// This computer cannot be made a member of a cluster because it does not have the correct version of Windows installed.
        /// </summary>
        ClusterWrongOsVersion = 0x170B,

        /// <summary>
        /// ERROR_CLUSTER_CANT_CREATE_DUP_CLUSTER_NAME
        /// A cluster cannot be created with the specified cluster name because that cluster name is already in use. Specify a different name for the cluster.
        /// </summary>
        ClusterCantCreateDupClusterName = 0x170C,

        /// <summary>
        /// ERROR_CLUSCFG_ALREADY_COMMITTED
        /// The cluster configuration action has already been committed.
        /// </summary>
        CluscfgAlreadyCommitted = 0x170D,

        /// <summary>
        /// ERROR_CLUSCFG_ROLLBACK_FAILED
        /// The cluster configuration action could not be rolled back.
        /// </summary>
        CluscfgRollbackFailed = 0x170E,

        /// <summary>
        /// ERROR_CLUSCFG_SYSTEM_DISK_DRIVE_LETTER_CONFLICT
        /// The drive letter assigned to a system disk on one node conflicted with the drive letter assigned to a disk on another node.
        /// </summary>
        CluscfgSystemDiskDriveLetterConflict = 0x170F,

        /// <summary>
        /// ERROR_CLUSTER_OLD_VERSION
        /// One or more nodes in the cluster are running a version of Windows that does not support this operation.
        /// </summary>
        ClusterOldVersion = 0x1710,

        /// <summary>
        /// ERROR_CLUSTER_MISMATCHED_COMPUTER_ACCT_NAME
        /// The name of the corresponding computer account doesn't match the Network Name for this resource.
        /// </summary>
        ClusterMismatchedComputerAcctName = 0x1711,

        /// <summary>
        /// ERROR_CLUSTER_NO_NET_ADAPTERS
        /// No network adapters are available.
        /// </summary>
        ClusterNoNetAdapters = 0x1712,

        /// <summary>
        /// ERROR_CLUSTER_POISONED
        /// The cluster node has been poisoned.
        /// </summary>
        ClusterPoisoned = 0x1713,

        /// <summary>
        /// ERROR_CLUSTER_GROUP_MOVING
        /// The group is unable to accept the request since it is moving to another node.
        /// </summary>
        ClusterGroupMoving = 0x1714,

        /// <summary>
        /// ERROR_CLUSTER_RESOURCE_TYPE_BUSY
        /// The resource type cannot accept the request since is too busy performing another operation.
        /// </summary>
        ClusterResourceTypeBusy = 0x1715,

        /// <summary>
        /// ERROR_RESOURCE_CALL_TIMED_OUT
        /// The call to the cluster resource DLL timed out.
        /// </summary>
        ResourceCallTimedOut = 0x1716,

        /// <summary>
        /// ERROR_INVALID_CLUSTER_IPV6_ADDRESS
        /// The address is not valid for an IPv6 Address resource. A global IPv6 address is required, and it must match a cluster network. Compatibility addresses are not permitted.
        /// </summary>
        InvalidClusterIpv6Address = 0x1717,

        /// <summary>
        /// ERROR_CLUSTER_INTERNAL_INVALID_FUNCTION
        /// An internal cluster error occurred. A call to an invalid function was attempted.
        /// </summary>
        ClusterInternalInvalidFunction = 0x1718,

        /// <summary>
        /// ERROR_CLUSTER_PARAMETER_OUT_OF_BOUNDS
        /// A parameter value is out of acceptable range.
        /// </summary>
        ClusterParameterOutOfBounds = 0x1719,

        /// <summary>
        /// ERROR_CLUSTER_PARTIAL_SEND
        /// A network error occurred while sending data to another node in the cluster. The number of bytes transmitted was less than required.
        /// </summary>
        ClusterPartialSend = 0x171A,

        /// <summary>
        /// ERROR_CLUSTER_REGISTRY_INVALID_FUNCTION
        /// An invalid cluster registry operation was attempted.
        /// </summary>
        ClusterRegistryInvalidFunction = 0x171B,

        /// <summary>
        /// ERROR_CLUSTER_INVALID_STRING_TERMINATION
        /// An input string of characters is not properly terminated.
        /// </summary>
        ClusterInvalidStringTermination = 0x171C,

        /// <summary>
        /// ERROR_CLUSTER_INVALID_STRING_FORMAT
        /// An input string of characters is not in a valid format for the data it represents.
        /// </summary>
        ClusterInvalidStringFormat = 0x171D,

        /// <summary>
        /// ERROR_CLUSTER_DATABASE_TRANSACTION_IN_PROGRESS
        /// An internal cluster error occurred. A cluster database transaction was attempted while a transaction was already in progress.
        /// </summary>
        ClusterDatabaseTransactionInProgress = 0x171E,

        /// <summary>
        /// ERROR_CLUSTER_DATABASE_TRANSACTION_NOT_IN_PROGRESS
        /// An internal cluster error occurred. There was an attempt to commit a cluster database transaction while no transaction was in progress.
        /// </summary>
        ClusterDatabaseTransactionNotInProgress = 0x171F,

        /// <summary>
        /// ERROR_CLUSTER_NULL_DATA
        /// An internal cluster error occurred. Data was not properly initialized.
        /// </summary>
        ClusterNullData = 0x1720,

        /// <summary>
        /// ERROR_CLUSTER_PARTIAL_READ
        /// An error occurred while reading from a stream of data. An unexpected number of bytes was returned.
        /// </summary>
        ClusterPartialRead = 0x1721,

        /// <summary>
        /// ERROR_CLUSTER_PARTIAL_WRITE
        /// An error occurred while writing to a stream of data. The required number of bytes could not be written.
        /// </summary>
        ClusterPartialWrite = 0x1722,

        /// <summary>
        /// ERROR_CLUSTER_CANT_DESERIALIZE_DATA
        /// An error occurred while deserializing a stream of cluster data.
        /// </summary>
        ClusterCantDeserializeData = 0x1723,

        /// <summary>
        /// ERROR_DEPENDENT_RESOURCE_PROPERTY_CONFLICT
        /// One or more property values for this resource are in conflict with one or more property values associated with its dependent resource(s).
        /// </summary>
        DependentResourcePropertyConflict = 0x1724,

        /// <summary>
        /// ERROR_CLUSTER_NO_QUORUM
        /// A quorum of cluster nodes was not present to form a cluster.
        /// </summary>
        ClusterNoQuorum = 0x1725,

        /// <summary>
        /// ERROR_CLUSTER_INVALID_IPV6_NETWORK
        /// The cluster network is not valid for an IPv6 Address resource, or it does not match the configured address.
        /// </summary>
        ClusterInvalidIpv6Network = 0x1726,

        /// <summary>
        /// ERROR_CLUSTER_INVALID_IPV6_TUNNEL_NETWORK
        /// The cluster network is not valid for an IPv6 Tunnel resource. Check the configuration of the IP Address resource on which the IPv6 Tunnel resource depends.
        /// </summary>
        ClusterInvalidIpv6TunnelNetwork = 0x1727,

        /// <summary>
        /// ERROR_QUORUM_NOT_ALLOWED_IN_THIS_GROUP
        /// Quorum resource cannot reside in the Available Storage group.
        /// </summary>
        QuorumNotAllowedInThisGroup = 0x1728,

        /// <summary>
        /// ERROR_DEPENDENCY_TREE_TOO_COMPLEX
        /// The dependencies for this resource are nested too deeply.
        /// </summary>
        DependencyTreeTooComplex = 0x1729,

        /// <summary>
        /// ERROR_EXCEPTION_IN_RESOURCE_CALL
        /// The call into the resource DLL raised an unhandled exception.
        /// </summary>
        ExceptionInResourceCall = 0x172A,

        /// <summary>
        /// ERROR_CLUSTER_RHS_FAILED_INITIALIZATION
        /// The RHS process failed to initialize.
        /// </summary>
        ClusterRhsFailedInitialization = 0x172B,

        /// <summary>
        /// ERROR_CLUSTER_NOT_INSTALLED
        /// The Failover Clustering feature is not installed on this node.
        /// </summary>
        ClusterNotInstalled = 0x172C,

        /// <summary>
        /// ERROR_CLUSTER_RESOURCES_MUST_BE_ONLINE_ON_THE_SAME_NODE
        /// The resources must be online on the same node for this operation.
        /// </summary>
        ClusterResourcesMustBeOnlineOnTheSameNode = 0x172D,

        /// <summary>
        /// ERROR_CLUSTER_MAX_NODES_IN_CLUSTER
        /// A new node can not be added since this cluster is already at its maximum number of nodes.
        /// </summary>
        ClusterMaxNodesInCluster = 0x172E,

        /// <summary>
        /// ERROR_CLUSTER_TOO_MANY_NODES
        /// This cluster can not be created since the specified number of nodes exceeds the maximum allowed limit.
        /// </summary>
        ClusterTooManyNodes = 0x172F,

        /// <summary>
        /// ERROR_CLUSTER_OBJECT_ALREADY_USED
        /// An attempt to use the specified cluster name failed because an enabled computer object with the given name already exists in the domain.
        /// </summary>
        ClusterObjectAlreadyUsed = 0x1730,

        /// <summary>
        /// ERROR_NONCORE_GROUPS_FOUND
        /// This cluster cannot be destroyed. It has non-core application groups which must be deleted before the cluster can be destroyed.
        /// </summary>
        NoncoreGroupsFound = 0x1731,

        /// <summary>
        /// ERROR_FILE_SHARE_RESOURCE_CONFLICT
        /// File share associated with file share witness resource cannot be hosted by this cluster or any of its nodes.
        /// </summary>
        FileShareResourceConflict = 0x1732,

        /// <summary>
        /// ERROR_CLUSTER_EVICT_INVALID_REQUEST
        /// Eviction of this node is invalid at this time. Due to quorum requirements node eviction will result in cluster shutdown. If it is the last node in the cluster, destroy cluster command should be used.
        /// </summary>
        ClusterEvictInvalidRequest = 0x1733,

        /// <summary>
        /// ERROR_CLUSTER_SINGLETON_RESOURCE
        /// Only one instance of this resource type is allowed in the cluster.
        /// </summary>
        ClusterSingletonResource = 0x1734,

        /// <summary>
        /// ERROR_CLUSTER_GROUP_SINGLETON_RESOURCE
        /// Only one instance of this resource type is allowed per resource group.
        /// </summary>
        ClusterGroupSingletonResource = 0x1735,

        /// <summary>
        /// ERROR_CLUSTER_RESOURCE_PROVIDER_FAILED
        /// The resource failed to come online due to the failure of one or more provider resources.
        /// </summary>
        ClusterResourceProviderFailed = 0x1736,

        /// <summary>
        /// ERROR_CLUSTER_RESOURCE_CONFIGURATION_ERROR
        /// The resource has indicated that it cannot come online on any node.
        /// </summary>
        ClusterResourceConfigurationError = 0x1737,

        /// <summary>
        /// ERROR_CLUSTER_GROUP_BUSY
        /// The current operation cannot be performed on this group at this time.
        /// </summary>
        ClusterGroupBusy = 0x1738,

        /// <summary>
        /// ERROR_CLUSTER_NOT_SHARED_VOLUME
        /// The directory or file is not located on a cluster shared volume.
        /// </summary>
        ClusterNotSharedVolume = 0x1739,

        /// <summary>
        /// ERROR_CLUSTER_INVALID_SECURITY_DESCRIPTOR
        /// The Security Descriptor does not meet the requirements for a cluster.
        /// </summary>
        ClusterInvalidSecurityDescriptor = 0x173A,

        /// <summary>
        /// ERROR_CLUSTER_SHARED_VOLUMES_IN_USE
        /// There is one or more shared volumes resources configured in the cluster. Those resources must be moved to available storage in order for operation to succeed.
        /// </summary>
        ClusterSharedVolumesInUse = 0x173B,

        /// <summary>
        /// ERROR_CLUSTER_USE_SHARED_VOLUMES_API
        /// This group or resource cannot be directly manipulated. Use shared volume APIs to perform desired operation.
        /// </summary>
        ClusterUseSharedVolumesApi = 0x173C,

        /// <summary>
        /// ERROR_CLUSTER_BACKUP_IN_PROGRESS
        /// Back up is in progress. Please wait for backup completion before trying this operation again.
        /// </summary>
        ClusterBackupInProgress = 0x173D,

        /// <summary>
        /// ERROR_NON_CSV_PATH
        /// The path does not belong to a cluster shared volume.
        /// </summary>
        NonCsvPath = 0x173E,

        /// <summary>
        /// ERROR_CSV_VOLUME_NOT_LOCAL
        /// The cluster shared volume is not locally mounted on this node.
        /// </summary>
        CsvVolumeNotLocal = 0x173F,

        /// <summary>
        /// ERROR_CLUSTER_WATCHDOG_TERMINATING
        /// The cluster watchdog is terminating.
        /// </summary>
        ClusterWatchdogTerminating = 0x1740,

        /// <summary>
        /// ERROR_CLUSTER_RESOURCE_VETOED_MOVE_INCOMPATIBLE_NODES
        /// A resource vetoed a move between two nodes because they are incompatible.
        /// </summary>
        ClusterResourceVetoedMoveIncompatibleNodes = 0x1741,

        /// <summary>
        /// ERROR_CLUSTER_INVALID_NODE_WEIGHT
        /// The request is invalid either because node weight cannot be changed while the cluster is in disk-only quorum mode, or because changing the node weight would violate the minimum cluster quorum requirements.
        /// </summary>
        ClusterInvalidNodeWeight = 0x1742,

        /// <summary>
        /// ERROR_CLUSTER_RESOURCE_VETOED_CALL
        /// The resource vetoed the call.
        /// </summary>
        ClusterResourceVetoedCall = 0x1743,

        /// <summary>
        /// ERROR_RESMON_SYSTEM_RESOURCES_LACKING
        /// Resource could not start or run because it could not reserve sufficient system resources.
        /// </summary>
        ResmonSystemResourcesLacking = 0x1744,

        /// <summary>
        /// ERROR_CLUSTER_RESOURCE_VETOED_MOVE_NOT_ENOUGH_RESOURCES_ON_DESTINATION
        /// A resource vetoed a move between two nodes because the destination currently does not have enough resources to complete the operation.
        /// </summary>
        ClusterResourceVetoedMoveNotEnoughResourcesOnDestination = 0x1745,

        /// <summary>
        /// ERROR_CLUSTER_RESOURCE_VETOED_MOVE_NOT_ENOUGH_RESOURCES_ON_SOURCE
        /// A resource vetoed a move between two nodes because the source currently does not have enough resources to complete the operation.
        /// </summary>
        ClusterResourceVetoedMoveNotEnoughResourcesOnSource = 0x1746,

        /// <summary>
        /// ERROR_CLUSTER_GROUP_QUEUED
        /// The requested operation can not be completed because the group is queued for an operation.
        /// </summary>
        ClusterGroupQueued = 0x1747,

        /// <summary>
        /// ERROR_CLUSTER_RESOURCE_LOCKED_STATUS
        /// The requested operation can not be completed because a resource has locked status.
        /// </summary>
        ClusterResourceLockedStatus = 0x1748,

        /// <summary>
        /// ERROR_CLUSTER_SHARED_VOLUME_FAILOVER_NOT_ALLOWED
        /// The resource cannot move to another node because a cluster shared volume vetoed the operation.
        /// </summary>
        ClusterSharedVolumeFailoverNotAllowed = 0x1749,

        /// <summary>
        /// ERROR_CLUSTER_NODE_DRAIN_IN_PROGRESS
        /// A node drain is already in progress.
        /// This value was also named ERROR_CLUSTER_NODE_EVACUATION_IN_PROGRESS
        /// </summary>
        ClusterNodeDrainInProgress = 0x174A,

        /// <summary>
        /// ERROR_CLUSTER_DISK_NOT_CONNECTED
        /// Clustered storage is not connected to the node.
        /// </summary>
        ClusterDiskNotConnected = 0x174B,

        /// <summary>
        /// ERROR_DISK_NOT_CSV_CAPABLE
        /// The disk is not configured in a way to be used with CSV. CSV disks must have at least one partition that is formatted with NTFS.
        /// </summary>
        DiskNotCsvCapable = 0x174C,

        /// <summary>
        /// ERROR_RESOURCE_NOT_IN_AVAILABLE_STORAGE
        /// The resource must be part of the Available Storage group to complete this action.
        /// </summary>
        ResourceNotInAvailableStorage = 0x174D,

        /// <summary>
        /// ERROR_CLUSTER_SHARED_VOLUME_REDIRECTED
        /// CSVFS failed operation as volume is in redirected mode.
        /// </summary>
        ClusterSharedVolumeRedirected = 0x174E,

        /// <summary>
        /// ERROR_CLUSTER_SHARED_VOLUME_NOT_REDIRECTED
        /// CSVFS failed operation as volume is not in redirected mode.
        /// </summary>
        ClusterSharedVolumeNotRedirected = 0x174F,

        /// <summary>
        /// ERROR_CLUSTER_CANNOT_RETURN_PROPERTIES
        /// Cluster properties cannot be returned at this time.
        /// </summary>
        ClusterCannotReturnProperties = 0x1750,

        /// <summary>
        /// ERROR_CLUSTER_RESOURCE_CONTAINS_UNSUPPORTED_DIFF_AREA_FOR_SHARED_VOLUMES
        /// The clustered disk resource contains software snapshot diff area that are not supported for Cluster Shared Volumes.
        /// </summary>
        ClusterResourceContainsUnsupportedDiffAreaForSharedVolumes = 0x1751,

        /// <summary>
        /// ERROR_CLUSTER_RESOURCE_IS_IN_MAINTENANCE_MODE
        /// The operation cannot be completed because the resource is in maintenance mode.
        /// </summary>
        ClusterResourceIsInMaintenanceMode = 0x1752,

        /// <summary>
        /// ERROR_CLUSTER_AFFINITY_CONFLICT
        /// The operation cannot be completed because of cluster affinity conflicts.
        /// </summary>
        ClusterAffinityConflict = 0x1753,

        /// <summary>
        /// ERROR_CLUSTER_RESOURCE_IS_REPLICA_VIRTUAL_MACHINE
        /// The operation cannot be completed because the resource is a replica virtual machine.
        /// </summary>
        ClusterResourceIsReplicaVirtualMachine = 0x1754,

        /// <summary>
        /// ERROR_ENCRYPTION_FAILED
        /// The specified file could not be encrypted.
        /// </summary>
        EncryptionFailed = 0x1770,

        /// <summary>
        /// ERROR_DECRYPTION_FAILED
        /// The specified file could not be decrypted.
        /// </summary>
        DecryptionFailed = 0x1771,

        /// <summary>
        /// ERROR_FILE_ENCRYPTED
        /// The specified file is encrypted and the user does not have the ability to decrypt it.
        /// </summary>
        FileEncrypted = 0x1772,

        /// <summary>
        /// ERROR_NO_RECOVERY_POLICY
        /// There is no valid encryption recovery policy configured for this system.
        /// </summary>
        NoRecoveryPolicy = 0x1773,

        /// <summary>
        /// ERROR_NO_EFS
        /// The required encryption driver is not loaded for this system.
        /// </summary>
        NoEfs = 0x1774,

        /// <summary>
        /// ERROR_WRONG_EFS
        /// The file was encrypted with a different encryption driver than is currently loaded.
        /// </summary>
        WrongEfs = 0x1775,

        /// <summary>
        /// ERROR_NO_USER_KEYS
        /// There are no EFS keys defined for the user.
        /// </summary>
        NoUserKeys = 0x1776,

        /// <summary>
        /// ERROR_FILE_NOT_ENCRYPTED
        /// The specified file is not encrypted.
        /// </summary>
        FileNotEncrypted = 0x1777,

        /// <summary>
        /// ERROR_NOT_EXPORT_FORMAT
        /// The specified file is not in the defined EFS export format.
        /// </summary>
        NotExportFormat = 0x1778,

        /// <summary>
        /// ERROR_FILE_READ_ONLY
        /// The specified file is read only.
        /// </summary>
        FileReadOnly = 0x1779,

        /// <summary>
        /// ERROR_DIR_EFS_DISALLOWED
        /// The directory has been disabled for encryption.
        /// </summary>
        DirEfsDisallowed = 0x177A,

        /// <summary>
        /// ERROR_EFS_SERVER_NOT_TRUSTED
        /// The server is not trusted for remote encryption operation.
        /// </summary>
        EfsServerNotTrusted = 0x177B,

        /// <summary>
        /// ERROR_BAD_RECOVERY_POLICY
        /// Recovery policy configured for this system contains invalid recovery certificate.
        /// </summary>
        BadRecoveryPolicy = 0x177C,

        /// <summary>
        /// ERROR_EFS_ALG_BLOB_TOO_BIG
        /// The encryption algorithm used on the source file needs a bigger key buffer than the one on the destination file.
        /// </summary>
        EfsAlgBlobTooBig = 0x177D,

        /// <summary>
        /// ERROR_VOLUME_NOT_SUPPORT_EFS
        /// The disk partition does not support file encryption.
        /// </summary>
        VolumeNotSupportEfs = 0x177E,

        /// <summary>
        /// ERROR_EFS_DISABLED
        /// This machine is disabled for file encryption.
        /// </summary>
        EfsDisabled = 0x177F,

        /// <summary>
        /// ERROR_EFS_VERSION_NOT_SUPPORT
        /// A newer system is required to decrypt this encrypted file.
        /// </summary>
        EfsVersionNotSupport = 0x1780,

        /// <summary>
        /// ERROR_CS_ENCRYPTION_INVALID_SERVER_RESPONSE
        /// The remote server sent an invalid response for a file being opened with Client Side Encryption.
        /// </summary>
        CsEncryptionInvalidServerResponse = 0x1781,

        /// <summary>
        /// ERROR_CS_ENCRYPTION_UNSUPPORTED_SERVER
        /// Client Side Encryption is not supported by the remote server even though it claims to support it.
        /// </summary>
        CsEncryptionUnsupportedServer = 0x1782,

        /// <summary>
        /// ERROR_CS_ENCRYPTION_EXISTING_ENCRYPTED_FILE
        /// File is encrypted and should be opened in Client Side Encryption mode.
        /// </summary>
        CsEncryptionExistingEncryptedFile = 0x1783,

        /// <summary>
        /// ERROR_CS_ENCRYPTION_NEW_ENCRYPTED_FILE
        /// A new encrypted file is being created and a $EFS needs to be provided.
        /// </summary>
        CsEncryptionNewEncryptedFile = 0x1784,

        /// <summary>
        /// ERROR_CS_ENCRYPTION_FILE_NOT_CSE
        /// The SMB client requested a CSE FSCTL on a non-CSE file.
        /// </summary>
        CsEncryptionFileNotCse = 0x1785,

        /// <summary>
        /// ERROR_ENCRYPTION_POLICY_DENIES_OPERATION
        /// The requested operation was blocked by policy. For more information, contact your system administrator.
        /// </summary>
        EncryptionPolicyDeniesOperation = 0x1786,

        /// <summary>
        /// ERROR_NO_BROWSER_SERVERS_FOUND
        /// The list of servers for this workgroup is not currently available.
        /// </summary>
        NoBrowserServersFound = 0x17E6,

        /// <summary>
        /// SCHED_E_SERVICE_NOT_LOCALSYSTEM
        /// The Task Scheduler service must be configured to run in the System account to function properly. Individual tasks may be configured to run in other accounts.
        /// </summary>
        SchedEServiceNotLocalsystem = 0x1838,

        /// <summary>
        /// ERROR_LOG_SECTOR_INVALID
        /// Log service encountered an invalid log sector.
        /// </summary>
        LogSectorInvalid = 0x19C8,

        /// <summary>
        /// ERROR_LOG_SECTOR_PARITY_INVALID
        /// Log service encountered a log sector with invalid block parity.
        /// </summary>
        LogSectorParityInvalid = 0x19C9,

        /// <summary>
        /// ERROR_LOG_SECTOR_REMAPPED
        /// Log service encountered a remapped log sector.
        /// </summary>
        LogSectorRemapped = 0x19CA,

        /// <summary>
        /// ERROR_LOG_BLOCK_INCOMPLETE
        /// Log service encountered a partial or incomplete log block.
        /// </summary>
        LogBlockIncomplete = 0x19CB,

        /// <summary>
        /// ERROR_LOG_INVALID_RANGE
        /// Log service encountered an attempt access data outside the active log range.
        /// </summary>
        LogInvalidRange = 0x19CC,

        /// <summary>
        /// ERROR_LOG_BLOCKS_EXHAUSTED
        /// Log service user marshalling buffers are exhausted.
        /// </summary>
        LogBlocksExhausted = 0x19CD,

        /// <summary>
        /// ERROR_LOG_READ_CONTEXT_INVALID
        /// Log service encountered an attempt read from a marshalling area with an invalid read context.
        /// </summary>
        LogReadContextInvalid = 0x19CE,

        /// <summary>
        /// ERROR_LOG_RESTART_INVALID
        /// Log service encountered an invalid log restart area.
        /// </summary>
        LogRestartInvalid = 0x19CF,

        /// <summary>
        /// ERROR_LOG_BLOCK_VERSION
        /// Log service encountered an invalid log block version.
        /// </summary>
        LogBlockVersion = 0x19D0,

        /// <summary>
        /// ERROR_LOG_BLOCK_INVALID
        /// Log service encountered an invalid log block.
        /// </summary>
        LogBlockInvalid = 0x19D1,

        /// <summary>
        /// ERROR_LOG_READ_MODE_INVALID
        /// Log service encountered an attempt to read the log with an invalid read mode.
        /// </summary>
        LogReadModeInvalid = 0x19D2,

        /// <summary>
        /// ERROR_LOG_NO_RESTART
        /// Log service encountered a log stream with no restart area.
        /// </summary>
        LogNoRestart = 0x19D3,

        /// <summary>
        /// ERROR_LOG_METADATA_CORRUPT
        /// Log service encountered a corrupted metadata file.
        /// </summary>
        LogMetadataCorrupt = 0x19D4,

        /// <summary>
        /// ERROR_LOG_METADATA_INVALID
        /// Log service encountered a metadata file that could not be created by the log file system.
        /// </summary>
        LogMetadataInvalid = 0x19D5,

        /// <summary>
        /// ERROR_LOG_METADATA_INCONSISTENT
        /// Log service encountered a metadata file with inconsistent data.
        /// </summary>
        LogMetadataInconsistent = 0x19D6,

        /// <summary>
        /// ERROR_LOG_RESERVATION_INVALID
        /// Log service encountered an attempt to erroneous allocate or dispose reservation space.
        /// </summary>
        LogReservationInvalid = 0x19D7,

        /// <summary>
        /// ERROR_LOG_CANT_DELETE
        /// Log service cannot delete log file or file system container.
        /// </summary>
        LogCantDelete = 0x19D8,

        /// <summary>
        /// ERROR_LOG_CONTAINER_LIMIT_EXCEEDED
        /// Log service has reached the maximum allowable containers allocated to a log file.
        /// </summary>
        LogContainerLimitExceeded = 0x19D9,

        /// <summary>
        /// ERROR_LOG_START_OF_LOG
        /// Log service has attempted to read or write backward past the start of the log.
        /// </summary>
        LogStartOfLog = 0x19DA,

        /// <summary>
        /// ERROR_LOG_POLICY_ALREADY_INSTALLED
        /// Log policy could not be installed because a policy of the same type is already present.
        /// </summary>
        LogPolicyAlreadyInstalled = 0x19DB,

        /// <summary>
        /// ERROR_LOG_POLICY_NOT_INSTALLED
        /// Log policy in question was not installed at the time of the request.
        /// </summary>
        LogPolicyNotInstalled = 0x19DC,

        /// <summary>
        /// ERROR_LOG_POLICY_INVALID
        /// The installed set of policies on the log is invalid.
        /// </summary>
        LogPolicyInvalid = 0x19DD,

        /// <summary>
        /// ERROR_LOG_POLICY_CONFLICT
        /// A policy on the log in question prevented the operation from completing.
        /// </summary>
        LogPolicyConflict = 0x19DE,

        /// <summary>
        /// ERROR_LOG_PINNED_ARCHIVE_TAIL
        /// Log space cannot be reclaimed because the log is pinned by the archive tail.
        /// </summary>
        LogPinnedArchiveTail = 0x19DF,

        /// <summary>
        /// ERROR_LOG_RECORD_NONEXISTENT
        /// Log record is not a record in the log file.
        /// </summary>
        LogRecordNonexistent = 0x19E0,

        /// <summary>
        /// ERROR_LOG_RECORDS_RESERVED_INVALID
        /// Number of reserved log records or the adjustment of the number of reserved log records is invalid.
        /// </summary>
        LogRecordsReservedInvalid = 0x19E1,

        /// <summary>
        /// ERROR_LOG_SPACE_RESERVED_INVALID
        /// Reserved log space or the adjustment of the log space is invalid.
        /// </summary>
        LogSpaceReservedInvalid = 0x19E2,

        /// <summary>
        /// ERROR_LOG_TAIL_INVALID
        /// An new or existing archive tail or base of the active log is invalid.
        /// </summary>
        LogTailInvalid = 0x19E3,

        /// <summary>
        /// ERROR_LOG_FULL
        /// Log space is exhausted.
        /// </summary>
        LogFull = 0x19E4,

        /// <summary>
        /// ERROR_COULD_NOT_RESIZE_LOG
        /// The log could not be set to the requested size.
        /// </summary>
        CouldNotResizeLog = 0x19E5,

        /// <summary>
        /// ERROR_LOG_MULTIPLEXED
        /// Log is multiplexed, no direct writes to the physical log is allowed.
        /// </summary>
        LogMultiplexed = 0x19E6,

        /// <summary>
        /// ERROR_LOG_DEDICATED
        /// The operation failed because the log is a dedicated log.
        /// </summary>
        LogDedicated = 0x19E7,

        /// <summary>
        /// ERROR_LOG_ARCHIVE_NOT_IN_PROGRESS
        /// The operation requires an archive context.
        /// </summary>
        LogArchiveNotInProgress = 0x19E8,

        /// <summary>
        /// ERROR_LOG_ARCHIVE_IN_PROGRESS
        /// Log archival is in progress.
        /// </summary>
        LogArchiveInProgress = 0x19E9,

        /// <summary>
        /// ERROR_LOG_EPHEMERAL
        /// The operation requires a non-ephemeral log, but the log is ephemeral.
        /// </summary>
        LogEphemeral = 0x19EA,

        /// <summary>
        /// ERROR_LOG_NOT_ENOUGH_CONTAINERS
        /// The log must have at least two containers before it can be read from or written to.
        /// </summary>
        LogNotEnoughContainers = 0x19EB,

        /// <summary>
        /// ERROR_LOG_CLIENT_ALREADY_REGISTERED
        /// A log client has already registered on the stream.
        /// </summary>
        LogClientAlreadyRegistered = 0x19EC,

        /// <summary>
        /// ERROR_LOG_CLIENT_NOT_REGISTERED
        /// A log client has not been registered on the stream.
        /// </summary>
        LogClientNotRegistered = 0x19ED,

        /// <summary>
        /// ERROR_LOG_FULL_HANDLER_IN_PROGRESS
        /// A request has already been made to handle the log full condition.
        /// </summary>
        LogFullHandlerInProgress = 0x19EE,

        /// <summary>
        /// ERROR_LOG_CONTAINER_READ_FAILED
        /// Log service encountered an error when attempting to read from a log container.
        /// </summary>
        LogContainerReadFailed = 0x19EF,

        /// <summary>
        /// ERROR_LOG_CONTAINER_WRITE_FAILED
        /// Log service encountered an error when attempting to write to a log container.
        /// </summary>
        LogContainerWriteFailed = 0x19F0,

        /// <summary>
        /// ERROR_LOG_CONTAINER_OPEN_FAILED
        /// Log service encountered an error when attempting open a log container.
        /// </summary>
        LogContainerOpenFailed = 0x19F1,

        /// <summary>
        /// ERROR_LOG_CONTAINER_STATE_INVALID
        /// Log service encountered an invalid container state when attempting a requested action.
        /// </summary>
        LogContainerStateInvalid = 0x19F2,

        /// <summary>
        /// ERROR_LOG_STATE_INVALID
        /// Log service is not in the correct state to perform a requested action.
        /// </summary>
        LogStateInvalid = 0x19F3,

        /// <summary>
        /// ERROR_LOG_PINNED
        /// Log space cannot be reclaimed because the log is pinned.
        /// </summary>
        LogPinned = 0x19F4,

        /// <summary>
        /// ERROR_LOG_METADATA_FLUSH_FAILED
        /// Log metadata flush failed.
        /// </summary>
        LogMetadataFlushFailed = 0x19F5,

        /// <summary>
        /// ERROR_LOG_INCONSISTENT_SECURITY
        /// Security on the log and its containers is inconsistent.
        /// </summary>
        LogInconsistentSecurity = 0x19F6,

        /// <summary>
        /// ERROR_LOG_APPENDED_FLUSH_FAILED
        /// Records were appended to the log or reservation changes were made, but the log could not be flushed.
        /// </summary>
        LogAppendedFlushFailed = 0x19F7,

        /// <summary>
        /// ERROR_LOG_PINNED_RESERVATION
        /// The log is pinned due to reservation consuming most of the log space. Free some reserved records to make space available.
        /// </summary>
        LogPinnedReservation = 0x19F8,

        /// <summary>
        /// ERROR_INVALID_TRANSACTION
        /// The transaction handle associated with this operation is not valid.
        /// </summary>
        InvalidTransaction = 0x1A2C,

        /// <summary>
        /// ERROR_TRANSACTION_NOT_ACTIVE
        /// The requested operation was made in the context of a transaction that is no longer active.
        /// </summary>
        TransactionNotActive = 0x1A2D,

        /// <summary>
        /// ERROR_TRANSACTION_REQUEST_NOT_VALID
        /// The requested operation is not valid on the Transaction object in its current state.
        /// </summary>
        TransactionRequestNotValid = 0x1A2E,

        /// <summary>
        /// ERROR_TRANSACTION_NOT_REQUESTED
        /// The caller has called a response API, but the response is not expected because the TM did not issue the corresponding request to the caller.
        /// </summary>
        TransactionNotRequested = 0x1A2F,

        /// <summary>
        /// ERROR_TRANSACTION_ALREADY_ABORTED
        /// It is too late to perform the requested operation, since the Transaction has already been aborted.
        /// </summary>
        TransactionAlreadyAborted = 0x1A30,

        /// <summary>
        /// ERROR_TRANSACTION_ALREADY_COMMITTED
        /// It is too late to perform the requested operation, since the Transaction has already been committed.
        /// </summary>
        TransactionAlreadyCommitted = 0x1A31,

        /// <summary>
        /// ERROR_TM_INITIALIZATION_FAILED
        /// The Transaction Manager was unable to be successfully initialized. Transacted operations are not supported.
        /// </summary>
        TmInitializationFailed = 0x1A32,

        /// <summary>
        /// ERROR_RESOURCEMANAGER_READ_ONLY
        /// The specified ResourceManager made no changes or updates to the resource under this transaction.
        /// </summary>
        ResourcemanagerReadOnly = 0x1A33,

        /// <summary>
        /// ERROR_TRANSACTION_NOT_JOINED
        /// The resource manager has attempted to prepare a transaction that it has not successfully joined.
        /// </summary>
        TransactionNotJoined = 0x1A34,

        /// <summary>
        /// ERROR_TRANSACTION_SUPERIOR_EXISTS
        /// The Transaction object already has a superior enlistment, and the caller attempted an operation that would have created a new superior. Only a single superior enlistment is allow.
        /// </summary>
        TransactionSuperiorExists = 0x1A35,

        /// <summary>
        /// ERROR_CRM_PROTOCOL_ALREADY_EXISTS
        /// The RM tried to register a protocol that already exists.
        /// </summary>
        CrmProtocolAlreadyExists = 0x1A36,

        /// <summary>
        /// ERROR_TRANSACTION_PROPAGATION_FAILED
        /// The attempt to propagate the Transaction failed.
        /// </summary>
        TransactionPropagationFailed = 0x1A37,

        /// <summary>
        /// ERROR_CRM_PROTOCOL_NOT_FOUND
        /// The requested propagation protocol was not registered as a CRM.
        /// </summary>
        CrmProtocolNotFound = 0x1A38,

        /// <summary>
        /// ERROR_TRANSACTION_INVALID_MARSHALL_BUFFER
        /// The buffer passed in to PushTransaction or PullTransaction is not in a valid format.
        /// </summary>
        TransactionInvalidMarshallBuffer = 0x1A39,

        /// <summary>
        /// ERROR_CURRENT_TRANSACTION_NOT_VALID
        /// The current transaction context associated with the thread is not a valid handle to a transaction object.
        /// </summary>
        CurrentTransactionNotValid = 0x1A3A,

        /// <summary>
        /// ERROR_TRANSACTION_NOT_FOUND
        /// The specified Transaction object could not be opened, because it was not found.
        /// </summary>
        TransactionNotFound = 0x1A3B,

        /// <summary>
        /// ERROR_RESOURCEMANAGER_NOT_FOUND
        /// The specified ResourceManager object could not be opened, because it was not found.
        /// </summary>
        ResourcemanagerNotFound = 0x1A3C,

        /// <summary>
        /// ERROR_ENLISTMENT_NOT_FOUND
        /// The specified Enlistment object could not be opened, because it was not found.
        /// </summary>
        EnlistmentNotFound = 0x1A3D,

        /// <summary>
        /// ERROR_TRANSACTIONMANAGER_NOT_FOUND
        /// The specified TransactionManager object could not be opened, because it was not found.
        /// </summary>
        TransactionmanagerNotFound = 0x1A3E,

        /// <summary>
        /// ERROR_TRANSACTIONMANAGER_NOT_ONLINE
        /// The object specified could not be created or opened, because its associated TransactionManager is not online. The TransactionManager must be brought fully Online by calling RecoverTransactionManager to recover to the end of its LogFile before objects in its Transaction or ResourceManager namespaces can be opened. In addition, errors in writing records to its LogFile can cause a TransactionManager to go offline.
        /// </summary>
        TransactionmanagerNotOnline = 0x1A3F,

        /// <summary>
        /// ERROR_TRANSACTIONMANAGER_RECOVERY_NAME_COLLISION
        /// The specified TransactionManager was unable to create the objects contained in its logfile in the Ob namespace. Therefore, the TransactionManager was unable to recover.
        /// </summary>
        TransactionmanagerRecoveryNameCollision = 0x1A40,

        /// <summary>
        /// ERROR_TRANSACTION_NOT_ROOT
        /// The call to create a superior Enlistment on this Transaction object could not be completed, because the Transaction object specified for the enlistment is a subordinate branch of the Transaction. Only the root of the Transaction can be enlisted on as a superior.
        /// </summary>
        TransactionNotRoot = 0x1A41,

        /// <summary>
        /// ERROR_TRANSACTION_OBJECT_EXPIRED
        /// Because the associated transaction manager or resource manager has been closed, the handle is no longer valid.
        /// </summary>
        TransactionObjectExpired = 0x1A42,

        /// <summary>
        /// ERROR_TRANSACTION_RESPONSE_NOT_ENLISTED
        /// The specified operation could not be performed on this Superior enlistment, because the enlistment was not created with the corresponding completion response in the NotificationMask.
        /// </summary>
        TransactionResponseNotEnlisted = 0x1A43,

        /// <summary>
        /// ERROR_TRANSACTION_RECORD_TOO_LONG
        /// The specified operation could not be performed, because the record that would be logged was too long. This can occur because of two conditions: either there are too many Enlistments on this Transaction, or the combined RecoveryInformation being logged on behalf of those Enlistments is too long.
        /// </summary>
        TransactionRecordTooLong = 0x1A44,

        /// <summary>
        /// ERROR_IMPLICIT_TRANSACTION_NOT_SUPPORTED
        /// Implicit transaction are not supported.
        /// </summary>
        ImplicitTransactionNotSupported = 0x1A45,

        /// <summary>
        /// ERROR_TRANSACTION_INTEGRITY_VIOLATED
        /// The kernel transaction manager had to abort or forget the transaction because it blocked forward progress.
        /// </summary>
        TransactionIntegrityViolated = 0x1A46,

        /// <summary>
        /// ERROR_TRANSACTIONMANAGER_IDENTITY_MISMATCH
        /// The TransactionManager identity that was supplied did not match the one recorded in the TransactionManager's log file.
        /// </summary>
        TransactionmanagerIdentityMismatch = 0x1A47,

        /// <summary>
        /// ERROR_RM_CANNOT_BE_FROZEN_FOR_SNAPSHOT
        /// This snapshot operation cannot continue because a transactional resource manager cannot be frozen in its current state. Please try again.
        /// </summary>
        RmCannotBeFrozenForSnapshot = 0x1A48,

        /// <summary>
        /// ERROR_TRANSACTION_MUST_WRITETHROUGH
        /// The transaction cannot be enlisted on with the specified EnlistmentMask, because the transaction has already completed the PrePrepare phase. In order to ensure correctness, the ResourceManager must switch to a write- through mode and cease caching data within this transaction. Enlisting for only subsequent transaction phases may still succeed.
        /// </summary>
        TransactionMustWritethrough = 0x1A49,

        /// <summary>
        /// ERROR_TRANSACTION_NO_SUPERIOR
        /// The transaction does not have a superior enlistment.
        /// </summary>
        TransactionNoSuperior = 0x1A4A,

        /// <summary>
        /// ERROR_HEURISTIC_DAMAGE_POSSIBLE
        /// The attempt to commit the Transaction completed, but it is possible that some portion of the transaction tree did not commit successfully due to heuristics. Therefore it is possible that some data modified in the transaction may not have committed, resulting in transactional inconsistency. If possible, check the consistency of the associated data.
        /// </summary>
        HeuristicDamagePossible = 0x1A4B,

        /// <summary>
        /// ERROR_TRANSACTIONAL_CONFLICT
        /// The function attempted to use a name that is reserved for use by another transaction.
        /// </summary>
        TransactionalConflict = 0x1A90,

        /// <summary>
        /// ERROR_RM_NOT_ACTIVE
        /// Transaction support within the specified resource manager is not started or was shut down due to an error.
        /// </summary>
        RmNotActive = 0x1A91,

        /// <summary>
        /// ERROR_RM_METADATA_CORRUPT
        /// The metadata of the RM has been corrupted. The RM will not function.
        /// </summary>
        RmMetadataCorrupt = 0x1A92,

        /// <summary>
        /// ERROR_DIRECTORY_NOT_RM
        /// The specified directory does not contain a resource manager.
        /// </summary>
        DirectoryNotRm = 0x1A93,

        /// <summary>
        /// ERROR_TRANSACTIONS_UNSUPPORTED_REMOTE
        /// The remote server or share does not support transacted file operations.
        /// </summary>
        TransactionsUnsupportedRemote = 0x1A95,

        /// <summary>
        /// ERROR_LOG_RESIZE_INVALID_SIZE
        /// The requested log size is invalid.
        /// </summary>
        LogResizeInvalidSize = 0x1A96,

        /// <summary>
        /// ERROR_OBJECT_NO_LONGER_EXISTS
        /// The object (file, stream, link) corresponding to the handle has been deleted by a Transaction Savepoint Rollback.
        /// </summary>
        ObjectNoLongerExists = 0x1A97,

        /// <summary>
        /// ERROR_STREAM_MINIVERSION_NOT_FOUND
        /// The specified file miniversion was not found for this transacted file open.
        /// </summary>
        StreamMiniversionNotFound = 0x1A98,

        /// <summary>
        /// ERROR_STREAM_MINIVERSION_NOT_VALID
        /// The specified file miniversion was found but has been invalidated. Most likely cause is a transaction savepoint rollback.
        /// </summary>
        StreamMiniversionNotValid = 0x1A99,

        /// <summary>
        /// ERROR_MINIVERSION_INACCESSIBLE_FROM_SPECIFIED_TRANSACTION
        /// A miniversion may only be opened in the context of the transaction that created it.
        /// </summary>
        MiniversionInaccessibleFromSpecifiedTransaction = 0x1A9A,

        /// <summary>
        /// ERROR_CANT_OPEN_MINIVERSION_WITH_MODIFY_INTENT
        /// It is not possible to open a miniversion with modify access.
        /// </summary>
        CantOpenMiniversionWithModifyIntent = 0x1A9B,

        /// <summary>
        /// ERROR_CANT_CREATE_MORE_STREAM_MINIVERSIONS
        /// It is not possible to create any more miniversions for this stream.
        /// </summary>
        CantCreateMoreStreamMiniversions = 0x1A9C,

        /// <summary>
        /// ERROR_REMOTE_FILE_VERSION_MISMATCH
        /// The remote server sent mismatching version number or Fid for a file opened with transactions.
        /// </summary>
        RemoteFileVersionMismatch = 0x1A9E,

        /// <summary>
        /// ERROR_HANDLE_NO_LONGER_VALID
        /// The handle has been invalidated by a transaction. The most likely cause is the presence of memory mapping on a file or an open handle when the transaction ended or rolled back to savepoint.
        /// </summary>
        HandleNoLongerValid = 0x1A9F,

        /// <summary>
        /// ERROR_NO_TXF_METADATA
        /// There is no transaction metadata on the file.
        /// </summary>
        NoTxfMetadata = 0x1AA0,

        /// <summary>
        /// ERROR_LOG_CORRUPTION_DETECTED
        /// The log data is corrupt.
        /// </summary>
        LogCorruptionDetected = 0x1AA1,

        /// <summary>
        /// ERROR_CANT_RECOVER_WITH_HANDLE_OPEN
        /// The file can't be recovered because there is a handle still open on it.
        /// </summary>
        CantRecoverWithHandleOpen = 0x1AA2,

        /// <summary>
        /// ERROR_RM_DISCONNECTED
        /// The transaction outcome is unavailable because the resource manager responsible for it has disconnected.
        /// </summary>
        RmDisconnected = 0x1AA3,

        /// <summary>
        /// ERROR_ENLISTMENT_NOT_SUPERIOR
        /// The request was rejected because the enlistment in question is not a superior enlistment.
        /// </summary>
        EnlistmentNotSuperior = 0x1AA4,

        /// <summary>
        /// ERROR_RECOVERY_NOT_NEEDED
        /// The transactional resource manager is already consistent. Recovery is not needed.
        /// </summary>
        RecoveryNotNeeded = 0x1AA5,

        /// <summary>
        /// ERROR_RM_ALREADY_STARTED
        /// The transactional resource manager has already been started.
        /// </summary>
        RmAlreadyStarted = 0x1AA6,

        /// <summary>
        /// ERROR_FILE_IDENTITY_NOT_PERSISTENT
        /// The file cannot be opened transactionally, because its identity depends on the outcome of an unresolved transaction.
        /// </summary>
        FileIdentityNotPersistent = 0x1AA7,

        /// <summary>
        /// ERROR_CANT_BREAK_TRANSACTIONAL_DEPENDENCY
        /// The operation cannot be performed because another transaction is depending on the fact that this property will not change.
        /// </summary>
        CantBreakTransactionalDependency = 0x1AA8,

        /// <summary>
        /// ERROR_CANT_CROSS_RM_BOUNDARY
        /// The operation would involve a single file with two transactional resource managers and is therefore not allowed.
        /// </summary>
        CantCrossRmBoundary = 0x1AA9,

        /// <summary>
        /// ERROR_TXF_DIR_NOT_EMPTY
        /// The $Txf directory must be empty for this operation to succeed.
        /// </summary>
        TxfDirNotEmpty = 0x1AAA,

        /// <summary>
        /// ERROR_INDOUBT_TRANSACTIONS_EXIST
        /// The operation would leave a transactional resource manager in an inconsistent state and is therefore not allowed.
        /// </summary>
        IndoubtTransactionsExist = 0x1AAB,

        /// <summary>
        /// ERROR_TM_VOLATILE
        /// The operation could not be completed because the transaction manager does not have a log.
        /// </summary>
        TmVolatile = 0x1AAC,

        /// <summary>
        /// ERROR_ROLLBACK_TIMER_EXPIRED
        /// A rollback could not be scheduled because a previously scheduled rollback has already executed or been queued for execution.
        /// </summary>
        RollbackTimerExpired = 0x1AAD,

        /// <summary>
        /// ERROR_TXF_ATTRIBUTE_CORRUPT
        /// The transactional metadata attribute on the file or directory is corrupt and unreadable.
        /// </summary>
        TxfAttributeCorrupt = 0x1AAE,

        /// <summary>
        /// ERROR_EFS_NOT_ALLOWED_IN_TRANSACTION
        /// The encryption operation could not be completed because a transaction is active.
        /// </summary>
        EfsNotAllowedInTransaction = 0x1AAF,

        /// <summary>
        /// ERROR_TRANSACTIONAL_OPEN_NOT_ALLOWED
        /// This object is not allowed to be opened in a transaction.
        /// </summary>
        TransactionalOpenNotAllowed = 0x1AB0,

        /// <summary>
        /// ERROR_LOG_GROWTH_FAILED
        /// An attempt to create space in the transactional resource manager's log failed. The failure status has been recorded in the event log.
        /// </summary>
        LogGrowthFailed = 0x1AB1,

        /// <summary>
        /// ERROR_TRANSACTED_MAPPING_UNSUPPORTED_REMOTE
        /// Memory mapping (creating a mapped section) a remote file under a transaction is not supported.
        /// </summary>
        TransactedMappingUnsupportedRemote = 0x1AB2,

        /// <summary>
        /// ERROR_TXF_METADATA_ALREADY_PRESENT
        /// Transaction metadata is already present on this file and cannot be superseded.
        /// </summary>
        TxfMetadataAlreadyPresent = 0x1AB3,

        /// <summary>
        /// ERROR_TRANSACTION_SCOPE_CALLBACKS_NOT_SET
        /// A transaction scope could not be entered because the scope handler has not been initialized.
        /// </summary>
        TransactionScopeCallbacksNotSet = 0x1AB4,

        /// <summary>
        /// ERROR_TRANSACTION_REQUIRED_PROMOTION
        /// Promotion was required in order to allow the resource manager to enlist, but the transaction was set to disallow it.
        /// </summary>
        TransactionRequiredPromotion = 0x1AB5,

        /// <summary>
        /// ERROR_CANNOT_EXECUTE_FILE_IN_TRANSACTION
        /// This file is open for modification in an unresolved transaction and may be opened for execute only by a transacted reader.
        /// </summary>
        CannotExecuteFileInTransaction = 0x1AB6,

        /// <summary>
        /// ERROR_TRANSACTIONS_NOT_FROZEN
        /// The request to thaw frozen transactions was ignored because transactions had not previously been frozen.
        /// </summary>
        TransactionsNotFrozen = 0x1AB7,

        /// <summary>
        /// ERROR_TRANSACTION_FREEZE_IN_PROGRESS
        /// Transactions cannot be frozen because a freeze is already in progress.
        /// </summary>
        TransactionFreezeInProgress = 0x1AB8,

        /// <summary>
        /// ERROR_NOT_SNAPSHOT_VOLUME
        /// The target volume is not a snapshot volume. This operation is only valid on a volume mounted as a snapshot.
        /// </summary>
        NotSnapshotVolume = 0x1AB9,

        /// <summary>
        /// ERROR_NO_SAVEPOINT_WITH_OPEN_FILES
        /// The savepoint operation failed because files are open on the transaction. This is not permitted.
        /// </summary>
        NoSavepointWithOpenFiles = 0x1ABA,

        /// <summary>
        /// ERROR_DATA_LOST_REPAIR
        /// Windows has discovered corruption in a file, and that file has since been repaired. Data loss may have occurred.
        /// </summary>
        DataLostRepair = 0x1ABB,

        /// <summary>
        /// ERROR_SPARSE_NOT_ALLOWED_IN_TRANSACTION
        /// The sparse operation could not be completed because a transaction is active on the file.
        /// </summary>
        SparseNotAllowedInTransaction = 0x1ABC,

        /// <summary>
        /// ERROR_TM_IDENTITY_MISMATCH
        /// The call to create a TransactionManager object failed because the Tm Identity stored in the logfile does not match the Tm Identity that was passed in as an argument.
        /// </summary>
        TmIdentityMismatch = 0x1ABD,

        /// <summary>
        /// ERROR_FLOATED_SECTION
        /// I/O was attempted on a section object that has been floated as a result of a transaction ending. There is no valid data.
        /// </summary>
        FloatedSection = 0x1ABE,

        /// <summary>
        /// ERROR_CANNOT_ACCEPT_TRANSACTED_WORK
        /// The transactional resource manager cannot currently accept transacted work due to a transient condition such as low resources.
        /// </summary>
        CannotAcceptTransactedWork = 0x1ABF,

        /// <summary>
        /// ERROR_CANNOT_ABORT_TRANSACTIONS
        /// The transactional resource manager had too many tranactions outstanding that could not be aborted. The transactional resource manger has been shut down.
        /// </summary>
        CannotAbortTransactions = 0x1AC0,

        /// <summary>
        /// ERROR_BAD_CLUSTERS
        /// The operation could not be completed due to bad clusters on disk.
        /// </summary>
        BadClusters = 0x1AC1,

        /// <summary>
        /// ERROR_COMPRESSION_NOT_ALLOWED_IN_TRANSACTION
        /// The compression operation could not be completed because a transaction is active on the file.
        /// </summary>
        CompressionNotAllowedInTransaction = 0x1AC2,

        /// <summary>
        /// ERROR_VOLUME_DIRTY
        /// The operation could not be completed because the volume is dirty. Please run chkdsk and try again.
        /// </summary>
        VolumeDirty = 0x1AC3,

        /// <summary>
        /// ERROR_NO_LINK_TRACKING_IN_TRANSACTION
        /// The link tracking operation could not be completed because a transaction is active.
        /// </summary>
        NoLinkTrackingInTransaction = 0x1AC4,

        /// <summary>
        /// ERROR_OPERATION_NOT_SUPPORTED_IN_TRANSACTION
        /// This operation cannot be performed in a transaction.
        /// </summary>
        OperationNotSupportedInTransaction = 0x1AC5,

        /// <summary>
        /// ERROR_EXPIRED_HANDLE
        /// The handle is no longer properly associated with its transaction. It may have been opened in a transactional resource manager that was subsequently forced to restart. Please close the handle and open a new one.
        /// </summary>
        ExpiredHandle = 0x1AC6,

        /// <summary>
        /// ERROR_TRANSACTION_NOT_ENLISTED
        /// The specified operation could not be performed because the resource manager is not enlisted in the transaction.
        /// </summary>
        TransactionNotEnlisted = 0x1AC7,

        /// <summary>
        /// ERROR_CTX_WINSTATION_NAME_INVALID
        /// The specified session name is invalid.
        /// </summary>
        CtxWinstationNameInvalid = 0x1B59,

        /// <summary>
        /// ERROR_CTX_INVALID_PD
        /// The specified protocol driver is invalid.
        /// </summary>
        CtxInvalidPd = 0x1B5A,

        /// <summary>
        /// ERROR_CTX_PD_NOT_FOUND
        /// The specified protocol driver was not found in the system path.
        /// </summary>
        CtxPdNotFound = 0x1B5B,

        /// <summary>
        /// ERROR_CTX_WD_NOT_FOUND
        /// The specified terminal connection driver was not found in the system path.
        /// </summary>
        CtxWdNotFound = 0x1B5C,

        /// <summary>
        /// ERROR_CTX_CANNOT_MAKE_EVENTLOG_ENTRY
        /// A registry key for event logging could not be created for this session.
        /// </summary>
        CtxCannotMakeEventlogEntry = 0x1B5D,

        /// <summary>
        /// ERROR_CTX_SERVICE_NAME_COLLISION
        /// A service with the same name already exists on the system.
        /// </summary>
        CtxServiceNameCollision = 0x1B5E,

        /// <summary>
        /// ERROR_CTX_CLOSE_PENDING
        /// A close operation is pending on the session.
        /// </summary>
        CtxClosePending = 0x1B5F,

        /// <summary>
        /// ERROR_CTX_NO_OUTBUF
        /// There are no free output buffers available.
        /// </summary>
        CtxNoOutbuf = 0x1B60,

        /// <summary>
        /// ERROR_CTX_MODEM_INF_NOT_FOUND
        /// The MODEM.INF file was not found.
        /// </summary>
        CtxModemInfNotFound = 0x1B61,

        /// <summary>
        /// ERROR_CTX_INVALID_MODEMNAME
        /// The modem name was not found in MODEM.INF.
        /// </summary>
        CtxInvalidModemname = 0x1B62,

        /// <summary>
        /// ERROR_CTX_MODEM_RESPONSE_ERROR
        /// The modem did not accept the command sent to it. Verify that the configured modem name matches the attached modem.
        /// </summary>
        CtxModemResponseError = 0x1B63,

        /// <summary>
        /// ERROR_CTX_MODEM_RESPONSE_TIMEOUT
        /// The modem did not respond to the command sent to it. Verify that the modem is properly cabled and powered on.
        /// </summary>
        CtxModemResponseTimeout = 0x1B64,

        /// <summary>
        /// ERROR_CTX_MODEM_RESPONSE_NO_CARRIER
        /// Carrier detect has failed or carrier has been dropped due to disconnect.
        /// </summary>
        CtxModemResponseNoCarrier = 0x1B65,

        /// <summary>
        /// ERROR_CTX_MODEM_RESPONSE_NO_DIALTONE
        /// Dial tone not detected within the required time. Verify that the phone cable is properly attached and functional.
        /// </summary>
        CtxModemResponseNoDialtone = 0x1B66,

        /// <summary>
        /// ERROR_CTX_MODEM_RESPONSE_BUSY
        /// Busy signal detected at remote site on callback.
        /// </summary>
        CtxModemResponseBusy = 0x1B67,

        /// <summary>
        /// ERROR_CTX_MODEM_RESPONSE_VOICE
        /// Voice detected at remote site on callback.
        /// </summary>
        CtxModemResponseVoice = 0x1B68,

        /// <summary>
        /// ERROR_CTX_TD_ERROR
        /// Transport driver error.
        /// </summary>
        CtxTdError = 0x1B69,

        /// <summary>
        /// ERROR_CTX_WINSTATION_NOT_FOUND
        /// The specified session cannot be found.
        /// </summary>
        CtxWinstationNotFound = 0x1B6E,

        /// <summary>
        /// ERROR_CTX_WINSTATION_ALREADY_EXISTS
        /// The specified session name is already in use.
        /// </summary>
        CtxWinstationAlreadyExists = 0x1B6F,

        /// <summary>
        /// ERROR_CTX_WINSTATION_BUSY
        /// The task you are trying to do can't be completed because Remote Desktop Services is currently busy. Please try again in a few minutes. Other users should still be able to log on.
        /// </summary>
        CtxWinstationBusy = 0x1B70,

        /// <summary>
        /// ERROR_CTX_BAD_VIDEO_MODE
        /// An attempt has been made to connect to a session whose video mode is not supported by the current client.
        /// </summary>
        CtxBadVideoMode = 0x1B71,

        /// <summary>
        /// ERROR_CTX_GRAPHICS_INVALID
        /// The application attempted to enable DOS graphics mode. DOS graphics mode is not supported.
        /// </summary>
        CtxGraphicsInvalid = 0x1B7B,

        /// <summary>
        /// ERROR_CTX_LOGON_DISABLED
        /// Your interactive logon privilege has been disabled. Please contact your administrator.
        /// </summary>
        CtxLogonDisabled = 0x1B7D,

        /// <summary>
        /// ERROR_CTX_NOT_CONSOLE
        /// The requested operation can be performed only on the system console. This is most often the result of a driver or system DLL requiring direct console access.
        /// </summary>
        CtxNotConsole = 0x1B7E,

        /// <summary>
        /// ERROR_CTX_CLIENT_QUERY_TIMEOUT
        /// The client failed to respond to the server connect message.
        /// </summary>
        CtxClientQueryTimeout = 0x1B80,

        /// <summary>
        /// ERROR_CTX_CONSOLE_DISCONNECT
        /// Disconnecting the console session is not supported.
        /// </summary>
        CtxConsoleDisconnect = 0x1B81,

        /// <summary>
        /// ERROR_CTX_CONSOLE_CONNECT
        /// Reconnecting a disconnected session to the console is not supported.
        /// </summary>
        CtxConsoleConnect = 0x1B82,

        /// <summary>
        /// ERROR_CTX_SHADOW_DENIED
        /// The request to control another session remotely was denied.
        /// </summary>
        CtxShadowDenied = 0x1B84,

        /// <summary>
        /// ERROR_CTX_WINSTATION_ACCESS_DENIED
        /// The requested session access is denied.
        /// </summary>
        CtxWinstationAccessDenied = 0x1B85,

        /// <summary>
        /// ERROR_CTX_INVALID_WD
        /// The specified terminal connection driver is invalid.
        /// </summary>
        CtxInvalidWd = 0x1B89,

        /// <summary>
        /// ERROR_CTX_SHADOW_INVALID
        /// The requested session cannot be controlled remotely. This may be because the session is disconnected or does not currently have a user logged on.
        /// </summary>
        CtxShadowInvalid = 0x1B8A,

        /// <summary>
        /// ERROR_CTX_SHADOW_DISABLED
        /// The requested session is not configured to allow remote control.
        /// </summary>
        CtxShadowDisabled = 0x1B8B,

        /// <summary>
        /// ERROR_CTX_CLIENT_LICENSE_IN_USE
        /// Your request to connect to this Terminal Server has been rejected. Your Terminal Server client license number is currently being used by another user. Please call your system administrator to obtain a unique license number.
        /// </summary>
        CtxClientLicenseInUse = 0x1B8C,

        /// <summary>
        /// ERROR_CTX_CLIENT_LICENSE_NOT_SET
        /// Your request to connect to this Terminal Server has been rejected. Your Terminal Server client license number has not been entered for this copy of the Terminal Server client. Please contact your system administrator.
        /// </summary>
        CtxClientLicenseNotSet = 0x1B8D,

        /// <summary>
        /// ERROR_CTX_LICENSE_NOT_AVAILABLE
        /// The number of connections to this computer is limited and all connections are in use right now. Try connecting later or contact your system administrator.
        /// </summary>
        CtxLicenseNotAvailable = 0x1B8E,

        /// <summary>
        /// ERROR_CTX_LICENSE_CLIENT_INVALID
        /// The client you are using is not licensed to use this system. Your logon request is denied.
        /// </summary>
        CtxLicenseClientInvalid = 0x1B8F,

        /// <summary>
        /// ERROR_CTX_LICENSE_EXPIRED
        /// The system license has expired. Your logon request is denied.
        /// </summary>
        CtxLicenseExpired = 0x1B90,

        /// <summary>
        /// ERROR_CTX_SHADOW_NOT_RUNNING
        /// Remote control could not be terminated because the specified session is not currently being remotely controlled.
        /// </summary>
        CtxShadowNotRunning = 0x1B91,

        /// <summary>
        /// ERROR_CTX_SHADOW_ENDED_BY_MODE_CHANGE
        /// The remote control of the console was terminated because the display mode was changed. Changing the display mode in a remote control session is not supported.
        /// </summary>
        CtxShadowEndedByModeChange = 0x1B92,

        /// <summary>
        /// ERROR_ACTIVATION_COUNT_EXCEEDED
        /// Activation has already been reset the maximum number of times for this installation. Your activation timer will not be cleared.
        /// </summary>
        ActivationCountExceeded = 0x1B93,

        /// <summary>
        /// ERROR_CTX_WINSTATIONS_DISABLED
        /// Remote logins are currently disabled.
        /// </summary>
        CtxWinstationsDisabled = 0x1B94,

        /// <summary>
        /// ERROR_CTX_ENCRYPTION_LEVEL_REQUIRED
        /// You do not have the proper encryption level to access this Session.
        /// </summary>
        CtxEncryptionLevelRequired = 0x1B95,

        /// <summary>
        /// ERROR_CTX_SESSION_IN_USE
        /// The user %s\\%s is currently logged on to this computer. Only the current user or an administrator can log on to this computer.
        /// </summary>
        CtxSessionInUse = 0x1B96,

        /// <summary>
        /// ERROR_CTX_NO_FORCE_LOGOFF
        /// The user %s\\%s is already logged on to the console of this computer. You do not have permission to log in at this time. To resolve this issue, contact %s\\%s and have them log off.
        /// </summary>
        CtxNoForceLogoff = 0x1B97,

        /// <summary>
        /// ERROR_CTX_ACCOUNT_RESTRICTION
        /// Unable to log you on because of an account restriction.
        /// </summary>
        CtxAccountRestriction = 0x1B98,

        /// <summary>
        /// ERROR_RDP_PROTOCOL_ERROR
        /// The RDP protocol component %2 detected an error in the protocol stream and has disconnected the client.
        /// </summary>
        RdpProtocolError = 0x1B99,

        /// <summary>
        /// ERROR_CTX_CDM_CONNECT
        /// The Client Drive Mapping Service Has Connected on Terminal Connection.
        /// </summary>
        CtxCdmConnect = 0x1B9A,

        /// <summary>
        /// ERROR_CTX_CDM_DISCONNECT
        /// The Client Drive Mapping Service Has Disconnected on Terminal Connection.
        /// </summary>
        CtxCdmDisconnect = 0x1B9B,

        /// <summary>
        /// ERROR_CTX_SECURITY_LAYER_ERROR
        /// The Terminal Server security layer detected an error in the protocol stream and has disconnected the client.
        /// </summary>
        CtxSecurityLayerError = 0x1B9C,

        /// <summary>
        /// ERROR_TS_INCOMPATIBLE_SESSIONS
        /// The target session is incompatible with the current session.
        /// </summary>
        TsIncompatibleSessions = 0x1B9D,

        /// <summary>
        /// ERROR_TS_VIDEO_SUBSYSTEM_ERROR
        /// Windows can't connect to your session because a problem occurred in the Windows video subsystem. Try connecting again later, or contact the server administrator for assistance.
        /// </summary>
        TsVideoSubsystemError = 0x1B9E,

        /// <summary>
        /// FRS_ERR_INVALID_API_SEQUENCE
        /// The file replication service API was called incorrectly.
        /// </summary>
        FrsErrInvalidApiSequence = 0x1F41,

        /// <summary>
        /// FRS_ERR_STARTING_SERVICE
        /// The file replication service cannot be started.
        /// </summary>
        FrsErrStartingService = 0x1F42,

        /// <summary>
        /// FRS_ERR_STOPPING_SERVICE
        /// The file replication service cannot be stopped.
        /// </summary>
        FrsErrStoppingService = 0x1F43,

        /// <summary>
        /// FRS_ERR_INTERNAL_API
        /// The file replication service API terminated the request. The event log may have more information.
        /// </summary>
        FrsErrInternalApi = 0x1F44,

        /// <summary>
        /// FRS_ERR_INTERNAL
        /// The file replication service terminated the request. The event log may have more information.
        /// </summary>
        FrsErrInternal = 0x1F45,

        /// <summary>
        /// FRS_ERR_SERVICE_COMM
        /// The file replication service cannot be contacted. The event log may have more information.
        /// </summary>
        FrsErrServiceComm = 0x1F46,

        /// <summary>
        /// FRS_ERR_INSUFFICIENT_PRIV
        /// The file replication service cannot satisfy the request because the user has insufficient privileges. The event log may have more information.
        /// </summary>
        FrsErrInsufficientPriv = 0x1F47,

        /// <summary>
        /// FRS_ERR_AUTHENTICATION
        /// The file replication service cannot satisfy the request because authenticated RPC is not available. The event log may have more information.
        /// </summary>
        FrsErrAuthentication = 0x1F48,

        /// <summary>
        /// FRS_ERR_PARENT_INSUFFICIENT_PRIV
        /// The file replication service cannot satisfy the request because the user has insufficient privileges on the domain controller. The event log may have more information.
        /// </summary>
        FrsErrParentInsufficientPriv = 0x1F49,

        /// <summary>
        /// FRS_ERR_PARENT_AUTHENTICATION
        /// The file replication service cannot satisfy the request because authenticated RPC is not available on the domain controller. The event log may have more information.
        /// </summary>
        FrsErrParentAuthentication = 0x1F4A,

        /// <summary>
        /// FRS_ERR_CHILD_TO_PARENT_COMM
        /// The file replication service cannot communicate with the file replication service on the domain controller. The event log may have more information.
        /// </summary>
        FrsErrChildToParentComm = 0x1F4B,

        /// <summary>
        /// FRS_ERR_PARENT_TO_CHILD_COMM
        /// The file replication service on the domain controller cannot communicate with the file replication service on this computer. The event log may have more information.
        /// </summary>
        FrsErrParentToChildComm = 0x1F4C,

        /// <summary>
        /// FRS_ERR_SYSVOL_POPULATE
        /// The file replication service cannot populate the system volume because of an internal error. The event log may have more information.
        /// </summary>
        FrsErrSysvolPopulate = 0x1F4D,

        /// <summary>
        /// FRS_ERR_SYSVOL_POPULATE_TIMEOUT
        /// The file replication service cannot populate the system volume because of an internal timeout. The event log may have more information.
        /// </summary>
        FrsErrSysvolPopulateTimeout = 0x1F4E,

        /// <summary>
        /// FRS_ERR_SYSVOL_IS_BUSY
        /// The file replication service cannot process the request. The system volume is busy with a previous request.
        /// </summary>
        FrsErrSysvolIsBusy = 0x1F4F,

        /// <summary>
        /// FRS_ERR_SYSVOL_DEMOTE
        /// The file replication service cannot stop replicating the system volume because of an internal error. The event log may have more information.
        /// </summary>
        FrsErrSysvolDemote = 0x1F50,

        /// <summary>
        /// FRS_ERR_INVALID_SERVICE_PARAMETER
        /// The file replication service detected an invalid parameter.
        /// </summary>
        FrsErrInvalidServiceParameter = 0x1F51,

        /// <summary>
        /// ERROR_DS_NOT_INSTALLED
        /// An error occurred while installing the directory service. For more information, see the event log.
        /// </summary>
        DsNotInstalled = 0x2008,

        /// <summary>
        /// ERROR_DS_MEMBERSHIP_EVALUATED_LOCALLY
        /// The directory service evaluated group memberships locally.
        /// </summary>
        DsMembershipEvaluatedLocally = 0x2009,

        /// <summary>
        /// ERROR_DS_NO_ATTRIBUTE_OR_VALUE
        /// The specified directory service attribute or value does not exist.
        /// </summary>
        DsNoAttributeOrValue = 0x200A,

        /// <summary>
        /// ERROR_DS_INVALID_ATTRIBUTE_SYNTAX
        /// The attribute syntax specified to the directory service is invalid.
        /// </summary>
        DsInvalidAttributeSyntax = 0x200B,

        /// <summary>
        /// ERROR_DS_ATTRIBUTE_TYPE_UNDEFINED
        /// The attribute type specified to the directory service is not defined.
        /// </summary>
        DsAttributeTypeUndefined = 0x200C,

        /// <summary>
        /// ERROR_DS_ATTRIBUTE_OR_VALUE_EXISTS
        /// The specified directory service attribute or value already exists.
        /// </summary>
        DsAttributeOrValueExists = 0x200D,

        /// <summary>
        /// ERROR_DS_BUSY
        /// The directory service is busy.
        /// </summary>
        DsBusy = 0x200E,

        /// <summary>
        /// ERROR_DS_UNAVAILABLE
        /// The directory service is unavailable.
        /// </summary>
        DsUnavailable = 0x200F,

        /// <summary>
        /// ERROR_DS_NO_RIDS_ALLOCATED
        /// The directory service was unable to allocate a relative identifier.
        /// </summary>
        DsNoRidsAllocated = 0x2010,

        /// <summary>
        /// ERROR_DS_NO_MORE_RIDS
        /// The directory service has exhausted the pool of relative identifiers.
        /// </summary>
        DsNoMoreRids = 0x2011,

        /// <summary>
        /// ERROR_DS_INCORRECT_ROLE_OWNER
        /// The requested operation could not be performed because the directory service is not the master for that type of operation.
        /// </summary>
        DsIncorrectRoleOwner = 0x2012,

        /// <summary>
        /// ERROR_DS_RIDMGR_INIT_ERROR
        /// The directory service was unable to initialize the subsystem that allocates relative identifiers.
        /// </summary>
        DsRidmgrInitError = 0x2013,

        /// <summary>
        /// ERROR_DS_OBJ_CLASS_VIOLATION
        /// The requested operation did not satisfy one or more constraints associated with the class of the object.
        /// </summary>
        DsObjClassViolation = 0x2014,

        /// <summary>
        /// ERROR_DS_CANT_ON_NON_LEAF
        /// The directory service can perform the requested operation only on a leaf object.
        /// </summary>
        DsCantOnNonLeaf = 0x2015,

        /// <summary>
        /// ERROR_DS_CANT_ON_RDN
        /// The directory service cannot perform the requested operation on the RDN attribute of an object.
        /// </summary>
        DsCantOnRdn = 0x2016,

        /// <summary>
        /// ERROR_DS_CANT_MOD_OBJ_CLASS
        /// The directory service detected an attempt to modify the object class of an object.
        /// </summary>
        DsCantModObjClass = 0x2017,

        /// <summary>
        /// ERROR_DS_CROSS_DOM_MOVE_ERROR
        /// The requested cross-domain move operation could not be performed.
        /// </summary>
        DsCrossDomMoveError = 0x2018,

        /// <summary>
        /// ERROR_DS_GC_NOT_AVAILABLE
        /// Unable to contact the global catalog server.
        /// </summary>
        DsGcNotAvailable = 0x2019,

        /// <summary>
        /// ERROR_SHARED_POLICY
        /// The policy object is shared and can only be modified at the root.
        /// </summary>
        SharedPolicy = 0x201A,

        /// <summary>
        /// ERROR_POLICY_OBJECT_NOT_FOUND
        /// The policy object does not exist.
        /// </summary>
        PolicyObjectNotFound = 0x201B,

        /// <summary>
        /// ERROR_POLICY_ONLY_IN_DS
        /// The requested policy information is only in the directory service.
        /// </summary>
        PolicyOnlyInDs = 0x201C,

        /// <summary>
        /// ERROR_PROMOTION_ACTIVE
        /// A domain controller promotion is currently active.
        /// </summary>
        PromotionActive = 0x201D,

        /// <summary>
        /// ERROR_NO_PROMOTION_ACTIVE
        /// A domain controller promotion is not currently active.
        /// </summary>
        NoPromotionActive = 0x201E,

        /// <summary>
        /// ERROR_DS_OPERATIONS_ERROR
        /// An operations error occurred.
        /// </summary>
        DsOperationsError = 0x2020,

        /// <summary>
        /// ERROR_DS_PROTOCOL_ERROR
        /// A protocol error occurred.
        /// </summary>
        DsProtocolError = 0x2021,

        /// <summary>
        /// ERROR_DS_TIMELIMIT_EXCEEDED
        /// The time limit for this request was exceeded.
        /// </summary>
        DsTimelimitExceeded = 0x2022,

        /// <summary>
        /// ERROR_DS_SIZELIMIT_EXCEEDED
        /// The size limit for this request was exceeded.
        /// </summary>
        DsSizelimitExceeded = 0x2023,

        /// <summary>
        /// ERROR_DS_ADMIN_LIMIT_EXCEEDED
        /// The administrative limit for this request was exceeded.
        /// </summary>
        DsAdminLimitExceeded = 0x2024,

        /// <summary>
        /// ERROR_DS_COMPARE_FALSE
        /// The compare response was false.
        /// </summary>
        DsCompareFalse = 0x2025,

        /// <summary>
        /// ERROR_DS_COMPARE_TRUE
        /// The compare response was true.
        /// </summary>
        DsCompareTrue = 0x2026,

        /// <summary>
        /// ERROR_DS_AUTH_METHOD_NOT_SUPPORTED
        /// The requested authentication method is not supported by the server.
        /// </summary>
        DsAuthMethodNotSupported = 0x2027,

        /// <summary>
        /// ERROR_DS_STRONG_AUTH_REQUIRED
        /// A more secure authentication method is required for this server.
        /// </summary>
        DsStrongAuthRequired = 0x2028,

        /// <summary>
        /// ERROR_DS_INAPPROPRIATE_AUTH
        /// Inappropriate authentication.
        /// </summary>
        DsInappropriateAuth = 0x2029,

        /// <summary>
        /// ERROR_DS_AUTH_UNKNOWN
        /// The authentication mechanism is unknown.
        /// </summary>
        DsAuthUnknown = 0x202A,

        /// <summary>
        /// ERROR_DS_REFERRAL
        /// A referral was returned from the server.
        /// </summary>
        DsReferral = 0x202B,

        /// <summary>
        /// ERROR_DS_UNAVAILABLE_CRIT_EXTENSION
        /// The server does not support the requested critical extension.
        /// </summary>
        DsUnavailableCritExtension = 0x202C,

        /// <summary>
        /// ERROR_DS_CONFIDENTIALITY_REQUIRED
        /// This request requires a secure connection.
        /// </summary>
        DsConfidentialityRequired = 0x202D,

        /// <summary>
        /// ERROR_DS_INAPPROPRIATE_MATCHING
        /// Inappropriate matching.
        /// </summary>
        DsInappropriateMatching = 0x202E,

        /// <summary>
        /// ERROR_DS_CONSTRAINT_VIOLATION
        /// A constraint violation occurred.
        /// </summary>
        DsConstraintViolation = 0x202F,

        /// <summary>
        /// ERROR_DS_NO_SUCH_OBJECT
        /// There is no such object on the server.
        /// </summary>
        DsNoSuchObject = 0x2030,

        /// <summary>
        /// ERROR_DS_ALIAS_PROBLEM
        /// There is an alias problem.
        /// </summary>
        DsAliasProblem = 0x2031,

        /// <summary>
        /// ERROR_DS_INVALID_DN_SYNTAX
        /// An invalid dn syntax has been specified.
        /// </summary>
        DsInvalidDnSyntax = 0x2032,

        /// <summary>
        /// ERROR_DS_IS_LEAF
        /// The object is a leaf object.
        /// </summary>
        DsIsLeaf = 0x2033,

        /// <summary>
        /// ERROR_DS_ALIAS_DEREF_PROBLEM
        /// There is an alias dereferencing problem.
        /// </summary>
        DsAliasDerefProblem = 0x2034,

        /// <summary>
        /// ERROR_DS_UNWILLING_TO_PERFORM
        /// The server is unwilling to process the request.
        /// </summary>
        DsUnwillingToPerform = 0x2035,

        /// <summary>
        /// ERROR_DS_LOOP_DETECT
        /// A loop has been detected.
        /// </summary>
        DsLoopDetect = 0x2036,

        /// <summary>
        /// ERROR_DS_NAMING_VIOLATION
        /// There is a naming violation.
        /// </summary>
        DsNamingViolation = 0x2037,

        /// <summary>
        /// ERROR_DS_OBJECT_RESULTS_TOO_LARGE
        /// The result set is too large.
        /// </summary>
        DsObjectResultsTooLarge = 0x2038,

        /// <summary>
        /// ERROR_DS_AFFECTS_MULTIPLE_DSAS
        /// The operation affects multiple DSAs.
        /// </summary>
        DsAffectsMultipleDsas = 0x2039,

        /// <summary>
        /// ERROR_DS_SERVER_DOWN
        /// The server is not operational.
        /// </summary>
        DsServerDown = 0x203A,

        /// <summary>
        /// ERROR_DS_LOCAL_ERROR
        /// A local error has occurred.
        /// </summary>
        DsLocalError = 0x203B,

        /// <summary>
        /// ERROR_DS_ENCODING_ERROR
        /// An encoding error has occurred.
        /// </summary>
        DsEncodingError = 0x203C,

        /// <summary>
        /// ERROR_DS_DECODING_ERROR
        /// A decoding error has occurred.
        /// </summary>
        DsDecodingError = 0x203D,

        /// <summary>
        /// ERROR_DS_FILTER_UNKNOWN
        /// The search filter cannot be recognized.
        /// </summary>
        DsFilterUnknown = 0x203E,

        /// <summary>
        /// ERROR_DS_PARAM_ERROR
        /// One or more parameters are illegal.
        /// </summary>
        DsParamError = 0x203F,

        /// <summary>
        /// ERROR_DS_NOT_SUPPORTED
        /// The specified method is not supported.
        /// </summary>
        DsNotSupported = 0x2040,

        /// <summary>
        /// ERROR_DS_NO_RESULTS_RETURNED
        /// No results were returned.
        /// </summary>
        DsNoResultsReturned = 0x2041,

        /// <summary>
        /// ERROR_DS_CONTROL_NOT_FOUND
        /// The specified control is not supported by the server.
        /// </summary>
        DsControlNotFound = 0x2042,

        /// <summary>
        /// ERROR_DS_CLIENT_LOOP
        /// A referral loop was detected by the client.
        /// </summary>
        DsClientLoop = 0x2043,

        /// <summary>
        /// ERROR_DS_REFERRAL_LIMIT_EXCEEDED
        /// The preset referral limit was exceeded.
        /// </summary>
        DsReferralLimitExceeded = 0x2044,

        /// <summary>
        /// ERROR_DS_SORT_CONTROL_MISSING
        /// The search requires a SORT control.
        /// </summary>
        DsSortControlMissing = 0x2045,

        /// <summary>
        /// ERROR_DS_OFFSET_RANGE_ERROR
        /// The search results exceed the offset range specified.
        /// </summary>
        DsOffsetRangeError = 0x2046,

        /// <summary>
        /// ERROR_DS_RIDMGR_DISABLED
        /// The directory service detected the subsystem that allocates relative identifiers is disabled. This can occur as a protective mechanism when the system determines a significant portion of relative identifiers (RIDs) have been exhausted. Please see https://go.microsoft.com/fwlink/p/?linkid=228610 for recommended diagnostic steps and the procedure to re-enable account creation.
        /// </summary>
        DsRidmgrDisabled = 0x2047,

        /// <summary>
        /// ERROR_DS_ROOT_MUST_BE_NC
        /// The root object must be the head of a naming context. The root object cannot have an instantiated parent.
        /// </summary>
        DsRootMustBeNc = 0x206D,

        /// <summary>
        /// ERROR_DS_ADD_REPLICA_INHIBITED
        /// The add replica operation cannot be performed. The naming context must be writeable in order to create the replica.
        /// </summary>
        DsAddReplicaInhibited = 0x206E,

        /// <summary>
        /// ERROR_DS_ATT_NOT_DEF_IN_SCHEMA
        /// A reference to an attribute that is not defined in the schema occurred.
        /// </summary>
        DsAttNotDefInSchema = 0x206F,

        /// <summary>
        /// ERROR_DS_MAX_OBJ_SIZE_EXCEEDED
        /// The maximum size of an object has been exceeded.
        /// </summary>
        DsMaxObjSizeExceeded = 0x2070,

        /// <summary>
        /// ERROR_DS_OBJ_STRING_NAME_EXISTS
        /// An attempt was made to add an object to the directory with a name that is already in use.
        /// </summary>
        DsObjStringNameExists = 0x2071,

        /// <summary>
        /// ERROR_DS_NO_RDN_DEFINED_IN_SCHEMA
        /// An attempt was made to add an object of a class that does not have an RDN defined in the schema.
        /// </summary>
        DsNoRdnDefinedInSchema = 0x2072,

        /// <summary>
        /// ERROR_DS_RDN_DOESNT_MATCH_SCHEMA
        /// An attempt was made to add an object using an RDN that is not the RDN defined in the schema.
        /// </summary>
        DsRdnDoesntMatchSchema = 0x2073,

        /// <summary>
        /// ERROR_DS_NO_REQUESTED_ATTS_FOUND
        /// None of the requested attributes were found on the objects.
        /// </summary>
        DsNoRequestedAttsFound = 0x2074,

        /// <summary>
        /// ERROR_DS_USER_BUFFER_TO_SMALL
        /// The user buffer is too small.
        /// </summary>
        DsUserBufferToSmall = 0x2075,

        /// <summary>
        /// ERROR_DS_ATT_IS_NOT_ON_OBJ
        /// The attribute specified in the operation is not present on the object.
        /// </summary>
        DsAttIsNotOnObj = 0x2076,

        /// <summary>
        /// ERROR_DS_ILLEGAL_MOD_OPERATION
        /// Illegal modify operation. Some aspect of the modification is not permitted.
        /// </summary>
        DsIllegalModOperation = 0x2077,

        /// <summary>
        /// ERROR_DS_OBJ_TOO_LARGE
        /// The specified object is too large.
        /// </summary>
        DsObjTooLarge = 0x2078,

        /// <summary>
        /// ERROR_DS_BAD_INSTANCE_TYPE
        /// The specified instance type is not valid.
        /// </summary>
        DsBadInstanceType = 0x2079,

        /// <summary>
        /// ERROR_DS_MASTERDSA_REQUIRED
        /// The operation must be performed at a master DSA.
        /// </summary>
        DsMasterdsaRequired = 0x207A,

        /// <summary>
        /// ERROR_DS_OBJECT_CLASS_REQUIRED
        /// The object class attribute must be specified.
        /// </summary>
        DsObjectClassRequired = 0x207B,

        /// <summary>
        /// ERROR_DS_MISSING_REQUIRED_ATT
        /// A required attribute is missing.
        /// </summary>
        DsMissingRequiredAtt = 0x207C,

        /// <summary>
        /// ERROR_DS_ATT_NOT_DEF_FOR_CLASS
        /// An attempt was made to modify an object to include an attribute that is not legal for its class.
        /// </summary>
        DsAttNotDefForClass = 0x207D,

        /// <summary>
        /// ERROR_DS_ATT_ALREADY_EXISTS
        /// The specified attribute is already present on the object.
        /// </summary>
        DsAttAlreadyExists = 0x207E,

        /// <summary>
        /// ERROR_DS_CANT_ADD_ATT_VALUES
        /// The specified attribute is not present, or has no values.
        /// </summary>
        DsCantAddAttValues = 0x2080,

        /// <summary>
        /// ERROR_DS_SINGLE_VALUE_CONSTRAINT
        /// Multiple values were specified for an attribute that can have only one value.
        /// </summary>
        DsSingleValueConstraint = 0x2081,

        /// <summary>
        /// ERROR_DS_RANGE_CONSTRAINT
        /// A value for the attribute was not in the acceptable range of values.
        /// </summary>
        DsRangeConstraint = 0x2082,

        /// <summary>
        /// ERROR_DS_ATT_VAL_ALREADY_EXISTS
        /// The specified value already exists.
        /// </summary>
        DsAttValAlreadyExists = 0x2083,

        /// <summary>
        /// ERROR_DS_CANT_REM_MISSING_ATT
        /// The attribute cannot be removed because it is not present on the object.
        /// </summary>
        DsCantRemMissingAtt = 0x2084,

        /// <summary>
        /// ERROR_DS_CANT_REM_MISSING_ATT_VAL
        /// The attribute value cannot be removed because it is not present on the object.
        /// </summary>
        DsCantRemMissingAttVal = 0x2085,

        /// <summary>
        /// ERROR_DS_ROOT_CANT_BE_SUBREF
        /// The specified root object cannot be a subref.
        /// </summary>
        DsRootCantBeSubref = 0x2086,

        /// <summary>
        /// ERROR_DS_NO_CHAINING
        /// Chaining is not permitted.
        /// </summary>
        DsNoChaining = 0x2087,

        /// <summary>
        /// ERROR_DS_NO_CHAINED_EVAL
        /// Chained evaluation is not permitted.
        /// </summary>
        DsNoChainedEval = 0x2088,

        /// <summary>
        /// ERROR_DS_NO_PARENT_OBJECT
        /// The operation could not be performed because the object's parent is either uninstantiated or deleted.
        /// </summary>
        DsNoParentObject = 0x2089,

        /// <summary>
        /// ERROR_DS_PARENT_IS_AN_ALIAS
        /// Having a parent that is an alias is not permitted. Aliases are leaf objects.
        /// </summary>
        DsParentIsAnAlias = 0x208A,

        /// <summary>
        /// ERROR_DS_CANT_MIX_MASTER_AND_REPS
        /// The object and parent must be of the same type, either both masters or both replicas.
        /// </summary>
        DsCantMixMasterAndReps = 0x208B,

        /// <summary>
        /// ERROR_DS_CHILDREN_EXIST
        /// The operation cannot be performed because child objects exist. This operation can only be performed on a leaf object.
        /// </summary>
        DsChildrenExist = 0x208C,

        /// <summary>
        /// ERROR_DS_OBJ_NOT_FOUND
        /// Directory object not found.
        /// </summary>
        DsObjNotFound = 0x208D,

        /// <summary>
        /// ERROR_DS_ALIASED_OBJ_MISSING
        /// The aliased object is missing.
        /// </summary>
        DsAliasedObjMissing = 0x208E,

        /// <summary>
        /// ERROR_DS_BAD_NAME_SYNTAX
        /// The object name has bad syntax.
        /// </summary>
        DsBadNameSyntax = 0x208F,

        /// <summary>
        /// ERROR_DS_ALIAS_POINTS_TO_ALIAS
        /// It is not permitted for an alias to refer to another alias.
        /// </summary>
        DsAliasPointsToAlias = 0x2090,

        /// <summary>
        /// ERROR_DS_CANT_DEREF_ALIAS
        /// The alias cannot be dereferenced.
        /// </summary>
        DsCantDerefAlias = 0x2091,

        /// <summary>
        /// ERROR_DS_OUT_OF_SCOPE
        /// The operation is out of scope.
        /// </summary>
        DsOutOfScope = 0x2092,

        /// <summary>
        /// ERROR_DS_OBJECT_BEING_REMOVED
        /// The operation cannot continue because the object is in the process of being removed.
        /// </summary>
        DsObjectBeingRemoved = 0x2093,

        /// <summary>
        /// ERROR_DS_CANT_DELETE_DSA_OBJ
        /// The DSA object cannot be deleted.
        /// </summary>
        DsCantDeleteDsaObj = 0x2094,

        /// <summary>
        /// ERROR_DS_GENERIC_ERROR
        /// A directory service error has occurred.
        /// </summary>
        DsGenericError = 0x2095,

        /// <summary>
        /// ERROR_DS_DSA_MUST_BE_INT_MASTER
        /// The operation can only be performed on an internal master DSA object.
        /// </summary>
        DsDsaMustBeIntMaster = 0x2096,

        /// <summary>
        /// ERROR_DS_CLASS_NOT_DSA
        /// The object must be of class DSA.
        /// </summary>
        DsClassNotDsa = 0x2097,

        /// <summary>
        /// ERROR_DS_INSUFF_ACCESS_RIGHTS
        /// Insufficient access rights to perform the operation.
        /// </summary>
        DsInsuffAccessRights = 0x2098,

        /// <summary>
        /// ERROR_DS_ILLEGAL_SUPERIOR
        /// The object cannot be added because the parent is not on the list of possible superiors.
        /// </summary>
        DsIllegalSuperior = 0x2099,

        /// <summary>
        /// ERROR_DS_ATTRIBUTE_OWNED_BY_SAM
        /// Access to the attribute is not permitted because the attribute is owned by the Security Accounts Manager (SAM).
        /// </summary>
        DsAttributeOwnedBySam = 0x209A,

        /// <summary>
        /// ERROR_DS_NAME_TOO_MANY_PARTS
        /// The name has too many parts.
        /// </summary>
        DsNameTooManyParts = 0x209B,

        /// <summary>
        /// ERROR_DS_NAME_TOO_LONG
        /// The name is too long.
        /// </summary>
        DsNameTooLong = 0x209C,

        /// <summary>
        /// ERROR_DS_NAME_VALUE_TOO_LONG
        /// The name value is too long.
        /// </summary>
        DsNameValueTooLong = 0x209D,

        /// <summary>
        /// ERROR_DS_NAME_UNPARSEABLE
        /// The directory service encountered an error parsing a name.
        /// </summary>
        DsNameUnparseable = 0x209E,

        /// <summary>
        /// ERROR_DS_NAME_TYPE_UNKNOWN
        /// The directory service cannot get the attribute type for a name.
        /// </summary>
        DsNameTypeUnknown = 0x209F,

        /// <summary>
        /// ERROR_DS_NOT_AN_OBJECT
        /// The name does not identify an object; the name identifies a phantom.
        /// </summary>
        DsNotAnObject = 0x20A0,

        /// <summary>
        /// ERROR_DS_SEC_DESC_TOO_SHORT
        /// The security descriptor is too short.
        /// </summary>
        DsSecDescTooShort = 0x20A1,

        /// <summary>
        /// ERROR_DS_SEC_DESC_INVALID
        /// The security descriptor is invalid.
        /// </summary>
        DsSecDescInvalid = 0x20A2,

        /// <summary>
        /// ERROR_DS_NO_DELETED_NAME
        /// Failed to create name for deleted object.
        /// </summary>
        DsNoDeletedName = 0x20A3,

        /// <summary>
        /// ERROR_DS_SUBREF_MUST_HAVE_PARENT
        /// The parent of a new subref must exist.
        /// </summary>
        DsSubrefMustHaveParent = 0x20A4,

        /// <summary>
        /// ERROR_DS_NCNAME_MUST_BE_NC
        /// The object must be a naming context.
        /// </summary>
        DsNcnameMustBeNc = 0x20A5,

        /// <summary>
        /// ERROR_DS_CANT_ADD_SYSTEM_ONLY
        /// It is not permitted to add an attribute which is owned by the system.
        /// </summary>
        DsCantAddSystemOnly = 0x20A6,

        /// <summary>
        /// ERROR_DS_CLASS_MUST_BE_CONCRETE
        /// The class of the object must be structural; you cannot instantiate an abstract class.
        /// </summary>
        DsClassMustBeConcrete = 0x20A7,

        /// <summary>
        /// ERROR_DS_INVALID_DMD
        /// The schema object could not be found.
        /// </summary>
        DsInvalidDmd = 0x20A8,

        /// <summary>
        /// ERROR_DS_OBJ_GUID_EXISTS
        /// A local object with this GUID (dead or alive) already exists.
        /// </summary>
        DsObjGuidExists = 0x20A9,

        /// <summary>
        /// ERROR_DS_NOT_ON_BACKLINK
        /// The operation cannot be performed on a back link.
        /// </summary>
        DsNotOnBacklink = 0x20AA,

        /// <summary>
        /// ERROR_DS_NO_CROSSREF_FOR_NC
        /// The cross reference for the specified naming context could not be found.
        /// </summary>
        DsNoCrossrefForNc = 0x20AB,

        /// <summary>
        /// ERROR_DS_SHUTTING_DOWN
        /// The operation could not be performed because the directory service is shutting down.
        /// </summary>
        DsShuttingDown = 0x20AC,

        /// <summary>
        /// ERROR_DS_UNKNOWN_OPERATION
        /// The directory service request is invalid.
        /// </summary>
        DsUnknownOperation = 0x20AD,

        /// <summary>
        /// ERROR_DS_INVALID_ROLE_OWNER
        /// The role owner attribute could not be read.
        /// </summary>
        DsInvalidRoleOwner = 0x20AE,

        /// <summary>
        /// ERROR_DS_COULDNT_CONTACT_FSMO
        /// The requested FSMO operation failed. The current FSMO holder could not be contacted.
        /// </summary>
        DsCouldntContactFsmo = 0x20AF,

        /// <summary>
        /// ERROR_DS_CROSS_NC_DN_RENAME
        /// Modification of a DN across a naming context is not permitted.
        /// </summary>
        DsCrossNcDnRename = 0x20B0,

        /// <summary>
        /// ERROR_DS_CANT_MOD_SYSTEM_ONLY
        /// The attribute cannot be modified because it is owned by the system.
        /// </summary>
        DsCantModSystemOnly = 0x20B1,

        /// <summary>
        /// ERROR_DS_REPLICATOR_ONLY
        /// Only the replicator can perform this function.
        /// </summary>
        DsReplicatorOnly = 0x20B2,

        /// <summary>
        /// ERROR_DS_OBJ_CLASS_NOT_DEFINED
        /// The specified class is not defined.
        /// </summary>
        DsObjClassNotDefined = 0x20B3,

        /// <summary>
        /// ERROR_DS_OBJ_CLASS_NOT_SUBCLASS
        /// The specified class is not a subclass.
        /// </summary>
        DsObjClassNotSubclass = 0x20B4,

        /// <summary>
        /// ERROR_DS_NAME_REFERENCE_INVALID
        /// The name reference is invalid.
        /// </summary>
        DsNameReferenceInvalid = 0x20B5,

        /// <summary>
        /// ERROR_DS_CROSS_REF_EXISTS
        /// A cross reference already exists.
        /// </summary>
        DsCrossRefExists = 0x20B6,

        /// <summary>
        /// ERROR_DS_CANT_DEL_MASTER_CROSSREF
        /// It is not permitted to delete a master cross reference.
        /// </summary>
        DsCantDelMasterCrossref = 0x20B7,

        /// <summary>
        /// ERROR_DS_SUBTREE_NOTIFY_NOT_NC_HEAD
        /// Subtree notifications are only supported on NC heads.
        /// </summary>
        DsSubtreeNotifyNotNcHead = 0x20B8,

        /// <summary>
        /// ERROR_DS_NOTIFY_FILTER_TOO_COMPLEX
        /// Notification filter is too complex.
        /// </summary>
        DsNotifyFilterTooComplex = 0x20B9,

        /// <summary>
        /// ERROR_DS_DUP_RDN
        /// Schema update failed: duplicate RDN.
        /// </summary>
        DsDupRdn = 0x20BA,

        /// <summary>
        /// ERROR_DS_DUP_OID
        /// Schema update failed: duplicate OID.
        /// </summary>
        DsDupOid = 0x20BB,

        /// <summary>
        /// ERROR_DS_DUP_MAPI_ID
        /// Schema update failed: duplicate MAPI identifier.
        /// </summary>
        DsDupMapiId = 0x20BC,

        /// <summary>
        /// ERROR_DS_DUP_SCHEMA_ID_GUID
        /// Schema update failed: duplicate schema-id GUID.
        /// </summary>
        DsDupSchemaIdGuid = 0x20BD,

        /// <summary>
        /// ERROR_DS_DUP_LDAP_DISPLAY_NAME
        /// Schema update failed: duplicate LDAP display name.
        /// </summary>
        DsDupLdapDisplayName = 0x20BE,

        /// <summary>
        /// ERROR_DS_SEMANTIC_ATT_TEST
        /// Schema update failed: range-lower less than range upper.
        /// </summary>
        DsSemanticAttTest = 0x20BF,

        /// <summary>
        /// ERROR_DS_SYNTAX_MISMATCH
        /// Schema update failed: syntax mismatch.
        /// </summary>
        DsSyntaxMismatch = 0x20C0,

        /// <summary>
        /// ERROR_DS_EXISTS_IN_MUST_HAVE
        /// Schema deletion failed: attribute is used in must-contain.
        /// </summary>
        DsExistsInMustHave = 0x20C1,

        /// <summary>
        /// ERROR_DS_EXISTS_IN_MAY_HAVE
        /// Schema deletion failed: attribute is used in may-contain.
        /// </summary>
        DsExistsInMayHave = 0x20C2,

        /// <summary>
        /// ERROR_DS_NONEXISTENT_MAY_HAVE
        /// Schema update failed: attribute in may-contain does not exist.
        /// </summary>
        DsNonexistentMayHave = 0x20C3,

        /// <summary>
        /// ERROR_DS_NONEXISTENT_MUST_HAVE
        /// Schema update failed: attribute in must-contain does not exist.
        /// </summary>
        DsNonexistentMustHave = 0x20C4,

        /// <summary>
        /// ERROR_DS_AUX_CLS_TEST_FAIL
        /// Schema update failed: class in aux-class list does not exist or is not an auxiliary class.
        /// </summary>
        DsAuxClsTestFail = 0x20C5,

        /// <summary>
        /// ERROR_DS_NONEXISTENT_POSS_SUP
        /// Schema update failed: class in poss-superiors does not exist.
        /// </summary>
        DsNonexistentPossSup = 0x20C6,

        /// <summary>
        /// ERROR_DS_SUB_CLS_TEST_FAIL
        /// Schema update failed: class in subclassof list does not exist or does not satisfy hierarchy rules.
        /// </summary>
        DsSubClsTestFail = 0x20C7,

        /// <summary>
        /// ERROR_DS_BAD_RDN_ATT_ID_SYNTAX
        /// Schema update failed: Rdn-Att-Id has wrong syntax.
        /// </summary>
        DsBadRdnAttIdSyntax = 0x20C8,

        /// <summary>
        /// ERROR_DS_EXISTS_IN_AUX_CLS
        /// Schema deletion failed: class is used as auxiliary class.
        /// </summary>
        DsExistsInAuxCls = 0x20C9,

        /// <summary>
        /// ERROR_DS_EXISTS_IN_SUB_CLS
        /// Schema deletion failed: class is used as sub class.
        /// </summary>
        DsExistsInSubCls = 0x20CA,

        /// <summary>
        /// ERROR_DS_EXISTS_IN_POSS_SUP
        /// Schema deletion failed: class is used as poss superior.
        /// </summary>
        DsExistsInPossSup = 0x20CB,

        /// <summary>
        /// ERROR_DS_RECALCSCHEMA_FAILED
        /// Schema update failed in recalculating validation cache.
        /// </summary>
        DsRecalcschemaFailed = 0x20CC,

        /// <summary>
        /// ERROR_DS_TREE_DELETE_NOT_FINISHED
        /// The tree deletion is not finished. The request must be made again to continue deleting the tree.
        /// </summary>
        DsTreeDeleteNotFinished = 0x20CD,

        /// <summary>
        /// ERROR_DS_CANT_DELETE
        /// The requested delete operation could not be performed.
        /// </summary>
        DsCantDelete = 0x20CE,

        /// <summary>
        /// ERROR_DS_ATT_SCHEMA_REQ_ID
        /// Cannot read the governs class identifier for the schema record.
        /// </summary>
        DsAttSchemaReqId = 0x20CF,

        /// <summary>
        /// ERROR_DS_BAD_ATT_SCHEMA_SYNTAX
        /// The attribute schema has bad syntax.
        /// </summary>
        DsBadAttSchemaSyntax = 0x20D0,

        /// <summary>
        /// ERROR_DS_CANT_CACHE_ATT
        /// The attribute could not be cached.
        /// </summary>
        DsCantCacheAtt = 0x20D1,

        /// <summary>
        /// ERROR_DS_CANT_CACHE_CLASS
        /// The class could not be cached.
        /// </summary>
        DsCantCacheClass = 0x20D2,

        /// <summary>
        /// ERROR_DS_CANT_REMOVE_ATT_CACHE
        /// The attribute could not be removed from the cache.
        /// </summary>
        DsCantRemoveAttCache = 0x20D3,

        /// <summary>
        /// ERROR_DS_CANT_REMOVE_CLASS_CACHE
        /// The class could not be removed from the cache.
        /// </summary>
        DsCantRemoveClassCache = 0x20D4,

        /// <summary>
        /// ERROR_DS_CANT_RETRIEVE_DN
        /// The distinguished name attribute could not be read.
        /// </summary>
        DsCantRetrieveDn = 0x20D5,

        /// <summary>
        /// ERROR_DS_MISSING_SUPREF
        /// No superior reference has been configured for the directory service. The directory service is therefore unable to issue referrals to objects outside this forest.
        /// </summary>
        DsMissingSupref = 0x20D6,

        /// <summary>
        /// ERROR_DS_CANT_RETRIEVE_INSTANCE
        /// The instance type attribute could not be retrieved.
        /// </summary>
        DsCantRetrieveInstance = 0x20D7,

        /// <summary>
        /// ERROR_DS_CODE_INCONSISTENCY
        /// An internal error has occurred.
        /// </summary>
        DsCodeInconsistency = 0x20D8,

        /// <summary>
        /// ERROR_DS_DATABASE_ERROR
        /// A database error has occurred.
        /// </summary>
        DsDatabaseError = 0x20D9,

        /// <summary>
        /// ERROR_DS_GOVERNSID_MISSING
        /// The attribute GOVERNSID is missing.
        /// </summary>
        DsGovernsidMissing = 0x20DA,

        /// <summary>
        /// ERROR_DS_MISSING_EXPECTED_ATT
        /// An expected attribute is missing.
        /// </summary>
        DsMissingExpectedAtt = 0x20DB,

        /// <summary>
        /// ERROR_DS_NCNAME_MISSING_CR_REF
        /// The specified naming context is missing a cross reference.
        /// </summary>
        DsNcnameMissingCrRef = 0x20DC,

        /// <summary>
        /// ERROR_DS_SECURITY_CHECKING_ERROR
        /// A security checking error has occurred.
        /// </summary>
        DsSecurityCheckingError = 0x20DD,

        /// <summary>
        /// ERROR_DS_SCHEMA_NOT_LOADED
        /// The schema is not loaded.
        /// </summary>
        DsSchemaNotLoaded = 0x20DE,

        /// <summary>
        /// ERROR_DS_SCHEMA_ALLOC_FAILED
        /// Schema allocation failed. Please check if the machine is running low on memory.
        /// </summary>
        DsSchemaAllocFailed = 0x20DF,

        /// <summary>
        /// ERROR_DS_ATT_SCHEMA_REQ_SYNTAX
        /// Failed to obtain the required syntax for the attribute schema.
        /// </summary>
        DsAttSchemaReqSyntax = 0x20E0,

        /// <summary>
        /// ERROR_DS_GCVERIFY_ERROR
        /// The global catalog verification failed. The global catalog is not available or does not support the operation. Some part of the directory is currently not available.
        /// </summary>
        DsGcverifyError = 0x20E1,

        /// <summary>
        /// ERROR_DS_DRA_SCHEMA_MISMATCH
        /// The replication operation failed because of a schema mismatch between the servers involved.
        /// </summary>
        DsDraSchemaMismatch = 0x20E2,

        /// <summary>
        /// ERROR_DS_CANT_FIND_DSA_OBJ
        /// The DSA object could not be found.
        /// </summary>
        DsCantFindDsaObj = 0x20E3,

        /// <summary>
        /// ERROR_DS_CANT_FIND_EXPECTED_NC
        /// The naming context could not be found.
        /// </summary>
        DsCantFindExpectedNc = 0x20E4,

        /// <summary>
        /// ERROR_DS_CANT_FIND_NC_IN_CACHE
        /// The naming context could not be found in the cache.
        /// </summary>
        DsCantFindNcInCache = 0x20E5,

        /// <summary>
        /// ERROR_DS_CANT_RETRIEVE_CHILD
        /// The child object could not be retrieved.
        /// </summary>
        DsCantRetrieveChild = 0x20E6,

        /// <summary>
        /// ERROR_DS_SECURITY_ILLEGAL_MODIFY
        /// The modification was not permitted for security reasons.
        /// </summary>
        DsSecurityIllegalModify = 0x20E7,

        /// <summary>
        /// ERROR_DS_CANT_REPLACE_HIDDEN_REC
        /// The operation cannot replace the hidden record.
        /// </summary>
        DsCantReplaceHiddenRec = 0x20E8,

        /// <summary>
        /// ERROR_DS_BAD_HIERARCHY_FILE
        /// The hierarchy file is invalid.
        /// </summary>
        DsBadHierarchyFile = 0x20E9,

        /// <summary>
        /// ERROR_DS_BUILD_HIERARCHY_TABLE_FAILED
        /// The attempt to build the hierarchy table failed.
        /// </summary>
        DsBuildHierarchyTableFailed = 0x20EA,

        /// <summary>
        /// ERROR_DS_CONFIG_PARAM_MISSING
        /// The directory configuration parameter is missing from the registry.
        /// </summary>
        DsConfigParamMissing = 0x20EB,

        /// <summary>
        /// ERROR_DS_COUNTING_AB_INDICES_FAILED
        /// The attempt to count the address book indices failed.
        /// </summary>
        DsCountingAbIndicesFailed = 0x20EC,

        /// <summary>
        /// ERROR_DS_HIERARCHY_TABLE_MALLOC_FAILED
        /// The allocation of the hierarchy table failed.
        /// </summary>
        DsHierarchyTableMallocFailed = 0x20ED,

        /// <summary>
        /// ERROR_DS_INTERNAL_FAILURE
        /// The directory service encountered an internal failure.
        /// </summary>
        DsInternalFailure = 0x20EE,

        /// <summary>
        /// ERROR_DS_UNKNOWN_ERROR
        /// The directory service encountered an unknown failure.
        /// </summary>
        DsUnknownError = 0x20EF,

        /// <summary>
        /// ERROR_DS_ROOT_REQUIRES_CLASS_TOP
        /// A root object requires a class of 'top'.
        /// </summary>
        DsRootRequiresClassTop = 0x20F0,

        /// <summary>
        /// ERROR_DS_REFUSING_FSMO_ROLES
        /// This directory server is shutting down, and cannot take ownership of new floating single-master operation roles.
        /// </summary>
        DsRefusingFsmoRoles = 0x20F1,

        /// <summary>
        /// ERROR_DS_MISSING_FSMO_SETTINGS
        /// The directory service is missing mandatory configuration information, and is unable to determine the ownership of floating single-master operation roles.
        /// </summary>
        DsMissingFsmoSettings = 0x20F2,

        /// <summary>
        /// ERROR_DS_UNABLE_TO_SURRENDER_ROLES
        /// The directory service was unable to transfer ownership of one or more floating single-master operation roles to other servers.
        /// </summary>
        DsUnableToSurrenderRoles = 0x20F3,

        /// <summary>
        /// ERROR_DS_DRA_GENERIC
        /// The replication operation failed.
        /// </summary>
        DsDraGeneric = 0x20F4,

        /// <summary>
        /// ERROR_DS_DRA_INVALID_PARAMETER
        /// An invalid parameter was specified for this replication operation.
        /// </summary>
        DsDraInvalidParameter = 0x20F5,

        /// <summary>
        /// ERROR_DS_DRA_BUSY
        /// The directory service is too busy to complete the replication operation at this time.
        /// </summary>
        DsDraBusy = 0x20F6,

        /// <summary>
        /// ERROR_DS_DRA_BAD_DN
        /// The distinguished name specified for this replication operation is invalid.
        /// </summary>
        DsDraBadDn = 0x20F7,

        /// <summary>
        /// ERROR_DS_DRA_BAD_NC
        /// The naming context specified for this replication operation is invalid.
        /// </summary>
        DsDraBadNc = 0x20F8,

        /// <summary>
        /// ERROR_DS_DRA_DN_EXISTS
        /// The distinguished name specified for this replication operation already exists.
        /// </summary>
        DsDraDnExists = 0x20F9,

        /// <summary>
        /// ERROR_DS_DRA_INTERNAL_ERROR
        /// The replication system encountered an internal error.
        /// </summary>
        DsDraInternalError = 0x20FA,

        /// <summary>
        /// ERROR_DS_DRA_INCONSISTENT_DIT
        /// The replication operation encountered a database inconsistency.
        /// </summary>
        DsDraInconsistentDit = 0x20FB,

        /// <summary>
        /// ERROR_DS_DRA_CONNECTION_FAILED
        /// The server specified for this replication operation could not be contacted.
        /// </summary>
        DsDraConnectionFailed = 0x20FC,

        /// <summary>
        /// ERROR_DS_DRA_BAD_INSTANCE_TYPE
        /// The replication operation encountered an object with an invalid instance type.
        /// </summary>
        DsDraBadInstanceType = 0x20FD,

        /// <summary>
        /// ERROR_DS_DRA_OUT_OF_MEM
        /// The replication operation failed to allocate memory.
        /// </summary>
        DsDraOutOfMem = 0x20FE,

        /// <summary>
        /// ERROR_DS_DRA_MAIL_PROBLEM
        /// The replication operation encountered an error with the mail system.
        /// </summary>
        DsDraMailProblem = 0x20FF,

        /// <summary>
        /// ERROR_DS_DRA_REF_ALREADY_EXISTS
        /// The replication reference information for the target server already exists.
        /// </summary>
        DsDraRefAlreadyExists = 0x2100,

        /// <summary>
        /// ERROR_DS_DRA_REF_NOT_FOUND
        /// The replication reference information for the target server does not exist.
        /// </summary>
        DsDraRefNotFound = 0x2101,

        /// <summary>
        /// ERROR_DS_DRA_OBJ_IS_REP_SOURCE
        /// The naming context cannot be removed because it is replicated to another server.
        /// </summary>
        DsDraObjIsRepSource = 0x2102,

        /// <summary>
        /// ERROR_DS_DRA_DB_ERROR
        /// The replication operation encountered a database error.
        /// </summary>
        DsDraDbError = 0x2103,

        /// <summary>
        /// ERROR_DS_DRA_NO_REPLICA
        /// The naming context is in the process of being removed or is not replicated from the specified server.
        /// </summary>
        DsDraNoReplica = 0x2104,

        /// <summary>
        /// ERROR_DS_DRA_ACCESS_DENIED
        /// Replication access was denied.
        /// </summary>
        DsDraAccessDenied = 0x2105,

        /// <summary>
        /// ERROR_DS_DRA_NOT_SUPPORTED
        /// The requested operation is not supported by this version of the directory service.
        /// </summary>
        DsDraNotSupported = 0x2106,

        /// <summary>
        /// ERROR_DS_DRA_RPC_CANCELLED
        /// The replication remote procedure call was cancelled.
        /// </summary>
        DsDraRpcCancelled = 0x2107,

        /// <summary>
        /// ERROR_DS_DRA_SOURCE_DISABLED
        /// The source server is currently rejecting replication requests.
        /// </summary>
        DsDraSourceDisabled = 0x2108,

        /// <summary>
        /// ERROR_DS_DRA_SINK_DISABLED
        /// The destination server is currently rejecting replication requests.
        /// </summary>
        DsDraSinkDisabled = 0x2109,

        /// <summary>
        /// ERROR_DS_DRA_NAME_COLLISION
        /// The replication operation failed due to a collision of object names.
        /// </summary>
        DsDraNameCollision = 0x210A,

        /// <summary>
        /// ERROR_DS_DRA_SOURCE_REINSTALLED
        /// The replication source has been reinstalled.
        /// </summary>
        DsDraSourceReinstalled = 0x210B,

        /// <summary>
        /// ERROR_DS_DRA_MISSING_PARENT
        /// The replication operation failed because a required parent object is missing.
        /// </summary>
        DsDraMissingParent = 0x210C,

        /// <summary>
        /// ERROR_DS_DRA_PREEMPTED
        /// The replication operation was preempted.
        /// </summary>
        DsDraPreempted = 0x210D,

        /// <summary>
        /// ERROR_DS_DRA_ABANDON_SYNC
        /// The replication synchronization attempt was abandoned because of a lack of updates.
        /// </summary>
        DsDraAbandonSync = 0x210E,

        /// <summary>
        /// ERROR_DS_DRA_SHUTDOWN
        /// The replication operation was terminated because the system is shutting down.
        /// </summary>
        DsDraShutdown = 0x210F,

        /// <summary>
        /// ERROR_DS_DRA_INCOMPATIBLE_PARTIAL_SET
        /// Synchronization attempt failed because the destination DC is currently waiting to synchronize new partial attributes from source. This condition is normal if a recent schema change modified the partial attribute set. The destination partial attribute set is not a subset of source partial attribute set.
        /// </summary>
        DsDraIncompatiblePartialSet = 0x2110,

        /// <summary>
        /// ERROR_DS_DRA_SOURCE_IS_PARTIAL_REPLICA
        /// The replication synchronization attempt failed because a master replica attempted to sync from a partial replica.
        /// </summary>
        DsDraSourceIsPartialReplica = 0x2111,

        /// <summary>
        /// ERROR_DS_DRA_EXTN_CONNECTION_FAILED
        /// The server specified for this replication operation was contacted, but that server was unable to contact an additional server needed to complete the operation.
        /// </summary>
        DsDraExtnConnectionFailed = 0x2112,

        /// <summary>
        /// ERROR_DS_INSTALL_SCHEMA_MISMATCH
        /// The version of the directory service schema of the source forest is not compatible with the version of directory service on this computer.
        /// </summary>
        DsInstallSchemaMismatch = 0x2113,

        /// <summary>
        /// ERROR_DS_DUP_LINK_ID
        /// Schema update failed: An attribute with the same link identifier already exists.
        /// </summary>
        DsDupLinkId = 0x2114,

        /// <summary>
        /// ERROR_DS_NAME_ERROR_RESOLVING
        /// Name translation: Generic processing error.
        /// </summary>
        DsNameErrorResolving = 0x2115,

        /// <summary>
        /// ERROR_DS_NAME_ERROR_NOT_FOUND
        /// Name translation: Could not find the name or insufficient right to see name.
        /// </summary>
        DsNameErrorNotFound = 0x2116,

        /// <summary>
        /// ERROR_DS_NAME_ERROR_NOT_UNIQUE
        /// Name translation: Input name mapped to more than one output name.
        /// </summary>
        DsNameErrorNotUnique = 0x2117,

        /// <summary>
        /// ERROR_DS_NAME_ERROR_NO_MAPPING
        /// Name translation: Input name found, but not the associated output format.
        /// </summary>
        DsNameErrorNoMapping = 0x2118,

        /// <summary>
        /// ERROR_DS_NAME_ERROR_DOMAIN_ONLY
        /// Name translation: Unable to resolve completely, only the domain was found.
        /// </summary>
        DsNameErrorDomainOnly = 0x2119,

        /// <summary>
        /// ERROR_DS_NAME_ERROR_NO_SYNTACTICAL_MAPPING
        /// Name translation: Unable to perform purely syntactical mapping at the client without going out to the wire.
        /// </summary>
        DsNameErrorNoSyntacticalMapping = 0x211A,

        /// <summary>
        /// ERROR_DS_CONSTRUCTED_ATT_MOD
        /// Modification of a constructed attribute is not allowed.
        /// </summary>
        DsConstructedAttMod = 0x211B,

        /// <summary>
        /// ERROR_DS_WRONG_OM_OBJ_CLASS
        /// The OM-Object-Class specified is incorrect for an attribute with the specified syntax.
        /// </summary>
        DsWrongOmObjClass = 0x211C,

        /// <summary>
        /// ERROR_DS_DRA_REPL_PENDING
        /// The replication request has been posted; waiting for reply.
        /// </summary>
        DsDraReplPending = 0x211D,

        /// <summary>
        /// ERROR_DS_DS_REQUIRED
        /// The requested operation requires a directory service, and none was available.
        /// </summary>
        DsDsRequired = 0x211E,

        /// <summary>
        /// ERROR_DS_INVALID_LDAP_DISPLAY_NAME
        /// The LDAP display name of the class or attribute contains non-ASCII characters.
        /// </summary>
        DsInvalidLdapDisplayName = 0x211F,

        /// <summary>
        /// ERROR_DS_NON_BASE_SEARCH
        /// The requested search operation is only supported for base searches.
        /// </summary>
        DsNonBaseSearch = 0x2120,

        /// <summary>
        /// ERROR_DS_CANT_RETRIEVE_ATTS
        /// The search failed to retrieve attributes from the database.
        /// </summary>
        DsCantRetrieveAtts = 0x2121,

        /// <summary>
        /// ERROR_DS_BACKLINK_WITHOUT_LINK
        /// The schema update operation tried to add a backward link attribute that has no corresponding forward link.
        /// </summary>
        DsBacklinkWithoutLink = 0x2122,

        /// <summary>
        /// ERROR_DS_EPOCH_MISMATCH
        /// Source and destination of a cross-domain move do not agree on the object's epoch number. Either source or destination does not have the latest version of the object.
        /// </summary>
        DsEpochMismatch = 0x2123,

        /// <summary>
        /// ERROR_DS_SRC_NAME_MISMATCH
        /// Source and destination of a cross-domain move do not agree on the object's current name. Either source or destination does not have the latest version of the object.
        /// </summary>
        DsSrcNameMismatch = 0x2124,

        /// <summary>
        /// ERROR_DS_SRC_AND_DST_NC_IDENTICAL
        /// Source and destination for the cross-domain move operation are identical. Caller should use local move operation instead of cross-domain move operation.
        /// </summary>
        DsSrcAndDstNcIdentical = 0x2125,

        /// <summary>
        /// ERROR_DS_DST_NC_MISMATCH
        /// Source and destination for a cross-domain move are not in agreement on the naming contexts in the forest. Either source or destination does not have the latest version of the Partitions container.
        /// </summary>
        DsDstNcMismatch = 0x2126,

        /// <summary>
        /// ERROR_DS_NOT_AUTHORITIVE_FOR_DST_NC
        /// Destination of a cross-domain move is not authoritative for the destination naming context.
        /// </summary>
        DsNotAuthoritiveForDstNc = 0x2127,

        /// <summary>
        /// ERROR_DS_SRC_GUID_MISMATCH
        /// Source and destination of a cross-domain move do not agree on the identity of the source object. Either source or destination does not have the latest version of the source object.
        /// </summary>
        DsSrcGuidMismatch = 0x2128,

        /// <summary>
        /// ERROR_DS_CANT_MOVE_DELETED_OBJECT
        /// Object being moved across-domains is already known to be deleted by the destination server. The source server does not have the latest version of the source object.
        /// </summary>
        DsCantMoveDeletedObject = 0x2129,

        /// <summary>
        /// ERROR_DS_PDC_OPERATION_IN_PROGRESS
        /// Another operation which requires exclusive access to the PDC FSMO is already in progress.
        /// </summary>
        DsPdcOperationInProgress = 0x212A,

        /// <summary>
        /// ERROR_DS_CROSS_DOMAIN_CLEANUP_REQD
        /// A cross-domain move operation failed such that two versions of the moved object exist - one each in the source and destination domains. The destination object needs to be removed to restore the system to a consistent state.
        /// </summary>
        DsCrossDomainCleanupReqd = 0x212B,

        /// <summary>
        /// ERROR_DS_ILLEGAL_XDOM_MOVE_OPERATION
        /// This object may not be moved across domain boundaries either because cross-domain moves for this class are disallowed, or the object has some special characteristics, e.g.: trust account or restricted RID, which prevent its move.
        /// </summary>
        DsIllegalXdomMoveOperation = 0x212C,

        /// <summary>
        /// ERROR_DS_CANT_WITH_ACCT_GROUP_MEMBERSHPS
        /// Can't move objects with memberships across domain boundaries as once moved, this would violate the membership conditions of the account group. Remove the object from any account group memberships and retry.
        /// </summary>
        DsCantWithAcctGroupMembershps = 0x212D,

        /// <summary>
        /// ERROR_DS_NC_MUST_HAVE_NC_PARENT
        /// A naming context head must be the immediate child of another naming context head, not of an interior node.
        /// </summary>
        DsNcMustHaveNcParent = 0x212E,

        /// <summary>
        /// ERROR_DS_CR_IMPOSSIBLE_TO_VALIDATE
        /// The directory cannot validate the proposed naming context name because it does not hold a replica of the naming context above the proposed naming context. Please ensure that the domain naming master role is held by a server that is configured as a global catalog server, and that the server is up to date with its replication partners. (Applies only to Windows 2000 Domain Naming masters.)
        /// </summary>
        DsCrImpossibleToValidate = 0x212F,

        /// <summary>
        /// ERROR_DS_DST_DOMAIN_NOT_NATIVE
        /// Destination domain must be in native mode.
        /// </summary>
        DsDstDomainNotNative = 0x2130,

        /// <summary>
        /// ERROR_DS_MISSING_INFRASTRUCTURE_CONTAINER
        /// The operation cannot be performed because the server does not have an infrastructure container in the domain of interest.
        /// </summary>
        DsMissingInfrastructureContainer = 0x2131,

        /// <summary>
        /// ERROR_DS_CANT_MOVE_ACCOUNT_GROUP
        /// Cross-domain move of non-empty account groups is not allowed.
        /// </summary>
        DsCantMoveAccountGroup = 0x2132,

        /// <summary>
        /// ERROR_DS_CANT_MOVE_RESOURCE_GROUP
        /// Cross-domain move of non-empty resource groups is not allowed.
        /// </summary>
        DsCantMoveResourceGroup = 0x2133,

        /// <summary>
        /// ERROR_DS_INVALID_SEARCH_FLAG
        /// The search flags for the attribute are invalid. The ANR bit is valid only on attributes of Unicode or Teletex strings.
        /// </summary>
        DsInvalidSearchFlag = 0x2134,

        /// <summary>
        /// ERROR_DS_NO_TREE_DELETE_ABOVE_NC
        /// Tree deletions starting at an object which has an NC head as a descendant are not allowed.
        /// </summary>
        DsNoTreeDeleteAboveNc = 0x2135,

        /// <summary>
        /// ERROR_DS_COULDNT_LOCK_TREE_FOR_DELETE
        /// The directory service failed to lock a tree in preparation for a tree deletion because the tree was in use.
        /// </summary>
        DsCouldntLockTreeForDelete = 0x2136,

        /// <summary>
        /// ERROR_DS_COULDNT_IDENTIFY_OBJECTS_FOR_TREE_DELETE
        /// The directory service failed to identify the list of objects to delete while attempting a tree deletion.
        /// </summary>
        DsCouldntIdentifyObjectsForTreeDelete = 0x2137,

        /// <summary>
        /// ERROR_DS_SAM_INIT_FAILURE
        /// Security Accounts Manager initialization failed because of the following error: %1. Error Status: 0x%2. Please shutdown this system and reboot into Directory Services Restore Mode, check the event log for more detailed information.
        /// </summary>
        DsSamInitFailure = 0x2138,

        /// <summary>
        /// ERROR_DS_SENSITIVE_GROUP_VIOLATION
        /// Only an administrator can modify the membership list of an administrative group.
        /// </summary>
        DsSensitiveGroupViolation = 0x2139,

        /// <summary>
        /// ERROR_DS_CANT_MOD_PRIMARYGROUPID
        /// Cannot change the primary group ID of a domain controller account.
        /// </summary>
        DsCantModPrimarygroupid = 0x213A,

        /// <summary>
        /// ERROR_DS_ILLEGAL_BASE_SCHEMA_MOD
        /// An attempt is made to modify the base schema.
        /// </summary>
        DsIllegalBaseSchemaMod = 0x213B,

        /// <summary>
        /// ERROR_DS_NONSAFE_SCHEMA_CHANGE
        /// Adding a new mandatory attribute to an existing class, deleting a mandatory attribute from an existing class, or adding an optional attribute to the special class Top that is not a backlink attribute (directly or through inheritance, for example, by adding or deleting an auxiliary class) is not allowed.
        /// </summary>
        DsNonsafeSchemaChange = 0x213C,

        /// <summary>
        /// ERROR_DS_SCHEMA_UPDATE_DISALLOWED
        /// Schema update is not allowed on this DC because the DC is not the schema FSMO Role Owner.
        /// </summary>
        DsSchemaUpdateDisallowed = 0x213D,

        /// <summary>
        /// ERROR_DS_CANT_CREATE_UNDER_SCHEMA
        /// An object of this class cannot be created under the schema container. You can only create attribute-schema and class-schema objects under the schema container.
        /// </summary>
        DsCantCreateUnderSchema = 0x213E,

        /// <summary>
        /// ERROR_DS_INSTALL_NO_SRC_SCH_VERSION
        /// The replica/child install failed to get the objectVersion attribute on the schema container on the source DC. Either the attribute is missing on the schema container or the credentials supplied do not have permission to read it.
        /// </summary>
        DsInstallNoSrcSchVersion = 0x213F,

        /// <summary>
        /// ERROR_DS_INSTALL_NO_SCH_VERSION_IN_INIFILE
        /// The replica/child install failed to read the objectVersion attribute in the SCHEMA section of the file schema.ini in the system32 directory.
        /// </summary>
        DsInstallNoSchVersionInInifile = 0x2140,

        /// <summary>
        /// ERROR_DS_INVALID_GROUP_TYPE
        /// The specified group type is invalid.
        /// </summary>
        DsInvalidGroupType = 0x2141,

        /// <summary>
        /// ERROR_DS_NO_NEST_GLOBALGROUP_IN_MIXEDDOMAIN
        /// You cannot nest global groups in a mixed domain if the group is security-enabled.
        /// </summary>
        DsNoNestGlobalgroupInMixeddomain = 0x2142,

        /// <summary>
        /// ERROR_DS_NO_NEST_LOCALGROUP_IN_MIXEDDOMAIN
        /// You cannot nest local groups in a mixed domain if the group is security-enabled.
        /// </summary>
        DsNoNestLocalgroupInMixeddomain = 0x2143,

        /// <summary>
        /// ERROR_DS_GLOBAL_CANT_HAVE_LOCAL_MEMBER
        /// A global group cannot have a local group as a member.
        /// </summary>
        DsGlobalCantHaveLocalMember = 0x2144,

        /// <summary>
        /// ERROR_DS_GLOBAL_CANT_HAVE_UNIVERSAL_MEMBER
        /// A global group cannot have a universal group as a member.
        /// </summary>
        DsGlobalCantHaveUniversalMember = 0x2145,

        /// <summary>
        /// ERROR_DS_UNIVERSAL_CANT_HAVE_LOCAL_MEMBER
        /// A universal group cannot have a local group as a member.
        /// </summary>
        DsUniversalCantHaveLocalMember = 0x2146,

        /// <summary>
        /// ERROR_DS_GLOBAL_CANT_HAVE_CROSSDOMAIN_MEMBER
        /// A global group cannot have a cross-domain member.
        /// </summary>
        DsGlobalCantHaveCrossdomainMember = 0x2147,

        /// <summary>
        /// ERROR_DS_LOCAL_CANT_HAVE_CROSSDOMAIN_LOCAL_MEMBER
        /// A local group cannot have another cross domain local group as a member.
        /// </summary>
        DsLocalCantHaveCrossdomainLocalMember = 0x2148,

        /// <summary>
        /// ERROR_DS_HAVE_PRIMARY_MEMBERS
        /// A group with primary members cannot change to a security-disabled group.
        /// </summary>
        DsHavePrimaryMembers = 0x2149,

        /// <summary>
        /// ERROR_DS_STRING_SD_CONVERSION_FAILED
        /// The schema cache load failed to convert the string default SD on a class-schema object.
        /// </summary>
        DsStringSdConversionFailed = 0x214A,

        /// <summary>
        /// ERROR_DS_NAMING_MASTER_GC
        /// Only DSAs configured to be Global Catalog servers should be allowed to hold the Domain Naming Master FSMO role. (Applies only to Windows 2000 servers.)
        /// </summary>
        DsNamingMasterGc = 0x214B,

        /// <summary>
        /// ERROR_DS_DNS_LOOKUP_FAILURE
        /// The DSA operation is unable to proceed because of a DNS lookup failure.
        /// </summary>
        DsDnsLookupFailure = 0x214C,

        /// <summary>
        /// ERROR_DS_COULDNT_UPDATE_SPNS
        /// While processing a change to the DNS Host Name for an object, the Service Principal Name values could not be kept in sync.
        /// </summary>
        DsCouldntUpdateSpns = 0x214D,

        /// <summary>
        /// ERROR_DS_CANT_RETRIEVE_SD
        /// The Security Descriptor attribute could not be read.
        /// </summary>
        DsCantRetrieveSd = 0x214E,

        /// <summary>
        /// ERROR_DS_KEY_NOT_UNIQUE
        /// The object requested was not found, but an object with that key was found.
        /// </summary>
        DsKeyNotUnique = 0x214F,

        /// <summary>
        /// ERROR_DS_WRONG_LINKED_ATT_SYNTAX
        /// The syntax of the linked attribute being added is incorrect. Forward links can only have syntax 2.5.5.1, 2.5.5.7, and 2.5.5.14, and backlinks can only have syntax 2.5.5.1.
        /// </summary>
        DsWrongLinkedAttSyntax = 0x2150,

        /// <summary>
        /// ERROR_DS_SAM_NEED_BOOTKEY_PASSWORD
        /// Security Account Manager needs to get the boot password.
        /// </summary>
        DsSamNeedBootkeyPassword = 0x2151,

        /// <summary>
        /// ERROR_DS_SAM_NEED_BOOTKEY_FLOPPY
        /// Security Account Manager needs to get the boot key from floppy disk.
        /// </summary>
        DsSamNeedBootkeyFloppy = 0x2152,

        /// <summary>
        /// ERROR_DS_CANT_START
        /// Directory Service cannot start.
        /// </summary>
        DsCantStart = 0x2153,

        /// <summary>
        /// ERROR_DS_INIT_FAILURE
        /// Directory Services could not start.
        /// </summary>
        DsInitFailure = 0x2154,

        /// <summary>
        /// ERROR_DS_NO_PKT_PRIVACY_ON_CONNECTION
        /// The connection between client and server requires packet privacy or better.
        /// </summary>
        DsNoPktPrivacyOnConnection = 0x2155,

        /// <summary>
        /// ERROR_DS_SOURCE_DOMAIN_IN_FOREST
        /// The source domain may not be in the same forest as destination.
        /// </summary>
        DsSourceDomainInForest = 0x2156,

        /// <summary>
        /// ERROR_DS_DESTINATION_DOMAIN_NOT_IN_FOREST
        /// The destination domain must be in the forest.
        /// </summary>
        DsDestinationDomainNotInForest = 0x2157,

        /// <summary>
        /// ERROR_DS_DESTINATION_AUDITING_NOT_ENABLED
        /// The operation requires that destination domain auditing be enabled.
        /// </summary>
        DsDestinationAuditingNotEnabled = 0x2158,

        /// <summary>
        /// ERROR_DS_CANT_FIND_DC_FOR_SRC_DOMAIN
        /// The operation couldn't locate a DC for the source domain.
        /// </summary>
        DsCantFindDcForSrcDomain = 0x2159,

        /// <summary>
        /// ERROR_DS_SRC_OBJ_NOT_GROUP_OR_USER
        /// The source object must be a group or user.
        /// </summary>
        DsSrcObjNotGroupOrUser = 0x215A,

        /// <summary>
        /// ERROR_DS_SRC_SID_EXISTS_IN_FOREST
        /// The source object's SID already exists in destination forest.
        /// </summary>
        DsSrcSidExistsInForest = 0x215B,

        /// <summary>
        /// ERROR_DS_SRC_AND_DST_OBJECT_CLASS_MISMATCH
        /// The source and destination object must be of the same type.
        /// </summary>
        DsSrcAndDstObjectClassMismatch = 0x215C,

        /// <summary>
        /// ERROR_SAM_INIT_FAILURE
        /// Security Accounts Manager initialization failed because of the following error: %1. Error Status: 0x%2. Click OK to shut down the system and reboot into Safe Mode. Check the event log for detailed information.
        /// </summary>
        SamInitFailure = 0x215D,

        /// <summary>
        /// ERROR_DS_DRA_SCHEMA_INFO_SHIP
        /// Schema information could not be included in the replication request.
        /// </summary>
        DsDraSchemaInfoShip = 0x215E,

        /// <summary>
        /// ERROR_DS_DRA_SCHEMA_CONFLICT
        /// The replication operation could not be completed due to a schema incompatibility.
        /// </summary>
        DsDraSchemaConflict = 0x215F,

        /// <summary>
        /// ERROR_DS_DRA_EARLIER_SCHEMA_CONFLICT
        /// The replication operation could not be completed due to a previous schema incompatibility.
        /// </summary>
        DsDraEarlierSchemaConflict = 0x2160,

        /// <summary>
        /// ERROR_DS_DRA_OBJ_NC_MISMATCH
        /// The replication update could not be applied because either the source or the destination has not yet received information regarding a recent cross-domain move operation.
        /// </summary>
        DsDraObjNcMismatch = 0x2161,

        /// <summary>
        /// ERROR_DS_NC_STILL_HAS_DSAS
        /// The requested domain could not be deleted because there exist domain controllers that still host this domain.
        /// </summary>
        DsNcStillHasDsas = 0x2162,

        /// <summary>
        /// ERROR_DS_GC_REQUIRED
        /// The requested operation can be performed only on a global catalog server.
        /// </summary>
        DsGcRequired = 0x2163,

        /// <summary>
        /// ERROR_DS_LOCAL_MEMBER_OF_LOCAL_ONLY
        /// A local group can only be a member of other local groups in the same domain.
        /// </summary>
        DsLocalMemberOfLocalOnly = 0x2164,

        /// <summary>
        /// ERROR_DS_NO_FPO_IN_UNIVERSAL_GROUPS
        /// Foreign security principals cannot be members of universal groups.
        /// </summary>
        DsNoFpoInUniversalGroups = 0x2165,

        /// <summary>
        /// ERROR_DS_CANT_ADD_TO_GC
        /// The attribute is not allowed to be replicated to the GC because of security reasons.
        /// </summary>
        DsCantAddToGc = 0x2166,

        /// <summary>
        /// ERROR_DS_NO_CHECKPOINT_WITH_PDC
        /// The checkpoint with the PDC could not be taken because there too many modifications being processed currently.
        /// </summary>
        DsNoCheckpointWithPdc = 0x2167,

        /// <summary>
        /// ERROR_DS_SOURCE_AUDITING_NOT_ENABLED
        /// The operation requires that source domain auditing be enabled.
        /// </summary>
        DsSourceAuditingNotEnabled = 0x2168,

        /// <summary>
        /// ERROR_DS_CANT_CREATE_IN_NONDOMAIN_NC
        /// Security principal objects can only be created inside domain naming contexts.
        /// </summary>
        DsCantCreateInNondomainNc = 0x2169,

        /// <summary>
        /// ERROR_DS_INVALID_NAME_FOR_SPN
        /// A Service Principal Name (SPN) could not be constructed because the provided hostname is not in the necessary format.
        /// </summary>
        DsInvalidNameForSpn = 0x216A,

        /// <summary>
        /// ERROR_DS_FILTER_USES_CONTRUCTED_ATTRS
        /// A Filter was passed that uses constructed attributes.
        /// </summary>
        DsFilterUsesContructedAttrs = 0x216B,

        /// <summary>
        /// ERROR_DS_UNICODEPWD_NOT_IN_QUOTES
        /// The unicodePwd attribute value must be enclosed in double quotes.
        /// </summary>
        DsUnicodepwdNotInQuotes = 0x216C,

        /// <summary>
        /// ERROR_DS_MACHINE_ACCOUNT_QUOTA_EXCEEDED
        /// Your computer could not be joined to the domain. You have exceeded the maximum number of computer accounts you are allowed to create in this domain. Contact your system administrator to have this limit reset or increased.
        /// </summary>
        DsMachineAccountQuotaExceeded = 0x216D,

        /// <summary>
        /// ERROR_DS_MUST_BE_RUN_ON_DST_DC
        /// For security reasons, the operation must be run on the destination DC.
        /// </summary>
        DsMustBeRunOnDstDc = 0x216E,

        /// <summary>
        /// ERROR_DS_SRC_DC_MUST_BE_SP4_OR_GREATER
        /// For security reasons, the source DC must be NT4SP4 or greater.
        /// </summary>
        DsSrcDcMustBeSp4OrGreater = 0x216F,

        /// <summary>
        /// ERROR_DS_CANT_TREE_DELETE_CRITICAL_OBJ
        /// Critical Directory Service System objects cannot be deleted during tree delete operations. The tree delete may have been partially performed.
        /// </summary>
        DsCantTreeDeleteCriticalObj = 0x2170,

        /// <summary>
        /// ERROR_DS_INIT_FAILURE_CONSOLE
        /// Directory Services could not start because of the following error: %1. Error Status: 0x%2. Please click OK to shutdown the system. You can use the recovery console to diagnose the system further.
        /// </summary>
        DsInitFailureConsole = 0x2171,

        /// <summary>
        /// ERROR_DS_SAM_INIT_FAILURE_CONSOLE
        /// Security Accounts Manager initialization failed because of the following error: %1. Error Status: 0x%2. Please click OK to shutdown the system. You can use the recovery console to diagnose the system further.
        /// </summary>
        DsSamInitFailureConsole = 0x2172,

        /// <summary>
        /// ERROR_DS_FOREST_VERSION_TOO_HIGH
        /// The version of the operating system is incompatible with the current AD DS forest functional level or AD LDS Configuration Set functional level. You must upgrade to a new version of the operating system before this server can become an AD DS Domain Controller or add an AD LDS Instance in this AD DS Forest or AD LDS Configuration Set.
        /// </summary>
        DsForestVersionTooHigh = 0x2173,

        /// <summary>
        /// ERROR_DS_DOMAIN_VERSION_TOO_HIGH
        /// The version of the operating system installed is incompatible with the current domain functional level. You must upgrade to a new version of the operating system before this server can become a domain controller in this domain.
        /// </summary>
        DsDomainVersionTooHigh = 0x2174,

        /// <summary>
        /// ERROR_DS_FOREST_VERSION_TOO_LOW
        /// The version of the operating system installed on this server no longer supports the current AD DS Forest functional level or AD LDS Configuration Set functional level. You must raise the AD DS Forest functional level or AD LDS Configuration Set functional level before this server can become an AD DS Domain Controller or an AD LDS Instance in this Forest or Configuration Set.
        /// </summary>
        DsForestVersionTooLow = 0x2175,

        /// <summary>
        /// ERROR_DS_DOMAIN_VERSION_TOO_LOW
        /// The version of the operating system installed on this server no longer supports the current domain functional level. You must raise the domain functional level before this server can become a domain controller in this domain.
        /// </summary>
        DsDomainVersionTooLow = 0x2176,

        /// <summary>
        /// ERROR_DS_INCOMPATIBLE_VERSION
        /// The version of the operating system installed on this server is incompatible with the functional level of the domain or forest.
        /// </summary>
        DsIncompatibleVersion = 0x2177,

        /// <summary>
        /// ERROR_DS_LOW_DSA_VERSION
        /// The functional level of the domain (or forest) cannot be raised to the requested value, because there exist one or more domain controllers in the domain (or forest) that are at a lower incompatible functional level.
        /// </summary>
        DsLowDsaVersion = 0x2178,

        /// <summary>
        /// ERROR_DS_NO_BEHAVIOR_VERSION_IN_MIXEDDOMAIN
        /// The forest functional level cannot be raised to the requested value since one or more domains are still in mixed domain mode. All domains in the forest must be in native mode, for you to raise the forest functional level.
        /// </summary>
        DsNoBehaviorVersionInMixeddomain = 0x2179,

        /// <summary>
        /// ERROR_DS_NOT_SUPPORTED_SORT_ORDER
        /// The sort order requested is not supported.
        /// </summary>
        DsNotSupportedSortOrder = 0x217A,

        /// <summary>
        /// ERROR_DS_NAME_NOT_UNIQUE
        /// The requested name already exists as a unique identifier.
        /// </summary>
        DsNameNotUnique = 0x217B,

        /// <summary>
        /// ERROR_DS_MACHINE_ACCOUNT_CREATED_PRENT4
        /// The machine account was created pre-NT4. The account needs to be recreated.
        /// </summary>
        DsMachineAccountCreatedPrent4 = 0x217C,

        /// <summary>
        /// ERROR_DS_OUT_OF_VERSION_STORE
        /// The database is out of version store.
        /// </summary>
        DsOutOfVersionStore = 0x217D,

        /// <summary>
        /// ERROR_DS_INCOMPATIBLE_CONTROLS_USED
        /// Unable to continue operation because multiple conflicting controls were used.
        /// </summary>
        DsIncompatibleControlsUsed = 0x217E,

        /// <summary>
        /// ERROR_DS_NO_REF_DOMAIN
        /// Unable to find a valid security descriptor reference domain for this partition.
        /// </summary>
        DsNoRefDomain = 0x217F,

        /// <summary>
        /// ERROR_DS_RESERVED_LINK_ID
        /// Schema update failed: The link identifier is reserved.
        /// </summary>
        DsReservedLinkId = 0x2180,

        /// <summary>
        /// ERROR_DS_LINK_ID_NOT_AVAILABLE
        /// Schema update failed: There are no link identifiers available.
        /// </summary>
        DsLinkIdNotAvailable = 0x2181,

        /// <summary>
        /// ERROR_DS_AG_CANT_HAVE_UNIVERSAL_MEMBER
        /// An account group cannot have a universal group as a member.
        /// </summary>
        DsAgCantHaveUniversalMember = 0x2182,

        /// <summary>
        /// ERROR_DS_MODIFYDN_DISALLOWED_BY_INSTANCE_TYPE
        /// Rename or move operations on naming context heads or read-only objects are not allowed.
        /// </summary>
        DsModifydnDisallowedByInstanceType = 0x2183,

        /// <summary>
        /// ERROR_DS_NO_OBJECT_MOVE_IN_SCHEMA_NC
        /// Move operations on objects in the schema naming context are not allowed.
        /// </summary>
        DsNoObjectMoveInSchemaNc = 0x2184,

        /// <summary>
        /// ERROR_DS_MODIFYDN_DISALLOWED_BY_FLAG
        /// A system flag has been set on the object and does not allow the object to be moved or renamed.
        /// </summary>
        DsModifydnDisallowedByFlag = 0x2185,

        /// <summary>
        /// ERROR_DS_MODIFYDN_WRONG_GRANDPARENT
        /// This object is not allowed to change its grandparent container. Moves are not forbidden on this object, but are restricted to sibling containers.
        /// </summary>
        DsModifydnWrongGrandparent = 0x2186,

        /// <summary>
        /// ERROR_DS_NAME_ERROR_TRUST_REFERRAL
        /// Unable to resolve completely, a referral to another forest is generated.
        /// </summary>
        DsNameErrorTrustReferral = 0x2187,

        /// <summary>
        /// ERROR_NOT_SUPPORTED_ON_STANDARD_SERVER
        /// The requested action is not supported on standard server.
        /// </summary>
        NotSupportedOnStandardServer = 0x2188,

        /// <summary>
        /// ERROR_DS_CANT_ACCESS_REMOTE_PART_OF_AD
        /// Could not access a partition of the directory service located on a remote server. Make sure at least one server is running for the partition in question.
        /// </summary>
        DsCantAccessRemotePartOfAd = 0x2189,

        /// <summary>
        /// ERROR_DS_CR_IMPOSSIBLE_TO_VALIDATE_V2
        /// The directory cannot validate the proposed naming context (or partition) name because it does not hold a replica nor can it contact a replica of the naming context above the proposed naming context. Please ensure that the parent naming context is properly registered in DNS, and at least one replica of this naming context is reachable by the Domain Naming master.
        /// </summary>
        DsCrImpossibleToValidateV2 = 0x218A,

        /// <summary>
        /// ERROR_DS_THREAD_LIMIT_EXCEEDED
        /// The thread limit for this request was exceeded.
        /// </summary>
        DsThreadLimitExceeded = 0x218B,

        /// <summary>
        /// ERROR_DS_NOT_CLOSEST
        /// The Global catalog server is not in the closest site.
        /// </summary>
        DsNotClosest = 0x218C,

        /// <summary>
        /// ERROR_DS_CANT_DERIVE_SPN_WITHOUT_SERVER_REF
        /// The DS cannot derive a service principal name (SPN) with which to mutually authenticate the target server because the corresponding server object in the local DS database has no serverReference attribute.
        /// </summary>
        DsCantDeriveSpnWithoutServerRef = 0x218D,

        /// <summary>
        /// ERROR_DS_SINGLE_USER_MODE_FAILED
        /// The Directory Service failed to enter single user mode.
        /// </summary>
        DsSingleUserModeFailed = 0x218E,

        /// <summary>
        /// ERROR_DS_NTDSCRIPT_SYNTAX_ERROR
        /// The Directory Service cannot parse the script because of a syntax error.
        /// </summary>
        DsNtdscriptSyntaxError = 0x218F,

        /// <summary>
        /// ERROR_DS_NTDSCRIPT_PROCESS_ERROR
        /// The Directory Service cannot process the script because of an error.
        /// </summary>
        DsNtdscriptProcessError = 0x2190,

        /// <summary>
        /// ERROR_DS_DIFFERENT_REPL_EPOCHS
        /// The directory service cannot perform the requested operation because the servers involved are of different replication epochs (which is usually related to a domain rename that is in progress).
        /// </summary>
        DsDifferentReplEpochs = 0x2191,

        /// <summary>
        /// ERROR_DS_DRS_EXTENSIONS_CHANGED
        /// The directory service binding must be renegotiated due to a change in the server extensions information.
        /// </summary>
        DsDrsExtensionsChanged = 0x2192,

        /// <summary>
        /// ERROR_DS_REPLICA_SET_CHANGE_NOT_ALLOWED_ON_DISABLED_CR
        /// Operation not allowed on a disabled cross ref.
        /// </summary>
        DsReplicaSetChangeNotAllowedOnDisabledCr = 0x2193,

        /// <summary>
        /// ERROR_DS_NO_MSDS_INTID
        /// Schema update failed: No values for msDS-IntId are available.
        /// </summary>
        DsNoMsdsIntid = 0x2194,

        /// <summary>
        /// ERROR_DS_DUP_MSDS_INTID
        /// Schema update failed: Duplicate msDS-INtId. Retry the operation.
        /// </summary>
        DsDupMsdsIntid = 0x2195,

        /// <summary>
        /// ERROR_DS_EXISTS_IN_RDNATTID
        /// Schema deletion failed: attribute is used in rDNAttID.
        /// </summary>
        DsExistsInRdnattid = 0x2196,

        /// <summary>
        /// ERROR_DS_AUTHORIZATION_FAILED
        /// The directory service failed to authorize the request.
        /// </summary>
        DsAuthorizationFailed = 0x2197,

        /// <summary>
        /// ERROR_DS_INVALID_SCRIPT
        /// The Directory Service cannot process the script because it is invalid.
        /// </summary>
        DsInvalidScript = 0x2198,

        /// <summary>
        /// ERROR_DS_REMOTE_CROSSREF_OP_FAILED
        /// The remote create cross reference operation failed on the Domain Naming Master FSMO. The operation's error is in the extended data.
        /// </summary>
        DsRemoteCrossrefOpFailed = 0x2199,

        /// <summary>
        /// ERROR_DS_CROSS_REF_BUSY
        /// A cross reference is in use locally with the same name.
        /// </summary>
        DsCrossRefBusy = 0x219A,

        /// <summary>
        /// ERROR_DS_CANT_DERIVE_SPN_FOR_DELETED_DOMAIN
        /// The DS cannot derive a service principal name (SPN) with which to mutually authenticate the target server because the server's domain has been deleted from the forest.
        /// </summary>
        DsCantDeriveSpnForDeletedDomain = 0x219B,

        /// <summary>
        /// ERROR_DS_CANT_DEMOTE_WITH_WRITEABLE_NC
        /// Writeable NCs prevent this DC from demoting.
        /// </summary>
        DsCantDemoteWithWriteableNc = 0x219C,

        /// <summary>
        /// ERROR_DS_DUPLICATE_ID_FOUND
        /// The requested object has a non-unique identifier and cannot be retrieved.
        /// </summary>
        DsDuplicateIdFound = 0x219D,

        /// <summary>
        /// ERROR_DS_INSUFFICIENT_ATTR_TO_CREATE_OBJECT
        /// Insufficient attributes were given to create an object. This object may not exist because it may have been deleted and already garbage collected.
        /// </summary>
        DsInsufficientAttrToCreateObject = 0x219E,

        /// <summary>
        /// ERROR_DS_GROUP_CONVERSION_ERROR
        /// The group cannot be converted due to attribute restrictions on the requested group type.
        /// </summary>
        DsGroupConversionError = 0x219F,

        /// <summary>
        /// ERROR_DS_CANT_MOVE_APP_BASIC_GROUP
        /// Cross-domain move of non-empty basic application groups is not allowed.
        /// </summary>
        DsCantMoveAppBasicGroup = 0x21A0,

        /// <summary>
        /// ERROR_DS_CANT_MOVE_APP_QUERY_GROUP
        /// Cross-domain move of non-empty query based application groups is not allowed.
        /// </summary>
        DsCantMoveAppQueryGroup = 0x21A1,

        /// <summary>
        /// ERROR_DS_ROLE_NOT_VERIFIED
        /// The FSMO role ownership could not be verified because its directory partition has not replicated successfully with at least one replication partner.
        /// </summary>
        DsRoleNotVerified = 0x21A2,

        /// <summary>
        /// ERROR_DS_WKO_CONTAINER_CANNOT_BE_SPECIAL
        /// The target container for a redirection of a well known object container cannot already be a special container.
        /// </summary>
        DsWkoContainerCannotBeSpecial = 0x21A3,

        /// <summary>
        /// ERROR_DS_DOMAIN_RENAME_IN_PROGRESS
        /// The Directory Service cannot perform the requested operation because a domain rename operation is in progress.
        /// </summary>
        DsDomainRenameInProgress = 0x21A4,

        /// <summary>
        /// ERROR_DS_EXISTING_AD_CHILD_NC
        /// The directory service detected a child partition below the requested partition name. The partition hierarchy must be created in a top down method.
        /// </summary>
        DsExistingAdChildNc = 0x21A5,

        /// <summary>
        /// ERROR_DS_REPL_LIFETIME_EXCEEDED
        /// The directory service cannot replicate with this server because the time since the last replication with this server has exceeded the tombstone lifetime.
        /// </summary>
        DsReplLifetimeExceeded = 0x21A6,

        /// <summary>
        /// ERROR_DS_DISALLOWED_IN_SYSTEM_CONTAINER
        /// The requested operation is not allowed on an object under the system container.
        /// </summary>
        DsDisallowedInSystemContainer = 0x21A7,

        /// <summary>
        /// ERROR_DS_LDAP_SEND_QUEUE_FULL
        /// The LDAP servers network send queue has filled up because the client is not processing the results of its requests fast enough. No more requests will be processed until the client catches up. If the client does not catch up then it will be disconnected.
        /// </summary>
        DsLdapSendQueueFull = 0x21A8,

        /// <summary>
        /// ERROR_DS_DRA_OUT_SCHEDULE_WINDOW
        /// The scheduled replication did not take place because the system was too busy to execute the request within the schedule window. The replication queue is overloaded. Consider reducing the number of partners or decreasing the scheduled replication frequency.
        /// </summary>
        DsDraOutScheduleWindow = 0x21A9,

        /// <summary>
        /// ERROR_DS_POLICY_NOT_KNOWN
        /// At this time, it cannot be determined if the branch replication policy is available on the hub domain controller. Please retry at a later time to account for replication latencies.
        /// </summary>
        DsPolicyNotKnown = 0x21AA,

        /// <summary>
        /// ERROR_NO_SITE_SETTINGS_OBJECT
        /// The site settings object for the specified site does not exist.
        /// </summary>
        NoSiteSettingsObject = 0x21AB,

        /// <summary>
        /// ERROR_NO_SECRETS
        /// The local account store does not contain secret material for the specified account.
        /// </summary>
        NoSecrets = 0x21AC,

        /// <summary>
        /// ERROR_NO_WRITABLE_DC_FOUND
        /// Could not find a writable domain controller in the domain.
        /// </summary>
        NoWritableDcFound = 0x21AD,

        /// <summary>
        /// ERROR_DS_NO_SERVER_OBJECT
        /// The server object for the domain controller does not exist.
        /// </summary>
        DsNoServerObject = 0x21AE,

        /// <summary>
        /// ERROR_DS_NO_NTDSA_OBJECT
        /// The NTDS Settings object for the domain controller does not exist.
        /// </summary>
        DsNoNtdsaObject = 0x21AF,

        /// <summary>
        /// ERROR_DS_NON_ASQ_SEARCH
        /// The requested search operation is not supported for ASQ searches.
        /// </summary>
        DsNonAsqSearch = 0x21B0,

        /// <summary>
        /// ERROR_DS_AUDIT_FAILURE
        /// A required audit event could not be generated for the operation.
        /// </summary>
        DsAuditFailure = 0x21B1,

        /// <summary>
        /// ERROR_DS_INVALID_SEARCH_FLAG_SUBTREE
        /// The search flags for the attribute are invalid. The subtree index bit is valid only on single valued attributes.
        /// </summary>
        DsInvalidSearchFlagSubtree = 0x21B2,

        /// <summary>
        /// ERROR_DS_INVALID_SEARCH_FLAG_TUPLE
        /// The search flags for the attribute are invalid. The tuple index bit is valid only on attributes of Unicode strings.
        /// </summary>
        DsInvalidSearchFlagTuple = 0x21B3,

        /// <summary>
        /// ERROR_DS_HIERARCHY_TABLE_TOO_DEEP
        /// The address books are nested too deeply. Failed to build the hierarchy table.
        /// </summary>
        DsHierarchyTableTooDeep = 0x21B4,

        /// <summary>
        /// ERROR_DS_DRA_CORRUPT_UTD_VECTOR
        /// The specified up-to-date-ness vector is corrupt.
        /// </summary>
        DsDraCorruptUtdVector = 0x21B5,

        /// <summary>
        /// ERROR_DS_DRA_SECRETS_DENIED
        /// The request to replicate secrets is denied.
        /// </summary>
        DsDraSecretsDenied = 0x21B6,

        /// <summary>
        /// ERROR_DS_RESERVED_MAPI_ID
        /// Schema update failed: The MAPI identifier is reserved.
        /// </summary>
        DsReservedMapiId = 0x21B7,

        /// <summary>
        /// ERROR_DS_MAPI_ID_NOT_AVAILABLE
        /// Schema update failed: There are no MAPI identifiers available.
        /// </summary>
        DsMapiIdNotAvailable = 0x21B8,

        /// <summary>
        /// ERROR_DS_DRA_MISSING_KRBTGT_SECRET
        /// The replication operation failed because the required attributes of the local krbtgt object are missing.
        /// </summary>
        DsDraMissingKrbtgtSecret = 0x21B9,

        /// <summary>
        /// ERROR_DS_DOMAIN_NAME_EXISTS_IN_FOREST
        /// The domain name of the trusted domain already exists in the forest.
        /// </summary>
        DsDomainNameExistsInForest = 0x21BA,

        /// <summary>
        /// ERROR_DS_FLAT_NAME_EXISTS_IN_FOREST
        /// The flat name of the trusted domain already exists in the forest.
        /// </summary>
        DsFlatNameExistsInForest = 0x21BB,

        /// <summary>
        /// ERROR_INVALID_USER_PRINCIPAL_NAME
        /// The User Principal Name (UPN) is invalid.
        /// </summary>
        InvalidUserPrincipalName = 0x21BC,

        /// <summary>
        /// ERROR_DS_OID_MAPPED_GROUP_CANT_HAVE_MEMBERS
        /// OID mapped groups cannot have members.
        /// </summary>
        DsOidMappedGroupCantHaveMembers = 0x21BD,

        /// <summary>
        /// ERROR_DS_OID_NOT_FOUND
        /// The specified OID cannot be found.
        /// </summary>
        DsOidNotFound = 0x21BE,

        /// <summary>
        /// ERROR_DS_DRA_RECYCLED_TARGET
        /// The replication operation failed because the target object referred by a link value is recycled.
        /// </summary>
        DsDraRecycledTarget = 0x21BF,

        /// <summary>
        /// ERROR_DS_DISALLOWED_NC_REDIRECT
        /// The redirect operation failed because the target object is in a NC different from the domain NC of the current domain controller.
        /// </summary>
        DsDisallowedNcRedirect = 0x21C0,

        /// <summary>
        /// ERROR_DS_HIGH_ADLDS_FFL
        /// The functional level of the AD LDS configuration set cannot be lowered to the requested value.
        /// </summary>
        DsHighAdldsFfl = 0x21C1,

        /// <summary>
        /// ERROR_DS_HIGH_DSA_VERSION
        /// The functional level of the domain (or forest) cannot be lowered to the requested value.
        /// </summary>
        DsHighDsaVersion = 0x21C2,

        /// <summary>
        /// ERROR_DS_LOW_ADLDS_FFL
        /// The functional level of the AD LDS configuration set cannot be raised to the requested value, because there exist one or more ADLDS instances that are at a lower incompatible functional level.
        /// </summary>
        DsLowAdldsFfl = 0x21C3,

        /// <summary>
        /// ERROR_DOMAIN_SID_SAME_AS_LOCAL_WORKSTATION
        /// The domain join cannot be completed because the SID of the domain you attempted to join was identical to the SID of this machine. This is a symptom of an improperly cloned operating system install. You should run sysprep on this machine in order to generate a new machine SID. Please see https://go.microsoft.com/fwlink/p/?linkid=168895 for more information.
        /// </summary>
        DomainSidSameAsLocalWorkstation = 0x21C4,

        /// <summary>
        /// ERROR_DS_UNDELETE_SAM_VALIDATION_FAILED
        /// The undelete operation failed because the Sam Account Name or Additional Sam Account Name of the object being undeleted conflicts with an existing live object.
        /// </summary>
        DsUndeleteSamValidationFailed = 0x21C5,

        /// <summary>
        /// ERROR_INCORRECT_ACCOUNT_TYPE
        /// The system is not authoritative for the specified account and therefore cannot complete the operation. Please retry the operation using the provider associated with this account. If this is an online provider please use the provider's online site.
        /// </summary>
        IncorrectAccountType = 0x21C6,

        /// <summary>
        /// DNS_ERROR_RCODE_FORMAT_ERROR
        /// DNS server unable to interpret format.
        /// </summary>
        DnsErrorRcodeFormatError = 0x2329,

        /// <summary>
        /// DNS_ERROR_RCODE_SERVER_FAILURE
        /// DNS server failure.
        /// </summary>
        DnsErrorRcodeServerFailure = 0x232A,

        /// <summary>
        /// DNS_ERROR_RCODE_NAME_ERROR
        /// DNS name does not exist.
        /// </summary>
        DnsErrorRcodeNameError = 0x232B,

        /// <summary>
        /// DNS_ERROR_RCODE_NOT_IMPLEMENTED
        /// DNS request not supported by name server.
        /// </summary>
        DnsErrorRcodeNotImplemented = 0x232C,

        /// <summary>
        /// DNS_ERROR_RCODE_REFUSED
        /// DNS operation refused.
        /// </summary>
        DnsErrorRcodeRefused = 0x232D,

        /// <summary>
        /// DNS_ERROR_RCODE_YXDOMAIN
        /// DNS name that ought not exist, does exist.
        /// </summary>
        DnsErrorRcodeYxdomain = 0x232E,

        /// <summary>
        /// DNS_ERROR_RCODE_YXRRSET
        /// DNS RR set that ought not exist, does exist.
        /// </summary>
        DnsErrorRcodeYxrrset = 0x232F,

        /// <summary>
        /// DNS_ERROR_RCODE_NXRRSET
        /// DNS RR set that ought to exist, does not exist.
        /// </summary>
        DnsErrorRcodeNxrrset = 0x2330,

        /// <summary>
        /// DNS_ERROR_RCODE_NOTAUTH
        /// DNS server not authoritative for zone.
        /// </summary>
        DnsErrorRcodeNotauth = 0x2331,

        /// <summary>
        /// DNS_ERROR_RCODE_NOTZONE
        /// DNS name in update or prereq is not in zone.
        /// </summary>
        DnsErrorRcodeNotzone = 0x2332,

        /// <summary>
        /// DNS_ERROR_RCODE_BADSIG
        /// DNS signature failed to verify.
        /// </summary>
        DnsErrorRcodeBadsig = 0x2338,

        /// <summary>
        /// DNS_ERROR_RCODE_BADKEY
        /// DNS bad key.
        /// </summary>
        DnsErrorRcodeBadkey = 0x2339,

        /// <summary>
        /// DNS_ERROR_RCODE_BADTIME
        /// DNS signature validity expired.
        /// </summary>
        DnsErrorRcodeBadtime = 0x233A,

        /// <summary>
        /// DNS_ERROR_KEYMASTER_REQUIRED
        /// Only the DNS server acting as the key master for the zone may perform this operation.
        /// </summary>
        DnsErrorKeymasterRequired = 0x238D,

        /// <summary>
        /// DNS_ERROR_NOT_ALLOWED_ON_SIGNED_ZONE
        /// This operation is not allowed on a zone that is signed or has signing keys.
        /// </summary>
        DnsErrorNotAllowedOnSignedZone = 0x238E,

        /// <summary>
        /// DNS_ERROR_NSEC3_INCOMPATIBLE_WITH_RSA_SHA1
        /// NSEC3 is not compatible with the RSA-SHA-1 algorithm. Choose a different algorithm or use NSEC.
        /// This value was also named DNS_ERROR_INVALID_NSEC3_PARAMETERS
        /// </summary>
        DnsErrorNsec3IncompatibleWithRsaSha1 = 0x238F,

        /// <summary>
        /// DNS_ERROR_NOT_ENOUGH_SIGNING_KEY_DESCRIPTORS
        /// The zone does not have enough signing keys. There must be at least one key signing key (KSK) and at least one zone signing key (ZSK).
        /// </summary>
        DnsErrorNotEnoughSigningKeyDescriptors = 0x2390,

        /// <summary>
        /// DNS_ERROR_UNSUPPORTED_ALGORITHM
        /// The specified algorithm is not supported.
        /// </summary>
        DnsErrorUnsupportedAlgorithm = 0x2391,

        /// <summary>
        /// DNS_ERROR_INVALID_KEY_SIZE
        /// The specified key size is not supported.
        /// </summary>
        DnsErrorInvalidKeySize = 0x2392,

        /// <summary>
        /// DNS_ERROR_SIGNING_KEY_NOT_ACCESSIBLE
        /// One or more of the signing keys for a zone are not accessible to the DNS server. Zone signing will not be operational until this error is resolved.
        /// </summary>
        DnsErrorSigningKeyNotAccessible = 0x2393,

        /// <summary>
        /// DNS_ERROR_KSP_DOES_NOT_SUPPORT_PROTECTION
        /// The specified key storage provider does not support DPAPI++ data protection. Zone signing will not be operational until this error is resolved.
        /// </summary>
        DnsErrorKspDoesNotSupportProtection = 0x2394,

        /// <summary>
        /// DNS_ERROR_UNEXPECTED_DATA_PROTECTION_ERROR
        /// An unexpected DPAPI++ error was encountered. Zone signing will not be operational until this error is resolved.
        /// </summary>
        DnsErrorUnexpectedDataProtectionError = 0x2395,

        /// <summary>
        /// DNS_ERROR_UNEXPECTED_CNG_ERROR
        /// An unexpected crypto error was encountered. Zone signing may not be operational until this error is resolved.
        /// </summary>
        DnsErrorUnexpectedCngError = 0x2396,

        /// <summary>
        /// DNS_ERROR_UNKNOWN_SIGNING_PARAMETER_VERSION
        /// The DNS server encountered a signing key with an unknown version. Zone signing will not be operational until this error is resolved.
        /// </summary>
        DnsErrorUnknownSigningParameterVersion = 0x2397,

        /// <summary>
        /// DNS_ERROR_KSP_NOT_ACCESSIBLE
        /// The specified key service provider cannot be opened by the DNS server.
        /// </summary>
        DnsErrorKspNotAccessible = 0x2398,

        /// <summary>
        /// DNS_ERROR_TOO_MANY_SKDS
        /// The DNS server cannot accept any more signing keys with the specified algorithm and KSK flag value for this zone.
        /// </summary>
        DnsErrorTooManySkds = 0x2399,

        /// <summary>
        /// DNS_ERROR_INVALID_ROLLOVER_PERIOD
        /// The specified rollover period is invalid.
        /// </summary>
        DnsErrorInvalidRolloverPeriod = 0x239A,

        /// <summary>
        /// DNS_ERROR_INVALID_INITIAL_ROLLOVER_OFFSET
        /// The specified initial rollover offset is invalid.
        /// </summary>
        DnsErrorInvalidInitialRolloverOffset = 0x239B,

        /// <summary>
        /// DNS_ERROR_ROLLOVER_IN_PROGRESS
        /// The specified signing key is already in process of rolling over keys.
        /// </summary>
        DnsErrorRolloverInProgress = 0x239C,

        /// <summary>
        /// DNS_ERROR_STANDBY_KEY_NOT_PRESENT
        /// The specified signing key does not have a standby key to revoke.
        /// </summary>
        DnsErrorStandbyKeyNotPresent = 0x239D,

        /// <summary>
        /// DNS_ERROR_NOT_ALLOWED_ON_ZSK
        /// This operation is not allowed on a zone signing key (ZSK).
        /// </summary>
        DnsErrorNotAllowedOnZsk = 0x239E,

        /// <summary>
        /// DNS_ERROR_NOT_ALLOWED_ON_ACTIVE_SKD
        /// This operation is not allowed on an active signing key.
        /// </summary>
        DnsErrorNotAllowedOnActiveSkd = 0x239F,

        /// <summary>
        /// DNS_ERROR_ROLLOVER_ALREADY_QUEUED
        /// The specified signing key is already queued for rollover.
        /// </summary>
        DnsErrorRolloverAlreadyQueued = 0x23A0,

        /// <summary>
        /// DNS_ERROR_NOT_ALLOWED_ON_UNSIGNED_ZONE
        /// This operation is not allowed on an unsigned zone.
        /// </summary>
        DnsErrorNotAllowedOnUnsignedZone = 0x23A1,

        /// <summary>
        /// DNS_ERROR_BAD_KEYMASTER
        /// This operation could not be completed because the DNS server listed as the current key master for this zone is down or misconfigured. Resolve the problem on the current key master for this zone or use another DNS server to seize the key master role.
        /// </summary>
        DnsErrorBadKeymaster = 0x23A2,

        /// <summary>
        /// DNS_ERROR_INVALID_SIGNATURE_VALIDITY_PERIOD
        /// The specified signature validity period is invalid.
        /// </summary>
        DnsErrorInvalidSignatureValidityPeriod = 0x23A3,

        /// <summary>
        /// DNS_ERROR_INVALID_NSEC3_ITERATION_COUNT
        /// The specified NSEC3 iteration count is higher than allowed by the minimum key length used in the zone.
        /// </summary>
        DnsErrorInvalidNsec3IterationCount = 0x23A4,

        /// <summary>
        /// DNS_ERROR_DNSSEC_IS_DISABLED
        /// This operation could not be completed because the DNS server has been configured with DNSSEC features disabled. Enable DNSSEC on the DNS server.
        /// </summary>
        DnsErrorDnssecIsDisabled = 0x23A5,

        /// <summary>
        /// DNS_ERROR_INVALID_XML
        /// This operation could not be completed because the XML stream received is empty or syntactically invalid.
        /// </summary>
        DnsErrorInvalidXml = 0x23A6,

        /// <summary>
        /// DNS_ERROR_NO_VALID_TRUST_ANCHORS
        /// This operation completed, but no trust anchors were added because all of the trust anchors received were either invalid, unsupported, expired, or would not become valid in less than 30 days.
        /// </summary>
        DnsErrorNoValidTrustAnchors = 0x23A7,

        /// <summary>
        /// DNS_ERROR_ROLLOVER_NOT_POKEABLE
        /// The specified signing key is not waiting for parental DS update.
        /// </summary>
        DnsErrorRolloverNotPokeable = 0x23A8,

        /// <summary>
        /// DNS_ERROR_NSEC3_NAME_COLLISION
        /// Hash collision detected during NSEC3 signing. Specify a different user-provided salt, or use a randomly generated salt, and attempt to sign the zone again.
        /// </summary>
        DnsErrorNsec3NameCollision = 0x23A9,

        /// <summary>
        /// DNS_ERROR_NSEC_INCOMPATIBLE_WITH_NSEC3_RSA_SHA1
        /// NSEC is not compatible with the NSEC3-RSA-SHA-1 algorithm. Choose a different algorithm or use NSEC3.
        /// </summary>
        DnsErrorNsecIncompatibleWithNsec3RsaSha1 = 0x23AA,

        /// <summary>
        /// DNS_INFO_NO_RECORDS
        /// No records found for given DNS query.
        /// </summary>
        DnsInfoNoRecords = 0x251D,

        /// <summary>
        /// DNS_ERROR_BAD_PACKET
        /// Bad DNS packet.
        /// </summary>
        DnsErrorBadPacket = 0x251E,

        /// <summary>
        /// DNS_ERROR_NO_PACKET
        /// No DNS packet.
        /// </summary>
        DnsErrorNoPacket = 0x251F,

        /// <summary>
        /// DNS_ERROR_RCODE
        /// DNS error, check rcode.
        /// </summary>
        DnsErrorRcode = 0x2520,

        /// <summary>
        /// DNS_ERROR_UNSECURE_PACKET
        /// Unsecured DNS packet.
        /// </summary>
        DnsErrorUnsecurePacket = 0x2521,

        /// <summary>
        /// DNS_REQUEST_PENDING
        /// DNS query request is pending.
        /// </summary>
        DnsRequestPending = 0x2522,

        /// <summary>
        /// DNS_ERROR_INVALID_TYPE
        /// Invalid DNS type.
        /// </summary>
        DnsErrorInvalidType = 0x254F,

        /// <summary>
        /// DNS_ERROR_INVALID_IP_ADDRESS
        /// Invalid IP address.
        /// </summary>
        DnsErrorInvalidIpAddress = 0x2550,

        /// <summary>
        /// DNS_ERROR_INVALID_PROPERTY
        /// Invalid property.
        /// </summary>
        DnsErrorInvalidProperty = 0x2551,

        /// <summary>
        /// DNS_ERROR_TRY_AGAIN_LATER
        /// Try DNS operation again later.
        /// </summary>
        DnsErrorTryAgainLater = 0x2552,

        /// <summary>
        /// DNS_ERROR_NOT_UNIQUE
        /// Record for given name and type is not unique.
        /// </summary>
        DnsErrorNotUnique = 0x2553,

        /// <summary>
        /// DNS_ERROR_NON_RFC_NAME
        /// DNS name does not comply with RFC specifications.
        /// </summary>
        DnsErrorNonRfcName = 0x2554,

        /// <summary>
        /// DNS_STATUS_FQDN
        /// DNS name is a fully-qualified DNS name.
        /// </summary>
        DnsStatusFqdn = 0x2555,

        /// <summary>
        /// DNS_STATUS_DOTTED_NAME
        /// DNS name is dotted (multi-label).
        /// </summary>
        DnsStatusDottedName = 0x2556,

        /// <summary>
        /// DNS_STATUS_SINGLE_PART_NAME
        /// DNS name is a single-part name.
        /// </summary>
        DnsStatusSinglePartName = 0x2557,

        /// <summary>
        /// DNS_ERROR_INVALID_NAME_CHAR
        /// DNS name contains an invalid character.
        /// </summary>
        DnsErrorInvalidNameChar = 0x2558,

        /// <summary>
        /// DNS_ERROR_NUMERIC_NAME
        /// DNS name is entirely numeric.
        /// </summary>
        DnsErrorNumericName = 0x2559,

        /// <summary>
        /// DNS_ERROR_NOT_ALLOWED_ON_ROOT_SERVER
        /// The operation requested is not permitted on a DNS root server.
        /// </summary>
        DnsErrorNotAllowedOnRootServer = 0x255A,

        /// <summary>
        /// DNS_ERROR_NOT_ALLOWED_UNDER_DELEGATION
        /// The record could not be created because this part of the DNS namespace has been delegated to another server.
        /// </summary>
        DnsErrorNotAllowedUnderDelegation = 0x255B,

        /// <summary>
        /// DNS_ERROR_CANNOT_FIND_ROOT_HINTS
        /// The DNS server could not find a set of root hints.
        /// </summary>
        DnsErrorCannotFindRootHints = 0x255C,

        /// <summary>
        /// DNS_ERROR_INCONSISTENT_ROOT_HINTS
        /// The DNS server found root hints but they were not consistent across all adapters.
        /// </summary>
        DnsErrorInconsistentRootHints = 0x255D,

        /// <summary>
        /// DNS_ERROR_DWORD_VALUE_TOO_SMALL
        /// The specified value is too small for this parameter.
        /// </summary>
        DnsErrorDwordValueTooSmall = 0x255E,

        /// <summary>
        /// DNS_ERROR_DWORD_VALUE_TOO_LARGE
        /// The specified value is too large for this parameter.
        /// </summary>
        DnsErrorDwordValueTooLarge = 0x255F,

        /// <summary>
        /// DNS_ERROR_BACKGROUND_LOADING
        /// This operation is not allowed while the DNS server is loading zones in the background. Please try again later.
        /// </summary>
        DnsErrorBackgroundLoading = 0x2560,

        /// <summary>
        /// DNS_ERROR_NOT_ALLOWED_ON_RODC
        /// The operation requested is not permitted on against a DNS server running on a read-only DC.
        /// </summary>
        DnsErrorNotAllowedOnRodc = 0x2561,

        /// <summary>
        /// DNS_ERROR_NOT_ALLOWED_UNDER_DNAME
        /// No data is allowed to exist underneath a DNAME record.
        /// </summary>
        DnsErrorNotAllowedUnderDname = 0x2562,

        /// <summary>
        /// DNS_ERROR_DELEGATION_REQUIRED
        /// This operation requires credentials delegation.
        /// </summary>
        DnsErrorDelegationRequired = 0x2563,

        /// <summary>
        /// DNS_ERROR_INVALID_POLICY_TABLE
        /// Name resolution policy table has been corrupted. DNS resolution will fail until it is fixed. Contact your network administrator.
        /// </summary>
        DnsErrorInvalidPolicyTable = 0x2564,

        /// <summary>
        /// DNS_ERROR_ZONE_DOES_NOT_EXIST
        /// DNS zone does not exist.
        /// </summary>
        DnsErrorZoneDoesNotExist = 0x2581,

        /// <summary>
        /// DNS_ERROR_NO_ZONE_INFO
        /// DNS zone information not available.
        /// </summary>
        DnsErrorNoZoneInfo = 0x2582,

        /// <summary>
        /// DNS_ERROR_INVALID_ZONE_OPERATION
        /// Invalid operation for DNS zone.
        /// </summary>
        DnsErrorInvalidZoneOperation = 0x2583,

        /// <summary>
        /// DNS_ERROR_ZONE_CONFIGURATION_ERROR
        /// Invalid DNS zone configuration.
        /// </summary>
        DnsErrorZoneConfigurationError = 0x2584,

        /// <summary>
        /// DNS_ERROR_ZONE_HAS_NO_SOA_RECORD
        /// DNS zone has no start of authority (SOA) record.
        /// </summary>
        DnsErrorZoneHasNoSoaRecord = 0x2585,

        /// <summary>
        /// DNS_ERROR_ZONE_HAS_NO_NS_RECORDS
        /// DNS zone has no Name Server (NS) record.
        /// </summary>
        DnsErrorZoneHasNoNsRecords = 0x2586,

        /// <summary>
        /// DNS_ERROR_ZONE_LOCKED
        /// DNS zone is locked.
        /// </summary>
        DnsErrorZoneLocked = 0x2587,

        /// <summary>
        /// DNS_ERROR_ZONE_CREATION_FAILED
        /// DNS zone creation failed.
        /// </summary>
        DnsErrorZoneCreationFailed = 0x2588,

        /// <summary>
        /// DNS_ERROR_ZONE_ALREADY_EXISTS
        /// DNS zone already exists.
        /// </summary>
        DnsErrorZoneAlreadyExists = 0x2589,

        /// <summary>
        /// DNS_ERROR_AUTOZONE_ALREADY_EXISTS
        /// DNS automatic zone already exists.
        /// </summary>
        DnsErrorAutozoneAlreadyExists = 0x258A,

        /// <summary>
        /// DNS_ERROR_INVALID_ZONE_TYPE
        /// Invalid DNS zone type.
        /// </summary>
        DnsErrorInvalidZoneType = 0x258B,

        /// <summary>
        /// DNS_ERROR_SECONDARY_REQUIRES_MASTER_IP
        /// Secondary DNS zone requires master IP address.
        /// </summary>
        DnsErrorSecondaryRequiresMasterIp = 0x258C,

        /// <summary>
        /// DNS_ERROR_ZONE_NOT_SECONDARY
        /// DNS zone not secondary.
        /// </summary>
        DnsErrorZoneNotSecondary = 0x258D,

        /// <summary>
        /// DNS_ERROR_NEED_SECONDARY_ADDRESSES
        /// Need secondary IP address.
        /// </summary>
        DnsErrorNeedSecondaryAddresses = 0x258E,

        /// <summary>
        /// DNS_ERROR_WINS_INIT_FAILED
        /// WINS initialization failed.
        /// </summary>
        DnsErrorWinsInitFailed = 0x258F,

        /// <summary>
        /// DNS_ERROR_NEED_WINS_SERVERS
        /// Need WINS servers.
        /// </summary>
        DnsErrorNeedWinsServers = 0x2590,

        /// <summary>
        /// DNS_ERROR_NBSTAT_INIT_FAILED
        /// NBTSTAT initialization call failed.
        /// </summary>
        DnsErrorNbstatInitFailed = 0x2591,

        /// <summary>
        /// DNS_ERROR_SOA_DELETE_INVALID
        /// Invalid delete of start of authority (SOA).
        /// </summary>
        DnsErrorSoaDeleteInvalid = 0x2592,

        /// <summary>
        /// DNS_ERROR_FORWARDER_ALREADY_EXISTS
        /// A conditional forwarding zone already exists for that name.
        /// </summary>
        DnsErrorForwarderAlreadyExists = 0x2593,

        /// <summary>
        /// DNS_ERROR_ZONE_REQUIRES_MASTER_IP
        /// This zone must be configured with one or more master DNS server IP addresses.
        /// </summary>
        DnsErrorZoneRequiresMasterIp = 0x2594,

        /// <summary>
        /// DNS_ERROR_ZONE_IS_SHUTDOWN
        /// The operation cannot be performed because this zone is shut down.
        /// </summary>
        DnsErrorZoneIsShutdown = 0x2595,

        /// <summary>
        /// DNS_ERROR_ZONE_LOCKED_FOR_SIGNING
        /// This operation cannot be performed because the zone is currently being signed. Please try again later.
        /// </summary>
        DnsErrorZoneLockedForSigning = 0x2596,

        /// <summary>
        /// DNS_ERROR_PRIMARY_REQUIRES_DATAFILE
        /// Primary DNS zone requires datafile.
        /// </summary>
        DnsErrorPrimaryRequiresDatafile = 0x25B3,

        /// <summary>
        /// DNS_ERROR_INVALID_DATAFILE_NAME
        /// Invalid datafile name for DNS zone.
        /// </summary>
        DnsErrorInvalidDatafileName = 0x25B4,

        /// <summary>
        /// DNS_ERROR_DATAFILE_OPEN_FAILURE
        /// Failed to open datafile for DNS zone.
        /// </summary>
        DnsErrorDatafileOpenFailure = 0x25B5,

        /// <summary>
        /// DNS_ERROR_FILE_WRITEBACK_FAILED
        /// Failed to write datafile for DNS zone.
        /// </summary>
        DnsErrorFileWritebackFailed = 0x25B6,

        /// <summary>
        /// DNS_ERROR_DATAFILE_PARSING
        /// Failure while reading datafile for DNS zone.
        /// </summary>
        DnsErrorDatafileParsing = 0x25B7,

        /// <summary>
        /// DNS_ERROR_RECORD_DOES_NOT_EXIST
        /// DNS record does not exist.
        /// </summary>
        DnsErrorRecordDoesNotExist = 0x25E5,

        /// <summary>
        /// DNS_ERROR_RECORD_FORMAT
        /// DNS record format error.
        /// </summary>
        DnsErrorRecordFormat = 0x25E6,

        /// <summary>
        /// DNS_ERROR_NODE_CREATION_FAILED
        /// Node creation failure in DNS.
        /// </summary>
        DnsErrorNodeCreationFailed = 0x25E7,

        /// <summary>
        /// DNS_ERROR_UNKNOWN_RECORD_TYPE
        /// Unknown DNS record type.
        /// </summary>
        DnsErrorUnknownRecordType = 0x25E8,

        /// <summary>
        /// DNS_ERROR_RECORD_TIMED_OUT
        /// DNS record timed out.
        /// </summary>
        DnsErrorRecordTimedOut = 0x25E9,

        /// <summary>
        /// DNS_ERROR_NAME_NOT_IN_ZONE
        /// Name not in DNS zone.
        /// </summary>
        DnsErrorNameNotInZone = 0x25EA,

        /// <summary>
        /// DNS_ERROR_CNAME_LOOP
        /// CNAME loop detected.
        /// </summary>
        DnsErrorCnameLoop = 0x25EB,

        /// <summary>
        /// DNS_ERROR_NODE_IS_CNAME
        /// Node is a CNAME DNS record.
        /// </summary>
        DnsErrorNodeIsCname = 0x25EC,

        /// <summary>
        /// DNS_ERROR_CNAME_COLLISION
        /// A CNAME record already exists for given name.
        /// </summary>
        DnsErrorCnameCollision = 0x25ED,

        /// <summary>
        /// DNS_ERROR_RECORD_ONLY_AT_ZONE_ROOT
        /// Record only at DNS zone root.
        /// </summary>
        DnsErrorRecordOnlyAtZoneRoot = 0x25EE,

        /// <summary>
        /// DNS_ERROR_RECORD_ALREADY_EXISTS
        /// DNS record already exists.
        /// </summary>
        DnsErrorRecordAlreadyExists = 0x25EF,

        /// <summary>
        /// DNS_ERROR_SECONDARY_DATA
        /// Secondary DNS zone data error.
        /// </summary>
        DnsErrorSecondaryData = 0x25F0,

        /// <summary>
        /// DNS_ERROR_NO_CREATE_CACHE_DATA
        /// Could not create DNS cache data.
        /// </summary>
        DnsErrorNoCreateCacheData = 0x25F1,

        /// <summary>
        /// DNS_ERROR_NAME_DOES_NOT_EXIST
        /// DNS name does not exist.
        /// </summary>
        DnsErrorNameDoesNotExist = 0x25F2,

        /// <summary>
        /// DNS_WARNING_PTR_CREATE_FAILED
        /// Could not create pointer (PTR) record.
        /// </summary>
        DnsWarningPtrCreateFailed = 0x25F3,

        /// <summary>
        /// DNS_WARNING_DOMAIN_UNDELETED
        /// DNS domain was undeleted.
        /// </summary>
        DnsWarningDomainUndeleted = 0x25F4,

        /// <summary>
        /// DNS_ERROR_DS_UNAVAILABLE
        /// The directory service is unavailable.
        /// </summary>
        DnsErrorDsUnavailable = 0x25F5,

        /// <summary>
        /// DNS_ERROR_DS_ZONE_ALREADY_EXISTS
        /// DNS zone already exists in the directory service.
        /// </summary>
        DnsErrorDsZoneAlreadyExists = 0x25F6,

        /// <summary>
        /// DNS_ERROR_NO_BOOTFILE_IF_DS_ZONE
        /// DNS server not creating or reading the boot file for the directory service integrated DNS zone.
        /// </summary>
        DnsErrorNoBootfileIfDsZone = 0x25F7,

        /// <summary>
        /// DNS_ERROR_NODE_IS_DNAME
        /// Node is a DNAME DNS record.
        /// </summary>
        DnsErrorNodeIsDname = 0x25F8,

        /// <summary>
        /// DNS_ERROR_DNAME_COLLISION
        /// A DNAME record already exists for given name.
        /// </summary>
        DnsErrorDnameCollision = 0x25F9,

        /// <summary>
        /// DNS_ERROR_ALIAS_LOOP
        /// An alias loop has been detected with either CNAME or DNAME records.
        /// </summary>
        DnsErrorAliasLoop = 0x25FA,

        /// <summary>
        /// DNS_INFO_AXFR_COMPLETE
        /// DNS AXFR (zone transfer) complete.
        /// </summary>
        DnsInfoAxfrComplete = 0x2617,

        /// <summary>
        /// DNS_ERROR_AXFR
        /// DNS zone transfer failed.
        /// </summary>
        DnsErrorAxfr = 0x2618,

        /// <summary>
        /// DNS_INFO_ADDED_LOCAL_WINS
        /// Added local WINS server.
        /// </summary>
        DnsInfoAddedLocalWins = 0x2619,

        /// <summary>
        /// DNS_STATUS_CONTINUE_NEEDED
        /// Secure update call needs to continue update request.
        /// </summary>
        DnsStatusContinueNeeded = 0x2649,

        /// <summary>
        /// DNS_ERROR_NO_TCPIP
        /// TCP/IP network protocol not installed.
        /// </summary>
        DnsErrorNoTcpip = 0x267B,

        /// <summary>
        /// DNS_ERROR_NO_DNS_SERVERS
        /// No DNS servers configured for local system.
        /// </summary>
        DnsErrorNoDnsServers = 0x267C,

        /// <summary>
        /// DNS_ERROR_DP_DOES_NOT_EXIST
        /// The specified directory partition does not exist.
        /// </summary>
        DnsErrorDpDoesNotExist = 0x26AD,

        /// <summary>
        /// DNS_ERROR_DP_ALREADY_EXISTS
        /// The specified directory partition already exists.
        /// </summary>
        DnsErrorDpAlreadyExists = 0x26AE,

        /// <summary>
        /// DNS_ERROR_DP_NOT_ENLISTED
        /// This DNS server is not enlisted in the specified directory partition.
        /// </summary>
        DnsErrorDpNotEnlisted = 0x26AF,

        /// <summary>
        /// DNS_ERROR_DP_ALREADY_ENLISTED
        /// This DNS server is already enlisted in the specified directory partition.
        /// </summary>
        DnsErrorDpAlreadyEnlisted = 0x26B0,

        /// <summary>
        /// DNS_ERROR_DP_NOT_AVAILABLE
        /// The directory partition is not available at this time. Please wait a few minutes and try again.
        /// </summary>
        DnsErrorDpNotAvailable = 0x26B1,

        /// <summary>
        /// DNS_ERROR_DP_FSMO_ERROR
        /// The operation failed because the domain naming master FSMO role could not be reached. The domain controller holding the domain naming master FSMO role is down or unable to service the request or is not running Windows Server 2003 or later.
        /// </summary>
        DnsErrorDpFsmoError = 0x26B2,

        /// <summary>
        /// WSAEINTR
        /// A blocking operation was interrupted by a call to WSACancelBlockingCall.
        /// </summary>
        Wsaeintr = 0x2714,

        /// <summary>
        /// WSAEBADF
        /// The file handle supplied is not valid.
        /// </summary>
        Wsaebadf = 0x2719,

        /// <summary>
        /// WSAEACCES
        /// An attempt was made to access a socket in a way forbidden by its access permissions.
        /// </summary>
        Wsaeacces = 0x271D,

        /// <summary>
        /// WSAEFAULT
        /// The system detected an invalid pointer address in attempting to use a pointer argument in a call.
        /// </summary>
        Wsaefault = 0x271E,

        /// <summary>
        /// WSAEINVAL
        /// An invalid argument was supplied.
        /// </summary>
        Wsaeinval = 0x2726,

        /// <summary>
        /// WSAEMFILE
        /// Too many open sockets.
        /// </summary>
        Wsaemfile = 0x2728,

        /// <summary>
        /// WSAEWOULDBLOCK
        /// A non-blocking socket operation could not be completed immediately.
        /// </summary>
        Wsaewouldblock = 0x2733,

        /// <summary>
        /// WSAEINPROGRESS
        /// A blocking operation is currently executing.
        /// </summary>
        Wsaeinprogress = 0x2734,

        /// <summary>
        /// WSAEALREADY
        /// An operation was attempted on a non-blocking socket that already had an operation in progress.
        /// </summary>
        Wsaealready = 0x2735,

        /// <summary>
        /// WSAENOTSOCK
        /// An operation was attempted on something that is not a socket.
        /// </summary>
        Wsaenotsock = 0x2736,

        /// <summary>
        /// WSAEDESTADDRREQ
        /// A required address was omitted from an operation on a socket.
        /// </summary>
        Wsaedestaddrreq = 0x2737,

        /// <summary>
        /// WSAEMSGSIZE
        /// A message sent on a datagram socket was larger than the internal message buffer or some other network limit, or the buffer used to receive a datagram into was smaller than the datagram itself.
        /// </summary>
        Wsaemsgsize = 0x2738,

        /// <summary>
        /// WSAEPROTOTYPE
        /// A protocol was specified in the socket function call that does not support the semantics of the socket type requested.
        /// </summary>
        Wsaeprototype = 0x2739,

        /// <summary>
        /// WSAENOPROTOOPT
        /// An unknown, invalid, or unsupported option or level was specified in a getsockopt or setsockopt call.
        /// </summary>
        Wsaenoprotoopt = 0x273A,

        /// <summary>
        /// WSAEPROTONOSUPPORT
        /// The requested protocol has not been configured into the system, or no implementation for it exists.
        /// </summary>
        Wsaeprotonosupport = 0x273B,

        /// <summary>
        /// WSAESOCKTNOSUPPORT
        /// The support for the specified socket type does not exist in this address family.
        /// </summary>
        Wsaesocktnosupport = 0x273C,

        /// <summary>
        /// WSAEOPNOTSUPP
        /// The attempted operation is not supported for the type of object referenced.
        /// </summary>
        Wsaeopnotsupp = 0x273D,

        /// <summary>
        /// WSAEPFNOSUPPORT
        /// The protocol family has not been configured into the system or no implementation for it exists.
        /// </summary>
        Wsaepfnosupport = 0x273E,

        /// <summary>
        /// WSAEAFNOSUPPORT
        /// An address incompatible with the requested protocol was used.
        /// </summary>
        Wsaeafnosupport = 0x273F,

        /// <summary>
        /// WSAEADDRINUSE
        /// Only one usage of each socket address (protocol/network address/port) is normally permitted.
        /// </summary>
        Wsaeaddrinuse = 0x2740,

        /// <summary>
        /// WSAEADDRNOTAVAIL
        /// The requested address is not valid in its context.
        /// </summary>
        Wsaeaddrnotavail = 0x2741,

        /// <summary>
        /// WSAENETDOWN
        /// A socket operation encountered a dead network.
        /// </summary>
        Wsaenetdown = 0x2742,

        /// <summary>
        /// WSAENETUNREACH
        /// A socket operation was attempted to an unreachable network.
        /// </summary>
        Wsaenetunreach = 0x2743,

        /// <summary>
        /// WSAENETRESET
        /// The connection has been broken due to keep-alive activity detecting a failure while the operation was in progress.
        /// </summary>
        Wsaenetreset = 0x2744,

        /// <summary>
        /// WSAECONNABORTED
        /// An established connection was aborted by the software in your host machine.
        /// </summary>
        Wsaeconnaborted = 0x2745,

        /// <summary>
        /// WSAECONNRESET
        /// An existing connection was forcibly closed by the remote host.
        /// </summary>
        Wsaeconnreset = 0x2746,

        /// <summary>
        /// WSAENOBUFS
        /// An operation on a socket could not be performed because the system lacked sufficient buffer space or because a queue was full.
        /// </summary>
        Wsaenobufs = 0x2747,

        /// <summary>
        /// WSAEISCONN
        /// A connect request was made on an already connected socket.
        /// </summary>
        Wsaeisconn = 0x2748,

        /// <summary>
        /// WSAENOTCONN
        /// A request to send or receive data was disallowed because the socket is not connected and (when sending on a datagram socket using a sendto call) no address was supplied.
        /// </summary>
        Wsaenotconn = 0x2749,

        /// <summary>
        /// WSAESHUTDOWN
        /// A request to send or receive data was disallowed because the socket had already been shut down in that direction with a previous shutdown call.
        /// </summary>
        Wsaeshutdown = 0x274A,

        /// <summary>
        /// WSAETOOMANYREFS
        /// Too many references to some kernel object.
        /// </summary>
        Wsaetoomanyrefs = 0x274B,

        /// <summary>
        /// WSAETIMEDOUT
        /// A connection attempt failed because the connected party did not properly respond after a period of time, or established connection failed because connected host has failed to respond.
        /// </summary>
        Wsaetimedout = 0x274C,

        /// <summary>
        /// WSAECONNREFUSED
        /// No connection could be made because the target machine actively refused it.
        /// </summary>
        Wsaeconnrefused = 0x274D,

        /// <summary>
        /// WSAELOOP
        /// Cannot translate name.
        /// </summary>
        Wsaeloop = 0x274E,

        /// <summary>
        /// WSAENAMETOOLONG
        /// Name component or name was too long.
        /// </summary>
        Wsaenametoolong = 0x274F,

        /// <summary>
        /// WSAEHOSTDOWN
        /// A socket operation failed because the destination host was down.
        /// </summary>
        Wsaehostdown = 0x2750,

        /// <summary>
        /// WSAEHOSTUNREACH
        /// A socket operation was attempted to an unreachable host.
        /// </summary>
        Wsaehostunreach = 0x2751,

        /// <summary>
        /// WSAENOTEMPTY
        /// Cannot remove a directory that is not empty.
        /// </summary>
        Wsaenotempty = 0x2752,

        /// <summary>
        /// WSAEPROCLIM
        /// A Windows Sockets implementation may have a limit on the number of applications that may use it simultaneously.
        /// </summary>
        Wsaeproclim = 0x2753,

        /// <summary>
        /// WSAEUSERS
        /// Ran out of quota.
        /// </summary>
        Wsaeusers = 0x2754,

        /// <summary>
        /// WSAEDQUOT
        /// Ran out of disk quota.
        /// </summary>
        Wsaedquot = 0x2755,

        /// <summary>
        /// WSAESTALE
        /// File handle reference is no longer available.
        /// </summary>
        Wsaestale = 0x2756,

        /// <summary>
        /// WSAEREMOTE
        /// Item is not available locally.
        /// </summary>
        Wsaeremote = 0x2757,

        /// <summary>
        /// WSASYSNOTREADY
        /// WSAStartup cannot function at this time because the underlying system it uses to provide network services is currently unavailable.
        /// </summary>
        Wsasysnotready = 0x276B,

        /// <summary>
        /// WSAVERNOTSUPPORTED
        /// The Windows Sockets version requested is not supported.
        /// </summary>
        Wsavernotsupported = 0x276C,

        /// <summary>
        /// WSANOTINITIALISED
        /// Either the application has not called WSAStartup, or WSAStartup failed.
        /// </summary>
        Wsanotinitialised = 0x276D,

        /// <summary>
        /// WSAEDISCON
        /// Returned by WSARecv or WSARecvFrom to indicate the remote party has initiated a graceful shutdown sequence.
        /// </summary>
        Wsaediscon = 0x2775,

        /// <summary>
        /// WSAENOMORE
        /// No more results can be returned by WSALookupServiceNext.
        /// </summary>
        Wsaenomore = 0x2776,

        /// <summary>
        /// WSAECANCELLED
        /// A call to WSALookupServiceEnd was made while this call was still processing. The call has been canceled.
        /// </summary>
        Wsaecancelled = 0x2777,

        /// <summary>
        /// WSAEINVALIDPROCTABLE
        /// The procedure call table is invalid.
        /// </summary>
        Wsaeinvalidproctable = 0x2778,

        /// <summary>
        /// WSAEINVALIDPROVIDER
        /// The requested service provider is invalid.
        /// </summary>
        Wsaeinvalidprovider = 0x2779,

        /// <summary>
        /// WSAEPROVIDERFAILEDINIT
        /// The requested service provider could not be loaded or initialized.
        /// </summary>
        Wsaeproviderfailedinit = 0x277A,

        /// <summary>
        /// WSASYSCALLFAILURE
        /// A system call has failed.
        /// </summary>
        Wsasyscallfailure = 0x277B,

        /// <summary>
        /// WSASERVICE_NOT_FOUND
        /// No such service is known. The service cannot be found in the specified name space.
        /// </summary>
        WsaserviceNotFound = 0x277C,

        /// <summary>
        /// WSATYPE_NOT_FOUND
        /// The specified class was not found.
        /// </summary>
        WsatypeNotFound = 0x277D,

        /// <summary>
        /// WSA_E_NO_MORE
        /// No more results can be returned by WSALookupServiceNext.
        /// </summary>
        WsaENoMore = 0x277E,

        /// <summary>
        /// WSA_E_CANCELLED
        /// A call to WSALookupServiceEnd was made while this call was still processing. The call has been canceled.
        /// </summary>
        WsaECancelled = 0x277F,

        /// <summary>
        /// WSAEREFUSED
        /// A database query failed because it was actively refused.
        /// </summary>
        Wsaerefused = 0x2780,

        /// <summary>
        /// WSAHOST_NOT_FOUND
        /// No such host is known.
        /// </summary>
        WsahostNotFound = 0x2AF9,

        /// <summary>
        /// WSATRY_AGAIN
        /// This is usually a temporary error during hostname resolution and means that the local server did not receive a response from an authoritative server.
        /// </summary>
        WsatryAgain = 0x2AFA,

        /// <summary>
        /// WSANO_RECOVERY
        /// A non-recoverable error occurred during a database lookup.
        /// </summary>
        WsanoRecovery = 0x2AFB,

        /// <summary>
        /// WSANO_DATA
        /// The requested name is valid, but no data of the requested type was found.
        /// </summary>
        WsanoData = 0x2AFC,

        /// <summary>
        /// WSA_QOS_RECEIVERS
        /// At least one reserve has arrived.
        /// </summary>
        WsaQosReceivers = 0x2AFD,

        /// <summary>
        /// WSA_QOS_SENDERS
        /// At least one path has arrived.
        /// </summary>
        WsaQosSenders = 0x2AFE,

        /// <summary>
        /// WSA_QOS_NO_SENDERS
        /// There are no senders.
        /// </summary>
        WsaQosNoSenders = 0x2AFF,

        /// <summary>
        /// WSA_QOS_NO_RECEIVERS
        /// There are no receivers.
        /// </summary>
        WsaQosNoReceivers = 0x2B00,

        /// <summary>
        /// WSA_QOS_REQUEST_CONFIRMED
        /// Reserve has been confirmed.
        /// </summary>
        WsaQosRequestConfirmed = 0x2B01,

        /// <summary>
        /// WSA_QOS_ADMISSION_FAILURE
        /// Error due to lack of resources.
        /// </summary>
        WsaQosAdmissionFailure = 0x2B02,

        /// <summary>
        /// WSA_QOS_POLICY_FAILURE
        /// Rejected for administrative reasons - bad credentials.
        /// </summary>
        WsaQosPolicyFailure = 0x2B03,

        /// <summary>
        /// WSA_QOS_BAD_STYLE
        /// Unknown or conflicting style.
        /// </summary>
        WsaQosBadStyle = 0x2B04,

        /// <summary>
        /// WSA_QOS_BAD_OBJECT
        /// Problem with some part of the filterspec or providerspecific buffer in general.
        /// </summary>
        WsaQosBadObject = 0x2B05,

        /// <summary>
        /// WSA_QOS_TRAFFIC_CTRL_ERROR
        /// Problem with some part of the flowspec.
        /// </summary>
        WsaQosTrafficCtrlError = 0x2B06,

        /// <summary>
        /// WSA_QOS_GENERIC_ERROR
        /// General QOS error.
        /// </summary>
        WsaQosGenericError = 0x2B07,

        /// <summary>
        /// WSA_QOS_ESERVICETYPE
        /// An invalid or unrecognized service type was found in the flowspec.
        /// </summary>
        WsaQosEservicetype = 0x2B08,

        /// <summary>
        /// WSA_QOS_EFLOWSPEC
        /// An invalid or inconsistent flowspec was found in the QOS structure.
        /// </summary>
        WsaQosEflowspec = 0x2B09,

        /// <summary>
        /// WSA_QOS_EPROVSPECBUF
        /// Invalid QOS provider-specific buffer.
        /// </summary>
        WsaQosEprovspecbuf = 0x2B0A,

        /// <summary>
        /// WSA_QOS_EFILTERSTYLE
        /// An invalid QOS filter style was used.
        /// </summary>
        WsaQosEfilterstyle = 0x2B0B,

        /// <summary>
        /// WSA_QOS_EFILTERTYPE
        /// An invalid QOS filter type was used.
        /// </summary>
        WsaQosEfiltertype = 0x2B0C,

        /// <summary>
        /// WSA_QOS_EFILTERCOUNT
        /// An incorrect number of QOS FILTERSPECs were specified in the FLOWDESCRIPTOR.
        /// </summary>
        WsaQosEfiltercount = 0x2B0D,

        /// <summary>
        /// WSA_QOS_EOBJLENGTH
        /// An object with an invalid ObjectLength field was specified in the QOS provider-specific buffer.
        /// </summary>
        WsaQosEobjlength = 0x2B0E,

        /// <summary>
        /// WSA_QOS_EFLOWCOUNT
        /// An incorrect number of flow descriptors was specified in the QOS structure.
        /// </summary>
        WsaQosEflowcount = 0x2B0F,

        /// <summary>
        /// WSA_QOS_EUNKOWNPSOBJ
        /// An unrecognized object was found in the QOS provider-specific buffer.
        /// </summary>
        WsaQosEunkownpsobj = 0x2B10,

        /// <summary>
        /// WSA_QOS_EPOLICYOBJ
        /// An invalid policy object was found in the QOS provider-specific buffer.
        /// </summary>
        WsaQosEpolicyobj = 0x2B11,

        /// <summary>
        /// WSA_QOS_EFLOWDESC
        /// An invalid QOS flow descriptor was found in the flow descriptor list.
        /// </summary>
        WsaQosEflowdesc = 0x2B12,

        /// <summary>
        /// WSA_QOS_EPSFLOWSPEC
        /// An invalid or inconsistent flowspec was found in the QOS provider specific buffer.
        /// </summary>
        WsaQosEpsflowspec = 0x2B13,

        /// <summary>
        /// WSA_QOS_EPSFILTERSPEC
        /// An invalid FILTERSPEC was found in the QOS provider-specific buffer.
        /// </summary>
        WsaQosEpsfilterspec = 0x2B14,

        /// <summary>
        /// WSA_QOS_ESDMODEOBJ
        /// An invalid shape discard mode object was found in the QOS provider specific buffer.
        /// </summary>
        WsaQosEsdmodeobj = 0x2B15,

        /// <summary>
        /// WSA_QOS_ESHAPERATEOBJ
        /// An invalid shaping rate object was found in the QOS provider-specific buffer.
        /// </summary>
        WsaQosEshaperateobj = 0x2B16,

        /// <summary>
        /// WSA_QOS_RESERVED_PETYPE
        /// A reserved policy element was found in the QOS provider-specific buffer.
        /// </summary>
        WsaQosReservedPetype = 0x2B17,

        /// <summary>
        /// WSA_SECURE_HOST_NOT_FOUND
        /// No such host is known securely.
        /// </summary>
        WsaSecureHostNotFound = 0x2B18,

        /// <summary>
        /// WSA_IPSEC_NAME_POLICY_ERROR
        /// Name based IPSEC policy could not be added.
        /// </summary>
        WsaIpsecNamePolicyError = 0x2B19,

        /// <summary>
        /// ERROR_IPSEC_QM_POLICY_EXISTS
        /// The specified quick mode policy already exists.
        /// </summary>
        IpsecQmPolicyExists = 0x32C8,

        /// <summary>
        /// ERROR_IPSEC_QM_POLICY_NOT_FOUND
        /// The specified quick mode policy was not found.
        /// </summary>
        IpsecQmPolicyNotFound = 0x32C9,

        /// <summary>
        /// ERROR_IPSEC_QM_POLICY_IN_USE
        /// The specified quick mode policy is being used.
        /// </summary>
        IpsecQmPolicyInUse = 0x32CA,

        /// <summary>
        /// ERROR_IPSEC_MM_POLICY_EXISTS
        /// The specified main mode policy already exists.
        /// </summary>
        IpsecMmPolicyExists = 0x32CB,

        /// <summary>
        /// ERROR_IPSEC_MM_POLICY_NOT_FOUND
        /// The specified main mode policy was not found.
        /// </summary>
        IpsecMmPolicyNotFound = 0x32CC,

        /// <summary>
        /// ERROR_IPSEC_MM_POLICY_IN_USE
        /// The specified main mode policy is being used.
        /// </summary>
        IpsecMmPolicyInUse = 0x32CD,

        /// <summary>
        /// ERROR_IPSEC_MM_FILTER_EXISTS
        /// The specified main mode filter already exists.
        /// </summary>
        IpsecMmFilterExists = 0x32CE,

        /// <summary>
        /// ERROR_IPSEC_MM_FILTER_NOT_FOUND
        /// The specified main mode filter was not found.
        /// </summary>
        IpsecMmFilterNotFound = 0x32CF,

        /// <summary>
        /// ERROR_IPSEC_TRANSPORT_FILTER_EXISTS
        /// The specified transport mode filter already exists.
        /// </summary>
        IpsecTransportFilterExists = 0x32D0,

        /// <summary>
        /// ERROR_IPSEC_TRANSPORT_FILTER_NOT_FOUND
        /// The specified transport mode filter does not exist.
        /// </summary>
        IpsecTransportFilterNotFound = 0x32D1,

        /// <summary>
        /// ERROR_IPSEC_MM_AUTH_EXISTS
        /// The specified main mode authentication list exists.
        /// </summary>
        IpsecMmAuthExists = 0x32D2,

        /// <summary>
        /// ERROR_IPSEC_MM_AUTH_NOT_FOUND
        /// The specified main mode authentication list was not found.
        /// </summary>
        IpsecMmAuthNotFound = 0x32D3,

        /// <summary>
        /// ERROR_IPSEC_MM_AUTH_IN_USE
        /// The specified main mode authentication list is being used.
        /// </summary>
        IpsecMmAuthInUse = 0x32D4,

        /// <summary>
        /// ERROR_IPSEC_DEFAULT_MM_POLICY_NOT_FOUND
        /// The specified default main mode policy was not found.
        /// </summary>
        IpsecDefaultMmPolicyNotFound = 0x32D5,

        /// <summary>
        /// ERROR_IPSEC_DEFAULT_MM_AUTH_NOT_FOUND
        /// The specified default main mode authentication list was not found.
        /// </summary>
        IpsecDefaultMmAuthNotFound = 0x32D6,

        /// <summary>
        /// ERROR_IPSEC_DEFAULT_QM_POLICY_NOT_FOUND
        /// The specified default quick mode policy was not found.
        /// </summary>
        IpsecDefaultQmPolicyNotFound = 0x32D7,

        /// <summary>
        /// ERROR_IPSEC_TUNNEL_FILTER_EXISTS
        /// The specified tunnel mode filter exists.
        /// </summary>
        IpsecTunnelFilterExists = 0x32D8,

        /// <summary>
        /// ERROR_IPSEC_TUNNEL_FILTER_NOT_FOUND
        /// The specified tunnel mode filter was not found.
        /// </summary>
        IpsecTunnelFilterNotFound = 0x32D9,

        /// <summary>
        /// ERROR_IPSEC_MM_FILTER_PENDING_DELETION
        /// The Main Mode filter is pending deletion.
        /// </summary>
        IpsecMmFilterPendingDeletion = 0x32DA,

        /// <summary>
        /// ERROR_IPSEC_TRANSPORT_FILTER_PENDING_DELETION
        /// The transport filter is pending deletion.
        /// </summary>
        IpsecTransportFilterPendingDeletion = 0x32DB,

        /// <summary>
        /// ERROR_IPSEC_TUNNEL_FILTER_PENDING_DELETION
        /// The tunnel filter is pending deletion.
        /// </summary>
        IpsecTunnelFilterPendingDeletion = 0x32DC,

        /// <summary>
        /// ERROR_IPSEC_MM_POLICY_PENDING_DELETION
        /// The Main Mode policy is pending deletion.
        /// </summary>
        IpsecMmPolicyPendingDeletion = 0x32DD,

        /// <summary>
        /// ERROR_IPSEC_MM_AUTH_PENDING_DELETION
        /// The Main Mode authentication bundle is pending deletion.
        /// </summary>
        IpsecMmAuthPendingDeletion = 0x32DE,

        /// <summary>
        /// ERROR_IPSEC_QM_POLICY_PENDING_DELETION
        /// The Quick Mode policy is pending deletion.
        /// </summary>
        IpsecQmPolicyPendingDeletion = 0x32DF,

        /// <summary>
        /// WARNING_IPSEC_MM_POLICY_PRUNED
        /// The Main Mode policy was successfully added, but some of the requested offers are not supported.
        /// </summary>
        WarningIpsecMmPolicyPruned = 0x32E0,

        /// <summary>
        /// WARNING_IPSEC_QM_POLICY_PRUNED
        /// The Quick Mode policy was successfully added, but some of the requested offers are not supported.
        /// </summary>
        WarningIpsecQmPolicyPruned = 0x32E1,

        /// <summary>
        /// ERROR_IPSEC_IKE_NEG_STATUS_BEGIN
        /// ERROR_IPSEC_IKE_NEG_STATUS_BEGIN
        /// </summary>
        IpsecIkeNegStatusBegin = 0x35E8,

        /// <summary>
        /// ERROR_IPSEC_IKE_AUTH_FAIL
        /// IKE authentication credentials are unacceptable.
        /// </summary>
        IpsecIkeAuthFail = 0x35E9,

        /// <summary>
        /// ERROR_IPSEC_IKE_ATTRIB_FAIL
        /// IKE security attributes are unacceptable.
        /// </summary>
        IpsecIkeAttribFail = 0x35EA,

        /// <summary>
        /// ERROR_IPSEC_IKE_NEGOTIATION_PENDING
        /// IKE Negotiation in progress.
        /// </summary>
        IpsecIkeNegotiationPending = 0x35EB,

        /// <summary>
        /// ERROR_IPSEC_IKE_GENERAL_PROCESSING_ERROR
        /// General processing error.
        /// </summary>
        IpsecIkeGeneralProcessingError = 0x35EC,

        /// <summary>
        /// ERROR_IPSEC_IKE_TIMED_OUT
        /// Negotiation timed out.
        /// </summary>
        IpsecIkeTimedOut = 0x35ED,

        /// <summary>
        /// ERROR_IPSEC_IKE_NO_CERT
        /// IKE failed to find valid machine certificate. Contact your Network Security Administrator about installing a valid certificate in the appropriate Certificate Store.
        /// </summary>
        IpsecIkeNoCert = 0x35EE,

        /// <summary>
        /// ERROR_IPSEC_IKE_SA_DELETED
        /// IKE SA deleted by peer before establishment completed.
        /// </summary>
        IpsecIkeSaDeleted = 0x35EF,

        /// <summary>
        /// ERROR_IPSEC_IKE_SA_REAPED
        /// IKE SA deleted before establishment completed.
        /// </summary>
        IpsecIkeSaReaped = 0x35F0,

        /// <summary>
        /// ERROR_IPSEC_IKE_MM_ACQUIRE_DROP
        /// Negotiation request sat in Queue too long.
        /// </summary>
        IpsecIkeMmAcquireDrop = 0x35F1,

        /// <summary>
        /// ERROR_IPSEC_IKE_QM_ACQUIRE_DROP
        /// Negotiation request sat in Queue too long.
        /// </summary>
        IpsecIkeQmAcquireDrop = 0x35F2,

        /// <summary>
        /// ERROR_IPSEC_IKE_QUEUE_DROP_MM
        /// Negotiation request sat in Queue too long.
        /// </summary>
        IpsecIkeQueueDropMm = 0x35F3,

        /// <summary>
        /// ERROR_IPSEC_IKE_QUEUE_DROP_NO_MM
        /// Negotiation request sat in Queue too long.
        /// </summary>
        IpsecIkeQueueDropNoMm = 0x35F4,

        /// <summary>
        /// ERROR_IPSEC_IKE_DROP_NO_RESPONSE
        /// No response from peer.
        /// </summary>
        IpsecIkeDropNoResponse = 0x35F5,

        /// <summary>
        /// ERROR_IPSEC_IKE_MM_DELAY_DROP
        /// Negotiation took too long.
        /// </summary>
        IpsecIkeMmDelayDrop = 0x35F6,

        /// <summary>
        /// ERROR_IPSEC_IKE_QM_DELAY_DROP
        /// Negotiation took too long.
        /// </summary>
        IpsecIkeQmDelayDrop = 0x35F7,

        /// <summary>
        /// ERROR_IPSEC_IKE_ERROR
        /// Unknown error occurred.
        /// </summary>
        IpsecIkeError = 0x35F8,

        /// <summary>
        /// ERROR_IPSEC_IKE_CRL_FAILED
        /// Certificate Revocation Check failed.
        /// </summary>
        IpsecIkeCrlFailed = 0x35F9,

        /// <summary>
        /// ERROR_IPSEC_IKE_INVALID_KEY_USAGE
        /// Invalid certificate key usage.
        /// </summary>
        IpsecIkeInvalidKeyUsage = 0x35FA,

        /// <summary>
        /// ERROR_IPSEC_IKE_INVALID_CERT_TYPE
        /// Invalid certificate type.
        /// </summary>
        IpsecIkeInvalidCertType = 0x35FB,

        /// <summary>
        /// ERROR_IPSEC_IKE_NO_PRIVATE_KEY
        /// IKE negotiation failed because the machine certificate used does not have a private key. IPsec certificates require a private key. Contact your Network Security administrator about replacing with a certificate that has a private key.
        /// </summary>
        IpsecIkeNoPrivateKey = 0x35FC,

        /// <summary>
        /// ERROR_IPSEC_IKE_SIMULTANEOUS_REKEY
        /// Simultaneous rekeys were detected.
        /// </summary>
        IpsecIkeSimultaneousRekey = 0x35FD,

        /// <summary>
        /// ERROR_IPSEC_IKE_DH_FAIL
        /// Failure in Diffie-Hellman computation.
        /// </summary>
        IpsecIkeDhFail = 0x35FE,

        /// <summary>
        /// ERROR_IPSEC_IKE_CRITICAL_PAYLOAD_NOT_RECOGNIZED
        /// Don't know how to process critical payload.
        /// </summary>
        IpsecIkeCriticalPayloadNotRecognized = 0x35FF,

        /// <summary>
        /// ERROR_IPSEC_IKE_INVALID_HEADER
        /// Invalid header.
        /// </summary>
        IpsecIkeInvalidHeader = 0x3600,

        /// <summary>
        /// ERROR_IPSEC_IKE_NO_POLICY
        /// No policy configured.
        /// </summary>
        IpsecIkeNoPolicy = 0x3601,

        /// <summary>
        /// ERROR_IPSEC_IKE_INVALID_SIGNATURE
        /// Failed to verify signature.
        /// </summary>
        IpsecIkeInvalidSignature = 0x3602,

        /// <summary>
        /// ERROR_IPSEC_IKE_KERBEROS_ERROR
        /// Failed to authenticate using Kerberos.
        /// </summary>
        IpsecIkeKerberosError = 0x3603,

        /// <summary>
        /// ERROR_IPSEC_IKE_NO_PUBLIC_KEY
        /// Peer's certificate did not have a public key.
        /// </summary>
        IpsecIkeNoPublicKey = 0x3604,

        /// <summary>
        /// ERROR_IPSEC_IKE_PROCESS_ERR
        /// Error processing error payload.
        /// </summary>
        IpsecIkeProcessErr = 0x3605,

        /// <summary>
        /// ERROR_IPSEC_IKE_PROCESS_ERR_SA
        /// Error processing SA payload.
        /// </summary>
        IpsecIkeProcessErrSa = 0x3606,

        /// <summary>
        /// ERROR_IPSEC_IKE_PROCESS_ERR_PROP
        /// Error processing Proposal payload.
        /// </summary>
        IpsecIkeProcessErrProp = 0x3607,

        /// <summary>
        /// ERROR_IPSEC_IKE_PROCESS_ERR_TRANS
        /// Error processing Transform payload.
        /// </summary>
        IpsecIkeProcessErrTrans = 0x3608,

        /// <summary>
        /// ERROR_IPSEC_IKE_PROCESS_ERR_KE
        /// Error processing KE payload.
        /// </summary>
        IpsecIkeProcessErrKe = 0x3609,

        /// <summary>
        /// ERROR_IPSEC_IKE_PROCESS_ERR_ID
        /// Error processing ID payload.
        /// </summary>
        IpsecIkeProcessErrId = 0x360A,

        /// <summary>
        /// ERROR_IPSEC_IKE_PROCESS_ERR_CERT
        /// Error processing Cert payload.
        /// </summary>
        IpsecIkeProcessErrCert = 0x360B,

        /// <summary>
        /// ERROR_IPSEC_IKE_PROCESS_ERR_CERT_REQ
        /// Error processing Certificate Request payload.
        /// </summary>
        IpsecIkeProcessErrCertReq = 0x360C,

        /// <summary>
        /// ERROR_IPSEC_IKE_PROCESS_ERR_HASH
        /// Error processing Hash payload.
        /// </summary>
        IpsecIkeProcessErrHash = 0x360D,

        /// <summary>
        /// ERROR_IPSEC_IKE_PROCESS_ERR_SIG
        /// Error processing Signature payload.
        /// </summary>
        IpsecIkeProcessErrSig = 0x360E,

        /// <summary>
        /// ERROR_IPSEC_IKE_PROCESS_ERR_NONCE
        /// Error processing Nonce payload.
        /// </summary>
        IpsecIkeProcessErrNonce = 0x360F,

        /// <summary>
        /// ERROR_IPSEC_IKE_PROCESS_ERR_NOTIFY
        /// Error processing Notify payload.
        /// </summary>
        IpsecIkeProcessErrNotify = 0x3610,

        /// <summary>
        /// ERROR_IPSEC_IKE_PROCESS_ERR_DELETE
        /// Error processing Delete Payload.
        /// </summary>
        IpsecIkeProcessErrDelete = 0x3611,

        /// <summary>
        /// ERROR_IPSEC_IKE_PROCESS_ERR_VENDOR
        /// Error processing VendorId payload.
        /// </summary>
        IpsecIkeProcessErrVendor = 0x3612,

        /// <summary>
        /// ERROR_IPSEC_IKE_INVALID_PAYLOAD
        /// Invalid payload received.
        /// </summary>
        IpsecIkeInvalidPayload = 0x3613,

        /// <summary>
        /// ERROR_IPSEC_IKE_LOAD_SOFT_SA
        /// Soft SA loaded.
        /// </summary>
        IpsecIkeLoadSoftSa = 0x3614,

        /// <summary>
        /// ERROR_IPSEC_IKE_SOFT_SA_TORN_DOWN
        /// Soft SA torn down.
        /// </summary>
        IpsecIkeSoftSaTornDown = 0x3615,

        /// <summary>
        /// ERROR_IPSEC_IKE_INVALID_COOKIE
        /// Invalid cookie received.
        /// </summary>
        IpsecIkeInvalidCookie = 0x3616,

        /// <summary>
        /// ERROR_IPSEC_IKE_NO_PEER_CERT
        /// Peer failed to send valid machine certificate.
        /// </summary>
        IpsecIkeNoPeerCert = 0x3617,

        /// <summary>
        /// ERROR_IPSEC_IKE_PEER_CRL_FAILED
        /// Certification Revocation check of peer's certificate failed.
        /// </summary>
        IpsecIkePeerCrlFailed = 0x3618,

        /// <summary>
        /// ERROR_IPSEC_IKE_POLICY_CHANGE
        /// New policy invalidated SAs formed with old policy.
        /// </summary>
        IpsecIkePolicyChange = 0x3619,

        /// <summary>
        /// ERROR_IPSEC_IKE_NO_MM_POLICY
        /// There is no available Main Mode IKE policy.
        /// </summary>
        IpsecIkeNoMmPolicy = 0x361A,

        /// <summary>
        /// ERROR_IPSEC_IKE_NOTCBPRIV
        /// Failed to enabled TCB privilege.
        /// </summary>
        IpsecIkeNotcbpriv = 0x361B,

        /// <summary>
        /// ERROR_IPSEC_IKE_SECLOADFAIL
        /// Failed to load SECURITY.DLL.
        /// </summary>
        IpsecIkeSecloadfail = 0x361C,

        /// <summary>
        /// ERROR_IPSEC_IKE_FAILSSPINIT
        /// Failed to obtain security function table dispatch address from SSPI.
        /// </summary>
        IpsecIkeFailsspinit = 0x361D,

        /// <summary>
        /// ERROR_IPSEC_IKE_FAILQUERYSSP
        /// Failed to query Kerberos package to obtain max token size.
        /// </summary>
        IpsecIkeFailqueryssp = 0x361E,

        /// <summary>
        /// ERROR_IPSEC_IKE_SRVACQFAIL
        /// Failed to obtain Kerberos server credentials for ISAKMP/ERROR_IPSEC_IKE service. Kerberos authentication will not function. The most likely reason for this is lack of domain membership. This is normal if your computer is a member of a workgroup.
        /// </summary>
        IpsecIkeSrvacqfail = 0x361F,

        /// <summary>
        /// ERROR_IPSEC_IKE_SRVQUERYCRED
        /// Failed to determine SSPI principal name for ISAKMP/ERROR_IPSEC_IKE service (QueryCredentialsAttributes).
        /// </summary>
        IpsecIkeSrvquerycred = 0x3620,

        /// <summary>
        /// ERROR_IPSEC_IKE_GETSPIFAIL
        /// Failed to obtain new SPI for the inbound SA from IPsec driver. The most common cause for this is that the driver does not have the correct filter. Check your policy to verify the filters.
        /// </summary>
        IpsecIkeGetspifail = 0x3621,

        /// <summary>
        /// ERROR_IPSEC_IKE_INVALID_FILTER
        /// Given filter is invalid.
        /// </summary>
        IpsecIkeInvalidFilter = 0x3622,

        /// <summary>
        /// ERROR_IPSEC_IKE_OUT_OF_MEMORY
        /// Memory allocation failed.
        /// </summary>
        IpsecIkeOutOfMemory = 0x3623,

        /// <summary>
        /// ERROR_IPSEC_IKE_ADD_UPDATE_KEY_FAILED
        /// Failed to add Security Association to IPsec Driver. The most common cause for this is if the IKE negotiation took too long to complete. If the problem persists, reduce the load on the faulting machine.
        /// </summary>
        IpsecIkeAddUpdateKeyFailed = 0x3624,

        /// <summary>
        /// ERROR_IPSEC_IKE_INVALID_POLICY
        /// Invalid policy.
        /// </summary>
        IpsecIkeInvalidPolicy = 0x3625,

        /// <summary>
        /// ERROR_IPSEC_IKE_UNKNOWN_DOI
        /// Invalid DOI.
        /// </summary>
        IpsecIkeUnknownDoi = 0x3626,

        /// <summary>
        /// ERROR_IPSEC_IKE_INVALID_SITUATION
        /// Invalid situation.
        /// </summary>
        IpsecIkeInvalidSituation = 0x3627,

        /// <summary>
        /// ERROR_IPSEC_IKE_DH_FAILURE
        /// Diffie-Hellman failure.
        /// </summary>
        IpsecIkeDhFailure = 0x3628,

        /// <summary>
        /// ERROR_IPSEC_IKE_INVALID_GROUP
        /// Invalid Diffie-Hellman group.
        /// </summary>
        IpsecIkeInvalidGroup = 0x3629,

        /// <summary>
        /// ERROR_IPSEC_IKE_ENCRYPT
        /// Error encrypting payload.
        /// </summary>
        IpsecIkeEncrypt = 0x362A,

        /// <summary>
        /// ERROR_IPSEC_IKE_DECRYPT
        /// Error decrypting payload.
        /// </summary>
        IpsecIkeDecrypt = 0x362B,

        /// <summary>
        /// ERROR_IPSEC_IKE_POLICY_MATCH
        /// Policy match error.
        /// </summary>
        IpsecIkePolicyMatch = 0x362C,

        /// <summary>
        /// ERROR_IPSEC_IKE_UNSUPPORTED_ID
        /// Unsupported ID.
        /// </summary>
        IpsecIkeUnsupportedId = 0x362D,

        /// <summary>
        /// ERROR_IPSEC_IKE_INVALID_HASH
        /// Hash verification failed.
        /// </summary>
        IpsecIkeInvalidHash = 0x362E,

        /// <summary>
        /// ERROR_IPSEC_IKE_INVALID_HASH_ALG
        /// Invalid hash algorithm.
        /// </summary>
        IpsecIkeInvalidHashAlg = 0x362F,

        /// <summary>
        /// ERROR_IPSEC_IKE_INVALID_HASH_SIZE
        /// Invalid hash size.
        /// </summary>
        IpsecIkeInvalidHashSize = 0x3630,

        /// <summary>
        /// ERROR_IPSEC_IKE_INVALID_ENCRYPT_ALG
        /// Invalid encryption algorithm.
        /// </summary>
        IpsecIkeInvalidEncryptAlg = 0x3631,

        /// <summary>
        /// ERROR_IPSEC_IKE_INVALID_AUTH_ALG
        /// Invalid authentication algorithm.
        /// </summary>
        IpsecIkeInvalidAuthAlg = 0x3632,

        /// <summary>
        /// ERROR_IPSEC_IKE_INVALID_SIG
        /// Invalid certificate signature.
        /// </summary>
        IpsecIkeInvalidSig = 0x3633,

        /// <summary>
        /// ERROR_IPSEC_IKE_LOAD_FAILED
        /// Load failed.
        /// </summary>
        IpsecIkeLoadFailed = 0x3634,

        /// <summary>
        /// ERROR_IPSEC_IKE_RPC_DELETE
        /// Deleted via RPC call.
        /// </summary>
        IpsecIkeRpcDelete = 0x3635,

        /// <summary>
        /// ERROR_IPSEC_IKE_BENIGN_REINIT
        /// Temporary state created to perform reinitialization. This is not a real failure.
        /// </summary>
        IpsecIkeBenignReinit = 0x3636,

        /// <summary>
        /// ERROR_IPSEC_IKE_INVALID_RESPONDER_LIFETIME_NOTIFY
        /// The lifetime value received in the Responder Lifetime Notify is below the Windows 2000 configured minimum value. Please fix the policy on the peer machine.
        /// </summary>
        IpsecIkeInvalidResponderLifetimeNotify = 0x3637,

        /// <summary>
        /// ERROR_IPSEC_IKE_INVALID_MAJOR_VERSION
        /// The recipient cannot handle version of IKE specified in the header.
        /// </summary>
        IpsecIkeInvalidMajorVersion = 0x3638,

        /// <summary>
        /// ERROR_IPSEC_IKE_INVALID_CERT_KEYLEN
        /// Key length in certificate is too small for configured security requirements.
        /// </summary>
        IpsecIkeInvalidCertKeylen = 0x3639,

        /// <summary>
        /// ERROR_IPSEC_IKE_MM_LIMIT
        /// Max number of established MM SAs to peer exceeded.
        /// </summary>
        IpsecIkeMmLimit = 0x363A,

        /// <summary>
        /// ERROR_IPSEC_IKE_NEGOTIATION_DISABLED
        /// IKE received a policy that disables negotiation.
        /// </summary>
        IpsecIkeNegotiationDisabled = 0x363B,

        /// <summary>
        /// ERROR_IPSEC_IKE_QM_LIMIT
        /// Reached maximum quick mode limit for the main mode. New main mode will be started.
        /// </summary>
        IpsecIkeQmLimit = 0x363C,

        /// <summary>
        /// ERROR_IPSEC_IKE_MM_EXPIRED
        /// Main mode SA lifetime expired or peer sent a main mode delete.
        /// </summary>
        IpsecIkeMmExpired = 0x363D,

        /// <summary>
        /// ERROR_IPSEC_IKE_PEER_MM_ASSUMED_INVALID
        /// Main mode SA assumed to be invalid because peer stopped responding.
        /// </summary>
        IpsecIkePeerMmAssumedInvalid = 0x363E,

        /// <summary>
        /// ERROR_IPSEC_IKE_CERT_CHAIN_POLICY_MISMATCH
        /// Certificate doesn't chain to a trusted root in IPsec policy.
        /// </summary>
        IpsecIkeCertChainPolicyMismatch = 0x363F,

        /// <summary>
        /// ERROR_IPSEC_IKE_UNEXPECTED_MESSAGE_ID
        /// Received unexpected message ID.
        /// </summary>
        IpsecIkeUnexpectedMessageId = 0x3640,

        /// <summary>
        /// ERROR_IPSEC_IKE_INVALID_AUTH_PAYLOAD
        /// Received invalid authentication offers.
        /// </summary>
        IpsecIkeInvalidAuthPayload = 0x3641,

        /// <summary>
        /// ERROR_IPSEC_IKE_DOS_COOKIE_SENT
        /// Sent DoS cookie notify to initiator.
        /// </summary>
        IpsecIkeDosCookieSent = 0x3642,

        /// <summary>
        /// ERROR_IPSEC_IKE_SHUTTING_DOWN
        /// IKE service is shutting down.
        /// </summary>
        IpsecIkeShuttingDown = 0x3643,

        /// <summary>
        /// ERROR_IPSEC_IKE_CGA_AUTH_FAILED
        /// Could not verify binding between CGA address and certificate.
        /// </summary>
        IpsecIkeCgaAuthFailed = 0x3644,

        /// <summary>
        /// ERROR_IPSEC_IKE_PROCESS_ERR_NATOA
        /// Error processing NatOA payload.
        /// </summary>
        IpsecIkeProcessErrNatoa = 0x3645,

        /// <summary>
        /// ERROR_IPSEC_IKE_INVALID_MM_FOR_QM
        /// Parameters of the main mode are invalid for this quick mode.
        /// </summary>
        IpsecIkeInvalidMmForQm = 0x3646,

        /// <summary>
        /// ERROR_IPSEC_IKE_QM_EXPIRED
        /// Quick mode SA was expired by IPsec driver.
        /// </summary>
        IpsecIkeQmExpired = 0x3647,

        /// <summary>
        /// ERROR_IPSEC_IKE_TOO_MANY_FILTERS
        /// Too many dynamically added IKEEXT filters were detected.
        /// </summary>
        IpsecIkeTooManyFilters = 0x3648,

        /// <summary>
        /// ERROR_IPSEC_IKE_NEG_STATUS_END
        /// ERROR_IPSEC_IKE_NEG_STATUS_END
        /// </summary>
        IpsecIkeNegStatusEnd = 0x3649,

        /// <summary>
        /// ERROR_IPSEC_IKE_KILL_DUMMY_NAP_TUNNEL
        /// NAP reauth succeeded and must delete the dummy NAP IKEv2 tunnel.
        /// </summary>
        IpsecIkeKillDummyNapTunnel = 0x364A,

        /// <summary>
        /// ERROR_IPSEC_IKE_INNER_IP_ASSIGNMENT_FAILURE
        /// Error in assigning inner IP address to initiator in tunnel mode.
        /// </summary>
        IpsecIkeInnerIpAssignmentFailure = 0x364B,

        /// <summary>
        /// ERROR_IPSEC_IKE_REQUIRE_CP_PAYLOAD_MISSING
        /// Require configuration payload missing.
        /// </summary>
        IpsecIkeRequireCpPayloadMissing = 0x364C,

        /// <summary>
        /// ERROR_IPSEC_KEY_MODULE_IMPERSONATION_NEGOTIATION_PENDING
        /// A negotiation running as the security principle who issued the connection is in progress.
        /// </summary>
        IpsecKeyModuleImpersonationNegotiationPending = 0x364D,

        /// <summary>
        /// ERROR_IPSEC_IKE_COEXISTENCE_SUPPRESS
        /// SA was deleted due to IKEv1/AuthIP co-existence suppress check.
        /// </summary>
        IpsecIkeCoexistenceSuppress = 0x364E,

        /// <summary>
        /// ERROR_IPSEC_IKE_RATELIMIT_DROP
        /// Incoming SA request was dropped due to peer IP address rate limiting.
        /// </summary>
        IpsecIkeRatelimitDrop = 0x364F,

        /// <summary>
        /// ERROR_IPSEC_IKE_PEER_DOESNT_SUPPORT_MOBIKE
        /// Peer does not support MOBIKE.
        /// </summary>
        IpsecIkePeerDoesntSupportMobike = 0x3650,

        /// <summary>
        /// ERROR_IPSEC_IKE_AUTHORIZATION_FAILURE
        /// SA establishment is not authorized.
        /// </summary>
        IpsecIkeAuthorizationFailure = 0x3651,

        /// <summary>
        /// ERROR_IPSEC_IKE_STRONG_CRED_AUTHORIZATION_FAILURE
        /// SA establishment is not authorized because there is not a sufficiently strong PKINIT-based credential.
        /// </summary>
        IpsecIkeStrongCredAuthorizationFailure = 0x3652,

        /// <summary>
        /// ERROR_IPSEC_IKE_AUTHORIZATION_FAILURE_WITH_OPTIONAL_RETRY
        /// SA establishment is not authorized. You may need to enter updated or different credentials such as a smartcard.
        /// </summary>
        IpsecIkeAuthorizationFailureWithOptionalRetry = 0x3653,

        /// <summary>
        /// ERROR_IPSEC_IKE_STRONG_CRED_AUTHORIZATION_AND_CERTMAP_FAILURE
        /// SA establishment is not authorized because there is not a sufficiently strong PKINIT-based credential. This might be related to certificate-to-account mapping failure for the SA.
        /// </summary>
        IpsecIkeStrongCredAuthorizationAndCertmapFailure = 0x3654,

        /// <summary>
        /// ERROR_IPSEC_IKE_NEG_STATUS_EXTENDED_END
        /// ERROR_IPSEC_IKE_NEG_STATUS_EXTENDED_END
        /// </summary>
        IpsecIkeNegStatusExtendedEnd = 0x3655,

        /// <summary>
        /// ERROR_IPSEC_BAD_SPI
        /// The SPI in the packet does not match a valid IPsec SA.
        /// </summary>
        IpsecBadSpi = 0x3656,

        /// <summary>
        /// ERROR_IPSEC_SA_LIFETIME_EXPIRED
        /// Packet was received on an IPsec SA whose lifetime has expired.
        /// </summary>
        IpsecSaLifetimeExpired = 0x3657,

        /// <summary>
        /// ERROR_IPSEC_WRONG_SA
        /// Packet was received on an IPsec SA that does not match the packet characteristics.
        /// </summary>
        IpsecWrongSa = 0x3658,

        /// <summary>
        /// ERROR_IPSEC_REPLAY_CHECK_FAILED
        /// Packet sequence number replay check failed.
        /// </summary>
        IpsecReplayCheckFailed = 0x3659,

        /// <summary>
        /// ERROR_IPSEC_INVALID_PACKET
        /// IPsec header and/or trailer in the packet is invalid.
        /// </summary>
        IpsecInvalidPacket = 0x365A,

        /// <summary>
        /// ERROR_IPSEC_INTEGRITY_CHECK_FAILED
        /// IPsec integrity check failed.
        /// </summary>
        IpsecIntegrityCheckFailed = 0x365B,

        /// <summary>
        /// ERROR_IPSEC_CLEAR_TEXT_DROP
        /// IPsec dropped a clear text packet.
        /// </summary>
        IpsecClearTextDrop = 0x365C,

        /// <summary>
        /// ERROR_IPSEC_AUTH_FIREWALL_DROP
        /// IPsec dropped an incoming ESP packet in authenticated firewall mode. This drop is benign.
        /// </summary>
        IpsecAuthFirewallDrop = 0x365D,

        /// <summary>
        /// ERROR_IPSEC_THROTTLE_DROP
        /// IPsec dropped a packet due to DoS throttling.
        /// </summary>
        IpsecThrottleDrop = 0x365E,

        /// <summary>
        /// ERROR_IPSEC_DOSP_BLOCK
        /// IPsec DoS Protection matched an explicit block rule.
        /// </summary>
        IpsecDospBlock = 0x3665,

        /// <summary>
        /// ERROR_IPSEC_DOSP_RECEIVED_MULTICAST
        /// IPsec DoS Protection received an IPsec specific multicast packet which is not allowed.
        /// </summary>
        IpsecDospReceivedMulticast = 0x3666,

        /// <summary>
        /// ERROR_IPSEC_DOSP_INVALID_PACKET
        /// IPsec DoS Protection received an incorrectly formatted packet.
        /// </summary>
        IpsecDospInvalidPacket = 0x3667,

        /// <summary>
        /// ERROR_IPSEC_DOSP_STATE_LOOKUP_FAILED
        /// IPsec DoS Protection failed to look up state.
        /// </summary>
        IpsecDospStateLookupFailed = 0x3668,

        /// <summary>
        /// ERROR_IPSEC_DOSP_MAX_ENTRIES
        /// IPsec DoS Protection failed to create state because the maximum number of entries allowed by policy has been reached.
        /// </summary>
        IpsecDospMaxEntries = 0x3669,

        /// <summary>
        /// ERROR_IPSEC_DOSP_KEYMOD_NOT_ALLOWED
        /// IPsec DoS Protection received an IPsec negotiation packet for a keying module which is not allowed by policy.
        /// </summary>
        IpsecDospKeymodNotAllowed = 0x366A,

        /// <summary>
        /// ERROR_IPSEC_DOSP_NOT_INSTALLED
        /// IPsec DoS Protection has not been enabled.
        /// </summary>
        IpsecDospNotInstalled = 0x366B,

        /// <summary>
        /// ERROR_IPSEC_DOSP_MAX_PER_IP_RATELIMIT_QUEUES
        /// IPsec DoS Protection failed to create a per internal IP rate limit queue because the maximum number of queues allowed by policy has been reached.
        /// </summary>
        IpsecDospMaxPerIpRatelimitQueues = 0x366C,

        /// <summary>
        /// ERROR_SXS_SECTION_NOT_FOUND
        /// The requested section was not present in the activation context.
        /// </summary>
        SxsSectionNotFound = 0x36B0,

        /// <summary>
        /// ERROR_SXS_CANT_GEN_ACTCTX
        /// The application has failed to start because its side-by-side configuration is incorrect. Please see the application event log or use the command-line sxstrace.exe tool for more detail.
        /// </summary>
        SxsCantGenActctx = 0x36B1,

        /// <summary>
        /// ERROR_SXS_INVALID_ACTCTXDATA_FORMAT
        /// The application binding data format is invalid.
        /// </summary>
        SxsInvalidActctxdataFormat = 0x36B2,

        /// <summary>
        /// ERROR_SXS_ASSEMBLY_NOT_FOUND
        /// The referenced assembly is not installed on your system.
        /// </summary>
        SxsAssemblyNotFound = 0x36B3,

        /// <summary>
        /// ERROR_SXS_MANIFEST_FORMAT_ERROR
        /// The manifest file does not begin with the required tag and format information.
        /// </summary>
        SxsManifestFormatError = 0x36B4,

        /// <summary>
        /// ERROR_SXS_MANIFEST_PARSE_ERROR
        /// The manifest file contains one or more syntax errors.
        /// </summary>
        SxsManifestParseError = 0x36B5,

        /// <summary>
        /// ERROR_SXS_ACTIVATION_CONTEXT_DISABLED
        /// The application attempted to activate a disabled activation context.
        /// </summary>
        SxsActivationContextDisabled = 0x36B6,

        /// <summary>
        /// ERROR_SXS_KEY_NOT_FOUND
        /// The requested lookup key was not found in any active activation context.
        /// </summary>
        SxsKeyNotFound = 0x36B7,

        /// <summary>
        /// ERROR_SXS_VERSION_CONFLICT
        /// A component version required by the application conflicts with another component version already active.
        /// </summary>
        SxsVersionConflict = 0x36B8,

        /// <summary>
        /// ERROR_SXS_WRONG_SECTION_TYPE
        /// The type requested activation context section does not match the query API used.
        /// </summary>
        SxsWrongSectionType = 0x36B9,

        /// <summary>
        /// ERROR_SXS_THREAD_QUERIES_DISABLED
        /// Lack of system resources has required isolated activation to be disabled for the current thread of execution.
        /// </summary>
        SxsThreadQueriesDisabled = 0x36BA,

        /// <summary>
        /// ERROR_SXS_PROCESS_DEFAULT_ALREADY_SET
        /// An attempt to set the process default activation context failed because the process default activation context was already set.
        /// </summary>
        SxsProcessDefaultAlreadySet = 0x36BB,

        /// <summary>
        /// ERROR_SXS_UNKNOWN_ENCODING_GROUP
        /// The encoding group identifier specified is not recognized.
        /// </summary>
        SxsUnknownEncodingGroup = 0x36BC,

        /// <summary>
        /// ERROR_SXS_UNKNOWN_ENCODING
        /// The encoding requested is not recognized.
        /// </summary>
        SxsUnknownEncoding = 0x36BD,

        /// <summary>
        /// ERROR_SXS_INVALID_XML_NAMESPACE_URI
        /// The manifest contains a reference to an invalid URI.
        /// </summary>
        SxsInvalidXmlNamespaceUri = 0x36BE,

        /// <summary>
        /// ERROR_SXS_ROOT_MANIFEST_DEPENDENCY_NOT_INSTALLED
        /// The application manifest contains a reference to a dependent assembly which is not installed.
        /// </summary>
        SxsRootManifestDependencyNotInstalled = 0x36BF,

        /// <summary>
        /// ERROR_SXS_LEAF_MANIFEST_DEPENDENCY_NOT_INSTALLED
        /// The manifest for an assembly used by the application has a reference to a dependent assembly which is not installed.
        /// </summary>
        SxsLeafManifestDependencyNotInstalled = 0x36C0,

        /// <summary>
        /// ERROR_SXS_INVALID_ASSEMBLY_IDENTITY_ATTRIBUTE
        /// The manifest contains an attribute for the assembly identity which is not valid.
        /// </summary>
        SxsInvalidAssemblyIdentityAttribute = 0x36C1,

        /// <summary>
        /// ERROR_SXS_MANIFEST_MISSING_REQUIRED_DEFAULT_NAMESPACE
        /// The manifest is missing the required default namespace specification on the assembly element.
        /// </summary>
        SxsManifestMissingRequiredDefaultNamespace = 0x36C2,

        /// <summary>
        /// ERROR_SXS_MANIFEST_INVALID_REQUIRED_DEFAULT_NAMESPACE
        /// The manifest has a default namespace specified on the assembly element but its value is not "urn:schemas-microsoft-com:asm.v1".
        /// </summary>
        SxsManifestInvalidRequiredDefaultNamespace = 0x36C3,

        /// <summary>
        /// ERROR_SXS_PRIVATE_MANIFEST_CROSS_PATH_WITH_REPARSE_POINT
        /// The private manifest probed has crossed a path with an unsupported reparse point.
        /// </summary>
        SxsPrivateManifestCrossPathWithReparsePoint = 0x36C4,

        /// <summary>
        /// ERROR_SXS_DUPLICATE_DLL_NAME
        /// Two or more components referenced directly or indirectly by the application manifest have files by the same name.
        /// </summary>
        SxsDuplicateDllName = 0x36C5,

        /// <summary>
        /// ERROR_SXS_DUPLICATE_WINDOWCLASS_NAME
        /// Two or more components referenced directly or indirectly by the application manifest have window classes with the same name.
        /// </summary>
        SxsDuplicateWindowclassName = 0x36C6,

        /// <summary>
        /// ERROR_SXS_DUPLICATE_CLSID
        /// Two or more components referenced directly or indirectly by the application manifest have the same COM server CLSIDs.
        /// </summary>
        SxsDuplicateClsid = 0x36C7,

        /// <summary>
        /// ERROR_SXS_DUPLICATE_IID
        /// Two or more components referenced directly or indirectly by the application manifest have proxies for the same COM interface IIDs.
        /// </summary>
        SxsDuplicateIid = 0x36C8,

        /// <summary>
        /// ERROR_SXS_DUPLICATE_TLBID
        /// Two or more components referenced directly or indirectly by the application manifest have the same COM type library TLBIDs.
        /// </summary>
        SxsDuplicateTlbid = 0x36C9,

        /// <summary>
        /// ERROR_SXS_DUPLICATE_PROGID
        /// Two or more components referenced directly or indirectly by the application manifest have the same COM ProgIDs.
        /// </summary>
        SxsDuplicateProgid = 0x36CA,

        /// <summary>
        /// ERROR_SXS_DUPLICATE_ASSEMBLY_NAME
        /// Two or more components referenced directly or indirectly by the application manifest are different versions of the same component which is not permitted.
        /// </summary>
        SxsDuplicateAssemblyName = 0x36CB,

        /// <summary>
        /// ERROR_SXS_FILE_HASH_MISMATCH
        /// A component's file does not match the verification information present in the component manifest.
        /// </summary>
        SxsFileHashMismatch = 0x36CC,

        /// <summary>
        /// ERROR_SXS_POLICY_PARSE_ERROR
        /// The policy manifest contains one or more syntax errors.
        /// </summary>
        SxsPolicyParseError = 0x36CD,

        /// <summary>
        /// ERROR_SXS_XML_E_MISSINGQUOTE
        /// Manifest Parse Error : A string literal was expected, but no opening quote character was found.
        /// </summary>
        SxsXmlEMissingquote = 0x36CE,

        /// <summary>
        /// ERROR_SXS_XML_E_COMMENTSYNTAX
        /// Manifest Parse Error : Incorrect syntax was used in a comment.
        /// </summary>
        SxsXmlECommentsyntax = 0x36CF,

        /// <summary>
        /// ERROR_SXS_XML_E_BADSTARTNAMECHAR
        /// Manifest Parse Error : A name was started with an invalid character.
        /// </summary>
        SxsXmlEBadstartnamechar = 0x36D0,

        /// <summary>
        /// ERROR_SXS_XML_E_BADNAMECHAR
        /// Manifest Parse Error : A name contained an invalid character.
        /// </summary>
        SxsXmlEBadnamechar = 0x36D1,

        /// <summary>
        /// ERROR_SXS_XML_E_BADCHARINSTRING
        /// Manifest Parse Error : A string literal contained an invalid character.
        /// </summary>
        SxsXmlEBadcharinstring = 0x36D2,

        /// <summary>
        /// ERROR_SXS_XML_E_XMLDECLSYNTAX
        /// Manifest Parse Error : Invalid syntax for an xml declaration.
        /// </summary>
        SxsXmlEXmldeclsyntax = 0x36D3,

        /// <summary>
        /// ERROR_SXS_XML_E_BADCHARDATA
        /// Manifest Parse Error : An Invalid character was found in text content.
        /// </summary>
        SxsXmlEBadchardata = 0x36D4,

        /// <summary>
        /// ERROR_SXS_XML_E_MISSINGWHITESPACE
        /// Manifest Parse Error : Required white space was missing.
        /// </summary>
        SxsXmlEMissingwhitespace = 0x36D5,

        /// <summary>
        /// ERROR_SXS_XML_E_EXPECTINGTAGEND
        /// Manifest Parse Error : The character '>' was expected.
        /// </summary>
        SxsXmlEExpectingtagend = 0x36D6,

        /// <summary>
        /// ERROR_SXS_XML_E_MISSINGSEMICOLON
        /// Manifest Parse Error : A semi colon character was expected.
        /// </summary>
        SxsXmlEMissingsemicolon = 0x36D7,

        /// <summary>
        /// ERROR_SXS_XML_E_UNBALANCEDPAREN
        /// Manifest Parse Error : Unbalanced parentheses.
        /// </summary>
        SxsXmlEUnbalancedparen = 0x36D8,

        /// <summary>
        /// ERROR_SXS_XML_E_INTERNALERROR
        /// Manifest Parse Error : Internal error.
        /// </summary>
        SxsXmlEInternalerror = 0x36D9,

        /// <summary>
        /// ERROR_SXS_XML_E_UNEXPECTED_WHITESPACE
        /// Manifest Parse Error : Whitespace is not allowed at this location.
        /// </summary>
        SxsXmlEUnexpectedWhitespace = 0x36DA,

        /// <summary>
        /// ERROR_SXS_XML_E_INCOMPLETE_ENCODING
        /// Manifest Parse Error : End of file reached in invalid state for current encoding.
        /// </summary>
        SxsXmlEIncompleteEncoding = 0x36DB,

        /// <summary>
        /// ERROR_SXS_XML_E_MISSING_PAREN
        /// Manifest Parse Error : Missing parenthesis.
        /// </summary>
        SxsXmlEMissingParen = 0x36DC,

        /// <summary>
        /// ERROR_SXS_XML_E_EXPECTINGCLOSEQUOTE
        /// Manifest Parse Error : A single or double closing quote character (\' or \") is missing.
        /// </summary>
        SxsXmlEExpectingclosequote = 0x36DD,

        /// <summary>
        /// ERROR_SXS_XML_E_MULTIPLE_COLONS
        /// Manifest Parse Error : Multiple colons are not allowed in a name.
        /// </summary>
        SxsXmlEMultipleColons = 0x36DE,

        /// <summary>
        /// ERROR_SXS_XML_E_INVALID_DECIMAL
        /// Manifest Parse Error : Invalid character for decimal digit.
        /// </summary>
        SxsXmlEInvalidDecimal = 0x36DF,

        /// <summary>
        /// ERROR_SXS_XML_E_INVALID_HEXIDECIMAL
        /// Manifest Parse Error : Invalid character for hexadecimal digit.
        /// </summary>
        SxsXmlEInvalidHexidecimal = 0x36E0,

        /// <summary>
        /// ERROR_SXS_XML_E_INVALID_UNICODE
        /// Manifest Parse Error : Invalid unicode character value for this platform.
        /// </summary>
        SxsXmlEInvalidUnicode = 0x36E1,

        /// <summary>
        /// ERROR_SXS_XML_E_WHITESPACEORQUESTIONMARK
        /// Manifest Parse Error : Expecting whitespace or '?'.
        /// </summary>
        SxsXmlEWhitespaceorquestionmark = 0x36E2,

        /// <summary>
        /// ERROR_SXS_XML_E_UNEXPECTEDENDTAG
        /// Manifest Parse Error : End tag was not expected at this location.
        /// </summary>
        SxsXmlEUnexpectedendtag = 0x36E3,

        /// <summary>
        /// ERROR_SXS_XML_E_UNCLOSEDTAG
        /// Manifest Parse Error : The following tags were not closed: %1.
        /// </summary>
        SxsXmlEUnclosedtag = 0x36E4,

        /// <summary>
        /// ERROR_SXS_XML_E_DUPLICATEATTRIBUTE
        /// Manifest Parse Error : Duplicate attribute.
        /// </summary>
        SxsXmlEDuplicateattribute = 0x36E5,

        /// <summary>
        /// ERROR_SXS_XML_E_MULTIPLEROOTS
        /// Manifest Parse Error : Only one top level element is allowed in an XML document.
        /// </summary>
        SxsXmlEMultipleroots = 0x36E6,

        /// <summary>
        /// ERROR_SXS_XML_E_INVALIDATROOTLEVEL
        /// Manifest Parse Error : Invalid at the top level of the document.
        /// </summary>
        SxsXmlEInvalidatrootlevel = 0x36E7,

        /// <summary>
        /// ERROR_SXS_XML_E_BADXMLDECL
        /// Manifest Parse Error : Invalid xml declaration.
        /// </summary>
        SxsXmlEBadxmldecl = 0x36E8,

        /// <summary>
        /// ERROR_SXS_XML_E_MISSINGROOT
        /// Manifest Parse Error : XML document must have a top level element.
        /// </summary>
        SxsXmlEMissingroot = 0x36E9,

        /// <summary>
        /// ERROR_SXS_XML_E_UNEXPECTEDEOF
        /// Manifest Parse Error : Unexpected end of file.
        /// </summary>
        SxsXmlEUnexpectedeof = 0x36EA,

        /// <summary>
        /// ERROR_SXS_XML_E_BADPEREFINSUBSET
        /// Manifest Parse Error : Parameter entities cannot be used inside markup declarations in an internal subset.
        /// </summary>
        SxsXmlEBadperefinsubset = 0x36EB,

        /// <summary>
        /// ERROR_SXS_XML_E_UNCLOSEDSTARTTAG
        /// Manifest Parse Error : Element was not closed.
        /// </summary>
        SxsXmlEUnclosedstarttag = 0x36EC,

        /// <summary>
        /// ERROR_SXS_XML_E_UNCLOSEDENDTAG
        /// Manifest Parse Error : End element was missing the character '>'.
        /// </summary>
        SxsXmlEUnclosedendtag = 0x36ED,

        /// <summary>
        /// ERROR_SXS_XML_E_UNCLOSEDSTRING
        /// Manifest Parse Error : A string literal was not closed.
        /// </summary>
        SxsXmlEUnclosedstring = 0x36EE,

        /// <summary>
        /// ERROR_SXS_XML_E_UNCLOSEDCOMMENT
        /// Manifest Parse Error : A comment was not closed.
        /// </summary>
        SxsXmlEUnclosedcomment = 0x36EF,

        /// <summary>
        /// ERROR_SXS_XML_E_UNCLOSEDDECL
        /// Manifest Parse Error : A declaration was not closed.
        /// </summary>
        SxsXmlEUncloseddecl = 0x36F0,

        /// <summary>
        /// ERROR_SXS_XML_E_UNCLOSEDCDATA
        /// Manifest Parse Error : A CDATA section was not closed.
        /// </summary>
        SxsXmlEUnclosedcdata = 0x36F1,

        /// <summary>
        /// ERROR_SXS_XML_E_RESERVEDNAMESPACE
        /// Manifest Parse Error : The namespace prefix is not allowed to start with the reserved string "xml".
        /// </summary>
        SxsXmlEReservednamespace = 0x36F2,

        /// <summary>
        /// ERROR_SXS_XML_E_INVALIDENCODING
        /// Manifest Parse Error : System does not support the specified encoding.
        /// </summary>
        SxsXmlEInvalidencoding = 0x36F3,

        /// <summary>
        /// ERROR_SXS_XML_E_INVALIDSWITCH
        /// Manifest Parse Error : Switch from current encoding to specified encoding not supported.
        /// </summary>
        SxsXmlEInvalidswitch = 0x36F4,

        /// <summary>
        /// ERROR_SXS_XML_E_BADXMLCASE
        /// Manifest Parse Error : The name 'xml' is reserved and must be lower case.
        /// </summary>
        SxsXmlEBadxmlcase = 0x36F5,

        /// <summary>
        /// ERROR_SXS_XML_E_INVALID_STANDALONE
        /// Manifest Parse Error : The standalone attribute must have the value 'yes' or 'no'.
        /// </summary>
        SxsXmlEInvalidStandalone = 0x36F6,

        /// <summary>
        /// ERROR_SXS_XML_E_UNEXPECTED_STANDALONE
        /// Manifest Parse Error : The standalone attribute cannot be used in external entities.
        /// </summary>
        SxsXmlEUnexpectedStandalone = 0x36F7,

        /// <summary>
        /// ERROR_SXS_XML_E_INVALID_VERSION
        /// Manifest Parse Error : Invalid version number.
        /// </summary>
        SxsXmlEInvalidVersion = 0x36F8,

        /// <summary>
        /// ERROR_SXS_XML_E_MISSINGEQUALS
        /// Manifest Parse Error : Missing equals sign between attribute and attribute value.
        /// </summary>
        SxsXmlEMissingequals = 0x36F9,

        /// <summary>
        /// ERROR_SXS_PROTECTION_RECOVERY_FAILED
        /// Assembly Protection Error : Unable to recover the specified assembly.
        /// </summary>
        SxsProtectionRecoveryFailed = 0x36FA,

        /// <summary>
        /// ERROR_SXS_PROTECTION_PUBLIC_KEY_TOO_SHORT
        /// Assembly Protection Error : The public key for an assembly was too short to be allowed.
        /// </summary>
        SxsProtectionPublicKeyTooShort = 0x36FB,

        /// <summary>
        /// ERROR_SXS_PROTECTION_CATALOG_NOT_VALID
        /// Assembly Protection Error : The catalog for an assembly is not valid, or does not match the assembly's manifest.
        /// </summary>
        SxsProtectionCatalogNotValid = 0x36FC,

        /// <summary>
        /// ERROR_SXS_UNTRANSLATABLE_HRESULT
        /// An HRESULT could not be translated to a corresponding Win32 error code.
        /// </summary>
        SxsUntranslatableHresult = 0x36FD,

        /// <summary>
        /// ERROR_SXS_PROTECTION_CATALOG_FILE_MISSING
        /// Assembly Protection Error : The catalog for an assembly is missing.
        /// </summary>
        SxsProtectionCatalogFileMissing = 0x36FE,

        /// <summary>
        /// ERROR_SXS_MISSING_ASSEMBLY_IDENTITY_ATTRIBUTE
        /// The supplied assembly identity is missing one or more attributes which must be present in this context.
        /// </summary>
        SxsMissingAssemblyIdentityAttribute = 0x36FF,

        /// <summary>
        /// ERROR_SXS_INVALID_ASSEMBLY_IDENTITY_ATTRIBUTE_NAME
        /// The supplied assembly identity has one or more attribute names that contain characters not permitted in XML names.
        /// </summary>
        SxsInvalidAssemblyIdentityAttributeName = 0x3700,

        /// <summary>
        /// ERROR_SXS_ASSEMBLY_MISSING
        /// The referenced assembly could not be found.
        /// </summary>
        SxsAssemblyMissing = 0x3701,

        /// <summary>
        /// ERROR_SXS_CORRUPT_ACTIVATION_STACK
        /// The activation context activation stack for the running thread of execution is corrupt.
        /// </summary>
        SxsCorruptActivationStack = 0x3702,

        /// <summary>
        /// ERROR_SXS_CORRUPTION
        /// The application isolation metadata for this process or thread has become corrupt.
        /// </summary>
        SxsCorruption = 0x3703,

        /// <summary>
        /// ERROR_SXS_EARLY_DEACTIVATION
        /// The activation context being deactivated is not the most recently activated one.
        /// </summary>
        SxsEarlyDeactivation = 0x3704,

        /// <summary>
        /// ERROR_SXS_INVALID_DEACTIVATION
        /// The activation context being deactivated is not active for the current thread of execution.
        /// </summary>
        SxsInvalidDeactivation = 0x3705,

        /// <summary>
        /// ERROR_SXS_MULTIPLE_DEACTIVATION
        /// The activation context being deactivated has already been deactivated.
        /// </summary>
        SxsMultipleDeactivation = 0x3706,

        /// <summary>
        /// ERROR_SXS_PROCESS_TERMINATION_REQUESTED
        /// A component used by the isolation facility has requested to terminate the process.
        /// </summary>
        SxsProcessTerminationRequested = 0x3707,

        /// <summary>
        /// ERROR_SXS_RELEASE_ACTIVATION_CONTEXT
        /// A kernel mode component is releasing a reference on an activation context.
        /// </summary>
        SxsReleaseActivationContext = 0x3708,

        /// <summary>
        /// ERROR_SXS_SYSTEM_DEFAULT_ACTIVATION_CONTEXT_EMPTY
        /// The activation context of system default assembly could not be generated.
        /// </summary>
        SxsSystemDefaultActivationContextEmpty = 0x3709,

        /// <summary>
        /// ERROR_SXS_INVALID_IDENTITY_ATTRIBUTE_VALUE
        /// The value of an attribute in an identity is not within the legal range.
        /// </summary>
        SxsInvalidIdentityAttributeValue = 0x370A,

        /// <summary>
        /// ERROR_SXS_INVALID_IDENTITY_ATTRIBUTE_NAME
        /// The name of an attribute in an identity is not within the legal range.
        /// </summary>
        SxsInvalidIdentityAttributeName = 0x370B,

        /// <summary>
        /// ERROR_SXS_IDENTITY_DUPLICATE_ATTRIBUTE
        /// An identity contains two definitions for the same attribute.
        /// </summary>
        SxsIdentityDuplicateAttribute = 0x370C,

        /// <summary>
        /// ERROR_SXS_IDENTITY_PARSE_ERROR
        /// The identity string is malformed. This may be due to a trailing comma, more than two unnamed attributes, missing attribute name or missing attribute value.
        /// </summary>
        SxsIdentityParseError = 0x370D,

        /// <summary>
        /// ERROR_MALFORMED_SUBSTITUTION_STRING
        /// A string containing localized substitutable content was malformed. Either a dollar sign ($) was followed by something other than a left parenthesis or another dollar sign or an substitution's right parenthesis was not found.
        /// </summary>
        MalformedSubstitutionString = 0x370E,

        /// <summary>
        /// ERROR_SXS_INCORRECT_PUBLIC_KEY_TOKEN
        /// The public key token does not correspond to the public key specified.
        /// </summary>
        SxsIncorrectPublicKeyToken = 0x370F,

        /// <summary>
        /// ERROR_UNMAPPED_SUBSTITUTION_STRING
        /// A substitution string had no mapping.
        /// </summary>
        UnmappedSubstitutionString = 0x3710,

        /// <summary>
        /// ERROR_SXS_ASSEMBLY_NOT_LOCKED
        /// The component must be locked before making the request.
        /// </summary>
        SxsAssemblyNotLocked = 0x3711,

        /// <summary>
        /// ERROR_SXS_COMPONENT_STORE_CORRUPT
        /// The component store has been corrupted.
        /// </summary>
        SxsComponentStoreCorrupt = 0x3712,

        /// <summary>
        /// ERROR_ADVANCED_INSTALLER_FAILED
        /// An advanced installer failed during setup or servicing.
        /// </summary>
        AdvancedInstallerFailed = 0x3713,

        /// <summary>
        /// ERROR_XML_ENCODING_MISMATCH
        /// The character encoding in the XML declaration did not match the encoding used in the document.
        /// </summary>
        XmlEncodingMismatch = 0x3714,

        /// <summary>
        /// ERROR_SXS_MANIFEST_IDENTITY_SAME_BUT_CONTENTS_DIFFERENT
        /// The identities of the manifests are identical but their contents are different.
        /// </summary>
        SxsManifestIdentitySameButContentsDifferent = 0x3715,

        /// <summary>
        /// ERROR_SXS_IDENTITIES_DIFFERENT
        /// The component identities are different.
        /// </summary>
        SxsIdentitiesDifferent = 0x3716,

        /// <summary>
        /// ERROR_SXS_ASSEMBLY_IS_NOT_A_DEPLOYMENT
        /// The assembly is not a deployment.
        /// </summary>
        SxsAssemblyIsNotADeployment = 0x3717,

        /// <summary>
        /// ERROR_SXS_FILE_NOT_PART_OF_ASSEMBLY
        /// The file is not a part of the assembly.
        /// </summary>
        SxsFileNotPartOfAssembly = 0x3718,

        /// <summary>
        /// ERROR_SXS_MANIFEST_TOO_BIG
        /// The size of the manifest exceeds the maximum allowed.
        /// </summary>
        SxsManifestTooBig = 0x3719,

        /// <summary>
        /// ERROR_SXS_SETTING_NOT_REGISTERED
        /// The setting is not registered.
        /// </summary>
        SxsSettingNotRegistered = 0x371A,

        /// <summary>
        /// ERROR_SXS_TRANSACTION_CLOSURE_INCOMPLETE
        /// One or more required members of the transaction are not present.
        /// </summary>
        SxsTransactionClosureIncomplete = 0x371B,

        /// <summary>
        /// ERROR_SMI_PRIMITIVE_INSTALLER_FAILED
        /// The SMI primitive installer failed during setup or servicing.
        /// </summary>
        SmiPrimitiveInstallerFailed = 0x371C,

        /// <summary>
        /// ERROR_GENERIC_COMMAND_FAILED
        /// A generic command executable returned a result that indicates failure.
        /// </summary>
        GenericCommandFailed = 0x371D,

        /// <summary>
        /// ERROR_SXS_FILE_HASH_MISSING
        /// A component is missing file verification information in its manifest.
        /// </summary>
        SxsFileHashMissing = 0x371E,

        /// <summary>
        /// ERROR_EVT_INVALID_CHANNEL_PATH
        /// The specified channel path is invalid.
        /// </summary>
        EvtInvalidChannelPath = 0x3A98,

        /// <summary>
        /// ERROR_EVT_INVALID_QUERY
        /// The specified query is invalid.
        /// </summary>
        EvtInvalidQuery = 0x3A99,

        /// <summary>
        /// ERROR_EVT_PUBLISHER_METADATA_NOT_FOUND
        /// The publisher metadata cannot be found in the resource.
        /// </summary>
        EvtPublisherMetadataNotFound = 0x3A9A,

        /// <summary>
        /// ERROR_EVT_EVENT_TEMPLATE_NOT_FOUND
        /// The template for an event definition cannot be found in the resource (error = %1).
        /// </summary>
        EvtEventTemplateNotFound = 0x3A9B,

        /// <summary>
        /// ERROR_EVT_INVALID_PUBLISHER_NAME
        /// The specified publisher name is invalid.
        /// </summary>
        EvtInvalidPublisherName = 0x3A9C,

        /// <summary>
        /// ERROR_EVT_INVALID_EVENT_DATA
        /// The event data raised by the publisher is not compatible with the event template definition in the publisher's manifest.
        /// </summary>
        EvtInvalidEventData = 0x3A9D,

        /// <summary>
        /// ERROR_EVT_CHANNEL_NOT_FOUND
        /// The specified channel could not be found. Check channel configuration.
        /// </summary>
        EvtChannelNotFound = 0x3A9F,

        /// <summary>
        /// ERROR_EVT_MALFORMED_XML_TEXT
        /// The specified xml text was not well-formed. See Extended Error for more details.
        /// </summary>
        EvtMalformedXmlText = 0x3AA0,

        /// <summary>
        /// ERROR_EVT_SUBSCRIPTION_TO_DIRECT_CHANNEL
        /// The caller is trying to subscribe to a direct channel which is not allowed. The events for a direct channel go directly to a logfile and cannot be subscribed to.
        /// </summary>
        EvtSubscriptionToDirectChannel = 0x3AA1,

        /// <summary>
        /// ERROR_EVT_CONFIGURATION_ERROR
        /// Configuration error.
        /// </summary>
        EvtConfigurationError = 0x3AA2,

        /// <summary>
        /// ERROR_EVT_QUERY_RESULT_STALE
        /// The query result is stale / invalid. This may be due to the log being cleared or rolling over after the query result was created. Users should handle this code by releasing the query result object and reissuing the query.
        /// </summary>
        EvtQueryResultStale = 0x3AA3,

        /// <summary>
        /// ERROR_EVT_QUERY_RESULT_INVALID_POSITION
        /// Query result is currently at an invalid position.
        /// </summary>
        EvtQueryResultInvalidPosition = 0x3AA4,

        /// <summary>
        /// ERROR_EVT_NON_VALIDATING_MSXML
        /// Registered MSXML doesn't support validation.
        /// </summary>
        EvtNonValidatingMsxml = 0x3AA5,

        /// <summary>
        /// ERROR_EVT_FILTER_ALREADYSCOPED
        /// An expression can only be followed by a change of scope operation if it itself evaluates to a node set and is not already part of some other change of scope operation.
        /// </summary>
        EvtFilterAlreadyscoped = 0x3AA6,

        /// <summary>
        /// ERROR_EVT_FILTER_NOTELTSET
        /// Can't perform a step operation from a term that does not represent an element set.
        /// </summary>
        EvtFilterNoteltset = 0x3AA7,

        /// <summary>
        /// ERROR_EVT_FILTER_INVARG
        /// Left hand side arguments to binary operators must be either attributes, nodes or variables and right hand side arguments must be constants.
        /// </summary>
        EvtFilterInvarg = 0x3AA8,

        /// <summary>
        /// ERROR_EVT_FILTER_INVTEST
        /// A step operation must involve either a node test or, in the case of a predicate, an algebraic expression against which to test each node in the node set identified by the preceeding node set can be evaluated.
        /// </summary>
        EvtFilterInvtest = 0x3AA9,

        /// <summary>
        /// ERROR_EVT_FILTER_INVTYPE
        /// This data type is currently unsupported.
        /// </summary>
        EvtFilterInvtype = 0x3AAA,

        /// <summary>
        /// ERROR_EVT_FILTER_PARSEERR
        /// A syntax error occurred at position %1!d!.
        /// </summary>
        EvtFilterParseerr = 0x3AAB,

        /// <summary>
        /// ERROR_EVT_FILTER_UNSUPPORTEDOP
        /// This operator is unsupported by this implementation of the filter.
        /// </summary>
        EvtFilterUnsupportedop = 0x3AAC,

        /// <summary>
        /// ERROR_EVT_FILTER_UNEXPECTEDTOKEN
        /// The token encountered was unexpected.
        /// </summary>
        EvtFilterUnexpectedtoken = 0x3AAD,

        /// <summary>
        /// ERROR_EVT_INVALID_OPERATION_OVER_ENABLED_DIRECT_CHANNEL
        /// The requested operation cannot be performed over an enabled direct channel. The channel must first be disabled before performing the requested operation.
        /// </summary>
        EvtInvalidOperationOverEnabledDirectChannel = 0x3AAE,

        /// <summary>
        /// ERROR_EVT_INVALID_CHANNEL_PROPERTY_VALUE
        /// Channel property %1!s! contains invalid value. The value has invalid type, is outside of valid range, can't be updated or is not supported by this type of channel.
        /// </summary>
        EvtInvalidChannelPropertyValue = 0x3AAF,

        /// <summary>
        /// ERROR_EVT_INVALID_PUBLISHER_PROPERTY_VALUE
        /// Publisher property %1!s! contains invalid value. The value has invalid type, is outside of valid range, can't be updated or is not supported by this type of publisher.
        /// </summary>
        EvtInvalidPublisherPropertyValue = 0x3AB0,

        /// <summary>
        /// ERROR_EVT_CHANNEL_CANNOT_ACTIVATE
        /// The channel fails to activate.
        /// </summary>
        EvtChannelCannotActivate = 0x3AB1,

        /// <summary>
        /// ERROR_EVT_FILTER_TOO_COMPLEX
        /// The xpath expression exceeded supported complexity. Please symplify it or split it into two or more simple expressions.
        /// </summary>
        EvtFilterTooComplex = 0x3AB2,

        /// <summary>
        /// ERROR_EVT_MESSAGE_NOT_FOUND
        /// the message resource is present but the message is not found in the string/message table.
        /// </summary>
        EvtMessageNotFound = 0x3AB3,

        /// <summary>
        /// ERROR_EVT_MESSAGE_ID_NOT_FOUND
        /// The message id for the desired message could not be found.
        /// </summary>
        EvtMessageIdNotFound = 0x3AB4,

        /// <summary>
        /// ERROR_EVT_UNRESOLVED_VALUE_INSERT
        /// The substitution string for insert index (%1) could not be found.
        /// </summary>
        EvtUnresolvedValueInsert = 0x3AB5,

        /// <summary>
        /// ERROR_EVT_UNRESOLVED_PARAMETER_INSERT
        /// The description string for parameter reference (%1) could not be found.
        /// </summary>
        EvtUnresolvedParameterInsert = 0x3AB6,

        /// <summary>
        /// ERROR_EVT_MAX_INSERTS_REACHED
        /// The maximum number of replacements has been reached.
        /// </summary>
        EvtMaxInsertsReached = 0x3AB7,

        /// <summary>
        /// ERROR_EVT_EVENT_DEFINITION_NOT_FOUND
        /// The event definition could not be found for event id (%1).
        /// </summary>
        EvtEventDefinitionNotFound = 0x3AB8,

        /// <summary>
        /// ERROR_EVT_MESSAGE_LOCALE_NOT_FOUND
        /// The locale specific resource for the desired message is not present.
        /// </summary>
        EvtMessageLocaleNotFound = 0x3AB9,

        /// <summary>
        /// ERROR_EVT_VERSION_TOO_OLD
        /// The resource is too old to be compatible.
        /// </summary>
        EvtVersionTooOld = 0x3ABA,

        /// <summary>
        /// ERROR_EVT_VERSION_TOO_NEW
        /// The resource is too new to be compatible.
        /// </summary>
        EvtVersionTooNew = 0x3ABB,

        /// <summary>
        /// ERROR_EVT_CANNOT_OPEN_CHANNEL_OF_QUERY
        /// The channel at index %1!d! of the query can't be opened.
        /// </summary>
        EvtCannotOpenChannelOfQuery = 0x3ABC,

        /// <summary>
        /// ERROR_EVT_PUBLISHER_DISABLED
        /// The publisher has been disabled and its resource is not available. This usually occurs when the publisher is in the process of being uninstalled or upgraded.
        /// </summary>
        EvtPublisherDisabled = 0x3ABD,

        /// <summary>
        /// ERROR_EVT_FILTER_OUT_OF_RANGE
        /// Attempted to create a numeric type that is outside of its valid range.
        /// </summary>
        EvtFilterOutOfRange = 0x3ABE,

        /// <summary>
        /// ERROR_EC_SUBSCRIPTION_CANNOT_ACTIVATE
        /// The subscription fails to activate.
        /// </summary>
        EcSubscriptionCannotActivate = 0x3AE8,

        /// <summary>
        /// ERROR_EC_LOG_DISABLED
        /// The log of the subscription is in disabled state, and cannot be used to forward events to. The log must first be enabled before the subscription can be activated.
        /// </summary>
        EcLogDisabled = 0x3AE9,

        /// <summary>
        /// ERROR_EC_CIRCULAR_FORWARDING
        /// When forwarding events from local machine to itself, the query of the subscription can't contain target log of the subscription.
        /// </summary>
        EcCircularForwarding = 0x3AEA,

        /// <summary>
        /// ERROR_EC_CREDSTORE_FULL
        /// The credential store that is used to save credentials is full.
        /// </summary>
        EcCredstoreFull = 0x3AEB,

        /// <summary>
        /// ERROR_EC_CRED_NOT_FOUND
        /// The credential used by this subscription can't be found in credential store.
        /// </summary>
        EcCredNotFound = 0x3AEC,

        /// <summary>
        /// ERROR_EC_NO_ACTIVE_CHANNEL
        /// No active channel is found for the query.
        /// </summary>
        EcNoActiveChannel = 0x3AED,

        /// <summary>
        /// ERROR_MUI_FILE_NOT_FOUND
        /// The resource loader failed to find MUI file.
        /// </summary>
        MuiFileNotFound = 0x3AFC,

        /// <summary>
        /// ERROR_MUI_INVALID_FILE
        /// The resource loader failed to load MUI file because the file fail to pass validation.
        /// </summary>
        MuiInvalidFile = 0x3AFD,

        /// <summary>
        /// ERROR_MUI_INVALID_RC_CONFIG
        /// The RC Manifest is corrupted with garbage data or unsupported version or missing required item.
        /// </summary>
        MuiInvalidRcConfig = 0x3AFE,

        /// <summary>
        /// ERROR_MUI_INVALID_LOCALE_NAME
        /// The RC Manifest has invalid culture name.
        /// </summary>
        MuiInvalidLocaleName = 0x3AFF,

        /// <summary>
        /// ERROR_MUI_INVALID_ULTIMATEFALLBACK_NAME
        /// The RC Manifest has invalid ultimatefallback name.
        /// </summary>
        MuiInvalidUltimatefallbackName = 0x3B00,

        /// <summary>
        /// ERROR_MUI_FILE_NOT_LOADED
        /// The resource loader cache doesn't have loaded MUI entry.
        /// </summary>
        MuiFileNotLoaded = 0x3B01,

        /// <summary>
        /// ERROR_RESOURCE_ENUM_USER_STOP
        /// User stopped resource enumeration.
        /// </summary>
        ResourceEnumUserStop = 0x3B02,

        /// <summary>
        /// ERROR_MUI_INTLSETTINGS_UILANG_NOT_INSTALLED
        /// UI language installation failed.
        /// </summary>
        MuiIntlsettingsUilangNotInstalled = 0x3B03,

        /// <summary>
        /// ERROR_MUI_INTLSETTINGS_INVALID_LOCALE_NAME
        /// Locale installation failed.
        /// </summary>
        MuiIntlsettingsInvalidLocaleName = 0x3B04,

        /// <summary>
        /// ERROR_MRM_RUNTIME_NO_DEFAULT_OR_NEUTRAL_RESOURCE
        /// A resource does not have default or neutral value.
        /// </summary>
        MrmRuntimeNoDefaultOrNeutralResource = 0x3B06,

        /// <summary>
        /// ERROR_MRM_INVALID_PRICONFIG
        /// Invalid PRI config file.
        /// </summary>
        MrmInvalidPriconfig = 0x3B07,

        /// <summary>
        /// ERROR_MRM_INVALID_FILE_TYPE
        /// Invalid file type.
        /// </summary>
        MrmInvalidFileType = 0x3B08,

        /// <summary>
        /// ERROR_MRM_UNKNOWN_QUALIFIER
        /// Unknown qualifier.
        /// </summary>
        MrmUnknownQualifier = 0x3B09,

        /// <summary>
        /// ERROR_MRM_INVALID_QUALIFIER_VALUE
        /// Invalid qualifier value.
        /// </summary>
        MrmInvalidQualifierValue = 0x3B0A,

        /// <summary>
        /// ERROR_MRM_NO_CANDIDATE
        /// No Candidate found.
        /// </summary>
        MrmNoCandidate = 0x3B0B,

        /// <summary>
        /// ERROR_MRM_NO_MATCH_OR_DEFAULT_CANDIDATE
        /// The ResourceMap or NamedResource has an item that does not have default or neutral resource..
        /// </summary>
        MrmNoMatchOrDefaultCandidate = 0x3B0C,

        /// <summary>
        /// ERROR_MRM_RESOURCE_TYPE_MISMATCH
        /// Invalid ResourceCandidate type.
        /// </summary>
        MrmResourceTypeMismatch = 0x3B0D,

        /// <summary>
        /// ERROR_MRM_DUPLICATE_MAP_NAME
        /// Duplicate Resource Map.
        /// </summary>
        MrmDuplicateMapName = 0x3B0E,

        /// <summary>
        /// ERROR_MRM_DUPLICATE_ENTRY
        /// Duplicate Entry.
        /// </summary>
        MrmDuplicateEntry = 0x3B0F,

        /// <summary>
        /// ERROR_MRM_INVALID_RESOURCE_IDENTIFIER
        /// Invalid Resource Identifier.
        /// </summary>
        MrmInvalidResourceIdentifier = 0x3B10,

        /// <summary>
        /// ERROR_MRM_FILEPATH_TOO_LONG
        /// Filepath too long.
        /// </summary>
        MrmFilepathTooLong = 0x3B11,

        /// <summary>
        /// ERROR_MRM_UNSUPPORTED_DIRECTORY_TYPE
        /// Unsupported directory type.
        /// </summary>
        MrmUnsupportedDirectoryType = 0x3B12,

        /// <summary>
        /// ERROR_MRM_INVALID_PRI_FILE
        /// Invalid PRI File.
        /// </summary>
        MrmInvalidPriFile = 0x3B16,

        /// <summary>
        /// ERROR_MRM_NAMED_RESOURCE_NOT_FOUND
        /// NamedResource Not Found.
        /// </summary>
        MrmNamedResourceNotFound = 0x3B17,

        /// <summary>
        /// ERROR_MRM_MAP_NOT_FOUND
        /// ResourceMap Not Found.
        /// </summary>
        MrmMapNotFound = 0x3B1F,

        /// <summary>
        /// ERROR_MRM_UNSUPPORTED_PROFILE_TYPE
        /// Unsupported MRT profile type.
        /// </summary>
        MrmUnsupportedProfileType = 0x3B20,

        /// <summary>
        /// ERROR_MRM_INVALID_QUALIFIER_OPERATOR
        /// Invalid qualifier operator.
        /// </summary>
        MrmInvalidQualifierOperator = 0x3B21,

        /// <summary>
        /// ERROR_MRM_INDETERMINATE_QUALIFIER_VALUE
        /// Unable to determine qualifier value or qualifier value has not been set.
        /// </summary>
        MrmIndeterminateQualifierValue = 0x3B22,

        /// <summary>
        /// ERROR_MRM_AUTOMERGE_ENABLED
        /// Automerge is enabled in the PRI file.
        /// </summary>
        MrmAutomergeEnabled = 0x3B23,

        /// <summary>
        /// ERROR_MRM_TOO_MANY_RESOURCES
        /// Too many resources defined for package.
        /// </summary>
        MrmTooManyResources = 0x3B24,

        /// <summary>
        /// ERROR_MCA_INVALID_CAPABILITIES_STRING
        /// The monitor returned a DDC/CI capabilities string that did not comply with the ACCESS.bus 3.0, DDC/CI 1.1 or MCCS 2 Revision 1 specification.
        /// </summary>
        McaInvalidCapabilitiesString = 0x3B60,

        /// <summary>
        /// ERROR_MCA_INVALID_VCP_VERSION
        /// The monitor's VCP Version (0xDF) VCP code returned an invalid version value.
        /// </summary>
        McaInvalidVcpVersion = 0x3B61,

        /// <summary>
        /// ERROR_MCA_MONITOR_VIOLATES_MCCS_SPECIFICATION
        /// The monitor does not comply with the MCCS specification it claims to support.
        /// </summary>
        McaMonitorViolatesMccsSpecification = 0x3B62,

        /// <summary>
        /// ERROR_MCA_MCCS_VERSION_MISMATCH
        /// The MCCS version in a monitor's mccs_ver capability does not match the MCCS version the monitor reports when the VCP Version (0xDF) VCP code is used.
        /// </summary>
        McaMccsVersionMismatch = 0x3B63,

        /// <summary>
        /// ERROR_MCA_UNSUPPORTED_MCCS_VERSION
        /// The Monitor Configuration API only works with monitors that support the MCCS 1.0 specification, MCCS 2.0 specification or the MCCS 2.0 Revision 1 specification.
        /// </summary>
        McaUnsupportedMccsVersion = 0x3B64,

        /// <summary>
        /// ERROR_MCA_INTERNAL_ERROR
        /// An internal Monitor Configuration API error occurred.
        /// </summary>
        McaInternalError = 0x3B65,

        /// <summary>
        /// ERROR_MCA_INVALID_TECHNOLOGY_TYPE_RETURNED
        /// The monitor returned an invalid monitor technology type. CRT, Plasma and LCD (TFT) are examples of monitor technology types. This error implies that the monitor violated the MCCS 2.0 or MCCS 2.0 Revision 1 specification.
        /// </summary>
        McaInvalidTechnologyTypeReturned = 0x3B66,

        /// <summary>
        /// ERROR_MCA_UNSUPPORTED_COLOR_TEMPERATURE
        /// The caller of SetMonitorColorTemperature specified a color temperature that the current monitor did not support. This error implies that the monitor violated the MCCS 2.0 or MCCS 2.0 Revision 1 specification.
        /// </summary>
        McaUnsupportedColorTemperature = 0x3B67,

        /// <summary>
        /// ERROR_AMBIGUOUS_SYSTEM_DEVICE
        /// The requested system device cannot be identified due to multiple indistinguishable devices potentially matching the identification criteria.
        /// </summary>
        AmbiguousSystemDevice = 0x3B92,

        /// <summary>
        /// ERROR_SYSTEM_DEVICE_NOT_FOUND
        /// The requested system device cannot be found.
        /// </summary>
        SystemDeviceNotFound = 0x3BC3,

        /// <summary>
        /// ERROR_HASH_NOT_SUPPORTED
        /// Hash generation for the specified hash version and hash type is not enabled on the server.
        /// </summary>
        HashNotSupported = 0x3BC4,

        /// <summary>
        /// ERROR_HASH_NOT_PRESENT
        /// The hash requested from the server is not available or no longer valid.
        /// </summary>
        HashNotPresent = 0x3BC5,

        /// <summary>
        /// ERROR_SECONDARY_IC_PROVIDER_NOT_REGISTERED
        /// The secondary interrupt controller instance that manages the specified interrupt is not registered.
        /// </summary>
        SecondaryIcProviderNotRegistered = 0x3BD9,

        /// <summary>
        /// ERROR_GPIO_CLIENT_INFORMATION_INVALID
        /// The information supplied by the GPIO client driver is invalid.
        /// </summary>
        GpioClientInformationInvalid = 0x3BDA,

        /// <summary>
        /// ERROR_GPIO_VERSION_NOT_SUPPORTED
        /// The version specified by the GPIO client driver is not supported.
        /// </summary>
        GpioVersionNotSupported = 0x3BDB,

        /// <summary>
        /// ERROR_GPIO_INVALID_REGISTRATION_PACKET
        /// The registration packet supplied by the GPIO client driver is not valid.
        /// </summary>
        GpioInvalidRegistrationPacket = 0x3BDC,

        /// <summary>
        /// ERROR_GPIO_OPERATION_DENIED
        /// The requested operation is not supported for the specified handle.
        /// </summary>
        GpioOperationDenied = 0x3BDD,

        /// <summary>
        /// ERROR_GPIO_INCOMPATIBLE_CONNECT_MODE
        /// The requested connect mode conflicts with an existing mode on one or more of the specified pins.
        /// </summary>
        GpioIncompatibleConnectMode = 0x3BDE,

        /// <summary>
        /// ERROR_GPIO_INTERRUPT_ALREADY_UNMASKED
        /// The interrupt requested to be unmasked is not masked.
        /// </summary>
        GpioInterruptAlreadyUnmasked = 0x3BDF,

        /// <summary>
        /// ERROR_CANNOT_SWITCH_RUNLEVEL
        /// The requested run level switch cannot be completed successfully.
        /// </summary>
        CannotSwitchRunlevel = 0x3C28,

        /// <summary>
        /// ERROR_INVALID_RUNLEVEL_SETTING
        /// The service has an invalid run level setting. The run level for a service must not be higher than the run level of its dependent services.
        /// </summary>
        InvalidRunlevelSetting = 0x3C29,

        /// <summary>
        /// ERROR_RUNLEVEL_SWITCH_TIMEOUT
        /// The requested run level switch cannot be completed successfully since one or more services will not stop or restart within the specified timeout.
        /// </summary>
        RunlevelSwitchTimeout = 0x3C2A,

        /// <summary>
        /// ERROR_RUNLEVEL_SWITCH_AGENT_TIMEOUT
        /// A run level switch agent did not respond within the specified timeout.
        /// </summary>
        RunlevelSwitchAgentTimeout = 0x3C2B,

        /// <summary>
        /// ERROR_RUNLEVEL_SWITCH_IN_PROGRESS
        /// A run level switch is currently in progress.
        /// </summary>
        RunlevelSwitchInProgress = 0x3C2C,

        /// <summary>
        /// ERROR_SERVICES_FAILED_AUTOSTART
        /// One or more services failed to start during the service startup phase of a run level switch.
        /// </summary>
        ServicesFailedAutostart = 0x3C2D,

        /// <summary>
        /// ERROR_COM_TASK_STOP_PENDING
        /// The task stop request cannot be completed immediately since task needs more time to shutdown.
        /// </summary>
        ComTaskStopPending = 0x3C8D,

        /// <summary>
        /// ERROR_INSTALL_OPEN_PACKAGE_FAILED
        /// Package could not be opened.
        /// </summary>
        InstallOpenPackageFailed = 0x3CF0,

        /// <summary>
        /// ERROR_INSTALL_PACKAGE_NOT_FOUND
        /// Package was not found.
        /// </summary>
        InstallPackageNotFound = 0x3CF1,

        /// <summary>
        /// ERROR_INSTALL_INVALID_PACKAGE
        /// Package data is invalid.
        /// </summary>
        InstallInvalidPackage = 0x3CF2,

        /// <summary>
        /// ERROR_INSTALL_RESOLVE_DEPENDENCY_FAILED
        /// Package failed updates, dependency or conflict validation.
        /// </summary>
        InstallResolveDependencyFailed = 0x3CF3,

        /// <summary>
        /// ERROR_INSTALL_OUT_OF_DISK_SPACE
        /// There is not enough disk space on your computer. Please free up some space and try again.
        /// </summary>
        InstallOutOfDiskSpace = 0x3CF4,

        /// <summary>
        /// ERROR_INSTALL_NETWORK_FAILURE
        /// There was a problem downloading your product.
        /// </summary>
        InstallNetworkFailure = 0x3CF5,

        /// <summary>
        /// ERROR_INSTALL_REGISTRATION_FAILURE
        /// Package could not be registered.
        /// </summary>
        InstallRegistrationFailure = 0x3CF6,

        /// <summary>
        /// ERROR_INSTALL_DEREGISTRATION_FAILURE
        /// Package could not be unregistered.
        /// </summary>
        InstallDeregistrationFailure = 0x3CF7,

        /// <summary>
        /// ERROR_INSTALL_CANCEL
        /// User cancelled the install request.
        /// </summary>
        InstallCancel = 0x3CF8,

        /// <summary>
        /// ERROR_INSTALL_FAILED
        /// Install failed. Please contact your software vendor.
        /// </summary>
        InstallFailed = 0x3CF9,

        /// <summary>
        /// ERROR_REMOVE_FAILED
        /// Removal failed. Please contact your software vendor.
        /// </summary>
        RemoveFailed = 0x3CFA,

        /// <summary>
        /// ERROR_PACKAGE_ALREADY_EXISTS
        /// The provided package is already installed, and reinstallation of the package was blocked. Check the AppXDeployment-Server event log for details.
        /// </summary>
        PackageAlreadyExists = 0x3CFB,

        /// <summary>
        /// ERROR_NEEDS_REMEDIATION
        /// The application cannot be started. Try reinstalling the application to fix the problem.
        /// </summary>
        NeedsRemediation = 0x3CFC,

        /// <summary>
        /// ERROR_INSTALL_PREREQUISITE_FAILED
        /// A Prerequisite for an install could not be satisfied.
        /// </summary>
        InstallPrerequisiteFailed = 0x3CFD,

        /// <summary>
        /// ERROR_PACKAGE_REPOSITORY_CORRUPTED
        /// The package repository is corrupted.
        /// </summary>
        PackageRepositoryCorrupted = 0x3CFE,

        /// <summary>
        /// ERROR_INSTALL_POLICY_FAILURE
        /// To install this application you need either a Windows developer license or a sideloading-enabled system.
        /// </summary>
        InstallPolicyFailure = 0x3CFF,

        /// <summary>
        /// ERROR_PACKAGE_UPDATING
        /// The application cannot be started because it is currently updating.
        /// </summary>
        PackageUpdating = 0x3D00,

        /// <summary>
        /// ERROR_DEPLOYMENT_BLOCKED_BY_POLICY
        /// The package deployment operation is blocked by policy. Please contact your system administrator.
        /// </summary>
        DeploymentBlockedByPolicy = 0x3D01,

        /// <summary>
        /// ERROR_PACKAGES_IN_USE
        /// The package could not be installed because resources it modifies are currently in use.
        /// </summary>
        PackagesInUse = 0x3D02,

        /// <summary>
        /// ERROR_RECOVERY_FILE_CORRUPT
        /// The package could not be recovered because necessary data for recovery have been corrupted.
        /// </summary>
        RecoveryFileCorrupt = 0x3D03,

        /// <summary>
        /// ERROR_INVALID_STAGED_SIGNATURE
        /// The signature is invalid. To register in developer mode, AppxSignature.p7x and AppxBlockMap.xml must be valid or should not be present.
        /// </summary>
        InvalidStagedSignature = 0x3D04,

        /// <summary>
        /// ERROR_DELETING_EXISTING_APPLICATIONDATA_STORE_FAILED
        /// An error occurred while deleting the package's previously existing application data.
        /// </summary>
        DeletingExistingApplicationdataStoreFailed = 0x3D05,

        /// <summary>
        /// ERROR_INSTALL_PACKAGE_DOWNGRADE
        /// The package could not be installed because a higher version of this package is already installed.
        /// </summary>
        InstallPackageDowngrade = 0x3D06,

        /// <summary>
        /// ERROR_SYSTEM_NEEDS_REMEDIATION
        /// An error in a system binary was detected. Try refreshing the PC to fix the problem.
        /// </summary>
        SystemNeedsRemediation = 0x3D07,

        /// <summary>
        /// ERROR_APPX_INTEGRITY_FAILURE_CLR_NGEN
        /// A corrupted CLR NGEN binary was detected on the system.
        /// </summary>
        AppxIntegrityFailureClrNgen = 0x3D08,

        /// <summary>
        /// ERROR_RESILIENCY_FILE_CORRUPT
        /// The operation could not be resumed because necessary data for recovery have been corrupted.
        /// </summary>
        ResiliencyFileCorrupt = 0x3D09,

        /// <summary>
        /// ERROR_INSTALL_FIREWALL_SERVICE_NOT_RUNNING
        /// The package could not be installed because the Windows Firewall service is not running. Enable the Windows Firewall service and try again.
        /// </summary>
        InstallFirewallServiceNotRunning = 0x3D0A,

        /// <summary>
        /// APPMODEL_ERROR_NO_PACKAGE
        /// The process has no package identity.
        /// </summary>
        AppmodelErrorNoPackage = 0x3D54,

        /// <summary>
        /// APPMODEL_ERROR_PACKAGE_RUNTIME_CORRUPT
        /// The package runtime information is corrupted.
        /// </summary>
        AppmodelErrorPackageRuntimeCorrupt = 0x3D55,

        /// <summary>
        /// APPMODEL_ERROR_PACKAGE_IDENTITY_CORRUPT
        /// The package identity is corrupted.
        /// </summary>
        AppmodelErrorPackageIdentityCorrupt = 0x3D56,

        /// <summary>
        /// APPMODEL_ERROR_NO_APPLICATION
        /// The process has no application identity.
        /// </summary>
        AppmodelErrorNoApplication = 0x3D57,

        /// <summary>
        /// ERROR_STATE_LOAD_STORE_FAILED
        /// Loading the state store failed.
        /// </summary>
        StateLoadStoreFailed = 0x3DB8,

        /// <summary>
        /// ERROR_STATE_GET_VERSION_FAILED
        /// Retrieving the state version for the application failed.
        /// </summary>
        StateGetVersionFailed = 0x3DB9,

        /// <summary>
        /// ERROR_STATE_SET_VERSION_FAILED
        /// Setting the state version for the application failed.
        /// </summary>
        StateSetVersionFailed = 0x3DBA,

        /// <summary>
        /// ERROR_STATE_STRUCTURED_RESET_FAILED
        /// Resetting the structured state of the application failed.
        /// </summary>
        StateStructuredResetFailed = 0x3DBB,

        /// <summary>
        /// ERROR_STATE_OPEN_CONTAINER_FAILED
        /// State Manager failed to open the container.
        /// </summary>
        StateOpenContainerFailed = 0x3DBC,

        /// <summary>
        /// ERROR_STATE_CREATE_CONTAINER_FAILED
        /// State Manager failed to create the container.
        /// </summary>
        StateCreateContainerFailed = 0x3DBD,

        /// <summary>
        /// ERROR_STATE_DELETE_CONTAINER_FAILED
        /// State Manager failed to delete the container.
        /// </summary>
        StateDeleteContainerFailed = 0x3DBE,

        /// <summary>
        /// ERROR_STATE_READ_SETTING_FAILED
        /// State Manager failed to read the setting.
        /// </summary>
        StateReadSettingFailed = 0x3DBF,

        /// <summary>
        /// ERROR_STATE_WRITE_SETTING_FAILED
        /// State Manager failed to write the setting.
        /// </summary>
        StateWriteSettingFailed = 0x3DC0,

        /// <summary>
        /// ERROR_STATE_DELETE_SETTING_FAILED
        /// State Manager failed to delete the setting.
        /// </summary>
        StateDeleteSettingFailed = 0x3DC1,

        /// <summary>
        /// ERROR_STATE_QUERY_SETTING_FAILED
        /// State Manager failed to query the setting.
        /// </summary>
        StateQuerySettingFailed = 0x3DC2,

        /// <summary>
        /// ERROR_STATE_READ_COMPOSITE_SETTING_FAILED
        /// State Manager failed to read the composite setting.
        /// </summary>
        StateReadCompositeSettingFailed = 0x3DC3,

        /// <summary>
        /// ERROR_STATE_WRITE_COMPOSITE_SETTING_FAILED
        /// State Manager failed to write the composite setting.
        /// </summary>
        StateWriteCompositeSettingFailed = 0x3DC4,

        /// <summary>
        /// ERROR_STATE_ENUMERATE_CONTAINER_FAILED
        /// State Manager failed to enumerate the containers.
        /// </summary>
        StateEnumerateContainerFailed = 0x3DC5,

        /// <summary>
        /// ERROR_STATE_ENUMERATE_SETTINGS_FAILED
        /// State Manager failed to enumerate the settings.
        /// </summary>
        StateEnumerateSettingsFailed = 0x3DC6,

        /// <summary>
        /// ERROR_STATE_COMPOSITE_SETTING_VALUE_SIZE_LIMIT_EXCEEDED
        /// The size of the state manager composite setting value has exceeded the limit.
        /// </summary>
        StateCompositeSettingValueSizeLimitExceeded = 0x3DC7,

        /// <summary>
        /// ERROR_STATE_SETTING_VALUE_SIZE_LIMIT_EXCEEDED
        /// The size of the state manager setting value has exceeded the limit.
        /// </summary>
        StateSettingValueSizeLimitExceeded = 0x3DC8,

        /// <summary>
        /// ERROR_STATE_SETTING_NAME_SIZE_LIMIT_EXCEEDED
        /// The length of the state manager setting name has exceeded the limit.
        /// </summary>
        StateSettingNameSizeLimitExceeded = 0x3DC9,

        /// <summary>
        /// ERROR_STATE_CONTAINER_NAME_SIZE_LIMIT_EXCEEDED
        /// The length of the state manager container name has exceeded the limit.
        /// </summary>
        StateContainerNameSizeLimitExceeded = 0x3DCA,

        /// <summary>
        /// ERROR_API_UNAVAILABLE
        /// This API cannot be used in the context of the caller's application type.
        /// </summary>
        ApiUnavailable = 0x3DE1
    }
}