﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NMCT.SCORES.Models {
    public class Team {

        public int Id { get; set; }
        public string Name { get; set; }
        public Competition Competition { get; set; }

    }
}