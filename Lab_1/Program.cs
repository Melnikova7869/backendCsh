var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//������� ��������
string htmlIndex = """    
<!DOCTYPE html>
<html lang="ru">
<head>
    <meta charset="UTF-8">
    <title>�������</title>
</head>
<body>
    <h1>����� ���������� � �� ����������!</h1>
    <p>����������� ������ �1</p>
    <p>������ ��������� ���������� �.� 231-331</p>
</body>
</html>
""";

//�������� ��������
string htmlContacts = """
<!DOCTYPE html>
<html lang="ru">
<head>
    <meta charset="UTF-8">
    <title>�������</title>
</head>
<body>
    <h1>��� ��������</h1>
    <p>�����: a.melnikovalod@mail.ru</p>
    <p>����� ��������: 89776737847</p>
    <p>���������: @serhy</p>
</body>
</html>
""";

//���������� �������������
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
