# WEBAPI

Comando de creacion vemos todos los tipos de proyectos

dotnet new --list

Para crear weapi

dotnet new webapi


Para ejecutarlo
dotnet run

Analisis de ficheros

MVC (Model View Controler)
Model = Datos
View  = Interface de usuario
Controller = Logica

En weapi
MXC (Model Controler) la V se encarga las vista o frontend

Componentes

Controllers WeatherForecastController.cs (Todas las carpetas se guaran en controllers, cada modelo debe estar asociado a un controlador)

Archivo de proyecto
webapi.csproj

URL https://localhost:7189/swagger/index.html


Manejo de Rutas

[Route("[controller]")]  // Permite manejar una ruta dinamica

[Route("api/[controller]")]


















