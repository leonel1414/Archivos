//Crear archivos TXT y realizar operaciones
/*
using System.IO;

string texto;

try {
    StreamReader sr = new StreamReader("C:\\Users\\leoo9\\source\\repos\\Archivos\\miArchivo.txt");
    var linea = sr.ReadLine();

    while (linea != null)
    {
        Console.WriteLine(linea);
        linea = sr.ReadLine();
    }
    sr.Close();
    Console.ReadKey();
} catch (Exception ex) {

    Console.WriteLine("Ha ocurrido un error" + ex.Message);
*/

//Conseguir un JSON de una API y usar su contenido
/*Creamos un request y un response para obtener el JSON
 * request  = peticion al servidor del API
 * response = gurdamos los datos que obtenemos de la peticion
 */

/*
using System.Net;

HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"https://pokeapi.co/api/v2/pokemon/ditto");

HttpWebResponse response = (HttpWebResponse)request.GetResponse();

//Creamos un stream
Stream stream = response.GetResponseStream();
StreamReader reader = new StreamReader(stream);

var json = reader.ReadToEnd();

Console.WriteLine(json);

*/


//MANEJO DE EXCEPCIONES
//Situaciones inesperada -> no deseada -> "error"

Console.WriteLine($"1 entre 2: {DivisionSegura(1,2)}");
try
{
    Console.WriteLine($"1 entre 0: {DivisionSegura(1, 0)}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ha ocurrido este Error: {ex.Message}");
}
finally {
    Console.WriteLine("Es correcto el valor que aparece?");
    //logica para que el usuario verifique si el valor es correcto;
}

//continuamos con el programa si capturamos la excepcion (catch)
Console.WriteLine($"1 entre 3: {DivisionSegura(1, 3)}"); //comprobamos que funciona

int[] arr = new int[3];
arr[0] = 1;
arr[1] = 2;
arr[2] = 3;
Console.WriteLine(arr[3]);

try {
Console.WriteLine(arr[3]);
} catch(Exception ex) {
Console.WriteLine(ex.Message);     
}


static double DivisionSegura(double a, double b) {

    if (b == 0) { 
        throw new DivideByZeroException();
    
    }
    return a / b;
}


/*Tipos
 *Exception -> clase base de las Excepciones
 *IndexOutOfRangeException -> Se intento pedir un elemento que no existe en un array, etc..
 *NullReferenceException -> Se pidio un objeto null. 
    object obj = null;
    obj.ToString();
 *ArgumentException -> clase base para Excepciones relacionadas con argumentos.
 *ArgumentNullException
    string str = null;
    str.Substring(0,2);

 */
