var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//главная страница
string htmlIndex = """    
<!DOCTYPE html>
<html lang="ru">
<head>
    <meta charset="UTF-8">
    <title>Главная</title>
</head>
<body>
    <h1>Добро пожаловать в моё приложение!</h1>
    <p>Лабораторая работа №1</p>
    <p>Работу выполнила Мельникова А.М 231-331</p>
</body>
</html>
""";

//страница контакты
string htmlContacts = """
<!DOCTYPE html>
<html lang="ru">
<head>
    <meta charset="UTF-8">
    <title>Главная</title>
</head>
<body>
    <h1>Мои контакты</h1>
    <p>Почта: a.melnikovalod@mail.ru</p>
    <p>Номер телефона: 89776737847</p>
    <p>Телеграмм: @serhy</p>
</body>
</html>
""";

//добавление маршрутизации
app.MapGet("/", async context =>
{
    context.Response.ContentType = "text/html; charset=UTF-8";
    await context.Response.WriteAsync(htmlIndex);
});

app.MapGet("/contacts", async context =>
{
    context.Response.ContentType = "text/html; charset=UTF-8";
    await context.Response.WriteAsync(htmlContacts);
}
);
app.Run();
