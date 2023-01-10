﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTypes.ObjectType
{
    public class Stack
    {
        int position;
        object[] data = new object[10];
        public void Push(object obj) { data[position++] = obj; }
        public object Pop() { return data[--position]; }
    }
}
