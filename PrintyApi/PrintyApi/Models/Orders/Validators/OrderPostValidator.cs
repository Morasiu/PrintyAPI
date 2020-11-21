using System;
using FluentValidation;

namespace PrintyApi.Models.Orders.Validators {
	public class OrderPostValidator : AbstractValidator<OrderPost> {
		public OrderPostValidator() {
			RuleFor(a => a.TakeawayTime).GreaterThan(DateTimeOffset.Now);
		}
	}
}