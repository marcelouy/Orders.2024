﻿using Orders.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Shared.Entities
{
    public class State : IEntityWithName
    {
        public string Name { get; set; } = null!;
    }
}