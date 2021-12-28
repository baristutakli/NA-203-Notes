

let main= document.querySelector("main");
main.style="background-color:grey;height:1000px;width:1080px;margin:0 auto;";

let sectionUp = document.querySelector(".containerUp");
let sectionDown =document.querySelector(".containerDown");

sectionUp.style ="displat:flex;flex-direction:column;Height:50%;margin-top:rem;";
sectionDown.style ="display:flex;justify-content: center;Height:50%;";

let up= document.querySelector(".containerUp .Up");
let down = document.querySelector(".containerUp .Down");
up.style ="displat:flex;flex-direction:row;Height:60%;width:80%;margin:0 auto;";
down.style ="displat:flex;flex-direction:row;Height:30% ;justify-content: center;width:80%;margin:0 auto;";

let upBoxLeft= document.querySelector(".containerUp .Up .left");
let upBoxRight =  document.querySelector(".containerUp .Up .right");

upBoxLeft.style= "Height:100%;Width:30%;display:inline-block;background-color:red;";
upBoxRight.style= "Height:100%;Width:60%;display:inline-block;background-color:yellow;";

let DownBoxList = document.querySelectorAll(".containerUp .Down .box");
let count =10;
for (let box of DownBoxList) {

    box.style ="margin-left:.5rem;margin-top:.2rem;Height:80%;Width:20%;display:inline-block;"+"background-color:"+"rgb(255, 0,"+ count+");";
    count+=50;
}

let DBoxlist =document.querySelectorAll(".containerDown .box");
for (let box of DBoxlist) {

    box.style ="margin-left:.4rem;Height:60%;Width:30%;display:inline-block;"+"background-color:"+"rgb(50, 0,"+ count+");";
    count+=50;
}