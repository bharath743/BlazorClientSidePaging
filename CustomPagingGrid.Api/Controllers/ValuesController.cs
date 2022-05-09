using CustomPagingGrid.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomPagingGrid.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        List<Value> GetValues = new List<Value>
        {
            new Value
            {
                FirstName ="michaella",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new Value
            {
                FirstName ="lucas",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new Value
            {
                FirstName ="Paul",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new Value
            {
                FirstName ="Angel",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new Value
            {
                FirstName ="Turbo",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new Value
            {
                FirstName ="Gil",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new Value
            {
                FirstName ="Fink",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new Value
            {
                FirstName ="Pinch",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new Value
            {
                FirstName ="Lucas",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new Value
            {
                FirstName ="Agrito",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new Value
            {
                FirstName ="Lua",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new Value
            {
                FirstName ="LUna",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new Value
            {
                FirstName ="Ten",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new Value
            {
                FirstName ="Ken",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new Value
            {
                FirstName ="Kenny",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new Value
            {
                FirstName ="Kent",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new Value
            {
                FirstName ="Superman",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new Value
            {
                FirstName ="Batman",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new Value
            {
                FirstName ="",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new Value
            {
                FirstName ="",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new Value
            {
                FirstName ="Lucas",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new Value
            {
                FirstName ="Amelia",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new Value
            {
                FirstName ="Jordan",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new Value
            {
                FirstName ="Poole",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new Value
            {
                FirstName ="John",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new Value
            {
                FirstName ="Doe",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new Value
            {
                FirstName ="Fi",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new Value
            {
                FirstName ="Lucia",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new Value
            {
                FirstName ="Guard",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new Value
            {
                FirstName ="",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            }, new Value
            {
                FirstName ="Toe",
                LastName ="M",
                Age=12,
                Gender="Female",
                MiddleName="Aringto",
                UserName="user2043"
            },
        };


        [HttpGet("data")]
        public async Task<IActionResult> GetDataEnvelop([FromQuery] int pageSize, [FromQuery] int pageNumber)
        {
            var data = new DataEnvelop
            {
                OdataContext = "",
                OdataCount = GetValues.Count,
                Value = GetValues.Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList()
            };
            return Ok(data);
        }
    }
}
