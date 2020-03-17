using Orleans;
using System;
using System.Threading.Tasks;

namespace MyOrleans.Grains
{
    public class BasicGrain : Grain, IGrains.IBasic
    {
        public Task<string> SayHello(string helloStr)
        {
            var id = this.GrainReference.GrainIdentity.PrimaryKeyLong;//当前grain的key
            Console.WriteLine($"{DateTime.Now.ToString("HH:mm:ss.fff")} {helloStr}");

            return Task.FromResult<string>("done");
        }
    }
}
