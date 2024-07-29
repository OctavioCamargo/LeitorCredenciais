/*Fazer um programa que leia o nome (apenas uma palavra) e a idade de duas pessoas.
Ao final mostrar uma mensagem com os nomes e a idade media dessas 2 pessoas, com uma casa decimal.*/

String nome1, nome2;
int idade1, idade2;
double media;

//criando um vetor de string e nomeando ele como vet
string[] vet;

//precisamos separar cada string do vetor e para isso vamos utilizar Split e usar como separador o espaco, ficando da seguinte maneira:
vet = Console.ReadLine().Split(' ');
nome1 = vet[0]; //estamos fazendo a variavel nome1 receber o valor do vetor posicao 0.
idade1 = int.Parse(vet[1]); //utilizando int.Parse podemos converter o valor de string para inteiro

nome2 = vet[2];
idade2 = int.Parse(vet[3]);


media = (idade1 + idade2) / 2.0; //calculando a media entre as duas idades

Console.WriteLine("A idade media de " + vet[0] + " e " + vet[2] + " é de "+ media);