﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class MenuListViewModel
    {
        public IEnumerable<Menu> allMenu { get; set; }
        public string MenuName { get; set; }
        

    }
}
