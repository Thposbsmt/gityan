﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gityan.Models
{
    public class User
    {

        public User(string name)
        {
            Name = name;
        }

        public void Hello()
        {
            Console.WriteLine(Name);
        }
    }
}
