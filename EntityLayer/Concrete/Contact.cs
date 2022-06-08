﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public String Mail { get; set; }
        public String Phone { get; set; }
    }
}
