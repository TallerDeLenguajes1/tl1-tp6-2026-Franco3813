
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

string c,x,h,u,d,e;
double t,y;
float f,k,l,g,r,s;
do{
    Console.WriteLine("----------CalculadoraV1----------");
    Console.WriteLine("Ingrese una operacion: \n1)Suma \n2)Resta \n3)Multiplicacion \n4)Divicion");
    c = Console.ReadLine();
    Console.WriteLine("Ingrese el primer numero: ");
    d = Console.ReadLine();
    Console.WriteLine("Ingrese el segundo numero: ");
    e = Console.ReadLine();
    
    if(float.TryParse(d, out f) && float.TryParse(e, out g)){

        if(c == "1"){
            r = f+g;
            Console.WriteLine("La suma es: "+r);
        }else if(c == "2"){
            r = f-g;
            Console.WriteLine("La resta es: "+r);
        }else if(c == "3"){
            r = f*g;
            Console.WriteLine("La multiplicacion es: "+r);
        }else if(c == "4" && g != 0){
            r = f/g;
            Console.WriteLine("La divicion es: "+r);
        }
    }


    Console.WriteLine("----------CalculadoraV2----------");
    Console.WriteLine("Ingrese un numero: ");
    c = Console.ReadLine();
    
    if(float.TryParse(c,out s)){
        //Valor absoluto
        t = Math.Abs(s);
        Console.WriteLine("El valor absoluto: "+t);

        //Cuadrado
        t = Math.Pow(s,2);
        Console.WriteLine("El cuadrado: "+t);

        //Raiz cuadrada
        if (s >= 0){
            t = Math.Sqrt(s);
            Console.WriteLine("La raiz cuadrada: "+t);
        }
        else{
            Console.WriteLine("No existe la raiz cuadrada");
        }

        //Radianes
        y = f * Math.PI / 180;

        //Seno
        t = Math.Sin(y);
        Console.WriteLine("Seno: "+t);

        //Coseno
        t = Math.Cos(y);
        Console.WriteLine("Coseno: "+t);

        //La parte entera de un tipo float
        t = Math.Round(s);
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


