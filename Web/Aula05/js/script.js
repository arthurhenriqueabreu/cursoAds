/*
    Aula de JavaScript
    Conceitos Básicos
*/

//Variaveis

var nome = "Marcelo"; //String
var nome = 'Marcelo'+nome; //String
var nome = `Marcelo ${nome}`; //String

let opcao = true; //boolean
let peso = 80.5; //float
let idade = 47; //inteiro

let idades = [42, 36, 7, 99]; //Array
console.log(idades[0])
console.log(idades[1])
console.log(idades[2])
console.log(idades[3])
console.log(idades[4])
idades[99] = "ultimo";
console.log(idades);

let valores = [10, 'Marcelo', 5.55, true];
console.log(valores)

console.log(nome);

nome = 1;

console.log(nome);

let objeto = document.querySelector("h1");
console.log(objeto.textContent);
objeto.textContent = "Novo Texto";

//funções
function soma(n1=2, n2=3){
    console.log(`Soma: ${n1+n2}`)
}

soma(4, 6);
soma(8, 9);
soma(0, 1);
soma();