﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform.Fullstack2.Entities
{
    public class Note
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }

    }
}
