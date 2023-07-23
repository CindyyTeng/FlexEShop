using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Flex_TEST.Models.Dto
{
    public class ActivityEditDto
    {
    
        public int ActivityId { get; set; }


        public string ActivityName { get; set; }


        public int fk_ActivityCategoryId { get; set; }


        public DateTime ActivityDate { get; set; }

        public string ActivityPlace { get; set; }

       
        public DateTime ActivityBookStartTime { get; set; }

       
        public DateTime ActivityBookEndTime { get; set; }


        public int fk_SpeakerId { get; set; }


        public string ActivityImage { get; set; }

        
        public byte ActivityAge { get; set; }

        
        public int ActivityOriginalPrice { get; set; }


        public int ActivitySalePrice { get; set; }

      
        public string ActivityDescription { get; set; }
    }
}
