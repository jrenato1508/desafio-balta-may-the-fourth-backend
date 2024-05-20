using MayTheFourth.Api.Data;
using MayTheFourth.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;


#region Configure Services
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MinimalDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "May The Fourth Minimal Api",
        Description = "Desenvolvido Pela equipe composta por Jos� Renato, Felipe Andr�, Vinicius Baum e Matheus ",
        License = new OpenApiLicense { Name = "MIT", Url = new Uri("https://opensource.org/licenses/MIT") }
    }); ; ;

    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "Insira o token JWT desta maneira: Bearer + espa�o + seu token",
        Name = "Authorization",
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
    });
});

#endregion


#region Configure Pipeline
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

AdicionandoActionOrEndpoint(app);
app.Run();

#endregion


#region Actions/EndPoints
void AdicionandoActionOrEndpoint(WebApplication app)
{
    #region Lista de Especies
    app.MapGet("/ObterEspecies/", async (MinimalDbContext context) =>
    await context.Species.ToListAsync())
    .WithName("Getspecies")
    .WithTags("Species");
    #endregion

    #region Lista de Filmes
    app.MapGet("/ObterFilms/", async (MinimalDbContext context) =>
    await context.Films.ToListAsync())
    .WithName("GetFilms")
    .WithTags("Films");
    #endregion

    #region Lista de Personagens
    app.MapGet("/ObterPersonagens/", async (MinimalDbContext context) =>
    await context.Peoples.ToListAsync())
    .WithName("GetPersonagens")
    .WithTags("Peoples");
    #endregion

    #region Lista de Planetas
    app.MapGet("/ObterPlanetas/", async  (MinimalDbContext context) =>
    await context.planet.ToListAsync())
    .WithName("GetPlanetas")
    .WithTags("Planets");
    #endregion

    #region Lista de Naves

    app.MapGet("/ObterStarShips/", async (MinimalDbContext context) =>
     await context.StarShips.ToListAsync())
    .WithName("GetStarShips")
    .WithTags("Starships");

    // testar a chamada
    #endregion

    #region  Lista de Veiculos
    app.MapGet("/ObterVeiculos/", async (MinimalDbContext context) =>
    await context.Vehicles.ToListAsync())
    .WithName("GetVehichles")
    .WithTags("Vehichles");
    #endregion

}
#endregion



