//Crear archivos TXT y realizar operaciones

using System.IO;

string texto;

try {
    StreamReader sr = new StreamReader("miArchivo.txt");
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
}