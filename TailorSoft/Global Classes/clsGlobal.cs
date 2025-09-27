using TailorSoft_Business_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TailorSoft_Models;

namespace HFS.Global_Classes
{
    public class clsGlobal
    {

        public static clsUser? CurrentUser { get; set; } = new clsUser();
        public static List<clsOrderStatisticsDTO> orderStatisticsDTOs { get; set; }
            = clsOrder.GetOrdersStatisticsForEachMonthByYear(DateTime.Now.Year);
    }
}
