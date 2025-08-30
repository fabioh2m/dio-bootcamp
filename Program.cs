using System.Formats.Asn1;
using System.Runtime.InteropServices;
using dio.Model;


// se executar assim sem dar um limite ao contador com ++, vai executar para sempre loop infinito.
// int numero = 5;

// while (true)

// {   


//     for (int contador = 1; contador <= 10; contador++)
//         Console.WriteLine($"{numero} x {contador} = {numero * contador}");

// }


// Agora com o contador ++, ele vai executar 10 vezes e parar.
int numero = 5;
int contador = 0;
while (contador <= 10)



{

    Console.WriteLine($"{contador}° {numero} x {contador} = {numero * contador}");
    contador++;
        // break; // com o break ele para a execução do laço, quando chegar no loop 6, mesmo que a condição seja verdadeira.
        if (contador == 6)
        {
            break;
        }   
}





















// int numero = 5;

// for (int contador = 1; contador <= 10; contador++)
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");





//Calculadora calc = new Calculadora();

// calc.Somar(10, 30);
// calc.Subtrair(10, 50);
// calc.Multiplicar(15, 45);
// calc.Dividir(2, 2);
//calc.Potencia(3, 3);
//  calc.Seno(30);
//  calc.Coseno(30);     
//  calc.Tangente(30);
//calc.RaizQuadrada(9);

// int numero = 10;

// Console.WriteLine(numero);
// numero++;















//operador NOT ! inverte o valor lógico de uma expressão. Se a expressão for verdadeira, o operador NOT a torna falsa, e vice-versa.

// bool choveu = false;
// bool estaTarde = false;  

// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar");
// }
// else
// {
//     Console.WriteLine("Vou pedalar outro dia");
// }   




// bool presencaMinima = true;
// double notaMinima = 7.5;

// if (presencaMinima && notaMinima >= 7)
// {
//     Console.WriteLine("Aprovado");
// }
// else
// {
//     Console.WriteLine("Reprovado");
// }  






//no casso do operador ||, se uma das condições for verdadeira, o bloco será executado como verdadeiro. se fosse o operador &&, se uma das condições fosse falsa, todas as condições seriam anuladas.
// bool ehMaiorDeIdade = false;
// bool possuiAutorizacaoDoResponsavel = false;

// if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada liberada");
// }
// else
// {
//     Console.WriteLine("Entrada não liberada");
// }







// Console.WriteLine(" Digite uma letra: ");

// string letra = Console.ReadLine()!;

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;
//     default:
//         Console.WriteLine("Não é vogal ");
//         break;
// }





// if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Não é vogal ");
// } 


















// if (letra == "a")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "e")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "i")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "o")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Não é vogal ");
// }




// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");

// Console.WriteLine($"Quantidade de compra: {quantidadeCompra}");

// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");


// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda invalida A quantidade de compra deve ser maior que zero");
// }

// else if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada com sucesso");
// }
// else
// {
//     Console.WriteLine("Não temos a quantidade desejada em estoque");
// }











// string a = "15-";
// int b = 0;

// int.TryParse(a, out b); // conversão explícita
// Console.WriteLine(b);

// Console.WriteLine("conversão realizado com sucesso");






//ordem das operações () * / + -

// double a = 4 / 2 + 2;
// Console.WriteLine(a);








// int a = 10;
// double b = a; // conversão implícita
// Console.WriteLine(b);

// double a = 10;




// int inteiro = 5;

// string a = inteiro.ToString();
// Console.WriteLine(a);



// int a = 10;
// int b = 20;
// int c = a + b;
// c = c + 5; // aqui estou somando c + 5;
// // c += 5; // esta é a forma reduzida de fazer o mesmo que a linha acima e posso usar também para subtração -, multiplicação * e divisão /.
// Console.WriteLine(c);





// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyy HH:mm"));



//Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm")); desta forma exibe NÃO os milisegundos.














// string apresentacao = "Olá, seja bem vindo";

// int quantidade = 10;

// double altura = 1.90;

// decimal preco = 1.89m;

// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("valor da variável quantidade: " + quantidade);
// Console.WriteLine("valor da variável altura: " + altura.ToString("0.00"));
// Console.WriteLine("valor da variável preco: " + preco);
// Console.WriteLine("valor da variável condicao: " + condicao);









//Pessoa pessoa = new Pessoa();

//pessoa.Nome = "Fábio";
//pessoa.Idade = 53;
//pessoa.Apresentar();