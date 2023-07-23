using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Flex_TEST.Models.ViewModels
{
    public class ActivityEditVM
    {
        [Display(Name = "活動編號")]
        public int ActivityId { get; set; }

        [Display(Name = "活動名稱")]
        public string ActivityName { get; set; }

    
        //public string ActivityCategoryName { get; set; }

        [Display(Name = "活動種類")]
        public int fk_ActivityCategoryId { get; set; }

        [Display(Name = "活動日期")]
        public DateTime ActivityDate { get; set; }

        [Display(Name = "活動地點")]
        public string ActivityPlace { get; set; }

        [Display(Name = "活動時間(起)")]
        public DateTime ActivityBookStartTime { get; set; }

        [Display(Name = "活動時間(迄)")]
        public DateTime ActivityBookEndTime { get; set; }

        [Display(Name = "活動講者")]
        //public string SpeakerName { get; set; }
        public int fk_SpeakerId { get; set; }

        [Display(Name ="活動照片")]
        public string ActivityImage { get; set; }

        [Display (Name ="參加年齡")]
        public byte ActivityAge { get; set; }

        [Display(Name ="活動原價")]
        public int ActivityOriginalPrice { get; set; }

        [Display(Name ="活動特價")]
        public int ActivitySalePrice { get; set; }

        [Display(Name ="活動描述")]
        public string ActivityDescription { get; set; }

    }
}
