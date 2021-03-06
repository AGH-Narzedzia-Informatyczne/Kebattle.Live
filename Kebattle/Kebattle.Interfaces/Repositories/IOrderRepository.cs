﻿using Kebattle.DomainModel;
using Kebattle.Interfaces.Generic;
using System.Collections.Generic;

namespace Kebattle.Interfaces.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
        List<Order> GetByCompanyId(int companyId);
        Order GetOrder(int orderId);
        List<SauceType> GetSauceTypes();
        List<KebabType> GetKebabTypes();
        List<MeatType> GetMeatTypes();
        void SaveOrder(Order order);
        void DeleteOrder(int id);
        List<KebabSize> GetKebabSizes();
    }
}
