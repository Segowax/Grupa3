﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Domain.Entities
{
    public abstract class Base
    {
        public int Id { get; set; }
        public required string Name { get; set; }
    }
}
