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
    
    public partial class DeviceStatu
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public string Status { get; set; }
        public string PhoneNo { get; set; }
        public string GroupNo { get; set; }
        public Nullable<double> StatusTime { get; set; }
        public string CallingNo { get; set; }
        public string CalledNo { get; set; }
        public string CallDir { get; set; }
    }
}
