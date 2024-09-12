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
Console.WriteLine("Bir sayi giriniz");
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
//