﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RaidCalenderWithIdentity.Models
{
    public class KlasseModel
    {
        //[Key]
        public int Klasse_Id { get; set; }
        public string Bezeichnung { get; set; }
        public string Avatarlink { get; set; }
    }
}