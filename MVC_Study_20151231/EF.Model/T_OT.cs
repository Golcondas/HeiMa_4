//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_OT
    {
        public int ID { get; set; }
        public string OT_Code { get; set; }
        public System.DateTime OT_App_DateTime { get; set; }
        public System.DateTime OT_DATETIME_S { get; set; }
        public System.DateTime OT_DATETIME_E { get; set; }
        public string OT_REASON { get; set; }
        public string OT_GUY { get; set; }
        public string OT_MEMO { get; set; }
        public Nullable<System.DateTime> INSERT_DATE { get; set; }
        public Nullable<byte> OT_STATUS { get; set; }
        public Nullable<System.DateTime> OT_APPOVE_DATETIME { get; set; }
        public string INSERT_USER { get; set; }
    }
}
