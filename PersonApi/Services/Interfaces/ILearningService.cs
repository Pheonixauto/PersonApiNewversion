using PersonApi.Models;
using PersonApi.ModelsDTO;

namespace PersonApi.Services.Interfaces
{
    public interface ILearningService
    {
        Task<List<InformationLearning>> GetAllLearning();
        Task<InformationLearning> GetLearning(int id);
        Task<bool> CreateLearning (CreateLearningDTO learning);
        Task<bool> UpdateLearning (int id,UpdateLearningDTO learning); 
        Task<bool> DeleteLearning(int id);
        
    }
}
