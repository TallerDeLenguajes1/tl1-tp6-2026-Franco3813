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

string c,d,e,x;
int f,g,h;
do{
    
    Console.WriteLine("Ingrese una operacion: \n1)Suma \n2)Resta \n3)Multiplicacion \n4)Divicion");
    c = Console.ReadLine();

    Console.WriteLine("Ingrese el primer numero: ");
    d = Console.ReadLine();
    Console.WriteLine("Ingrese el segundo numero: ");
    e = Console.ReadLine();
    
    if(int.TryParse(d, out f) && int.TryParse(e, out g)){

        if(c == "1"){
            h = f+g;
            Console.WriteLine("La suma es: "+h);
        }else if(c == "2"){
            h = f-g;
            Console.WriteLine("La resta es: "+h);
        }else if(c == "3"){
            h = f*g;
            Console.WriteLine("La multiplicacion es: "+h);
        }else if(c == "4" && g != 0){
            h = f/g;
            Console.WriteLine("La divicion es: "+h);
        }
    }

    Console.WriteLine("Desea hacer otra operacion? \n1)Si \n2)No");
    x = Console.ReadLine();
    
}while(x == "1");
