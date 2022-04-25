using System;
using System.Collections.Generic;

namespace HTML_Generator
{
    public class Person 
    {
        public string Name { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var t = new Generic<Person>();

            t.Add(new Person
            {
                Name = "antanas"
            });


            var htmlFormatter = new HTMLFormatter();

            var reportItem = new List<ReportItem>
            {
                new ReportItem
                {
                    AircraftTailNumber = "TEST",
                    ModelNumber = "TEST",
                    ModelDescription = "TEST",
                    OwnerCompanyName = "TEST",
                    CompanyCountryCode = "TEST",
                    CompanyCountryName = "TEST",
                    BelongsToEU = true
                },
                new ReportItem
                {
                    AircraftTailNumber = "TEST2",
                    ModelNumber = "TEST2",
                    ModelDescription = "TEST2",
                    OwnerCompanyName = "TEST2",
                    CompanyCountryCode = "TES2T",
                    CompanyCountryName = "TEST2",
                    BelongsToEU = false
                },
                new ReportItem
                {
                    AircraftTailNumber = "TEST3",
                    ModelNumber = "TEST3",
                    ModelDescription = "TEST3",
                    OwnerCompanyName = "TEST3",
                    CompanyCountryCode = "TEST3",
                    CompanyCountryName = "TEST3",
                    BelongsToEU = true
                }
            };

            var result = htmlFormatter.FormatHTML(reportItem);
        }
    }
}
