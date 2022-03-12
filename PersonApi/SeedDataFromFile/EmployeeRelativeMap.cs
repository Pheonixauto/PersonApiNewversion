using CsvHelper.Configuration;
using Microsoft.VisualBasic;
using PersonApi.DTO;
using PersonApi.Models;
using PersonApi.ModelsDTO;
using Serilog.Core;
using System.Reflection.Metadata;

namespace PersonApi.SeedDataFromFile
{
    public class EmployeeRelativeMap : ClassMap<ImportEmployeeRelativeDTO>
    {
        public EmployeeRelativeMap()
        {
            Map(m => m.IdentityNumber).Name("IdentityNumberEmp").TypeConverterOption.NullValues("0");
            Map(m => m.FirstName).Name("FirstNameEmp");
            Map(m => m.MiddleName).Name("MiddleNameEmp");
            Map(m => m.LastName).Name("LastNameEmp");
            Map(m => m.BirthDay).Name("BirthDayEmp");
            Map(m => m.PhoneNumber).Name("PhoneNumberEmp");
            Map(m => m.Province).Name("ProvinceEmp");
            Map(m => m.City).Name("CityEmp");
            Map(m => m.District).Name("DistrictEmp");
            Map(m => m.Address).Name("AddressEmp");
            Map(m => m.DepartmentId).Name("DepartmentIdEmp");
            Map(m => m.PositionId).Name("PositionIdEmp");

            Map(m => m.IdentityNumberRel).Name("IdentityNumberRel").TypeConverterOption.NullValues("0");
            Map(m => m.FullNameRel).Name("FullNameRel");
            Map(m => m.BirthDayRel).Name("BirthDayRel");
            Map(m => m.PhoneNumberRel).Name("PhoneNumberRel");
            Map(m => m.ProvinceRel).Name("ProvinceRel");
            Map(m => m.CityRel).Name("CityRel");
            Map(m => m.DistrictRel).Name("DistrictRel");
            Map(m => m.AddressRel).Name("AddressRel");
            Map(m => m.RelationshipRel).Name("RelationshipRel");
            Map(m => m.EmployeeIdRel).Name("EmployeeIdRel");

        }

    }
}

