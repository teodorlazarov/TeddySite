﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeddySite.Models
{
    public class FeedbackEntry
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Message { get; set; }
        public DateTime DateAdded { get; set; }
    }
}