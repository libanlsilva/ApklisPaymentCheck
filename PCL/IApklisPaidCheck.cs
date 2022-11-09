using System;
using System.Collections.Generic;
using System.Text;

namespace ApklisPaymentCheck.CrossPlataform
{
    public interface IApklisPaidCheck
    {
        (bool, string) GetPaidInfo(string pakageName);
    }
}
