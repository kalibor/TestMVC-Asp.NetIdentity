using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TestIdentity.Models
{
    public class MyAppDbContext : IdentityDbContext<MyAppUser>
    {
        //DefaultConnection 剛才所設定之連線字串名稱
        //注意，該連線字串不可為Entity Framework Database First的連線字串
        public MyAppDbContext(): base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //更改預設資料表名稱
            modelBuilder.Entity<MyAppUser>().ToTable("MyAppUser");
        }

    }

    public class MyAppUser : IdentityUser
    {
        public int Age { get; set; }
    }

}