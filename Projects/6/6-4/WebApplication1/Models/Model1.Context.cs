﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ReportServerTempDBEntities : DbContext
    {
        public ReportServerTempDBEntities()
            : base("name=ReportServerTempDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ChunkData> ChunkData { get; set; }
        public virtual DbSet<ChunkSegmentMapping> ChunkSegmentMapping { get; set; }
        public virtual DbSet<DBUpgradeHistory> DBUpgradeHistory { get; set; }
        public virtual DbSet<ExecutionCache> ExecutionCache { get; set; }
        public virtual DbSet<PersistedStream> PersistedStream { get; set; }
        public virtual DbSet<Segment> Segment { get; set; }
        public virtual DbSet<SegmentedChunk> SegmentedChunk { get; set; }
        public virtual DbSet<TempCatalog> TempCatalog { get; set; }
        public virtual DbSet<TempDataSets> TempDataSets { get; set; }
        public virtual DbSet<TempDataSources> TempDataSources { get; set; }
        public virtual DbSet<SessionData> SessionData { get; set; }
        public virtual DbSet<SessionLock> SessionLock { get; set; }
        public virtual DbSet<SnapshotData> SnapshotData { get; set; }
    }
}