
using Microsoft.OpenApi.Models;


#region Configure Services
var builder = WebApplication.CreateBuilder(args);

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
    #region Lista de Filmes

    #endregion

    #region Lista de Personagens

    #endregion

    #region Lista de Planetas

    #endregion

    #region  Lista de Veiculos

    #endregion

    #region Lista de Naves

    #endregion
}
#endregion



