﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobilyAccounting.BL
{
    class CLS_RECEIPT_ACOUNT
    {
        public int الرقم { get; set; }
        public string الاسم { get; set; }
        public string النوع { get; set; }
        public int الكميه { get; set; }
        public double السعر { get; set; }
        public double المجموع { get { return السعر * الكميه; } }
    }
}
