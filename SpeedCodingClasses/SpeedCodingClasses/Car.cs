﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SpeedCodingClasses
{
    class Car : Vehicle
    {
        public int NumberOfWheels {
            get { return 4; }
        }

        public string Horn()
        {

            return "BBBBRRRRRRRRRRRRR";
        }

    }
}
