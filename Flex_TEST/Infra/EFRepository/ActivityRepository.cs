using Flex_TEST.Interface;
using Flex_TEST.Models;
using Flex_TEST.Models.Dto;
using Flex_TEST.Models.Exts;
using Microsoft.EntityFrameworkCore;

namespace Flex_TEST.Infra.EFRepository
{
    public class ActivityRepository : IActivityRepository
    {
        private readonly AppDbContext _context;
        public ActivityRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ActivityIndexDto>> GetAllAsync()
        {
            var activities = await _context.Activities
                    .AsNoTracking()
                    .Include(a => a.fk_ActivityCategory)
                    .Include(b => b.fk_ActivityStatus)
                    .Include(c => c.fk_Speaker)
                    .ToListAsync();
            return activities.Select(a => a.ToIndexDto());
        }
    }
}
