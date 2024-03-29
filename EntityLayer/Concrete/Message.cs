﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Message
    {
        [Key]
        public int MessageID { get; set; }
        public String Name { get; set; }
        public String Mail { get; set; }
        public String Content { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}
