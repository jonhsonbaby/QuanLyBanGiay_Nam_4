using Microsoft.AspNetCore.Mvc;
using QuanLyBanGiay_ADMIN.Data;
using QuanLyBanGiay_ADMIN.ModelsDAO;

namespace QuanLyBanGiay_ADMIN.Components
{
	public class Concern : ViewComponent
	{
		private readonly BanGiayContext _context;

		public Concern(BanGiayContext context)
		{
			_context = context;
		}

		public IViewComponentResult Invoke()
		{
			SanphamhienthiDAO sanphamhienthi = new SanphamhienthiDAO(_context);
			ViewBag.Sanphamseco = sanphamhienthi.Laysanseco();
			return View(sanphamhienthi.Laysanphammoi());
		}
	}
}
