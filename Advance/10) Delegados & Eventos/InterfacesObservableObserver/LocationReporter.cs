﻿using System;
using static System.Console;

namespace InterfacesObservableObserver
{
    public class LocationReporter : IObserver<Location>
    {
        private IDisposable unsubscriber;
        private string instName;

        public LocationReporter(string name) => this.instName = name;

        public string Name
        {
            get {
                return this.instName;
            }
        }

        public virtual void Subscribe(IObservable<Location> provider)
        {
            if (provider != null) unsubscriber = provider.Subscribe(this);
        }

        public virtual void OnCompleted()
        {
            WriteLine("The Location Tracker has completed transmitting data to {0}.", this.Name);
            this.Unsubscribe();
        }

        public virtual void OnError(Exception e) => WriteLine("{0}: The location cannot be determined.", this.Name);

        public virtual void OnNext(Location value) => WriteLine("{2}: The current location is {0}, {1}", value.Latitude, value.Longitude, this.Name);

        public virtual void Unsubscribe() => unsubscriber.Dispose();
    }
}
