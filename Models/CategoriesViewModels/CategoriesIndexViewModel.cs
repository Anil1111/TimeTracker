﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTracker.Models.CategoriesViewModels
{
    public class CategoriesIndexViewModel
    {
   
        public Category Category { get; set; }
      
        public UserCategory UserCategory { get; set; }
      
        public List<Category> Categories { get; set; }
     
        public List<UserCategory> UserCategories { get; set; }
        [Required]
        public int MinutesSpent { get; set; }

        public List<int> MinutesSpentList { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Select Date:")]
        public DateTime DatePicked { get; set; }
    }
}
