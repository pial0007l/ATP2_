using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EMSService;
using EMSEntity;

namespace EMS.Controllers
{
    public class DepartmentController : Controller
    {
        IDepartmentService service;
        
        public DepartmentController()
        {
            this.service = Injector.Container.Resolve<IDepartmentService>();
        }

        public ActionResult Index()
        {
            
            return View(service.GetAll());
        }
    }
}