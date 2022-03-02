using PersonApi.Models;
using PersonApi.ModelsDTO;

namespace PersonApi.Services.Interfaces
{
    public interface IRelativeService
    {
        Task<List<InformationRelative>> GetAllRelative();
        Task<InformationRelative> GetRelativeById(int id);
        Task<bool> CreateRelative(CreateRelativeDTO createRelativeDTO);
        Task<bool> UpDateRelative(int id, UpdateRelativeDTO updateRelativeDTO);     
        Task<bool > DeleteRelativeById(int id);
        
    }
}
