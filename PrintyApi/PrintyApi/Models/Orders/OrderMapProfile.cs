using AutoMapper;

namespace PrintyApi.Models.Orders {
	public class OrderMapProfile : Profile {
		public OrderMapProfile() {
			CreateMap<OrderPost, Order>();
		}
	}
}