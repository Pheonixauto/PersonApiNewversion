using AutoMapper;
using CsvHelper;
using PersonApi.Datas;
using PersonApi.DTO;
using PersonApi.Models;
using PersonApi.ModelsDTO;
using PersonApi.Repository.UnitOfWork;
using PersonApi.SeedDataFromFile;
using PersonApi.Services.Interfaces;
using System.Globalization;

namespace PersonApi.Services
{
    public class HandleFileService : IHandleFileService
    {

        public readonly IUnitOfWork _unitOfWork;
        public DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _webHostEnvironment;


        public HandleFileService(IUnitOfWork unitOfWork, DatabaseContext context, IMapper mapper, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _context = context;
            _mapper = mapper;
            _webHostEnvironment = webHostEnvironment;
        }
        public async Task<bool> AddEmployeeRelativeFromCSV(string path)
        {
            using (var reader = new StreamReader(@$"D:\ATSProject\PersonApi\PersonApi\HandleFile\ImportFileCsv\{path}"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture, leaveOpen: false))
            {
                csv.Context.RegisterClassMap<EmployeeRelativeMap>();
                var records1 = csv.GetRecords<ImportEmployeeRelativeDTO>();
                foreach (var item in records1)
                {
                    var result1 = _mapper.Map<InformationEmployee>(item);
                    var result2 = _mapper.Map<InformationRelative>(item);

                    if (result1.IdentityNumber != 0)
                    {
                        await _unitOfWork.EmployeeRepository.Add(result1);
                    }
                    if (result2.IdentityNumberRel != 0)
                    {
                        await _unitOfWork.RelativeRepository.Add(result2);
                    }
                }
                var br = _unitOfWork.Complete();
                if (br > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public async Task<string> ImportFileCsv(IFormFile file)
        {
            string directoryPath = Path.Combine(_webHostEnvironment.ContentRootPath, @"HandleFile\ImportFileCsv");
            if (!Directory.Exists(directoryPath))
                Directory.CreateDirectory(directoryPath);
            FileInfo fileInfo = new FileInfo(file.FileName);
            var fullPath = Path.Combine(directoryPath, fileInfo.Name);
            if (!System.IO.File.Exists(fullPath))
            {
                using (FileStream fileStream = new FileStream(fullPath, FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }
                return fileInfo.Name;
            }
            return string.Empty;
        }

        public async Task<bool> CreateFileSalary()
        {
            var salaryList = await _unitOfWork.SalaryRepository.GetAll();
            var re = _mapper.Map<List<CreateSalaryDTO>>(salaryList);
            using (var writer = new StreamWriter(@"D:\ATSProject\PersonApi\PersonApi\HandleFile\CreateFileCsv\Salary.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(re);
            }
            return true;
        }
    }
}
