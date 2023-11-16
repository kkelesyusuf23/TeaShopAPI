using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShopAPI.EntityLayer.Concrete
{
	public class Testimonial
	{
        public int TestimonialID { get; set; }
		public string TestimonialName { get; set; }
		public string TestimonialComment { get; set; }
		public string TestimonialImageURL { get; set; }
    }
}
