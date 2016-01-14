using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Services.Maps;

namespace RuntimeComponent1
{
    public sealed class Class1
    {
        public IAsyncOperation<Geoposition> GetPositionAsync2()
        {

            return Task.Run<Geoposition>(async () => {
                Geolocator g = new Geolocator();
                var pos =  await g.GetGeopositionAsync();
               
                // Do something with pos here..

                return pos;
            }).AsAsyncOperation();
        }      

    }

}
