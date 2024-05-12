using Fitness.Web.Helpers;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddTransient<IEmailSender, EmailSender>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();




//areas ad�nda folder
//, areas new scoffolded item -> new mvc ile management olu�turuyoruz
//, ��kan sayfada end points eklicez program.cs e 
//, app run �n hemen �st�ne yap���r�yoruz
//, areas,default ve mangement in map controller y�nlendirmesini yap�yoruz
//, sonras�nda management in satatic dosyalar�n� (vertical assets) root i�ine management folder � olu�turup at�yoruz
//, management in view �na prjenin view daki view import ve start � kopyalay�p yap��turuyoruz
//, management view shared _Layout a template �n index i kopyalay�p  yap��t�r�yoruz
//, layout da ctrl f ile assets/ yerine ~/Management/ (hangi dosya ad�n� yazd�ysan ayn� dsya ad�) ile de�i�tiriyoruz
//, layout u partial ile par�al�yoruz (render body i  page content wrapper i�ine yaz�yoruz)
//, management controlls e add controller ile mvc controller with read/write actions (mvc empty de�il) ile DashBoardController � ekliyoruz
//, a��lan controller da index sa� t�k add view razor view empty ile dashboard i�in index a��l�yo management view i�ine
//aras management yapt�ktan sonra buray� yaz�uoruz ,map area control ile y�nlendirmi�tik bir de management diye area ekledik,mangement deki dashboardeki indxe y�nleniyo adlar� farkl� olmal� home controller ile kar��mas�n diye,sitedeki home controler ile management deki dashboard controlu farkl� 
app.UseEndpoints(endpoints =>  {
    endpoints.MapAreaControllerRoute(
    name: "Management",
    areaName: "Management",
    pattern: "Management/{controller=Dashboard}/{action=Index}/{id?}"
    );

    endpoints.MapControllerRoute(
    name: "areas",
    pattern: "{area=exists}/{controller}/{action}"
    );

    endpoints.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

});



app.Run();
