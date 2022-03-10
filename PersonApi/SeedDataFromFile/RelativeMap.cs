using CsvHelper.Configuration;
using PersonApi.ModelsDTO;

namespace PersonApi.SeedDataFromFile
{
    public class RelativeMap : ClassMap<CreateRelativeDTO>
    {
        public RelativeMap()
        {
            Map(m => m.IdentityNumber).Name("IdentityNumberRelative");
            Map(m => m.FullName).Name("FullName");        
            Map(m => m.BirthDay).Name("BirthDayRelative");
            Map(m => m.PhoneNumber).Name("PhoneNumberRelative");
            Map(m => m.Province).Name("ProvinceRelative");
            Map(m => m.City).Name("CityRelative");
            Map(m => m.District).Name("DistrictRelative");
            Map(m => m.Address).Name("AddressRelative");
            Map(m => m.Relationship).Name("Relationship");
            Map(m => m.EmployeeId).Name("EmployeeId");
        }
    }
}
