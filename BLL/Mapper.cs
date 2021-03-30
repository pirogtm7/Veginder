using AutoMapper;
using BLL.DTOs;
using DLL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
	public class Mapper : Profile
	{
        public Mapper()
        {
            CreateMap<Address, AddressEntity>()
                .ReverseMap();
            CreateMap<CartOrderItem, CartOrderItemEntity>()
                .ReverseMap();
            CreateMap<Order, OrderEntity>()
                .ForMember(d => d.Items, opt => opt.MapFrom(src => src.Items))
                .ReverseMap();
            CreateMap<ProductCategory, ProductCategoryEntity>()
                .ReverseMap();
            CreateMap<Product, ProductEntity>()
                .ReverseMap();
            CreateMap<Shop, ShopEntity>()
                .ReverseMap();
            CreateMap<Stock, StockEntity>()
                .ReverseMap();
        }
    }
}
