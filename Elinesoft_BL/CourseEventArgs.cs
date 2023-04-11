﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elinesoft_BL
{
    public sealed class CourseEventArgs : EventArgs
    {
        public readonly decimal Price;
        public CourseEventArgs(decimal price)
        {
            Price = price;
        }
    }
}
