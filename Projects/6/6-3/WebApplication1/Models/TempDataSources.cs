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
    
    public partial class TempDataSources
    {
        public System.Guid DSID { get; set; }
        public System.Guid ItemID { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        public Nullable<System.Guid> Link { get; set; }
        public Nullable<int> CredentialRetrieval { get; set; }
        public string Prompt { get; set; }
        public byte[] ConnectionString { get; set; }
        public byte[] OriginalConnectionString { get; set; }
        public Nullable<bool> OriginalConnectStringExpressionBased { get; set; }
        public byte[] UserName { get; set; }
        public byte[] Password { get; set; }
        public Nullable<int> Flags { get; set; }
        public int Version { get; set; }
    }
}
