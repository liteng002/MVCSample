﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class Article : BaseEntity
    {
        public string Title { get; set; }
        public string Body { get; set; }
      //  public int AuthorId { get; set; }
        public User Author { get; set; }
    }
}
