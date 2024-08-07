﻿using Microsoft.AspNetCore.Identity;
using System.Collections;
using System.Collections.Generic;

namespace FakeXiechange.API.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Address { get; set; } 

        //Shopping Cart
        public ShoppingCart ShoppingCart { get; set; }

        //Order

        public virtual ICollection<IdentityUserRole<string>> UserRoles { get; set; }    
        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }  
        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }  
        public virtual ICollection<IdentityUserToken<string>> Tokens { get; set; }
    }
}
