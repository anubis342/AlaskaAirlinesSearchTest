using System;
using System.Collections.Generic;
using AlaskaAirlines.BL.Models;
using AlaskaAirlines.DAL;

namespace AlaskaAirlines.BL
{
    public class AirportManager
    {
        private static AirportManager _instance;

        private const String AIRPORT_FILEPATH = "c:\\users\\paul\\documents\\visual studio 2017\\Projects\\AlaskaAirlines\\AlaskaAirlines\\airports.csv";

        public static AirportManager Instance => _instance ?? (_instance = new AirportManager());

        public List<Airport> airports { get; }

        private AirportManager()
        {
            airports = GetAirports(AIRPORT_FILEPATH);
        }
        
        private List<Airport> GetAirports(String absoluteFilePath)
        {
            return CSVParser.LoadCsv<Airport>(absoluteFilePath);
        }
    }
}