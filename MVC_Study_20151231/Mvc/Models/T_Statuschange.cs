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
    
    public partial class T_Statuschange
    {
        public int iID { get; set; }
        public string vTicketCode { get; set; }
        public string vContactCode { get; set; }
        public string vHeadCode { get; set; }
        public Nullable<int> iOldFlag { get; set; }
        public Nullable<int> iNewFlag { get; set; }
        public string vInsUser { get; set; }
        public Nullable<System.DateTime> dtUpdTime { get; set; }
        public string vUpdUser { get; set; }
    }
}
