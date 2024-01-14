using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShopAPI.DtoLayer.TestimonialDtos
{
    public class CreateTestimonialDto
    {
        public string TestimonialName { get; set; }
        public string TestimonialComment { get; set; }
        public string TestimonialImageURL { get; set; }
    }
}
