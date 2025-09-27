using Microsoft.IdentityModel.Protocols;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace TailorSoft_Data_Layer
{
    public class clsDatabaseSettings
    {
        public static string? DefaultConnection { get; set; } 
        public static string? OnlineConnection { get; set; }
    }
}
