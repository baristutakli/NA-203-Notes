// Learn regex
// Düzenli olmyan verilerden düzenli şekilde elde etmeye yarıyor.
// İstediğimiz formattaki verileri aramamızı kolaylaştırır

// Bir rgex cümlesi ters slash ile başlar ve biter

// g: global
// +: one or more, bir karakterin devamında da benzeri yapıya rastlarsa devamındakileri de seçer


let str ="aloo burada neler oluyor acaba? burda çok şey oluyor"

let myPattern ="/bura?da/g";
// hem burada hem burda kelimelerini seçtik. a harfi optionel olduğu için ? kullandık.

// ----------- * -------------
// *: optionel notasyon ve + nın birleşimi
// optionel varsa takip et varsa +la
let myPattern2 ="/o*/g";

// ----------- . ---------------
// Tek bir karakter seçimi için nokta kullanılır

let myPattern3 ="/./g";

// bütün karakterleri tek tek seçip birleştirdik
let myPattern4 ="/.+/g";

// a dan sonra bir karakter daha olsun
let myPattern5 ="/a./g";


// a dan önce bir karakter daha olsun. Eğer ilk harf ise bu onu seçmez
let myPattern6 ="/.a/g";

// b den sonra herhangi bir harf gelebilir
let myPattern7 ="/b.rada/g";

// Nokta yeni satıra geçerse geçersiz kalır


// \w : herhangi bir karakteri bana getirir

// \s: sadece space leri alır
// örneğin, boşlujları kaldırabiliriz.

// sadece sayıları seçmek istersek \d
// 123456 tek tek seçmek için \d
// Birleştirmek için + koyarız

// herhangi iki karkteri ikili gruplar halinde seçmek için
let myPattern8 ="/.{2}/g";

// en az ikili en fazla 4 lü seçmek için
let myPattern9 ="/.{2,4}/g";

// En az iç karakteri grupla sınırsız olsun
let myPattern10 ="/.{3,}/g";

let str2= "fat cat hat tat nat Fat Cat 4at 5at";

// sadece karakterleri seçmek için
let myPattern11 ="/\w{3}/g";

// ilk karakterin ne olduğu önemli olmayan ve at ile bitenler
let myPattern12 ="/.at/g";
// Bir diğer kullanımı
let myPattern13 ="/{fchtnF54}at/g";


// -----------[]--------
let myPattern14 ="/[a-zA-Z0-9]at/g";



