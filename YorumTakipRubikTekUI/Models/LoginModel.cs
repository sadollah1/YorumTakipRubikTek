﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YorumTakipRubikTekUI.Models
{
    public class LoginModel
    {
        [Required, DisplayName("Username")]
        public string Username { get; set; }
        [Required, DisplayName("Şifre"), DataType(DataType.Password)]
        public string Password { get; set; }
    }
}