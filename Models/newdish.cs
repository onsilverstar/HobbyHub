using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using ChefsDishes.Models;

namespace ChefsDishes
{
    public class NewDish
    {
        public string DishName {get; set;}
        public string Description {get; set;}

        public int CaloriesNum {get; set;}
        public int Tasty {get; set;}
        public string Names {get; set;}
    }
}