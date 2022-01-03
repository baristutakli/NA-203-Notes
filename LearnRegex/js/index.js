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


let str3= "gray grey";

let myPattern15 ="/gr[ae]y/g"; // burada gruplama yapmaz
let myPattern16 ="/gr(a|e)y/g"; // burada gruplama yapar


let str4= "rerere rarara bir şeyler şampiyon";

let myPattern17 ="/(r(e|a))+"; // re'yi parantez içine alığ birleştirerek grupladık
// seçme sonucunda rerere ve rarara kelimelerini iki grup halinde alırız
let myPattern18 ="/(r(e|a))+";
let myPattern19 ="/(r(e|a)){2,3}";


// ----------- ^ ---------
// satır başındaki bir karakteri seçmek için
// örnegin 
let str5 ="sokakta yalnız yürüyorum.sokak bununfarkında bile değil."
let myPattern20 ="/^s/g";
// ------------- $--------
// sonundaki karakteri dolar ile seçeriz
let myPattern21 ="/\.$/gm"; // m multiline


// (lookbehind)x(lookahead)
// devamında k olan herhangi bir karakteri seçme
let myPattern22 ="/.(?=k)/gm"; 

let myPattern23 ="/[a-zA-Z](?=k)/gm"; 

// devamında k olmayanı seç

let myPattern24 ="/.(?!k)/gm"; 

let str6 ="url"
//  url seçme lookahead ile birlikte seçme işlemi
let myPattern25 ='/...(?=")/g'; 

// lookbehind
// (?<="). 
let str6 ='src="url"';
// iki tırnak arasındaki urlyi seçme

let myPattern26 ='/(?<=").+(?=")/g';
// Bir diğer bulma yöntemi
let myPattern28='/(?<=src=")(.*)(?=")/g';


//telefon Numarası Seçmek
let str7 ="1234567890";
let myptr1 ="/\d{10}/g"

let str8 ="123-456-7890";
let myptr2 ="/(\d{3})-?(\d{3})-?(\d{4})/g";

let str9 ="123 456 7890";
let myptr3 ="/(\d{3})[ -]?(\d{3})[ -]?(\d{4})/g";

// +90 123 456 7890
let str9 ="+90 123 456 7890";
let myptr4 ="(\+\d{2})?[ ]?\(?(\d{3})\)?[ -]?(\d{3})[ -]?(\d{4})"


// Grupları isimlendirme
// (?<areacode>\d{3})[ -]?(?<inital>\d{3})[ -]?(?<deneme>\d{4})

let myptr5 ="(?<areaCode>\+\d{2})?[ ]?\(?(?<operator>\d{3})\)?[ -]?(?<main>\d{3})[ -]?(?<number>\d{4})";

// ilk grubun ismi: areacode
// ikinci: initial
// son kısım: deneme