using CsvHelper.Configuration;
using Microsoft.VisualBasic;
using PersonApi.Models;
using PersonApi.ModelsDTO;
using Serilog.Core;
using System.Reflection.Metadata;

namespace PersonApi.SeedDataFromFile
{
    public class EmployeeMap : ClassMap<CreateEmployeeDTO>
    {
        public EmployeeMap()
        {
            Map(m => m.IdentityNumber).Name("IdentityNumber");
            Map(m => m.FirstName).Name("FirstName");
            Map(m => m.MiddleName).Name("MiddleName");
            Map(m => m.LastName).Name("LastName");
            Map(m => m.BirthDay).Name("BirthDay");
            Map(m => m.PhoneNumber).Name("PhoneNumber");
            Map(m => m.Province).Name("Province");
            Map(m => m.City).Name("City");
            Map(m => m.District).Name("District");
            Map(m => m.Address).Name("Address");
            Map(m => m.DepartmentId).Name("DepartmentId");
            Map(m => m.PositionId).Name("PositionId");
           
        }

    }
}

