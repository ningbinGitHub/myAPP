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
    
    public partial class consumer_apply
    {
        public int id { get; set; }
        public int consumerId { get; set; }
        public int curriculumId { get; set; }
        public int applyStatus { get; set; }
        public int teacherId { get; set; }
        public int allClassHour { get; set; }
        public int nowClassHour { get; set; }
        public int consumerNowContryId { get; set; }
        public int consumerNowProvinceId { get; set; }
        public int consumerNowCityId { get; set; }
        public int consumerNowAreaId { get; set; }
        public string consumerNowLongitude { get; set; }
        public string consumerNowLatitude { get; set; }
        public int recordAccountId { get; set; }
        public System.DateTime recordDate { get; set; }
        public System.DateTime applyDate { get; set; }
        public System.DateTime applySuccessDate { get; set; }
        public System.DateTime applyFinishDate { get; set; }
        public System.DateTime addDate { get; set; }
        public bool isDelete { get; set; }
    }
}
