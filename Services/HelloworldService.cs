using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.Services
{
    public class HelloworldService : IHelloworldService
    {

        public string GetHelloWorld()
        {
            return "Hello World";
        }

    }

    public interface IHelloworldService
    {
        string GetHelloWorld();
    }


}