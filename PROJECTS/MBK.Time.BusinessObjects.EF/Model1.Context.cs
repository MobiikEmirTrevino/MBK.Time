﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MBK.Time.BusinessObjects.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
     using InteractivePreGeneratedViews;
    
    public partial class MBKTimeContext : DbContext
    {
     public MBKTimeContext(string conn, string pathCacheViews )
            : base(conn)
        {
            Database.SetInitializer(new NullDatabaseInitializer<MBKTimeContext>());
    		Configuration.ProxyCreationEnabled = false;
    
    		 if (!string.IsNullOrEmpty(pathCacheViews))
                {
                    if (!InteractiveViewsHelper.Attached(this))
                    {
    					try{
    						InteractiveViews.SetViewCacheFactory(this, new FileViewCacheFactory(pathCacheViews + @"MyViews.xml"));
    					}catch{
    
    					}
                    }
                }
        }
    
        public MBKTimeContext()
            : base("name=MBKTimeContext")
        {
    		Configuration.ProxyCreationEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<timeTask> timeTasks { get; set; }
    }
}
