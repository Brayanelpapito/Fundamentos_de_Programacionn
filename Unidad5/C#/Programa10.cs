using System.Text; 
namespace Programa10;

class Password{
    static void Main(string[] args){
        int longitud=8;
        Console.Write("Password: "+random(longitud));
    }
    public static String random(int x){ //x es el tamaño    
       
        string letras = "ABSLHDLHKAH/$%#&_jkjsaloqn"; //Doble comilla para string y comillas simpre para caracter
        StringBuilder cadena = new StringBuilder(x); //Construir caracteres como un arreglo 
        Random alea = new Random(); //Funcion para que genere un numero aleatorio
       
        for(int i=0; i<x; i++){
        
           int IndiceCaracter = alea.Next(letras.Length); 
           cadena.Append(letras[IndiceCaracter]); 
        
        }
        return cadena.ToString(); //toString() el resultado lo conviertes en texto
    }
}