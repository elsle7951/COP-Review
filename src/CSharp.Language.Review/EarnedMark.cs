﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Language.Review
{
    class EarnedMark
    {
        public int Possible { get; private set; }
        private double _Earned;
        public double Earned
        {
            get { return _Earned;  }
            set
            {
                if (value < 0 || value > Possible)
                            throw new Exception("Invalid earned mark assigned");
                        _Earned = value;                
            }
        }
    }
}
