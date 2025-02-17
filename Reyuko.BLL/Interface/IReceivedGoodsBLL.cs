﻿using Reyuko.DAL.Domain;

namespace Reyuko.BLL.Interface
{
    public interface IReceivedGoodsBLL
    {
        int AddReceivedGoods(Receivedgood oData);
        bool EditReceivedGoods(Receivedgood oData);
        bool RemoveReceivedGoods(int id);
        int AddOrderProdukbeli(OrderProdukBeli oData);
        bool EditOrderProdukbeli(ListOrderBeli oData, Receivedgood oDatas);
       
    }
}
