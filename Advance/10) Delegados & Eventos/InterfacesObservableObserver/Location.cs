namespace InterfacesObservableObserver
{
    public struct Location
    {
        private readonly double lat;
        private readonly double lon;

        public Location(double latitude, double longitude)
        {
            this.lat = latitude;
            this.lon = longitude;
        }

        public double Latitude
        {
            get
            {
                return this.lat;
            }
        }

        public double Longitude
        {
            get
            {
                return this.lon;
            }
        }
    }
}
