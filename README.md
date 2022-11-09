# ApklisPaymentCheck
Ejemplo de como verificar el pago de una APP en Apklis con Xamarin.Forms

# Como usar: 

1- Agrega la interfaz IApklisPaidCheck.cs en el proyecto compartido.
2- Agrega la clase ApklisPaidCheck.cs en el proyecto android.

Luego realiza la llamada con el servicio de dependencia.

var result = DependencyService.Get<IApklisPaidCheck>().GetPaidInfo("Nombre del pakete");
var isPaid = result.Item1; // True si se pago la app; False Si no se pago la app
var username = result.Item2; //Nombre del usuario logueado en Apklis

NOTA:

Debe tener la App Apklist instalada en el dispositivo y logueado con un usuario.




