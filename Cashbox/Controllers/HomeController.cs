using Microsoft.AspNetCore.Mvc;
using Cashbox.Models;
using Microsoft.AspNetCore.Http;
using Cashbox.Helpers;

namespace Cashbox.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/pay")]
        public IActionResult Index([FromQuery(Name = "orderSum")] int sum,
                                    [FromQuery(Name = "returnUrl")]string retUrl,
                                    [FromQuery(Name = "orderNumber")] string orderNum)
        {
            var data = new OrderModel() { orderNumber = orderNum, orderSum = sum, returnUrl = retUrl };
            return View("Views/Payment.cshtml", data);
        }

        [HttpPost]
        [Route("/result")]
        public IActionResult Result(int Sum, int CardNumber, int CVV, string returnUrl, string orderNum)
        {
            var result = new ResultModel() { OrderSum = Sum, CardNumber = CardNumber, Cvv = CVV, ReturnUrl = returnUrl, OrderNumber = orderNum };
            var hash = Encryptor.GetMd5Hash(result.ToString());
            result.ReturnUrl = result.ReturnUrl + "&checkNumber=" + hash;
            return View("Views/Result.cshtml", result);
        }

        //obsolete
        [HttpPost]
        public IActionResult Index([FromBody] OrderModel data)
        {
            var orderNum = data.orderNumber;
            HttpContext.Session.SetString("OrderNum", orderNum);
            var url = data.returnUrl;
            HttpContext.Session.SetString("ReturnUrl", url);

            return View("Views/Payment.cshtml", data);
        }
    }
}
