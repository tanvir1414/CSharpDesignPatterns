using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._16facade
{
    // Used in web api
    class InsuraceFacade
    {
        private Car car;
        private Driver driver;
        private Location location;

        public InsuraceFacade(string vin, DateTime dob, string state)
        {
            this.car = new Car(vin);
            this.driver = new Driver(dob);
            this.location = new Location(state);
        }

        public void GetQuote()
        {
            car.CheckCarHistory();
            car.CheckCarSafety();
            driver.CheckDriverDetails();
            location.CheckDrivingConditions();
        }
    }
}
