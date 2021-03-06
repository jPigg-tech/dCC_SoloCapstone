﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CalorieTracker.Models
{
    public class Health_Enthusiast
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Your Height in Inches")]
        public int Height { get; set; }

        [Display(Name = "Current Weight")]
        public int StartingWeight { get; set; }

        [Display(Name = "Goal Weight")]
        public int GoalWeight { get; set; }

        [Display(Name = "Sex")]
        public string Sex { get; set; }

        [Display(Name = "Your age")]
        public int Age { get; set; }

        [Display(Name = "Email for the Newsletter!")]
        public string? Email { get; set; }

        public int? InitialCalorieIntake { get; set; }
        // public int InitialCalorieIntake = 0;  

        [Display(Name = "Calories Per Day")]
        public int? GoalCalories { get; set; }
        [Display(Name = "Pounds per week you will lose")]
        public double? WeeklyWeightLoss { get; set; }
        public int? Activity { get; set; }        

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
