using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using JsonUseInNetCoreProject.Models;
using Newtonsoft.Json;
using System.Collections.Generic;


namespace JsonUseInNetCoreProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Dictionary<string, string> _infodictionary = new Dictionary<string, string>();
            _infodictionary.Add("username","gamecc666");
            _infodictionary.Add("age", "16");
            _infodictionary.Add("gender", "男");
            _infodictionary.Add("heigh", "183");
            _infodictionary.Add("weight", "78");

            string _jsonstr = JsonConvert.SerializeObject(_infodictionary);
            PersionData _sb = JsonConvert.DeserializeObject<PersionData>(_jsonstr);
            return Content("转换后的Json字符串："+_jsonstr+" ||解析后的类中的字段值 用户名字："+_sb.username);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
