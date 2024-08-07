﻿using FakeXiechange.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeXiechange.API.Dtos
{
    public class ShoppingCartDto
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public ICollection<LineItemDto> ShoppingCartItems { get; set; }
    }
}
