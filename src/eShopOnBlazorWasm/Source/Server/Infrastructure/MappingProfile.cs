﻿namespace eShopOnBlazorWasm.Infrastructure
{
  using AutoMapper;
  using eShopOnBlazorWasm.Features.CatalogBrands;
  using eShopOnBlazorWasm.Features.CatalogItem;
  using eShopOnBlazorWasm.Features.Catalogs;
  using Microsoft.eShopWeb.ApplicationCore.Entities;

  public class MappingProfile : Profile
  {
    public MappingProfile()
    {
      CreateMap<CatalogType, CatalogTypeDto>();
      CreateMap<CatalogBrand, CatalogBrandDto>();
      CreateMap<CatalogItem, CatalogItemDto>();
    }
  }
}