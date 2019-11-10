using System.ComponentModel.DataAnnotations;

namespace Webapp.Model
{
    public class Randomuser
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string name { get; set; }
        public string gender { get; set; }
        public string location { get; set; }
        public string registered { get; set; }
        public string phone { get; set; }
        public string cell { get; set; }
        public string large_picture { get; set; }
        public string medium_picture { get; set; }
        public string thumbnail_picture { get; set; }
    }
}