// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232509
(function () {
	"use strict";

	var app = WinJS.Application;
	var activation = Windows.ApplicationModel.Activation;

	app.onactivated = function (args) {
		if (args.detail.kind === activation.ActivationKind.launch) {
			if (args.detail.previousExecutionState !== activation.ApplicationExecutionState.terminated) {
				// TODO: This application has been newly launched. Initialize your application here.
			} else {
				// TODO: This application was suspended and then terminated.
				// To create a smooth user experience, restore application state here so that it looks like the app never stopped running.
			}
			args.setPromise(WinJS.UI.processAll());
		}

        getLocationForMap();
	};

	app.oncheckpoint = function (args) {
		// TODO: This application is about to be suspended. Save any state that needs to persist across suspensions here.
		// You might use the WinJS.Application.sessionState object, which is automatically saved and restored across suspension.
		// If you need to complete an asynchronous operation before your application is suspended, call args.setPromise().
	};


	function getLocationForMap() {
	    Windows.Devices.Geolocation.Geolocator.requestAccessAsync().done(
            function (accessStatus) {
                switch (accessStatus) {
                    case Windows.Devices.Geolocation.GeolocationAccessStatus.allowed:

                        // call the WinRT Component
                        var rc = new RuntimeComponent1.Class1();

                        rc.getPositionAsync2().then(function (res) {

                            // access the props of the result
                            var m = new Windows.UI.Popups.MessageDialog(res.coordinate.latitude);

                            // show latitude in message box
                            m.showAsync();

                        }, function (err) {
                            var e = err;
                        });
                     
                        break;

                    case Windows.Devices.Geolocation.GeolocationAccessStatus.denied:
                        WinJS.log && WinJS.log("Access to location is denied.", "sample", "error");
                        break;

                    case Windows.Devices.Geolocation.GeolocationAccessStatus.unspecified:
                        WinJS.log && WinJS.log("Unspecified error!", "sample", "error");
                        break;
                }
            },
            function (err) {
                WinJS.log && WinJS.log(err, "sample", "error");
            });
	}


	app.start();
})();
