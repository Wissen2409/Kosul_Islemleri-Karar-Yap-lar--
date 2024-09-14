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
/*
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
*/


// IF - Else If- Else Blokları(Çoklu case kontrolü)

// If ve Else kullanımında, derleyici iki tek bir kontrol yapıyordu.
// If bloğunda kapılan kontrol ıf bloğu şartına uyuyorsa, if çalışıyordu,
// uymuyorsa, else çalışıyordu.

// Peki, eğer birden fazla koşum varsa ve ben bu koşulları, her birini if gibi değerlendirmek istiyorsam

/*
if(Koşul)
{
}
else if(koşul)
{
}
else if(koşul)
{
}
else
{

}
*/

// if -else if-else konusunda bir örnek

//Console.WriteLine("Not giriniz");
//int not = int.Parse(Console.ReadLine());

// not 0-24 arasındaysa, 1
// not 25-44 arasındaysa 2
// not 45-60 arasındaysa 3
// not 59-84 arasındaysa 4
// not 85 ve 100 arasındaysa 5

/*
if(not>0 && not<24){
    Console.WriteLine("1 aldın");
}
else if(not>=25 && not<=44){
    Console.WriteLine("2 aldın");
}
else if(not>45 && not<=60){
    Console.WriteLine("3 aldın ");
}
else if (not>60 && not<84){
    Console.WriteLine("4 aldın");
}
else if(not>85 && not<100){
    Console.WriteLine("5 aldın");
}
else{
    Console.WriteLine("Lütfen geçerli bir not giriniz");
}
*/
// Bir basit hesap makinası yapalım
// Ekradan iki adet sayı alıp, birde işlem tipi alıp (+,-,/,*) işlem tipine hesap yapan
// kod bloğunu yazalım
// burada ek bir kontrol daha yapalım
// eğer aldığınız bölen sıfır ise, uyarı mesajı verelim/ bölen sıfır olamaz

/*Console.WriteLine("Hesap makinasına hoşgeldiniz");
Console.WriteLine("1 sayıyı giriniz");
int birinciSayi = int.Parse(Console.ReadLine());
Console.WriteLine("2. sayıyı giriniz");
int ikinciSayi = int.Parse(Console.ReadLine());
Console.WriteLine("İşlem tipini giriniz(+,-,/,*)");
string islemTipi =Console.ReadLine();
*/
/* 1. case
if(islemTipi=="/" && ikinciSayi!=0){
    // programı devam ettir
}
else{
    // bölen sıfır olamaz
}
*/
// 2. case
/*if(islemTipi=="+"){
    Console.WriteLine(birinciSayi+ikinciSayi);
}
else if(islemTipi=="-"){
    Console.WriteLine(birinciSayi-ikinciSayi);
}
else if(islemTipi=="*"){
    Console.WriteLine(birinciSayi*ikinciSayi);   
}
else if(islemTipi=="/"){
    if(ikinciSayi!=0){
        Console.WriteLine(birinciSayi/ikinciSayi);
    }
    else{
        // yukarıda 0 değilse, kontrolü var, değer 0'ı ise burası çalışacak
        Console.WriteLine("Bölen sıfır olamaz");
    }
}
// if veya else if'ler else olmadan çalışabilir.
*/

// Üçgenin alanı ve çevresi ve dairenin alanı ve çevresi hesaplama aracı yapacağız.

// Uygulama çalıştığında, öncelikle programın yapabileceği özellikler ekrana çıksın
// Örnek : Hesaplama için öncelikle şeklin adını sorsun
// değer olarak üçgen yada daire giriniz

// bu değeri girdikten sonra, alan yada çevre hesabı yapmak istediğinizi sorsun
// değer olarak alan yada çevre girin
// daha sonra bu hesaplamalar için gerekli olan parametreleri kullanıcıdan istesin

// daha sonra hesaplama yapıp ekrana sonucu göstersin

Console.WriteLine("Hesaplama aracına hoşgeldin");
Console.WriteLine("Hesaplama aracımız üçgen ve daire için çalışmaktadır");
Console.WriteLine("Lütfen ücgen yada daire yazınız");

string sekil = Console.ReadLine();
if(sekil.ToLower()=="ucgen"){
    Console.WriteLine("Alan hesaplama Alan, Çevre hesaplamak için çevre yazınız");
    string hesapText = Console.ReadLine();
    if(hesapText.ToLower()=="alan"){

        // taban* yukseklik/2
        Console.WriteLine("Taban değerini giriniz");
        int taban = int.Parse(Console.ReadLine());
        Console.WriteLine("Yükseklik değeri giriniz");
        int yukseklik = int.Parse(Console.ReadLine());
        // hesaplama
        decimal result = taban*yukseklik/2;
        Console.WriteLine("Taban değeri {0} yükseklik değeri {1} olan üçgenin alanı : {2}",taban,yukseklik,result);
    }
    else if(hesapText.ToLower()=="cevre"){
        Console.WriteLine("1. kenar uzunluğu");
        int birinciKenar = int.Parse(Console.ReadLine());
        Console.WriteLine("2. kenar");
        int ikinciKenar = int.Parse(Console.ReadLine());
        Console.WriteLine("3. kenar");
        int ucuncuKenar = int.Parse(Console.ReadLine());
        int result = birinciKenar+ikinciKenar+ucuncuKenar;
        Console.WriteLine("Üçgenin çevre uzunluğu : {0}",result);
    }
    else{
        Console.WriteLine("İşlem tipi geçersizdir");
    }
}
else if(sekil.ToLower()=="daire"){

Console.WriteLine("Alan hesaplamak için Alan, Çevre hesaplamak için Cevre yazınız");
string hesapText = Console.ReadLine();
if(hesapText.ToLower()=="alan"){

    Console.WriteLine("Alan hesabı için, yarı çap değerini giriniz");
    int yariCap = int.Parse(Console.ReadLine());
    Console.WriteLine("Yarı çapı : {0} olan dairenin alanı : {1}",yariCap,Math.PI*yariCap*yariCap);
}
else if(hesapText.ToLower()=="cevre"){

Console.WriteLine("Çevre hesabı için yarı çap değerini giriniz");
int yariCap = int.Parse(Console.ReadLine());
Console.WriteLine("Yarı Çapı {0} olan dairenin çevresi {1}",yariCap,Math.PI*yariCap*2);
}
else
{
    Console.WriteLine("Geçersiz işlem tipi");
}

}
else{
    Console.WriteLine("Geçersiz şekil");
}