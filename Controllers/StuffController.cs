using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

public class StuffController : Controller //BaseController <- API
{
    StuffService _stuffService;

    public StuffController(StuffService service)
    {
        _stuffService = service;
    }

    // /Stuff/Index
    public async Task<IActionResult> Index()
    {
        return View(await _stuffService.GetStuffAsync());
    }

    public async Task<IActionResult> Create(Post post)
    {
        if (ModelState.IsValid)
        {
            await _stuffService.AddStuffAsync(post);
        }

        return RedirectToAction("Index");
    }

    public async Task<IActionResult> Delete(int id)
    {
        await _stuffService.DeleteStuffAsync(id);
        return RedirectToAction("Index");
    }
}