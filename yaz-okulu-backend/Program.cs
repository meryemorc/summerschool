var builder = WebApplication.CreateBuilder(args);

// 🔥 Controller ve Swagger'ı ekliyoruz
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// 🔥 Geliştirme ortamında Swagger UI'yi aktif et
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers(); // 🔥 Controller'ları API'ye tanıtıyoruz

app.Run();
