﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSample.Models
{
    public class ContactModel
    {
        public UserModel UrgentContact { get; set; }

    }


}