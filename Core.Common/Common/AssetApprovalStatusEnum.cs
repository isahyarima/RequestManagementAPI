using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Common.Common
{
    public enum AssetApprovalStatusEnum
    {
        Processing = 1,
        Disapproved = 2,
        Approved = 3,
        NotAvailable = 4,
        NotInGoodCondition = 5,
        UnderMaintenance = 6,
        Assigned = 7,
        Reassigned = 8

    }
}
