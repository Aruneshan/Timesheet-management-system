﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
#nullable disable

namespace TimeMate.Areas.Identity.Data;

// Add profile data for application users by adding properties to the TimeMateUser class
public class TimeMateUser : IdentityUser
{
    public string FirstName { get;set; }
    public string LastName { get;set; }

    public TimeMateUser()
    {

    }
}

