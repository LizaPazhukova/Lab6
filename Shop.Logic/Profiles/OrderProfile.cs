using AutoMapper;
using Shop.DAL.Models;
using Shop.Logic.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Logic.Profiles
{
    public class OrderProfile: Profile
    {
        public OrderProfile()
        {
            CreateMap<Order, OrderDTO>();
            CreateMap<OrderDTO, Order>();
        }
    }
}
