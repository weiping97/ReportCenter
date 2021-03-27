using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReportCenterAPI.Data;
using ReportCenterAPI.Library.DataAccess;
using ReportCenterAPI.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportCenterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ICountryData _countryData;
        public CountryController(ApplicationDbContext context,
            ICountryData countryData)
        {
            _context = context;
            _countryData = countryData;
        }

        [HttpGet]
        [Route("GetAllCountry")]
        public List<CountryModel> GetAll()
        {
            return _countryData.GetAllCountry();
        }

        [HttpPost]
        [Route("CreateCountry")]
        public IActionResult CreateCountry([FromBody]CountryModel item)
        {
            _countryData.SaveCountryData(item);

            return Ok();
        }
    }
}
