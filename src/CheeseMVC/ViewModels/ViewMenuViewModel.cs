﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheeseMVC.Models;

namespace CheeseMVC.ViewModels
{
    public class ViewMenuViewModel
    {
        public Menu Menu { get; set; }
        public IList<CheeseMenu> Items { get; set; }

        public ViewMenuViewModel (Menu menu, IList<CheeseMenu> items)
        {
            Menu = menu;
            Items = items;
        }
    }
}
