﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidzy
{
    public class Tag
    {
        public int Id { get; set;}
        public string Name { get; set;}
        public ICollection<Video> Videos { get; set;}

        public Tag()
        {
            Videos = new Collection<Video>();
        }
    }
}
