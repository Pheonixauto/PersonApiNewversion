using PersonApi.Models;
using PersonApi.ModelsDTO;
using X.PagedList;

namespace PersonApi.Services.Interfaces
{
    public interface IRelativeService
    {
        Task<List<InforRelative>> GetAllRelative();
        Task<InforRelative> GetRelativeById(int id);
        Task<bool> CreateRelative(CreateRelativeDTO createRelativeDTO);
        Task<bool> UpDateRelative(int id, UpdateRelativeDTO updateRelativeDTO);     
        Task<bool > DeleteRelativeById(int id);

        /////////
        Task<IPagedList<InforRelative>> GetRelativePagedList(RequestParams requestParams);


    }
}
