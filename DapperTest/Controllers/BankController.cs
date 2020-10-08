using DapperTest.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DapperTest.Controllers
{
    [Route("api/teste")]
    [ApiController]
    public class BankController : ControllerBase
    {
        private readonly IBank _bank;

        public BankController(IBank bank)
        {
            _bank = bank;
        }

        [HttpGet("{id}")]
        public ActionResult<BankInfo> Get(int id)
        {
            var result = _bank.GetBank(id);

            return Ok(result);
        }

        [HttpPost]
        public ActionResult<BankInfo> Save([FromBody] BankInfo info)
        {
            var result = _bank.Save(info);

            return Ok(result);
        }

        [HttpPut]
        public ActionResult<BankInfo> Update([FromBody] BankInfo info)
        {
            var result = _bank.Update(info);

            return Ok(result);
        }

    }
}
