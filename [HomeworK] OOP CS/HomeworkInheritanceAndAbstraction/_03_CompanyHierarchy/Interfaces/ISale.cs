﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CompanyHierarchy.Interfaces
{
    public interface ISale
    {
         string Name
        {
            get;
            set;
        }

         DateTime Date
        {
            get;
            set;
        }

         decimal Price
         {
             get;
             set;
         }
       
    }
}
