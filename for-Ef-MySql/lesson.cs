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
    
    public partial class lesson
    {
        public int id { get; set; }
        public string lessonName { get; set; }
        public int courseId { get; set; }
        public string resourcesCoverPath { get; set; }
        public bool resourcesType { get; set; }
        public int addAccountId { get; set; }
        public System.DateTime addDate { get; set; }
        public bool isDelete { get; set; }
    }
}
