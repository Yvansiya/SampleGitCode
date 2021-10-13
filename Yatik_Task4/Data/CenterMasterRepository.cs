using Yatik_Task4.DataRepository;
using Yatik_Task4.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;
using Yatik_Task4.CommonUtility;

namespace Yatik_Task4.Data
{
   
    public class CenterMasterRepository:ICenterMasterRepository
    {
       private readonly EFCoreDBContext _context;
       private readonly IConfiguration _IConfiguration;
              
       public CenterMasterRepository(EFCoreDBContext eFCoreDBContext,IConfiguration configuration)
       {
           _context=eFCoreDBContext;
           _IConfiguration=configuration;
       }
       public DataTable GetCenterMasterDataStoredProcedure()
        {
            DataTable dt = new DataTable();
               List<Center_Master> lstCenterMaster =new List<Center_Master>();
               using (SqlConnection Con =new SqlConnection(_IConfiguration.GetConnectionString("Connstring")))
               {
                Con.Open();
                SqlCommand cmd=new SqlCommand("Usp_Get_CenterMasters",Con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                
                sd.Fill(dt);
                Con.Close();
               }
               return dt;
       }
        public List<Center_Master> GetCenterMasterDataStoredProcedureWithCommon()
        {
            DataTable dt = new DataTable();
            List<Center_Master> lstCenterMaster =new List<Center_Master>();
            string conn= _IConfiguration.GetConnectionString("Connstring");
            dt= Common.GetDataTableResult("Usp_Get_CenterMasters",conn);
            return Common.ConvertDataTableToGenericList<Center_Master>(dt);
       }
       public List<Center_Master> GetCenterMasterData()
       {
                return _context.Center_Masters.ToList();
       } 
    }
}