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
    
    public partial class SnapshotData
    {
        public System.Guid SnapshotDataID { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> ParamsHash { get; set; }
        public string QueryParams { get; set; }
        public string EffectiveParams { get; set; }
        public string Description { get; set; }
        public Nullable<bool> DependsOnUser { get; set; }
        public int PermanentRefcount { get; set; }
        public int TransientRefcount { get; set; }
        public System.DateTime ExpirationDate { get; set; }
        public Nullable<int> PageCount { get; set; }
        public Nullable<bool> HasDocMap { get; set; }
        public string Machine { get; set; }
        public Nullable<short> PaginationMode { get; set; }
        public Nullable<int> ProcessingFlags { get; set; }
        public Nullable<bool> IsCached { get; set; }
    }
}
