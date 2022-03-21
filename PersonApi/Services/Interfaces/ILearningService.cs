using PersonApi.Models;
using PersonApi.ModelsDTO;

namespace PersonApi.Services.Interfaces
{
    public interface ILearningService
    {
        Task<List<InforLearning>> GetAllLearning();
        Task<InforLearning> GetLearning(int id);
        Task<bool> CreateLearning (CreateLearningDTO learning);
        Task<bool> UpdateLearning (int id,UpdateLearningDTO learning); 
        Task<bool> DeleteLearning(int id);
        
    }
}
