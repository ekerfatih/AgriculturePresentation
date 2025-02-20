
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUI.Controllers {
    public class DefaultController : Controller {

        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
        TeamManager teamManager = new TeamManager(new EfTeamDal());

        public IActionResult Index() {
            // var values = teamManager.TGetListAll();
            // return View(values);

            var values = serviceManager.TGetListAll();
            return View(values);
        }
    }
}