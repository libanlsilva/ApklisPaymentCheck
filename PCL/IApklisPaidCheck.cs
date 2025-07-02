using System;
using System.Collections.Generic;
using System.Text;

namespace ApklisPaymentCheck.CrossPlataform
{
    public interface IApklisPaidCheck
    {
        (bool isPaid, string userName) GetPaidInfo(string pakageName);
    }
}
