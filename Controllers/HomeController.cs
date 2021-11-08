using MyHomePage.Models.Params;
using MyHomePage.Services;
using System.Web.Mvc;

namespace MyHomePage.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 一覧
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public ActionResult Index(IndexParameter param)
        {
            var service = new IndexService();
            var model = service.Do(param);

            return View(model);
        }

        /// <summary>
        /// 自己紹介
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public ActionResult Introduction(IntroductionParameter param)
        {
            var service = new IntroductionService();
            var model = service.Do(param);

            return View(model);
        }

        /// <summary>
        /// 記事
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public ActionResult Article(ArticleParameter param)
        {
            var service = new ArticleService();
            var model = service.Do(param);

            return View(model);
        }
    }
}