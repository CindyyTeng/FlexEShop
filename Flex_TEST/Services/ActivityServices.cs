using Flex_TEST.Interface;
using Flex_TEST.Models;
using Flex_TEST.Models.Dto;

namespace Flex_TEST.Services
{
    public class ActivityServices
    {
        private IActivityRepository _repo;
        private readonly AppDbContext _context;

        public ActivityServices(IActivityRepository repo, AppDbContext context)
        {
            this._repo = repo;
            _context = context;
        }

        public async Task<IEnumerable<ActivityIndexDto>> GetAllAsync()
        {
            return await _repo.GetAllAsync();
        }
    }
}
