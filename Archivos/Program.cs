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
using System.Net;

HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"https://cat-fact.heroku.com/facts");

HttpWebResponse response = (HttpWebResponse)request.GetResponse();

//Creamos un stream
Stream stream = response.GetResponseStream();
StreamReader reader = new StreamReader(stream);

var json = reader.ReadToEnd();