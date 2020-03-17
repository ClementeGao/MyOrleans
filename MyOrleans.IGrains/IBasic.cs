using Orleans;
using System;
using System.Threading.Tasks;

namespace MyOrleans.IGrains
{
    public interface IBasic:IGrainWithIntegerKey
    {
        Task<string> SayHello(string helloStr); 
    }
}
