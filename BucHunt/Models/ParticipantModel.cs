﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BucHunt.Models
{
    public class ParticipantModel
    {
        public int AccessCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Password { get; set; }
    }
}