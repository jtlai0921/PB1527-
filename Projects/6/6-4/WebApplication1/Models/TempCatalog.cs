//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TempCatalog
    {
        public string EditSessionID { get; set; }
        public System.Guid TempCatalogID { get; set; }
        public string ContextPath { get; set; }
        public string Name { get; set; }
        public byte[] Content { get; set; }
        public string Description { get; set; }
        public Nullable<System.Guid> Intermediate { get; set; }
        public bool IntermediateIsPermanent { get; set; }
        public string Property { get; set; }
        public string Parameter { get; set; }
        public System.Guid OwnerID { get; set; }
        public System.DateTime CreationTime { get; set; }
        public System.DateTime ExpirationTime { get; set; }
        public byte[] DataCacheHash { get; set; }
    }
}