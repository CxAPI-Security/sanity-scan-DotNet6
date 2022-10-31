using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Sanity_Scan_CSharp.Controllers
{

    [ApiController]
    public class UtilController : ControllerBase
    {
        [HttpGet]
        [Route("/runCommand/{cmd}")]
        public string RunCommand([FromRoute] string cmd)
        {
            var processStartInfo = new ProcessStartInfo("cmd.exe", cmd)
            {
                CreateNoWindow = true,
                UseShellExecute = true
            };
            Process.Start(processStartInfo);
            return "commandRun";
        }
    }
}