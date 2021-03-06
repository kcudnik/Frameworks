namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// Options defining the properties of a StreetViewPanorama object.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class StreetViewPanoramaOptions
    {
        /// <summary>
        /// The enabled/disabled state of the address control.
        /// </summary>
        public bool AddressControl;

        /// <summary>
        /// The display options for the address control.
        /// </summary>
        public StreetViewAddressControlOptions AddressControlOptions;

        /// <summary>
        /// The enabled/disabled state of click-to-go.
        /// </summary>
        public bool ClickToGo;

        /// <summary>
        /// Enables/disables all default UI. May be overridden individually.
        /// </summary>
        public bool DisableDefaultUI;

        /// <summary>
        /// Enables/disables zoom on double click. Disabled by default.
        /// </summary>
        public bool DisableDoubleClickZoom;

        /// <summary>
        /// If true, the close button is displayed. Disabled by default.
        /// </summary>
        public bool EnableCloseButton;

        /// <summary>
        /// The enabled/disabled state of the fullscreen control.
        /// </summary>
        public bool FullscreenControl;

        /// <summary>
        /// The display options for the fullscreen control.
        /// </summary>
        public FullscreenControlOptions FullscreenControlOptions;

        /// <summary>
        /// The enabled/disabled state of the imagery acquisition date control. Disabled by default.
        /// </summary>
        public bool ImageDateControl;

        /// <summary>
        /// The enabled/disabled state of the links control.
        /// </summary>
        public bool LinksControl;

        /// <summary>
        /// The enabled/disabled state of the pan control.
        /// </summary>
        public bool PanControl;

        /// <summary>
        /// The display options for the pan control.
        /// </summary>
        public PanControlOptions PanControlOptions;

        /// <summary>
        /// The panorama ID, which should be set when specifying a custom panorama.
        /// </summary>
        public string Pano;

        /// <summary>
        /// Custom panorama provider, which takes a string pano id and returns an object defining the panorama given that id. This function must be defined to specify custom panorama imagery.
        /// </summary>
        public StreetViewPanoramaData PanoProvider;

        /// <summary>
        /// The LatLng position of the Street View panorama.
        /// </summary>
        public Any<LatLng, LatLngLiteral> Position;

        /// <summary>
        /// The camera orientation, specified as heading and pitch, for the panorama.
        /// </summary>
        public StreetViewPov Pov;

        /// <summary>
        /// If false, disables scrollwheel zooming in Street View. The scrollwheel is enabled by default.
        /// </summary>
        public bool Scrollwheel;

        /// <summary>
        /// If true, the Street View panorama is visible on load.
        /// </summary>
        public bool Visible;

        /// <summary>
        /// The enabled/disabled state of the zoom control.
        /// </summary>
        public bool ZoomControl;

        /// <summary>
        /// The display options for the zoom control.
        /// </summary>
        public ZoomControlOptions ZoomControlOptions;
    }
}
