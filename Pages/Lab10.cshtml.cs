using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Lab10_AdvBusProg.Pages
{
    public class Lab10Model : PageModel
    {

        private readonly ILogger _log;
        public Lab10Model(ILogger<IndexModel> log)
        {
            _log = log;
        }

        public void OnPost()
        {

            Object b = null;
            if(b==null) _log.LogWarning("Object is null!");
            else b.ToString();

        }
    }
}
