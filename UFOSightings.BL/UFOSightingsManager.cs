using System;
using System.Collections.Generic;
using UFOSightings.DAL;

namespace UFOSightings.BL
{
    public class UFOSightingsManager
    {
        private static UFOSightingsManager _instance;

        private const String AIRPORT_FILEPATH = "C:\\Users\\Paul\\Desktop\\interview-exercise-anubis342\\ufo-sightings.csv";

        public static UFOSightingsManager Instance => _instance ?? (_instance = new UFOSightingsManager());

        public List<Models.UFOSightings> UFOSightings { get; }

        private UFOSightingsManager()
        {
            UFOSightings = GetUFOSightings(AIRPORT_FILEPATH);
        }
        
        private List<Models.UFOSightings> GetUFOSightings(String absoluteFilePath)
        {
            return CSVParser.LoadCsv<Models.UFOSightings>(absoluteFilePath);
        }
    }
}