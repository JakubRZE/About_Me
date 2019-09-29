using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace about_me_Web_API.EntityModels
{
    public class EventDetail
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime Date { get; set; }

        public Byte[] Avatar { get; set; }

        //public int FileId { get; set; }
        //public virtual File File { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
