using Flex_TEST.Models.Dto;
using Flex_TEST.Models.ViewModels;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Flex_TEST.Models.Exts
{
	public static class ActivityExts
	{
		public static ActivityIndexVM ToIndexVM(this ActivityIndexDto dto)
		{
			return new ActivityIndexVM
			{
				ActivityId = dto.ActivityId,
				ActivityName = dto.ActivityName,
				ActivityCategoryName = dto.ActivityCategoryName,
				ActivityDate = dto.ActivityDate,
				SpeakerName = dto.SpeakerName,
				ActivityPlace = dto.ActivityPlace,
				ActivityBookStartTime = dto.ActivityBookStartTime,
				ActivityBookEndTime = dto.ActivityBookEndTime,
				ActivityStatusDescription = dto.ActivityStatusDescription
			};
		}

		public static ActivityIndexDto ToIndexDto (this Activities entity)
		{
			return new ActivityIndexDto
			{
				ActivityId = entity.ActivityId,
				ActivityName = entity.ActivityName,
				ActivityCategoryName = entity.fk_ActivityCategory.ActivityCategoryName,
				ActivityDate = entity.ActivityDate,
				SpeakerName = entity.fk_Speaker.SpeakerName,
				ActivityPlace = entity.ActivityPlace,
				ActivityBookStartTime = entity.ActivityBookStartTime,
				ActivityBookEndTime = entity.ActivityBookEndTime,
				ActivityStatusDescription = entity.fk_ActivityStatus.ActivityStatusDescription
			};
		}
	}
}
