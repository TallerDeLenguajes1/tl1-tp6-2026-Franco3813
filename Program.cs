// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;
int b;

a = 0;
b = 20;

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
    Console.WriteLine("Funciona o nel "+aux +i);
}

do{
    Console.WriteLine("Ingrese una operacion: \n1)Suma \n2)Resta \n3)Multiplicacion \n4)Divicion");
    string c;
    c = Console.ReadLine();

    
    Console.WriteLine("El valo de a:"+c);

}while(a == 1);

