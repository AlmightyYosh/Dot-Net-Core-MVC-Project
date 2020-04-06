using Microsoft.EntityFrameworkCore;
using CoreMVCProject.Models;

namespace CoreMVCProject.Data
{
    public class MVCContext : DbContext
    {
        public MVCContext(DbContextOptions<MVCContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }

    }
    //Sends ef the models you want to turn into a table. 
    //this works in core3.0 after adding ef.design, ef.tools, ef.sqlite using nugget manager.







}

