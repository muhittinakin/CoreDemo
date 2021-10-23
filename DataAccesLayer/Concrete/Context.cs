using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete
{
  public  class Context :DbContext //miras alımı
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)//
        {

            optionsBuilder.UseSqlServer("server=BIM9;database=CoreBlogDb;integrated security=true;");



        }
        public  DbSet<About>Abouts { get; set; }
        public DbSet <Blog>Blogs { get; set; }
        public DbSet <Category>Categorys { get; set; }
        public DbSet<Comment>Comments { get; set; }
        public DbSet<Contact>Contacts { get; set; }
        public DbSet<Writer>Writers { get; set; }
    }
}
