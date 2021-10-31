using System;
using System.Runtime.InteropServices;

namespace DustInTheWind.WindowsApi.Wingdi
{
    public class Wingdi
    {
        /// <summary>
        /// The BitBlt function performs a bit-block transfer of the color data
        /// corresponding to a rectangle of pixels from the specified source device
        /// context into a destination device context.
        /// </summary>
        [DllImport("gdi32.dll")]
        public static extern bool BitBlt(IntPtr hObject, int nXDest, int nYDest,
            int nWidth, int nHeight, IntPtr hObjectSource,
            int nXSrc, int nYSrc, int dwRop);

        /// <summary>
        /// The CreateCompatibleBitmap function creates a bitmap compatible with
        /// the device that is associated with the specified device context.
        /// </summary>
        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateCompatibleBitmap(IntPtr hDC, int nWidth, int nHeight);

        /// <summary>
        /// The CreateCompatibleDC function creates a memory device context (DC)
        /// compatible with the specified device.
        /// </summary>
        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateCompatibleDC(IntPtr hDC);

        /// <summary>
        /// The DeleteDC function deletes the specified device context (DC).
        /// </summary>
        [DllImport("gdi32.dll")]
        public static extern bool DeleteDC(IntPtr hDC);

        /// <summary>
        /// The DeleteObject function deletes a logical pen, brush, font, bitmap,
        /// region, or palette, freeing all system resources associated with the object.
        /// After the object is deleted, the specified handle is no longer valid.
        /// </summary>
        [DllImport("gdi32.dll")]
        public static extern bool DeleteObject(IntPtr hObject);

        /// <summary>
        /// The SelectObject function selects an object into the specified device context (DC).
        /// The new object replaces the previous object of the same type.
        /// </summary>
        [DllImport("gdi32.dll")]
        public static extern IntPtr SelectObject(IntPtr hDC, IntPtr hObject);
    }
}
