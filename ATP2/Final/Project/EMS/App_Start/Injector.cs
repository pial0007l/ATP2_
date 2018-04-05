using EMS.Controllers;
using EMSEntity;
using EMSService;
using Injection;
using Injection.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EMS
{
    public class Injector
    {
        public static IInjectionContainer Container { get; set; }

        static Injector()
        {
            Container = new Container();
        }
 
        public static void Configure()
        {

            Container.Register<IDepartmentService, DepartmentService>().Singleton();
            //Container.Register<DepartmentController, DepartmentController>();
            //ControllerBuilder.Current.SetControllerFactory(new InjectionControllerFactory());
        }
    }
}