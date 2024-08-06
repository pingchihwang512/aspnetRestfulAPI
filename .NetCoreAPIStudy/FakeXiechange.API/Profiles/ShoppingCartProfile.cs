﻿using AutoMapper;
using FakeXiechange.API.Dtos;
using FakeXiechange.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeXiechange.API.Profiles
{
    public class ShoppingCartProfile : Profile
    {
        public ShoppingCartProfile() {
            CreateMap<ShoppingCart, ShoppingCartDto>();
            CreateMap<LineItem, LineItemDto>();
        }
    }
}
