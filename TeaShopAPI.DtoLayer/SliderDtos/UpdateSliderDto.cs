using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShopAPI.DtoLayer.SliderDtos
{
    public class UpdateSliderDto
    {
        public int SliderID { get; set; }
        public string Title { get; set; }
        public string ImageURL { get; set; }
    }
}
