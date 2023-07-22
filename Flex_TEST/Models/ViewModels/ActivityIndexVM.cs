using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Flex_TEST.Models.ViewModels
{
	public class ActivityIndexVM
	{
		[Display(Name ="活動編號")]
		public int ActivityId { get; set; }

		[Display(Name ="活動名稱")]
		public string ActivityName { get; set; }

		[Display(Name ="活動種類")]
		public string ActivityCategoryName { get; set; }

		[Display(Name ="活動日期")]
		public DateTime ActivityDate { get; set; }

		[Display(Name ="活動講師")]
		public string SpeakerName { get; set; }

		[Display(Name ="活動地點")]
		public string ActivityPlace { get; set; }

		[Display(Name ="活動時間(起)")]
		public DateTime ActivityBookStartTime { get; set; }

		[Display(Name ="活動時間(迄)")]
		public DateTime ActivityBookEndTime { get; set; }

		[Display(Name ="狀態")]
		public string ActivityStatusDescription { get; set; }

		
	}
}
