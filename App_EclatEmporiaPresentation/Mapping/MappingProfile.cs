using App.Models.Models;
using App_EclatEmporiaPresentation.DTO;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_EclatEmporiaPresentation.MappingProfile
{
	public class MappingProfile :Profile
	{
        public MappingProfile()
        {
			CreateMap<Product, ProductDto>()
			.ForMember(d => d.CategoryName, o => o.MapFrom(src => src.Category != null ? src.Category.CategoryName : string.Empty));

			CreateMap<Category, CategoryDto>();
		}
    }
}
