﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace StudentData.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }

        [Required(ErrorMessage = "Enter Your Name")]
        [StringLength(20, ErrorMessage = "Name should be less than or equal to 20 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter Your Address")]
        [StringLength(50, ErrorMessage = "Address should be less than or equal to 50 characters.")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Your must provide a PhoneNumber")]
        [Display(Name = "Home Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number")]
        public string Mobileno { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Enter Your DOB.")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [StudentData.Models.CustomValidationAttributeDemo.ValidBirthDate(ErrorMessage = "Birth Date can not be greater than current date")]
        public DateTime Birthdate { get; set; }
        [Required(ErrorMessage = "Enter Your EmailID")]
        [RegularExpression(@"^[\w-\._\+%]+@(?:[\w-]+\.)+[\w]{2,6}$", ErrorMessage = "Please enter a valid email address")]
        public string EmailID { get; set; }
        public List<Student> ShowallStudent { get; set; }
    }
}