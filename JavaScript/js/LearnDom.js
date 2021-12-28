"use strict"

/*  Slecetors */
let kutum = document.getElementById("kutu");
kutum.style.backgroundColor="black";
let kutucuklar = document.getElementsByClassName("kutucuk");


for (let element of kutucuklar) {
    element.style.backgroundColor ="red";
    
}
let kutum2 = document.getElementById("kutu");

let kutucuklar2 = document.getElementsByClassName("kutucuk2");
let count =100;
for (let elt of kutucuklar2) {
    elt.style.backgroundColor ="red";
    elt.style.marginLeft= count +"px";
    console.log(count);
    
    count+=200;
}

let ul = document.querySelector(".genel ul#menu");
ul.style= "list-style-type:None";
let lis = document.querySelectorAll(".genel ul#menu li");
for (let element of lis) {
    element.style = "color:red";
    element.style = "padding:1rem";
}

let li1 = document.querySelector(".genel ul#menu li:nth-child(2)");
li1.style= "color:red;padding:1rem;";


