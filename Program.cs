// See https://aka.ms/new-console-template for more information
using System.IO.Compression;

Console.WriteLine("Hello, World!");

int a;
int b;

a = 10;
b = a;

Console.WriteLine("El valo de a:"+a);
Console.WriteLine("El valor de b:"+b);

int i = 0;
string dato;
Console.WriteLine("Ingrese un numero: ");
dato = Console.ReadLine();

if(int.TryParse(dato, out i) && i > 0){
    int aux = 0;
    while(i >= 10){
        aux  = aux*10 + i%10;
        i = i/10;
    }
    Console.WriteLine("El numero invertido es: "+aux +i);
}

string c,x,h,u;
double e,t;
float f,k,l;
do{

    Console.WriteLine("Ingrese un numero: ");
    c = Console.ReadLine();
    
    if(float.TryParse(c,out f)){
        //Valor absoluto
        t = Math.Abs(f);
        Console.WriteLine("El valor absoluto: "+t);

        //Cuadrado
        t = Math.Pow(f,2);
        Console.WriteLine("El cuadrado: "+t);

        //Raiz cuadrada
        if (f >= 0){
            t = Math.Sqrt(f);
            Console.WriteLine("La raiz cuadrada: "+t);
        }
        else{
            Console.WriteLine("No existe la raiz cuadrada");
        }

        //Radianes
        e = f * Math.PI / 180;

        //Seno
        t = Math.Sin(e);
        Console.WriteLine("Seno: "+t);

        //Coseno
        t = Math.Cos(e);
        t = Math.Round(t);
        Console.WriteLine("Coseno: "+t);

        //La parte entera de un tipo float
        t = Math.Round(f);
        Console.WriteLine("La parte entera del float: "+t);


    }
    else{
        Console.WriteLine("El dato ingresado no es un numero");
    }

    Console.WriteLine("Ingrese el primer numero: ");
    h = Console.ReadLine();

    Console.WriteLine("Ingrese el segundo numero: ");
    u = Console.ReadLine();

    if (float.TryParse(h,out k) && float.TryParse(u,out l)){
        if (k < l){
            Console.WriteLine("El numero maximo es: "+l);
            Console.WriteLine("El numero minimo es: "+k);
        }
        else{
            Console.WriteLine("El numero maximo es: "+k);
            Console.WriteLine("El numero minimo es: "+l);
        }
        
    }

    

    Console.WriteLine("Desea hacer otra operacion? \n1)Si \n2)No");
    x = Console.ReadLine();
    
}while(x == "1");


