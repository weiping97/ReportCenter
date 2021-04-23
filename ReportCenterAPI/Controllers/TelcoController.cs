using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    public class TelcoController : ControllerBase
    {
        private ITelcoData _telcoData;
        public TelcoController(ITelcoData telcoData)
        {
            _telcoData = telcoData;
        }

        [HttpGet]
        [Route("GetAllTelco")]
        public List<TelcoModel> GetAllTelco()
        {
            return _telcoData.GetAllTelco();
        }

        [HttpGet]
        [Route("GetById/{Id}")]
        public TelcoModel GetById(int Id)
        {
            return _telcoData.GetById(Id);
        }

    }
}
