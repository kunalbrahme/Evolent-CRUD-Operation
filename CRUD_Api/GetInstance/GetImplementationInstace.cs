using CRUD_Api.CommonHelper;
using CRUD_Api.Implementation;
using CRUD_Api.ImplementationFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_Api.GetInstance
{
    public class GetImplementationInstace
    {
        public static IContact GetInstanceMode(string mode)
        {
            string implementationMode = String.IsNullOrEmpty(mode) ? "" : mode.Trim().ToUpper();
            switch (implementationMode)
            {
                case ApiConstant.REAL:
                    return new Implementation.Implementation();
                case ApiConstant.TEST:
                    return new TestImplementation();
                default:
                    return new Implementation.Implementation();
            }
        }
    }
}