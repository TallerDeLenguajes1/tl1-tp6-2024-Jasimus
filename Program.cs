// See https://aka.ms/new-console-template for more information
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



//punto 2

int n1, n2, resul, oper, hacer;

do{
    Console.WriteLine("qué operación desea hacer?:\n\t1.Sumar\n\t2.Restar\n\t3.Multiplicar\n\t4.Dividir\n");
    oper = Console.Read();
    Console.WriteLine("ingrese el primer número a operar: ");
    n1 = Console.Read();
    Console.WriteLine("ingrese el segundo número a operar: ");
    n2 = Console.Read();

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
    Console.WriteLine("desea realizar otro cálculo? 1.Si 0.No");
    hacer = Console.Read();
}while(hacer);
