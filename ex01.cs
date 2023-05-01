//Operações matematicas

//Calculo de média
int n1 = 8;
decimal n2 = 9.3m;
decimal n3 = 6.3m;
decimal media = n1 + n2 + n3 % 3 ;
string average = $"your average is : {media}";
Console.WriteLine(average);


//Executando divisao usando dados decimais iterais
decimal quotient = 25.2m / 4;
Console.WriteLine(quotient);

//divisão usando dados decimais literais  etp 4: Converter valor
int firstNumber = 65;
int secondNumber = 21;
float quotient = (float)firstNumber / (float)secondNumber;
Console.WriteLine(quotient);

//Divisao inteira
Console.WriteLine("Divisao inteira de 3 / 8: " + (3 % 8));
Console.WriteLine("Divisão inteira de 200 / 12: " +(200 % 12));

//Ordem das operaçoes PEMDAS
//Pârenteses (O que estiver dentro do pârenteses vai ser executado primeiro)
//Expoentes
//Multiplicação e Divisão (da esquerda para a direita)
//Adição e Subtração (da esquerda para a direita)

//Exemplo
int value1 = 21 + 3 * 4;
int value2 = (23+2) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);

//Incrementando decrementando valor em uma variavel
//Exemplo 1
int value = 1;

value += 1;
Console.WriteLine($"First Increment: {value}");

value = value + 1;
Console.WriteLine($"Second Increment: {value}");

value++;
Console.WriteLine($"Three Increment: {value}");

value -= 1;
Console.WriteLine($"First Decrement: {value}");

value--;
Console.WriteLine($"Second Decrement: {value}");

value = value - 1;
Console.WriteLine($"Three Decrement: {value}");

//Exemplo 2
int value = 1;
value++;
Console.WriteLine($"First: {value}");
Console.WriteLine($"Second: {value++}");
Console.WriteLine($"Three: {value}");
Console.WriteLine($"Four: {++value}");

//Convertendo fahrenheit para celcius
int fahrenheit = 94;
decimal celciues = ((decimal) fahrenheit - 32) / 1.8m;
Console.WriteLine(celciues);