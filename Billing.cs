using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace WebApiUtils
{
    [ApiController]
    [Route("[controller]")]
    public class Billing : ControllerBase
    {
        [HttpHead(Name = "Head")]
        public string Head(string tid, string time, string cid, string appid, string sc)
        {
            Console.WriteLine(tid + "\t" + time + "\t" + cid + "\t" + appid + "\t" + sc);
            
            return "";
        }
    }
}
