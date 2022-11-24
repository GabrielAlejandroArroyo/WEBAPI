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

 [HttpGet(Name = "GetWeatherForecast")]
    [Route("Get/weatherforecast")]
    [Route("Get/weatherforecast2")]
    [Route("[action]")]



Template Minimal APi (estyilo minimalista)

Minimal API esta diseñado para proyectos simples que no tengan muchos endpoints. Por ejemplo para hacer un CRUD.

En una minimal api se hace todo sobre program sin controladores orientado a pequeños proyectos, demo, microservicios y azure function muy dificil de escalar

Webapi orientados a MVC, proyectos de cualquier tamaño y escalables


Middlewares

Codigo que se agrega al ciclo de vida de una peticion Http, permiten una ejecucuin de oeticiones a travez de capas.
Facilitan la implementacion de interceptores y filtros sobre las peticiones de una APi

Orden de los middlewares

Exceptionhandler
Hsts
Httpredirection
StaticFiles
Routing
Cors
Authentication
Authorization

los middlewars son los  que empiezan con use

    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseHttpsRedirection();
    app.UseCors();

    app.UseAuthorization();
    // Pagima de bienvenida
    app.UseWelcomePage();



    agregando librerias

    dotnet add package Microsoft.EntityFrameworkCore --version 6.0.3

    dotnet add package Microsoft.EntityFrameworkCore.InMemory --version 6.0.3

    dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 6.0.3































