using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Differentbranch
{
    public class StorageClassData
    {
        public static string SUserName { get; set; }
        public static int IntEntryNumber { get; set; }

        public static int IntWorkingMinutes { get; set; }
        public static int IntBreakMinutes { get; set; }

        public static string SEntryTime { get; set; }
        public static string STodayDate { get; set; }

        public static int IntOnlineTime { get; set; }
        public static int IntLogoffTime { get; set; }


        public static string SCurrentTask { get; set; }
        public static int  IntStoryPoints { get; set; }
        public static int   IntStoryPointsLeft { get; set; }

        public static int IntBrakeTimeEnable { get; set; }
        /* to be continued */
    }

    public class EnableClassData
    {
        public static bool bEnableOnlineTime { get; set; }
        public static bool bEnableBreakTime { get; set; }
        public static bool bEnableLogoffTime { get; set; }
    }

    public class ProcentClassData
    {
        public static double ActiveTime { get; set; }
        public static double BreakTime { get; set; }
        public static double TaskTime { get; set; }
    }

}

