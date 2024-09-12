// See https://aka.ms/new-console-template for more information

// Karar mekanizmaları bir yazılımın en önemli bileşenidir.
// Derleyiciye belli değerlere göre, belli kod bloklarını çalıştırmasını söylemek, karar yapılarını açıklar.

// bir koşul 
// koşul true ise, bu kod çalışssın
// değilse bu kod bloğu çalışssın

// Kaç farklı koşul işlemi tipi var : 2
// bunlar;
// If - Else IF-Else
// Switch Case


#region If Yöntemi
// syntax
/*

// Koşul değişkeni, her zaman mantıksal operatörlerden gelen bir değer olmalıdır (True,False)
// yani if her zaman true yada false değerine göre karar verir.


if(Koşul)
{
    // koşul true ise, bu kod bloğu çalışacaktır.
    
}

// Bir örnek açıklayalım
*/

//bool isOk = false;
// if parantezi, ya true false değer alır, yada true false değer üretecek bir mantıksal operatör işlemi alır.
//Console.WriteLine("A");
//if(isOk)
//{
//    Console.WriteLine("B");
//}
//Console.WriteLine("C");


// Bool değişken yerine, mantıksal oparatör kullanalım
/*Console.WriteLine("Bir değer giriniz");
int intDegisken = int.Parse(Console.ReadLine());
bool isOk = intDegisken > 5;
if(isOk)
{
    // isOk değişkenin değeri true ise bu blok çalışır.
    Console.WriteLine("Girilen değer 5 den büyük");
}
*/
// İf içerisinde bir değişken değilde, mantıksal değer üretecek olan bir kod bloğu yazabiliriz.
/*Console.WriteLine("Bir değer giriniz");
int intDegisken = int.Parse(Console.ReadLine());
if(intDegisken>5)
{
    // isOk değişkenin değeri true ise bu blok çalışır.
    Console.WriteLine("Girilen değer 5 den büyük");
}
*/
#endregion


// Bir örnek daha
/*Console.WriteLine("Lütfen bir sayı giriniz");
int intDegisken = int.Parse(Console.ReadLine());
bool isCift = intDegisken%2 == 0;
if(isCift)
{
    Console.WriteLine("Girmiş olduğunuz sayı çift sayıdır.");
}  
if(isCift!=true){
   Console.WriteLine("Girdiğiniz sayı tek sayıdır.");
}
*/

// if - else
/*Console.WriteLine("Bir sayi giriniz");
int intDegisken = int.Parse(Console.ReadLine());
if(intDegisken%2 == 0)
{
    // yukarıdaki koşul işlemi true ise bu blok çalığır
    Console.WriteLine("Girmiş olduğunuz sayı çift sayı");
}
else{
    // yukarıdaki koşul işlemi false bu blok çalışır
    Console.WriteLine("Girmiş olduğunuz sayı tek sayı");
}
Console.WriteLine("Uygulama sonu");


// Örnek : ekrandan bir karakter alalım, bu karakter büyük harf ise, ekrana büyük harf, 
// küçük harf ise, ekrana küçük harf yazdıran bir uygulama yapınız

*/
// Süre 10 dakikadır.
/*

// Ekrandan bir string karakter alıp, büyük yada küçük harf olduğunu ekrana yazdıran uygulama
Console.WriteLine("Lütfen küçük yada büyük bir harf giriniz");
char charKarakter = char.Parse(Console.ReadLine());
int intDegisken = Convert.ToInt32(charKarakter);
if(intDegisken>64 && intDegisken<91){
    // true ise bu blok çalışır
    Console.WriteLine("Girdiğiniz harf büyük harf");
}
else{
    Console.WriteLine("Girdiğiniz harf küçük harf");
}
*/
// Kullanıdan not bilgisini alınız.(Not 50 den düşük ise, kaldı, büyük ise geçti yazdırınız)
/*Console.WriteLine("Lütfen aldığınız notu yazınız");
int not = int.Parse(Console.ReadLine());
if(not<50){
    Console.WriteLine("Kaldın");
}
else{
    System.Console.WriteLine("Geçtin");
}

*/
// Örnek : 
// Kullanıcıdan aldığınız username=wissen ve password=1010'a eşitse, 
//ekrana giriş başarılı, değilse, giriş başarısız yazan uygulamayı yapınız

/*
Console.WriteLine("Lütfen kullanıcı adını giriniz");
string userName = Console.ReadLine();
Console.WriteLine("Lütfen şifrenizi giriniz");
string password = Console.ReadLine();
if(userName=="wissen" && password=="1010"){
    Console.WriteLine("Hoşgeldiniz");
}
else{
    Console.WriteLine("Kullanıcı yada şifre hatalı");
}
*/


// İf ve Else koşullarında, eğer bu blokların içerisinde tek bir satır kod yazacaksak, parantez yapmamıza gerek yoktur.
// yukarıdaki örneği bu şekilde yazalım

/*Console.WriteLine("Lütfen kullanıcı adını giriniz");
string userName = Console.ReadLine();
Console.WriteLine("Lütfen şifrenizi giriniz");
string password = Console.ReadLine();
if(userName=="wissen" && password=="1010")
    Console.WriteLine("Hoşgeldiniz");
else
    Console.WriteLine("Kullanıcı yada şifre hatalı");
*/

// Ekrandan bir ürün fiyatı değeri alalım, ürün fiyatı değeri 100'den büyük ise %20 kdv payı ekleyip ekranda gösterelim
// ürün fiyatı 100'den küçük ise, %30 indirim yapıp ekrana yazdıralım
/*
Console.WriteLine("Lütfen ürün fiyatını giriniz");
double productPrice = double.Parse(Console.ReadLine());

if(productPrice<100){
    double newPrice = productPrice-(productPrice*0.3);
    Console.WriteLine("ürünün yeni fiyatı : {0}",newPrice);
}
else{

    double newPrice = (productPrice*1.2);
    Console.WriteLine("ürünün yeni fiyatı : {0}",newPrice);
}*/


// İf Blokları içerine başka if blokları ve else bloklarıda yazabiliriz.
// İç İçe İf
// syntax
/*
if(koşul)
{
    if(koşul)
    {
        
    }
    else
    {
    }
}
else
{
    if(koşul)
    {
    }
    else
    {
    }
}
*/


// Örnek :

Console.WriteLine("Lütfen not giriniz");
int not = int.Parse(Console.ReadLine());
if(not<50)
{

    if(not<25){
        Console.WriteLine("Sınıfta kaldın");
    }
    else{
        Console.WriteLine("Düşük seviyeli geçtin");
    }

}
else{
    if(not<75){
        Console.WriteLine("Orta seviyeli geçtin");
    }
    else{
        Console.WriteLine("Çok iyi seviye ile geçtin");
    }
}