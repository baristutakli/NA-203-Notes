let body = document.querySelector("body");
body.style="margin:0px";
let container = document.createElement('section');
container.style ="Height:200px;background-color:red;";
let main = document.querySelector("main");
main.style="margin:0px";
main.appendChild(container);

let fname = document.getElementsByName('fname');
for (let element of fname) {
    console.log(element.getAttribute('value'));
}


//let id= document.getElementsByTagName('studentid')[0].dataset.id;//data-id
//let tc= document.getElementsByTagName('studentid')[0].dataset.tc;//data-id


// document.getElementById("kutu").classList.remove("default");
