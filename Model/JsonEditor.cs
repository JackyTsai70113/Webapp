using System;
using System.ComponentModel.DataAnnotations;

namespace Webapp.Model
{
    public class JsonEditor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "名稱")]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime UpdateTime { get; set; }

        [Display(Name = "內容")]
        public string Content { get; set; }

        [Display(Name = "備註")]
        public string Note { get; set; }
    }
}
