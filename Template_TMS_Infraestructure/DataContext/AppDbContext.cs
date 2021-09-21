using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using Template_TMS_Infraestructure.DatabaseInMemory;

namespace Template_TMS_Infraestructure.DataContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<WeatherForecastDb>? WeatherForecast { get; set; }
    }
}
