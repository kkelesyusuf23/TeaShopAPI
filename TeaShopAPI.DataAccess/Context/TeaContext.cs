using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShopAPI.EntityLayer.Concrete;

namespace TeaShopAPI.DataAccess.Context
{
	public class TeaContext:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=YUSUF; initial Catalog=DBTeaShop; integrated security=true;");
		}
		public DbSet<Drink> Drinks { get; set; }
		public DbSet<Message> Messages { get; set; }
		public DbSet<Question> Questions { get; set; }
		public DbSet<Testimonial> Testimonials { get; set; }

	}
}
