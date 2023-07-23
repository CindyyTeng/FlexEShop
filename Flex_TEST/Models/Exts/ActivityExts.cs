using Flex_TEST.Models.Dto;
using Flex_TEST.Models.ViewModels;
using Humanizer;
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

		public static ActivityEditDto ToEditDto( this ActivityEditVM vm)
		{
			return new ActivityEditDto
			{
				ActivityId = vm.ActivityId,

				ActivityName = vm.ActivityName,

				fk_ActivityCategoryId = vm.fk_ActivityCategoryId,
				ActivityDate = vm.ActivityDate,
				ActivityPlace = vm.ActivityPlace,
				ActivityBookStartTime = vm.ActivityBookStartTime,
				ActivityBookEndTime = vm.ActivityBookEndTime,
				fk_SpeakerId = vm.fk_SpeakerId,
				ActivityImage = vm.ActivityImage,
				ActivityAge = vm.ActivityAge,
				ActivityOriginalPrice = vm.ActivityOriginalPrice,
				ActivitySalePrice = vm.ActivitySalePrice,
				ActivityDescription = vm.ActivityDescription

			};
		}

        public static Activities ToEditEntity(this ActivityEditDto dto)
        {

            return new Activities
            {
                ActivityId = dto.ActivityId,

                ActivityName = dto.ActivityName,
                fk_ActivityCategoryId = dto.fk_ActivityCategoryId,

                //fk_ActivityCategory = new ActivityCategories
                //{
                //    ActivityCategoryName = dto.ActivityCategoryName
                //},
                ActivityDate = dto.ActivityDate,
                ActivityPlace = dto.ActivityPlace,
                ActivityBookStartTime = dto.ActivityBookStartTime,
                ActivityBookEndTime = dto.ActivityBookEndTime,
                fk_SpeakerId = dto.fk_SpeakerId,
                //fk_Speaker = new Speakers
                //{
                //    SpeakerName = dto.SpeakerName
                //},
                ActivityImage = dto.ActivityImage,
                ActivityAge = dto.ActivityAge,
                ActivityOriginalPrice = dto.ActivityOriginalPrice,
                ActivitySalePrice = dto.ActivitySalePrice,
                ActivityDescription = dto.ActivityDescription

            };
        }

		public static ActivityEditDto ToEditDto(this Activities entity)
		{
			return new ActivityEditDto
			{
				ActivityId = entity.ActivityId,
				ActivityName = entity.ActivityName,
                fk_ActivityCategoryId = entity.fk_ActivityCategoryId,
                //ActivityCategoryName = entity.fk_ActivityCategory.ActivityCategoryName,

                ActivityDate = entity.ActivityDate,
				ActivityPlace = entity.ActivityPlace,
				ActivityBookStartTime = entity.ActivityBookStartTime,
				ActivityBookEndTime = entity.ActivityBookEndTime,
                //SpeakerName = entity.fk_Speaker.SpeakerName,
                fk_SpeakerId = entity.fk_SpeakerId,
                ActivityImage = entity.ActivityImage,
				ActivityAge = entity.ActivityAge,
				ActivityOriginalPrice = entity.ActivityOriginalPrice,
				ActivitySalePrice = entity.ActivitySalePrice,
				ActivityDescription = entity.ActivityDescription

			};
		}

        public static ActivityEditVM ToEditVM(this ActivityEditDto dto)
        {
            return new ActivityEditVM
            {
                ActivityId = dto.ActivityId,
                ActivityName = dto.ActivityName,
                fk_ActivityCategoryId = dto.fk_ActivityCategoryId,
                //ActivityCategoryName = dto.ActivityCategoryName,
                ActivityDate = dto.ActivityDate,
                ActivityPlace = dto.ActivityPlace,
                ActivityBookStartTime = dto.ActivityBookStartTime,
                ActivityBookEndTime = dto.ActivityBookEndTime,
                //SpeakerName = dto.SpeakerName,
                fk_SpeakerId = dto.fk_SpeakerId,
                ActivityImage = dto.ActivityImage,
                ActivityAge = dto.ActivityAge,
                ActivityOriginalPrice = dto.ActivityOriginalPrice,
                ActivitySalePrice = dto.ActivitySalePrice,
                ActivityDescription = dto.ActivityDescription

            };
        }
    }
}
