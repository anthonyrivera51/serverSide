using System;
using Microsoft.AspNetCore.Mvc;
using apiServices.Model;

namespace apiServices.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class Services : ControllerBase
    {

        private readonly ILogger<Services> _logger;

        private static readonly string[] Items = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };


        public Services(ILogger<Services> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "/Api1")]
        public IEnumerable<Api1> GetApi1()
        {
            return Enumerable.Range(1, 5).Select(index => new Api1
            {
                id = index,
                Contact_Address = Items[index].ToString(),
                Warehouse_Address = Items[index].ToString(),
                dimension = Items[Random.Shared.Next(Items.Length)]
            })
            .ToArray();
        }

        [HttpPut(Name = "/Api2")]
        public IEnumerable<Api2> GetApi2()
        {
            return Enumerable.Range(1, 5).Select(i => new Api2
            {
                id = i,
                Consignor = Items[i].ToString(),
                Cartons = Items[Random.Shared.Next(Items.Length)],
                Consignee = Items[i].ToString()
            })
                .ToArray();
        }

        [HttpGet(Name = "/Api3")]
        public IEnumerable<Api3> GetApi3()
        {
            return Enumerable.Range(1, 5).Select(index => new Api3
            {
                id = index,
                Destination = Items[index].ToString(),
                Source = Items[index].ToString(),
                Package = Items[Random.Shared.Next(Items.Length)]
            })
                .ToArray();
        }
    }
}

