using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DishesNChefs.Models
{
    

    public class Chef
    {
       [Key]
       public int IdChef {get; set;}
       public int Age {get; set;}
       public int NumbDishes {get; set;}
       public string Name {get; set;}
       public List<Dish> CreatedDishes {get; set;}

    }
    public class Dish
    {
        [Key]
        public int IdDishe {get; set;}
        public int IdChef {get; set;}
        public string DishName {get; set;}
        public int Tastiness {get; set;}
        public int Calories {get; set;}
        public Chef Creator {get; set;}
    }
}