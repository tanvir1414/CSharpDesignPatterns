using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._25builder
{
    interface IInsuranceBuilder
    {
        void BuildDriver();
        void BuildVehicle();
        void BuildLocation();

        Insurace GetInsurace();

    }
}
