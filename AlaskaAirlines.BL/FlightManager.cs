using System;
using System.Collections.Generic;
using System.Text;
using AlaskaAirlines.BL.Models;
using AlaskaAirlines.DAL;

namespace AlaskaAirlines.BL
{
    public class FlightManager
    {
        private static FlightManager _instance;

        private const String FLIGHTS_FILEPATH = "c:\\users\\paul\\documents\\visual studio 2017\\Projects\\AlaskaAirlines\\AlaskaAirlines\\flights.csv";

        public static FlightManager Instance => _instance ?? (_instance = new FlightManager());

        public List<Flight> flights { get; }

        private FlightManager()
        {
            flights = GetFlights(FLIGHTS_FILEPATH);
        }

        private List<Flight> GetFlights(String absoluteFilePath)
        {
            return CSVParser.LoadCsv<Flight>(absoluteFilePath);
        }
    }
}
