﻿using ECommerce.DataAccess.Abstract;
using ECommerce.DataAccess.Context;
using ECommerce.Domain.Entities;
using ECommerce.Repository.DataAccess.EntityFrameworkAccess;

namespace ECommerce.DataAccess.Implementation.EFEntityFramework;

public class EFProductDal:EFEntityRepositoryBase<Product,NorthWindDbContext>,IProductDal
{
}

