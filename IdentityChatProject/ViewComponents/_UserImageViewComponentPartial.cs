using IdentityChatProject.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityChatProject.ViewComponents
{
	public class _UserImageViewComponentPartial : ViewComponent
	{
		private readonly UserManager<AppUser> _userManager;

		public _UserImageViewComponentPartial(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}


		public async Task<IViewComponentResult> InvokeAsync()
		{
			var user = await _userManager.FindByNameAsync(User.Identity.Name);
			string imageUrl = user?.ProfileImageUrl;

			return View("Default", imageUrl);
		}
	}
}
