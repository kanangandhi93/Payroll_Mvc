﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Payroll_Mvc.Models
{
    [Table("tbl_Country")]
    public class country
    {
        public String Country { get; set; }
        public Int64 Id { get; set; }
    }
}