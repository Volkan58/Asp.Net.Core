using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public  class SocialMedia
    {
        [Key]
        public int SocialMediaID { get; set; }
        public String Name { get; set; }
        public String Url { get; set; }
        public String Icon { get; set; }
        public bool Status { get; set; }
    }
}
