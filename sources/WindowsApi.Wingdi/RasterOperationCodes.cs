namespace DustInTheWind.WindowsApi.Wingdi
{
    public static class RasterOperationCodes
    {
        ///// <summary>
        ///// Fills the destination rectangle using the color associated with index 0 in the physical palette. (This color is black for the default physical palette.)
        ///// </summary>
        //public const int BLACKNESS;

        ///// <summary>
        ///// Includes any windows that are layered on top of your window in the resulting image.By default, the image only contains your window.Note that this generally cannot be used for printing device contexts.
        ///// </summary>
        //public const int CAPTUREBLT; // new DWORD(0x00CC0020 | 0x40000000)

        ///// <summary>
        ///// Inverts the destination rectangle.
        ///// </summary>
        //public const int DSTINVERT;

        ///// <summary>
        ///// Merges the colors of the source rectangle with the brush currently selected in hdcDest, by using the Boolean AND operator.
        ///// </summary>
        //public const int MERGECOPY;

        ///// <summary>
        ///// Merges the colors of the inverted source rectangle with the colors of the destination rectangle by using the Boolean OR operator.
        ///// </summary>
        //public const int MERGEPAINT;


        ///// <summary>
        ///// Prevents the bitmap from being mirrored.
        ///// </summary>
        //public const int NOMIRRORBITMAP;

        ///// <summary>
        ///// Copies the inverted source rectangle to the destination.
        ///// </summary>
        //public const int NOTSRCCOPY;

        ///// <summary>
        ///// Combines the colors of the source and destination rectangles by using the Boolean OR operator and then inverts the resultant color.
        ///// </summary>
        //public const int NOTSRCERASE;

        ///// <summary>
        ///// Copies the brush currently selected in hdcDest, into the destination bitmap.
        ///// </summary>
        //public const int PATCOPY;

        ///// <summary>
        ///// Combines the colors of the brush currently selected in hdcDest, with the colors of the destination rectangle by using the Boolean XOR operator.
        ///// </summary>
        //public const int PATINVERT;

        ///// <summary>
        ///// Combines the colors of the brush currently selected in hdcDest, with the colors of the inverted source rectangle by using the Boolean OR operator. The result of this operation is combined with the colors of the destination rectangle by using the Boolean OR operator.
        ///// </summary>
        //public const int PATPAINT;

        ///// <summary>
        ///// Combines the colors of the source and destination rectangles by using the Boolean AND operator.
        ///// </summary>
        //public const int SRCAND;

        /// <summary>
        /// Copies the source rectangle directly to the destination rectangle.
        /// </summary>
        public const int SRCCOPY = 0x00CC0020; // BitBlt dwRop parameter

        ///// <summary>
        ///// Combines the inverted colors of the destination rectangle with the colors of the source rectangle by using the Boolean AND operator.
        ///// </summary>
        //public const int SRCERASE;

        ///// <summary>
        ///// Combines the colors of the source and destination rectangles by using the Boolean XOR operator.
        ///// </summary>
        //public const int SRCINVERT;

        ///// <summary>
        ///// Combines the colors of the source and destination rectangles by using the Boolean OR operator.
        ///// </summary>
        //public const int SRCPAINT;

        ///// <summary>
        ///// Fills the destination rectangle using the color associated with index 1 in the physical palette. (This color is white for the default physical palette.)
        ///// </summary>
        //public const int WHITENESS;
    }
}