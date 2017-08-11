using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AlaskaAirlines.BL.Models;
using CsvHelper;

namespace AlaskaAirlines.DAL
{
    public class CSVParser
    {
        public static List<T> LoadCsv<T>(String absolutePath)
        {
            using (TextReader fileReader = File.OpenText(absolutePath))
            {
                var csv = new CsvReader(fileReader);
                return csv.GetRecords<T>().ToList();
            }
        }
    }
}
