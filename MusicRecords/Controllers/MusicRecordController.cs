using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicRecords.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MusicRecordController : ControllerBase
    {
        Managers.MusicRecordManager MusicRecordManager;

        private readonly ILogger<MusicRecordController> _logger;

        public MusicRecordController(ILogger<MusicRecordController> logger)
        {
            _logger = logger;
            MusicRecordManager = new Managers.MusicRecordManager();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]          
       //  [Route("{id}")] // Http request URI 
       // [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IEnumerable<MusicRecord> Get()
        {
            return MusicRecordManager.GetAll();
        }
    }
}
