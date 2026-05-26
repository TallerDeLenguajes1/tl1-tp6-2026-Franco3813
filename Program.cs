// See https://aka.ms/new-console-template for more information
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

string texto,texto2,texto3,texto4,concat,sub,mayuscula,minuscula,operacion;
int primero,segundo;

Console.WriteLine("Ingrese una linea de texto: ");
texto = Console.ReadLine();

int longitud = texto.Length;
Console.WriteLine("Longitud de texto: "+longitud);

Console.WriteLine("Ingrese una segunda linea de texto: ");
texto2 = Console.ReadLine();
concat = texto+texto2;
Console.WriteLine("concatenacion de ambos textos: "+concat);

sub = texto.Substring(2);
Console.WriteLine("Sub texto: "+sub);


string c,d,e;
int f,g,r;
Console.WriteLine("Ingrese una operacion: \n1)Suma \n2)Resta \n3)Multiplicacion \n4)Divicion");
c = Console.ReadLine();
Console.WriteLine("Ingrese el primer numero: ");
d = Console.ReadLine();
Console.WriteLine("Ingrese el segundo numero: ");
e = Console.ReadLine();
    
if(int.TryParse(d, out f) && int.TryParse(e, out g)){

    if(c == "1"){
        r = f+g;
        Console.WriteLine("La suma de "+f.ToString()+" y de "+g.ToString()+" es igual a "+r.ToString());
    }else if(c == "2"){
        r = f-g;
        Console.WriteLine("La resta de "+f.ToString()+" y de "+g.ToString()+" es igual a "+r.ToString());
    }else if(c == "3"){
        r = f*g;
        Console.WriteLine("La multiplicacion de "+f.ToString()+" y de "+g.ToString()+" es igual a "+r.ToString());
    }else if(c == "4" && g != 0){
        r = f/g;
        Console.WriteLine("La divicion de "+f.ToString()+" y de "+g.ToString()+" es igual a "+r.ToString());
    }
}

foreach (char letra in texto){
    Console.WriteLine("Texto mostrado por un foreach: "+letra);
}

Console.WriteLine("Ingrese una cadena:");
texto4 = Console.ReadLine();

Console.WriteLine("Ingrese la palabra a buscar:");
string palabra = Console.ReadLine();

texto4 = texto4.ToLower();
palabra = palabra.ToLower();

string[] partes1 = texto4.Split(' ');
int contador = 0;

foreach (string p in partes1){
    string limpia = p.Trim();

    if (limpia == palabra){
        contador++;
    }
}

Console.WriteLine("La palabra aparece: " + contador + " veces");

mayuscula = texto.ToUpper();
Console.WriteLine("Texto en mayuscula: "+mayuscula);

minuscula = texto.ToLower();
Console.WriteLine("Texto en minuscula: "+minuscula);

Console.WriteLine("Ingrese una linea de texto separada por coma: ");
texto3 = Console.ReadLine();

string[] sub2 = texto3.Split(',');
Console.WriteLine("Partes separadas: ");

foreach (string separado in sub2){
    Console.WriteLine(separado);
}

Console.WriteLine("Ingrese una operacion: ");
operacion = Console.ReadLine();
char operador = ' ';
foreach (char signo in operacion)
{
    if (signo == '+' || signo == '-' || signo == '*' || signo == '/'){
        operador = signo;
    }
}

string[] partes = operacion.Split(operador);


bool num1 = int.TryParse(partes[0], out primero);
bool num2 = int.TryParse(partes[1], out segundo);

if(operador == '+'){
    Console.WriteLine("La suma es: "+(primero+segundo));
}else if(operador == '-'){
    Console.WriteLine("La resta es: "+(primero-segundo));
}else if(operador == '*'){
    Console.WriteLine("La multiplicacion es: "+(primero*segundo));
}else if(operador == '/' && segundo != 0){
    Console.WriteLine("La divicion es: "+(primero/segundo));
}else{
    Console.WriteLine("Operacion no valida");
}