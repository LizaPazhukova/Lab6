using AutoMapper;
using Shop.DAL.Models;
using Shop.Logic.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Logic.Profiles
{
    public class ProductProfile: Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDTO>();
            CreateMap<ProductDTO, Product>();
        }
    }
}
