﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Interface
{
    public interface IPromotion
    {
        decimal GetPrice(IEnumerable<Cart> units);
    }
}
