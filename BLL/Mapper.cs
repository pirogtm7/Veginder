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
            CreateMap<Cart, CartEntity>()
                .ForMember(d => d.ItemEntities, opt => opt.MapFrom(src => src.Items))
                .ReverseMap();
            CreateMap<CartOrderItem, CartOrderItemEntity>()
                .ReverseMap();
            CreateMap<Order, OrderEntity>()
                .ForMember(d => d.ItemEntities, opt => opt.MapFrom(src => src.Items))
                //.ForMember(d => d.OrderStatus, opt => opt.MapFrom(src => src.OrderStatus))
                .ReverseMap();
            CreateMap<ProductEntity, Product>()
                .ForMember(d => d.Category, opt => opt.MapFrom(src => src.Category.Name))
                .ReverseMap();
            CreateMap<Shop, ShopEntity>()
                //.ForMember(d => d.ProductEntities, opt => opt.MapFrom(src => src.Products))
                .ReverseMap();
            CreateMap<Stock, StockEntity>()
                .ReverseMap();
            //CreateMap<User, UserEntity>()
            //    .ReverseMap();
        }
    }
}
