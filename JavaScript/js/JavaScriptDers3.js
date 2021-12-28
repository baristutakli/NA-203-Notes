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

