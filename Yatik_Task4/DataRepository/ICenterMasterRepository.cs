using System.Collections.Generic;
using Yatik_Task4.Models;
using System.Data;

namespace Yatik_Task4.DataRepository
{
    public interface ICenterMasterRepository
    {
        List<Center_Master> GetCenterMasterData();
        DataTable GetCenterMasterDataStoredProcedure();
        List<Center_Master> GetCenterMasterDataStoredProcedureWithCommon();
    }
}