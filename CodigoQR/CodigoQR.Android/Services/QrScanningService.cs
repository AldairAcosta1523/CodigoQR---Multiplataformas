using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodigoQR.Services;
using ZXing.Mobile;
using CodigoQR.Droid.Service;
using Xamarin.Forms;


[assembly: Xamarin.Forms.Dependency(typeof(CodigoQR.Droid.Service.QrScanningService))]

namespace CodigoQR.Droid.Service
{
    public class QrScanningService : IQrScanningService
    {
        public async Task<string> ScanAsync()
        {
            var optionsDefault = new MobileBarcodeScanningOptions();
            var optionsCustom = new MobileBarcodeScanningOptions();

            var scanner = new MobileBarcodeScanner()
            {
                TopText = "Scan the QR Code",
                BottomText = "Please Wait",
            };

            var scanResult = await scanner.Scan(optionsCustom);
            return scanResult.Text;
        }
    }
}