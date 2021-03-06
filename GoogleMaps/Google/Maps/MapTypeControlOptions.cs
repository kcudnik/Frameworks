namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// Options for the rendering of the map type control.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class MapTypeControlOptions
    {
        /// <summary>
        /// IDs of map types to show in the control.
        /// </summary>
        public Any<string, MapTypeId>[] MapTypeIds;

        /// <summary>
        /// Position id. Used to specify the position of the control on the map. The default position is TOP_RIGHT.
        /// </summary>
        public ControlPosition Position;

        /// <summary>
        /// Style id. Used to select what style of map type control to display
        /// </summary>
        public MapTypeControlStyle Style;
    }
}
