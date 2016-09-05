using System.Threading;
using System.Threading.Tasks;

namespace Controllers.Models
{
    public class RemoteService
    {
        public async Task<string> GetRemoteData()
        {
            return await Task<string>.Factory.StartNew(() =>
            {
                Thread.Sleep(2000);
                return "Hello from the other side of the world";
            });
        }
    }
}