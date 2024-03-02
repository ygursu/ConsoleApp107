
string ad,sifre;
Console.Write("Kullanıcı adını giriniz:");
ad=Console.ReadLine();
Console.Write("Şifre giriniz:");
sifre=Console.ReadLine();
if(ad=="admin" && sifre=="12345")
{
  Console.WriteLine("Giriş başarılı");
}
else
{
  Console.WriteLine("Kullanıcı adını veya şifreyi kontrol ediniz");
}
Console.ReadKey();