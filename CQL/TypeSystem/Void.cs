﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQL.TypeSystem
{
    public sealed class Void
    {
        public static Void Instance = new Void();
        private Void() { }
    }
}
