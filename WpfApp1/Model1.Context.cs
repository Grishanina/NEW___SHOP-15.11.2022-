﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------


namespace WpfApp1
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class Entities12 : DbContext
{
    public Entities12()
        : base("name=Entities12")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

    public virtual DbSet<T_Discount> T_Discount { get; set; }

    public virtual DbSet<T_Manufacturer> T_Manufacturer { get; set; }

    public virtual DbSet<T_Pol> T_Pol { get; set; }

    public virtual DbSet<T_Product> T_Product { get; set; }

    public virtual DbSet<T_Provider> T_Provider { get; set; }

    public virtual DbSet<T_Role> T_Role { get; set; }

    public virtual DbSet<T_Sostav> T_Sostav { get; set; }

    public virtual DbSet<T_Sostav_Product> T_Sostav_Product { get; set; }

    public virtual DbSet<T_Type> T_Type { get; set; }

    public virtual DbSet<T_Users> T_Users { get; set; }

    public virtual DbSet<T_Userphoto> T_Userphoto { get; set; }

}

}

