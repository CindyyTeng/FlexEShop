using Flex_TEST.Models.Dto;

namespace Flex_TEST.Interface
{
    public interface IActivityRepository
    {

        Task<IEnumerable<ActivityIndexDto>> GetAllAsync();
    }
}
