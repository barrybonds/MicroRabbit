using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Models;
using MicroRabbit.Banking.Domain.Models;
using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransferLogsController : ControllerBase
    {
        private readonly ITransferService _transferService;

        public TransferLogsController(ITransferService transferService)
        {
            _transferService = transferService;
        }

        //GET api/banking
        [HttpGet]
        public ActionResult<IEnumerable<TransferLog>> GetTransfer()
        {
            return Ok(_transferService.GetTransferLogs());
        }

        //[HttpPost]
        //public IActionResult Post([FromBody] AccountTransfer accountTransfer)
        //{
        //    _accountService.Transfer(accountTransfer);

        //    return Ok(accountTransfer);
        //}


    }
}
