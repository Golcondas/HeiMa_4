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
    
    public partial class ModuleRunStatu
    {
        public int ID { get; set; }
        public string SessionID { get; set; }
        public string UtilityName { get; set; }
        public string ProjectName { get; set; }
        public string ModuleID { get; set; }
        public Nullable<System.DateTime> InTime { get; set; }
        public Nullable<double> TimeLength { get; set; }
        public string NextModuleID { get; set; }
        public string PrivateData { get; set; }
        public string ModuleName { get; set; }
        public string CallerID { get; set; }
    }
}
