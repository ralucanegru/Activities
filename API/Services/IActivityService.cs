using API.Models;

namespace API.Services
{
    public interface IActivityService
    {
        Task<List<ActivityModel>> List();
    }
}
