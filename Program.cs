﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// int a;

// int b;

// a = 10;

// b = a;

// Console.WriteLine("valor de a: "+a);
// Console.WriteLine("valor de b: "+b);


//punto 1

string num;
int i = 0;
bool resultado;
do
{
    Console.WriteLine("escriba un número mayor a 0: ");
    num = Console.ReadLine();
    resultado = int.TryParse(num, out i);
}while(resultado && i <= 0);

int aux = i;

static int invertir(int num)
{
    int resul=num%10;
    while(num >= 10)
    {
        num = num/10;
        resul = resul * 10 + (num%10);
    }
    return resul;
}

Console.WriteLine("el número invertido es: "+invertir(aux));



//CalculadoraV2

float n1, n2, n3, resul;
int oper, hacer;
string num1, num2, num3, operS, seguir;
bool esOper, esNum1, esNum2, esNum3, esSeguir;

do{
    Console.WriteLine("ingrese el número a operar: ");
    num3 = Console.ReadLine();
    
    esNum3 = float.TryParse(num3, out n3);

    if(esNum3)
    {
        Console.WriteLine("valor absoluto: " + Math.Abs(n3));
        Console.WriteLine("cuadrado: " + n3*n3);
        Console.WriteLine("raíz cuadrada: " + Math.Sqrt(n3));
        Console.WriteLine("seno: " + Math.Sin(n3));
        Console.WriteLine("coseno: " + Math.Cos(n3));
        Console.WriteLine("truncado: " + Math.Truncate(n3));
    }

    Console.WriteLine("ingrese un primer número: ");
    num1 = Console.ReadLine();
    Console.WriteLine("ingrese un segundo número: ");
    num2 = Console.ReadLine();

    esNum1 = float.TryParse(num1, out n1);
    esNum2 = float.TryParse(num2, out n2);

    if(esNum1 && esNum2)
    {
        Console.WriteLine("el número mayor es: "+Math.Max(n1, n2));
        Console.WriteLine("el número menor es: "+Math.Min(n1, n2));
    }

    do{
        Console.WriteLine("desea realizar otro cálculo? 1.Si 0.No");
        seguir = Console.ReadLine();
        esSeguir = int.TryParse(seguir, out hacer);
    }while(!esSeguir || hacer < 0 || hacer > 1);
}while(hacer != 0);


//CalculadoraV1

do{
    Console.WriteLine("qué operación desea hacer?:\n\t1.Sumar\n\t2.Restar\n\t3.Multiplicar\n\t4.Dividir\n");
    operS = Console.ReadLine();
    Console.WriteLine("ingrese el primer número a operar: ");
    num1 = Console.ReadLine();
    Console.WriteLine("ingrese el segundo número a operar: ");
    num2 = Console.ReadLine();

    esOper = int.TryParse(operS, out oper);
    esNum1 = float.TryParse(num1, out n1);
    esNum2 = float.TryParse(num2, out n2);

    if(esOper && esNum1 && esNum2)
    {
        switch(oper)
        {
            case 1:
                resul = n1 + n2;
                break;
            case 2:
                resul = n1 - n2;
                break;
            case 3:
                resul = n1 * n2;
                break;
            case 4:
                resul = n1 / n2;
                break;
            default:
                resul = 0;
                break;
        }
        Console.WriteLine("resultado: "+resul);
    }
    else
    {
        Console.WriteLine("algo de lo ingresado no es correcto");
    }

    do{
        Console.WriteLine("desea realizar otro cálculo? 1.Si 0.No");
        seguir = Console.ReadLine();
        esSeguir = int.TryParse(seguir, out hacer);
    }while(!esSeguir || hacer < 0 || hacer > 1);
}while(hacer != 0);


// punto 4

