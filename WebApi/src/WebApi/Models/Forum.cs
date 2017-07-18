﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Forum : ModelId
    {
        public string Name{ get; set; }
        public ICollection<Topic> Topics { get; set; }


        public Forum()
        {
            Topics = new List<Topic>();
        }
    }
}
