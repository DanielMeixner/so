using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Services.Maps;

namespace RuntimeComponent1
{
    public sealed class Class1
    {
        public static  IAsyncOperation <Geoposition> GetGeopoisitionAsync()
        {
            Geolocator g = new Geolocator();
            return g.GetGeopositionAsync() as IAsyncOperation<Geoposition> ;                     // get the raw geoposition data                      
            
        }


        //public static Geoposition GetGeolocation()
        //{
        //    Geolocator _geolocator = new Geolocator();
        //    MapLocation mapInfo = null;

        //    _geolocator.DesiredAccuracyInMeters = 5;

        //    try
        //    {
        //        Geoposition currentPosition = GetGeopoisitionWrapper(_geolocator).Result;
        //        //      Geoposition currentPosition = GetGeopoisitionWrapper(_geolocator).AsAsyncOperation().GetResults(); 

        //        //other stuff needing currentPosition, and another async function call

        //        return currentPosition;
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }

        //}

    }

   
}
