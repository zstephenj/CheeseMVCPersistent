using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.ViewModels
{
    public class AddMenuItemViewModel
    {
        [Required(ErrorMessage = "A cheese must be selected")]
        [Display(Name = "Cheese Name")]
        public int cheeseID { get; set; }
        [Required(ErrorMessage = "Must be adding to valid menu")]
        public int menuID { get; set; }
        public Menu Menu { get; set; }
        public List<SelectListItem> Cheeses { get; set; }

        public AddMenuItemViewModel()
        {

        }

        public AddMenuItemViewModel(Menu menu, List<Cheese> cheeses)
        {
            Cheeses = new List<SelectListItem>();
            Menu = menu;
            foreach (Cheese cheese in cheeses)
            {
                Cheeses.Add(new SelectListItem
                {
                    Value = cheese.ID.ToString(),
                    Text = cheese.Name
                });
            }

            
        }
    }
}
