using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;


class Programan
{
    public static void Main()
{

    Queue<string> cola = new Queue<string>();

    while (true)
    {
        Console.WriteLine("Escriba las cadenas de texto que desee almacenar en la queue");
        Console.WriteLine("o introduzca una cadena vacia para recibir lo almacenado en la queue");
        Console.WriteLine("");

        string datoEnQueue = Console.ReadLine();

        Console.WriteLine("");

        if (datoEnQueue == "")
        {
            MostrarQueue(cola);
            break;
        }
        else
        {
            cola.Enqueue(datoEnQueue);
        }
    }

    static void MostrarQueue(Queue<string> cola)
    {
        while (cola.Count > 0)
        {
            string dato = (string)cola.Dequeue();

            Console.WriteLine(dato);
        }
    }
}


}

