using Microsoft.AspNetCore.Mvc;
using TelegramAdminPlus_ASP_.Models;

namespace TelegramAdminPlus_ASP_.Controllers
{
    public class LikeActivityController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var likeActivityModel = new LikeActivityBindingModel();
            return View(likeActivityModel);
        }

        [HttpPost]
        public IActionResult StartActivity(LikeActivityBindingModel model)
        {
            var c = model.ChannelName;
            var i = model.InitialMessage;
            var f = model.FinalMessage;
            var l = model.FolderPath;
            var s = model.Step;
            var o = model.TimeRadio;
            var z = model.maxMinutes;
            var y = model.CountRadio;
            var b = model.MaxPosts;
            
            return View("Index");
        } 
    }
}
