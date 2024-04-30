using MayTheFourth.Api.Data;
using MayTheFourth.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using MiniValidation;


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
        Description = "Desenvolvido Pela equipe composta por José Renato, Felipe André, Vinicius Baum e Matheus ",
        License = new OpenApiLicense { Name = "MIT", Url = new Uri("https://opensource.org/licenses/MIT") }
    }); ; ;

    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "Insira o token JWT desta maneira: Bearer + espaço + seu token",
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
    #region Lista de Filmes

    #endregion

    #region Lista de Personagens

    #endregion

    #region Lista de Planetas

    #endregion

    #region  Lista de Veiculos

    app.MapGet("/Vehicles", async (MinimalDbContext context) => // Retornar todos os veiculos
    await context.Vehicles.ToListAsync())
        .WithName("GetVehicles")
        .WithTags("Vehicles");

    app.MapGet("/Vehicles/{id}", async (MinimalDbContext context, Guid id) =>
    await context.Vehicles.FindAsync(id)
    is Vehicle veiculo ? Results.Ok(veiculo) : Results.NotFound())
    .Produces<Vehicle>(StatusCodes.Status200OK)
    .Produces(StatusCodes.Status404NotFound)
    .WithName("GetVehicleById")
    .WithTags("Vehicles");

    app.MapPost("/Vehicles", async (MinimalDbContext context, Vehicle veiculo) =>
    {
        if (!MiniValidator.TryValidate(veiculo, out var errors))
            return Results.ValidationProblem(errors);

        context.Add(veiculo);
        var result = await context.SaveChangesAsync();
        return result > 0 ? Results.CreatedAtRoute("GetVehicleById", new { id = veiculo.Id }, veiculo) : Results.BadRequest("Houve um problema ao salvar o registro!");

    }).ProducesValidationProblem()
    .Produces<Vehicle>(StatusCodes.Status201Created)
    .Produces(StatusCodes.Status400BadRequest)
    .WithName("PostVehicle")
    .WithTags("Vehicles");

    app.MapPut("Vehicles/{id}", async (Guid id, MinimalDbContext context, Vehicle veiculo) =>
    {
        var vehicleDB = await context.Vehicles.AsNoTracking<Vehicle>().FirstOrDefaultAsync(x => x.Id == id);
        if (vehicleDB is null)
            return Results.NotFound();


        if (!MiniValidator.TryValidate(veiculo, out var errors))
            return Results.ValidationProblem(errors);

        context.Vehicles.Update(veiculo);

        var result = await context.SaveChangesAsync();

        return result > 0 ? Results.NoContent() : Results.BadRequest("Houve um problema ao salvar o registro!");

    }).ProducesValidationProblem()
    .Produces(StatusCodes.Status204NoContent)
    .Produces(StatusCodes.Status400BadRequest)
    .WithName("PutVehicle")
    .WithTags("Vehicles");

    app.MapDelete("/Vehicles/{id}", async (MinimalDbContext context, Guid id) =>
    {
        var veiculo = await context.Vehicles.FindAsync(id);
        if (veiculo is null)
            return Results.NotFound();

        context.Vehicles.Remove(veiculo);
        var result = await context.SaveChangesAsync();

        return result > 0 ? Results.NoContent() : Results.BadRequest("Houve um problema ao salvar o registro!");
    }).Produces(StatusCodes.Status400BadRequest)
    .Produces(StatusCodes.Status204NoContent)
    .Produces(StatusCodes.Status404NotFound)
    .WithName("DeleteVehicle")
    .WithTags("Vehicles");

    #endregion

    #region Lista de Naves

    #endregion
}
#endregion



