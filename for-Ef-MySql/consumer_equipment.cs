//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace for_Ef_MySql
{
    using System;
    using System.Collections.Generic;
    
    public partial class consumer_equipment
    {
        public int id { get; set; }
        public int consumerId { get; set; }
        public string equipmentIPAddress { get; set; }
        public bool isDefault { get; set; }
        public System.DateTime addDate { get; set; }
        public bool isDelete { get; set; }
    }
}