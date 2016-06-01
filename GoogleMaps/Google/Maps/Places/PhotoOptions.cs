namespace Bridge.Google.Maps.Places
{
    using Bridge;

    /// <summary>
    /// Defines photo-requesting options.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class PhotoOptions
    {
        /// <summary>
        /// The maximum height in pixels of the returned image.
        /// </summary>
        public int MaxHwight;

        /// <summary>
        /// The maximum width in pixels of the returned image.
        /// </summary>
        public int MaxWidth;
    }
}