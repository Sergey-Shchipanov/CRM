//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataBaseWCF
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Task
    {
        public System.Guid ID { get; set; }
        public System.Guid ManagerID { get; set; }
        public System.Guid CustomerID { get; set; }
        public System.Guid TaskTypeID { get; set; }
        public System.Guid TaskResultID { get; set; }
    
        public virtual tbl_Customer tbl_Customer { get; set; }
        public virtual tbl_Manager tbl_Manager { get; set; }
        public virtual tbl_TaskResult tbl_TaskResult { get; set; }
        public virtual tbl_TaskType tbl_TaskType { get; set; }
    }
}
