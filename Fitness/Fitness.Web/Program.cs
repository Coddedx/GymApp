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




//areas adýnda folder
//, areas new scoffolded item -> new mvc ile management oluþturuyoruz
//, çýkan sayfada end points eklicez program.cs e 
//, app run ýn hemen üstüne yapýþýrýyoruz
//, areas,default ve mangement in map controller yönlendirmesini yapýyoruz
//, sonrasýnda management in satatic dosyalarýný (vertical assets) root içine management folder ý oluþturup atýyoruz
//, management in view ýna prjenin view daki view import ve start ý kopyalayýp yapýþturuyoruz
//, management view shared _Layout a template ýn index i kopyalayýp  yapýþtýrýyoruz
//, layout da ctrl f ile assets/ yerine ~/Management/ (hangi dosya adýný yazdýysan ayný dsya adý) ile deðiþtiriyoruz
//, layout u partial ile parçalýyoruz (render body i  page content wrapper içine yazýyoruz)
//, management controlls e add controller ile mvc controller with read/write actions (mvc empty deðil) ile DashBoardController ý ekliyoruz
//, açýlan controller da index sað týk add view razor view empty ile dashboard için index açýlýyo management view içine
//aras management yaptýktan sonra burayý yazýuoruz ,map area control ile yönlendirmiþtik bir de management diye area ekledik,mangement deki dashboardeki indxe yönleniyo adlarý farklý olmalý home controller ile karýþmasýn diye,sitedeki home controler ile management deki dashboard controlu farklý 
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
