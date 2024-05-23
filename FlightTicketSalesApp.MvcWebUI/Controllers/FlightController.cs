using FlightTicketSalesApp.Core.Helpers;
using FlightTicketSalesApp.Core.Utilities.Configuration;
using FlightTicketSalesApp.Entities.Concrete;
using FlightTicketSalesApp.Entities.Dtos;
using FlightTicketSalesApp.MvcWebUI.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FlightTicketSalesApp.MvcWebUI.Controllers
{
    public class FlightController : Controller
    {
        public List<Airline> AirlineList { get; set; }

        public FlightController()
        {
            AirlineList = new List<Airline>
            {
                new Airline { Id = 1, Name = "İSTANBUL - Sabiha Gökçen Hvl(SAW)" },
                new Airline { Id = 2, Name = "ORDU - GİRESUN - Ordu - Giresun Hvl.(OGU)" },
                new Airline { Id = 3, Name = "ANKARA - Esenboğa Hvl.(ESB)" },
                new Airline { Id = 4, Name = "KONYA - Konya Hvl.(KYA)" },
                new Airline { Id = 5, Name = "ANTALYA - Antalya Hvl. (AYT)" }
            };
        }

        public IActionResult Search()
        {
            ViewBag.AirlineList = new SelectList(AirlineList, "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Search(FlightRequestDto flightRequestDto)
        {
            var destination = AirlineList.Where(x => x.Id == int.Parse(flightRequestDto.Destination)).FirstOrDefault().Name;
            var origin = AirlineList.Where(x => x.Id == int.Parse(flightRequestDto.Origin)).FirstOrDefault().Name;

            flightRequestDto.Destination = destination;
            flightRequestDto.Origin = origin;

            var response = RestApiHelper.CallRestWebService<FlightRequestDto, List<FlightResultDto>>(flightRequestDto, CoreConfig.BaseUri, CoreConfig.FlightGetAllByRequest);
            HttpContext.Session.SetObject("Airlines", response);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Index()
        {
            var flights = HttpContext.Session.GetObject<List<FlightResultDto>>("Airlines");
            return View(flights);
        }

        [HttpGet]
        public IActionResult Detail(string flightNumber)
        {
            var flights = HttpContext.Session.GetObject<List<FlightResultDto>>("Airlines");
            var detailResult = flights.FirstOrDefault(x => x.FlightNumber == flightNumber);
            return View(detailResult);
        }
    }
}
