using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using StudyCMS.One.Models;


namespace StudyCMS.One.Controllers
{
    public class ContentController : Controller
    {
        private readonly Content contents;
        public ContentController(IOptions<Content> option)
        {
            contents = option.Value;
        }

        public IActionResult Index()
        {
            //var contents = new List<Content>();
            //var vm = new ContentViewModel();
            //vm.Contents = contents;
            //for (int i = 1; i < 11; i++)
            //{
            //    contents.Add(new Content { Id = i, title = $"{i}的标题", content = $"{i}的内容", status = 1, add_time = DateTime.Now.AddDays(-i) });
            //}
            //return View(vm);
            //var vm = new ContentViewModel();
            //vm.Contents = new List<Content> { contents };
            //return View(vm);
            return View(new ContentViewModel { Contents = new List<Content> { contents } });
        }
    }
}