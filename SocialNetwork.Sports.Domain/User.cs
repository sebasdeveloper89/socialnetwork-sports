﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Sports.Domain
{
    public class User
    {
        public int UserId { get; set; }

        public string UserName { get; set; }

        public DateTime BirthDate { get; set; }

        public string Email { get; set; }
    }
}
