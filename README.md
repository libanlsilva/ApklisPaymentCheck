
# ✅ Apklis Payment Check para Xamarin.Forms

Este proyecto es un ejemplo de cómo verificar si una aplicación ha sido adquirida a través de [Apklis](https://www.apklis.cu/es/) utilizando **Xamarin.Forms**.

---

## 🚀 ¿Cómo usarlo?

1. **Agregar la interfaz**  
   Copia el archivo `IApklisPaidCheck.cs` dentro del proyecto compartido (`.NET Standard` o `Shared Project`).

2. **Agregar la implementación para Android**  
   Copia el archivo `ApklisPaidCheck.cs` dentro del proyecto Android.

3. **Realizar la verificación desde tu código**  
   Utiliza el servicio de dependencias de Xamarin.Forms para obtener la información del pago:

```csharp
var result = DependencyService.Get<IApklisPaidCheck>().GetPaidInfo("nombre.del.paquete");
var isPaid = result.isPaid;       // true si la app ha sido comprada; false si no
var username = result.userName;     // Nombre del usuario logueado en Apklis
````

---

## ⚙️ Configuración adicional

Es necesario agregar la siguiente sección dentro del archivo `AndroidManifest.xml`, **justo después de la sección de permisos**:

```xml
<queries>
    <package android:name="cu.uci.android.apklis" />
    <provider android:authorities="cu.uci.android.apklis.PaymentProvider" />
</queries>
```

---

## ℹ️ Requisitos importantes

* El dispositivo debe tener instalada la aplicación **Apklis**.
* El usuario debe estar **logueado en Apklis** en ese dispositivo para que la verificación funcione correctamente.

---

## 📄 Licencia

Este proyecto se proporciona con fines educativos y de referencia. Úsalo bajo tu responsabilidad según las políticas de Apklis y de la plataforma donde publiques tu aplicación.

