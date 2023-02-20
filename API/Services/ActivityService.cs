using API.Models;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
    public class ActivityService : IActivityService
    {
        private readonly DataContext dbContext;

        public ActivityService(DataContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<ActivityModel>> List()
        {
            var activities = await (from activity in dbContext.Activities
                                    select new ActivityModel()
                                    {
                                        Id = activity.Id,
                                        Title = activity.Title,
                                        Date = activity.Date,
                                        Location = activity.Location,
                                        Category = activity.Category,   
                                        Description = activity.Description,
                                    }).ToListAsync();

            return activities;
        }
    }
}
