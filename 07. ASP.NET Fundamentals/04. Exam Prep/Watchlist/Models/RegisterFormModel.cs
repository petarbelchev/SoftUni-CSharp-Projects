﻿using System.ComponentModel.DataAnnotations;
using static Watchlist.Common.EntitiesConstants.UserConstants;

namespace Watchlist.Models
{
	public class RegisterFormModel
	{
		[Required]
		[StringLength(UserNameMaxLength, MinimumLength = UserNameMinLength,
			ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.")]
		[Display(Name = "Username")]
		public string UserName { get; set; } = null!;

		[Required]
		[EmailAddress]
		[StringLength(EmailMaxLength, MinimumLength = EmailMinLength,
			ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.")]
		[Display(Name = "Email")]
		public string Email { get; set; } = null!;

		[Required]
		[StringLength(PasswordMaxLength, MinimumLength = PasswordMinLength,
			ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.")]
		[DataType(DataType.Password)]
		[Display(Name = "Password")]
		public string Password { get; set; } = null!;

		[DataType(DataType.Password)]
		[Display(Name = "Confirm password")]
		[Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
		public string ConfirmPassword { get; set; } = null!;
	}
}
