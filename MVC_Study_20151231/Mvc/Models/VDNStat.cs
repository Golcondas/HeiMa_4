//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mvc.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class VDNStat
    {
        public int ID { get; set; }
        public string VDNID { get; set; }
        public string VDNName { get; set; }
        public Nullable<System.DateTime> StatisticDate { get; set; }
        public Nullable<int> AnswerCalls { get; set; }
        public Nullable<int> TotalAnswerTime { get; set; }
        public Nullable<int> MaxAnswerTime { get; set; }
        public Nullable<int> AbandonCalls { get; set; }
        public Nullable<int> TotalAbandonTime { get; set; }
        public Nullable<int> MaxAbandonTime { get; set; }
        public Nullable<int> OverFlowedCalls { get; set; }
        public Nullable<int> TotalFlowedTime { get; set; }
        public Nullable<int> AnswerCallsIn20s { get; set; }
        public Nullable<int> TotalTalkTime { get; set; }
        public Nullable<int> TotalQueuedTime { get; set; }
        public Nullable<int> MaxQueuedTime { get; set; }
        public Nullable<int> TotalQueuedCalls { get; set; }
        public Nullable<int> QueueAbandonCalls { get; set; }
    }
}
