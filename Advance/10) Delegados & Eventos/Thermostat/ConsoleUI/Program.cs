using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }


    public class HeatSensor : IHeatSensor
    {
        double _warningLevel = 0;
        double _emergencyLevel = 0;
        bool _hasReachedWarningTemperature = false;
        protected EventHandlerList listEventDelegates = new EventHandlerList();

        // Quedé en 08:00 (y me parece que va a pasar igual que antes...)

        public HeatSensor(double warningLevel, double emergencyLevel)
        {
            _warningLevel = warningLevel;
            _emergencyLevel = emergencyLevel;
        }

        event EventHandler<TemperatureEventArgs> IHeatSensor.TemperatureReachesEmergencyLevelEventHandler
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        event EventHandler<TemperatureEventArgs> IHeatSensor.TemperatureReachesWarningLevelEventHandler
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        event EventHandler<TemperatureEventArgs> IHeatSensor.TemperatureFallsBelowWarningLevelEventHandler
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        public void RunHeatSensor()
        {
            throw new NotImplementedException();
        }
    }


    public interface IHeatSensor
    {
        event EventHandler<TemperatureEventArgs> TemperatureReachesEmergencyLevelEventHandler;
        event EventHandler<TemperatureEventArgs> TemperatureReachesWarningLevelEventHandler;
        event EventHandler<TemperatureEventArgs> TemperatureFallsBelowWarningLevelEventHandler;
        void RunHeatSensor();
    }


    public class TemperatureEventArgs : EventArgs
    {
        public double Temperature { get; set; }
        public DateTime CurrentDateTime { get; set; }
    }
}
