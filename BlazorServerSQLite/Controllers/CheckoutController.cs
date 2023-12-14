using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Stripe.Checkout;
using BlazorServerSQLite.Data;
using Microsoft.AspNetCore.Components;
using static System.Net.WebRequestMethods;
using Newtonsoft.Json;

namespace BlazorServerSQLite.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.RouteAttribute("[controller]")]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class CheckoutController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        private static string s_wasmClientURL = string.Empty;
        [Inject]
        public NavigationManager Navigation { get; set; } = default!;
        [Inject]
        public HttpClient Http { get; set; } = default!;

        private ApplicationUser selectedTeacher = new ApplicationUser();
        public CheckoutController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        public async Task<ActionResult> CheckoutOrder(ApplicationUser selectedTeacher, [FromServices] IServiceProvider sp)
        {
            s_wasmClientURL = "https://localhost:7068/";

            var server = sp.GetRequiredService<IServer>();

            var serverAddressesFeature = server.Features.Get<IServerAddressesFeature>();

            string? thisApiUrl = null;

            if (serverAddressesFeature is not null)
            {
                thisApiUrl = serverAddressesFeature.Addresses.FirstOrDefault();
            }

            if (thisApiUrl is not null)
            {
                var sessionId = await CheckOut(selectedTeacher, thisApiUrl);
                var pubKey = _configuration["Stripe:PubKey"];

                var checkoutOrderResponse = new CheckoutOrderResponse()
                {
                    SessionId = sessionId,
                    PubKey = pubKey
                };

                return Ok(checkoutOrderResponse);
            }
            else
            {
                return StatusCode(500);
            }
        }

        [NonAction]
        public async Task<string> CheckOut(ApplicationUser selectedTeacher, string thisApiUrl)
        {
            var options = new SessionCreateOptions
            {
                SuccessUrl = $"{thisApiUrl}/success?sessionId=" + "{CHECKOUT_SESSION_ID}" + "&thisAppUrl=" + thisApiUrl,
                CancelUrl = s_wasmClientURL + "failed",  
                PaymentMethodTypes = new List<string>
            {
                "card"
            },
                LineItems = new List<SessionLineItemOptions>
            {
                new()
                {
                    PriceData = new SessionLineItemPriceDataOptions
                    {
                        UnitAmount = 300,
                        Currency = "EUR",
                        ProductData = new SessionLineItemPriceDataProductDataOptions
                        {
                              Name = "Unblock "+selectedTeacher.Firstname,
                              Description = "When you unblock a teacher... ",
                        },
                    },
                    Quantity = 1,
                },
            },
                Mode = "payment"
            };

            var service = new SessionService();
            var session = await service.CreateAsync(options);

            return session.Id;
        }

    }
}
