﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.structs.Trades
{
    public class TradeMoneyFindArgs
    {
        public long TradeID { get; set; }
        public int EntityID { get; set; }
        public int CurrencyID { get; set; }
    }
}
