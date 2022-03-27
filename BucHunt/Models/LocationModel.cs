﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BucHunt.Models
{
    public class LocationModel
    { 
        public int Id { get; set; }
        public string LocationName { get; set; }
        public string Completion { get; set; }
        public string DecodedQR { get; set; }
        public string UserEntry { get; set; }
    }
}