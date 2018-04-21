﻿using SmartClinic.Bus;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SmartClinic.DataObject
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public EnumType.UserType UserType { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthOfDate { get; set; }
        public string PhoneNumber { get; set; }
        public EnumType.Gender Gender { get; set; }
        public string Description { get; set; }

    }
}