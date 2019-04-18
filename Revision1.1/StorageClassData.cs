using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityApp
{  /* class used to create and store some data used in user configuration */
    public class SCD //StorageClassData
    {
        public static int IntRecordNumber { get; set; }
        public static int IntEntryNumber { get; set; }

        public static int IntOnlineTime { get; set; }
        public static int IntOfflineTime { get; set; }

        public static int IntTotalOnlineTime { get; set; }
        public static int IntTotalOfflineTime { get; set; }
        public static int IntTotalTimeInDay { get; set; }
        public static int IntOvertime{ get; set; }

        public static string StrTodayDate { get; set; }
        public static string StrDayOfTheWeek { get; set; }
        public static string StrHourNow { get; set; }

        public static int IntPlannedWorkingTime { get; set; }
        public static int IntPlannedBreakTime { get; set; }

        public static string StrCurrentTaskLink { get; set; }
        public static string StrCurrentTaskStatus { get; set; }
        public static int IntCurrentTaskPercent { get; set; }

        public static int IntLockTimeStart { get; set; }
        public static int IntLockTimeFinish { get; set; }
    }
    /* class used to create and store online data about user activity */
    public class ECD // EnableClassData
    {
        public static bool bEnableOvertime { get; set; }
        public static bool bEnableOnlineTime { get; set; }
        public static bool bEnableBreakTime { get; set; }
        public static bool bEnableLogoffTime { get; set; }
        public static bool bEnableReport { get; set; }
        public static bool bWinEventLock { get; set; }
        public static bool bWinEventUnLock { get; set; }
        public static bool bClearPanel { get; set; }
    }
    /* class used to for panel features */
    public class PCD // ProcentClassData
    {
        public static double ActiveTime { get; set; }
        public static double BreakTime { get; set; }
        public static double TaskTime { get; set; }
    }
}

