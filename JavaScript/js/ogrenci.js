class Ogrenci{

    constructor(name){
        this.name = name;
    }

    sayHi(){
        console.log(this.name);
    }
}
let ogr= new Ogrenci("Barış");
ogr.sayHi();