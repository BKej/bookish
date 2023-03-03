using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using bookish.Models;
using bookish.Services;

namespace bookish.Controllers;

public class CheckoutController : Controller
{
    private readonly ICheckoutActions _ICheckoutActions;
    public CheckoutController(ICheckoutActions chcekoutAction)
    {
        _ICheckoutActions = chcekoutAction;
    }

    [HttpGet]
    public IActionResult CheckoutBook()
    {
        var listViewModel = _ICheckoutActions.ViewCheckout();
        return View(listViewModel);
    
    }

    [Route("Books")]
    [HttpPost]
    public IActionResult Checkout(int bookId, int memberId)
    {
        _ICheckoutActions.Checkout( bookId,  memberId);
        return Redirect("Books");
    }

}