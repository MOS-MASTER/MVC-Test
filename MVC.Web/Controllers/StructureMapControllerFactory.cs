using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using StructureMap;

namespace CS.Web.Controllers
{
    public class StructureMapControllerFactory : DefaultControllerFactory
    {

        protected override IController GetControllerInstance(Type controllerType)
        {
            try
            {
                return ObjectFactory.GetInstance(controllerType) as Controller;

            }
            catch (StructureMapException x)
            {
                Debug.WriteLine(ObjectFactory.WhatDoIHave());
                Debug.WriteLine(x.Message);
                throw;
            }
        }
    }
}
