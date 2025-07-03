﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesApp
{
    internal class MaximumMoviesException : Exception
    {
        public MaximumMoviesException(string message) : base(message) { }
    }

    internal class InvalidIdException : Exception
    {
        public InvalidIdException(string message) : base(message) { }
    }
}
