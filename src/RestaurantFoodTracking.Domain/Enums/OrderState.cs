using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFoodTracking.Domain.Enums
{
    public enum OrderState
    {
        TakeOrder, // Sipariş alındı,
        Preparing, // Hazırlanıyor
        OnTheRoad, // Yolda
        WasDelivered // Teslim edildi
    }
}
