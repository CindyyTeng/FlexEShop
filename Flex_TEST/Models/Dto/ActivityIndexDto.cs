using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Flex_TEST.Models.Dto
{
	public class ActivityIndexDto
	{
	
		public int ActivityId { get; set; }

		
		public string ActivityName { get; set; }


		public string ActivityCategoryName { get; set; }

	
		public DateTime ActivityDate { get; set; }

		public string SpeakerName { get; set; }


		public string ActivityPlace { get; set; }


		public DateTime ActivityBookStartTime { get; set; }

		public DateTime ActivityBookEndTime { get; set; }

		public string ActivityStatusDescription { get; set; }
	}
}
