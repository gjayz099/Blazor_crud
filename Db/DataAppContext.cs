using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using web_api.Models;

namespace web_api.Db
{
    public class DataAppContext : DbContext
    {
        public DataAppContext(DbContextOptions<DataAppContext> options) : base(options)
        {

        }

        public DbSet<Game> Games { get; set; }
    }
}