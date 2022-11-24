using webapi;
using webapi.middlewares;
using webapi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configurao entity framework con BD
int dbType = builder.Configuration.GetValue<int>("DbType");
switch (dbType)
{
    case 1:
        // Base de datos en memoria
        //builder.Services.AddDbContext<TareasContext>(p => p.UseInMemoryDatabase("TareasDB"));
        break;
    case 2:
        // Base de datos en MSSQL Server
        //builder.Services.AddSqlServer<TareasContext>("Data Source=xxxxx\\xxxxx;Initial Catalog=xxxxxx;user id=xxxxx;password=xxxx");
        builder.Services.AddSqlServer<TareasContext>(builder.Configuration.GetConnectionString("SqlConnection"));
        break;
    case 3:
        // Base de datos en Postgres
        //builder.Services.AddSqlServer<TareasContext>("Data Source=xxxxx\\xxxxx;Initial Catalog=xxxxxx;user id=xxxxx;password=xxxx");
        //builder.Services.AddSqlServer<TareasContext>(builder.Configuration.GetConnectionString("SqlConnection"));
        break;
    case 4:
        // Base de datos en Mysql
        //builder.Services.AddSqlServer<TareasContext>("Data Source=xxxxx\\xxxxx;Initial Catalog=xxxxxx;user id=xxxxx;password=xxxx");
        //builder.Services.AddSqlServer<TareasContext>(builder.Configuration.GetConnectionString("SqlConnection"));
        break;
    default:
        // Base de datos en memoria
        //builder.Services.AddDbContext<TareasContext>(p => p.UseInMemoryDatabase("TareasDB"));
        break;
}

//builder.Services.AddSqlServer<TareasContext>(builder.Configuration.GetConnectionString("SqlConnection"));


// Injeccion de dependencia
builder.Services.AddScoped<IHelloworldService, HelloworldService>();
builder.Services.AddScoped<ICategoriaServices, CategoriaServices>();
builder.Services.AddScoped<ITareaServices, TareaServices>();
// Otra manera de hacer inyeccion de depnedencias, no recomendado, siempre es conveniente utilizar una interface
// Esta oppcion es para pasar parametros en el contructor
//builder.Services.AddScoped(p=> new HelloworldService());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

//app.UseWelcomePage();

//app.UseTimeMiddleware();

app.MapControllers();

app.Run();
