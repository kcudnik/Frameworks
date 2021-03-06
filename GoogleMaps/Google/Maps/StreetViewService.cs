namespace Bridge.Google.Maps
{
    using Bridge;
    using System;

    /// <summary>
    /// A StreetViewService object performs searches for Street View data.
    /// </summary>
    [External]
    [Namespace("google.maps")]
    public class StreetViewService
    {
        /// <summary>
        /// Retrieves the StreetViewPanoramaData for a panorama that matches the supplied Street View query request. The StreetViewPanoramaData is passed to the provided callback.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="callback">The callback.</param>
        public extern void GetPanorama(Any<StreetViewLocationRequest, StreetViewPanoRequest> request, Action <StreetViewPanoramaData, StreetViewStatus> callback);
    }
}