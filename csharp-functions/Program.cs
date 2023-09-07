// ESERCIZIO SULLE FUNZIONI
// definisco l'array di numeri interi
int[] arrayDiNumeri = { 2, 6, 7, 5, 3, 9 };

// stampo l'array di numeri interi
StampaArray(arrayDiNumeri);

Console.WriteLine(); // linea vuota 

// stampo l'array con i numeri elevati al quadrato
StampaArray(ElevaArrayAlQuadrato(arrayDiNumeri));
StampaArray(arrayDiNumeri);

Console.WriteLine(); // linea vuota

// stampo la somma di tutti i numeri
Console.WriteLine($"La somma di tutti i numeri interi contenuti nell'array è {sommaElementiArray(arrayDiNumeri)}");

Console.WriteLine(); // linea vuota

// stampo la somma di tutti i numeri elevati al quadrato
Console.WriteLine($"La somma di tutti i numeri interi contenuti nell'array ed elevati al quadrato è {sommaElementiArray(ElevaArrayAlQuadrato(arrayDiNumeri))}");



// FUNZIONI
// funzione per visualizzare in modo carino l'array
void StampaArray(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write(array[i] + ", ");
        }
        else
        {
            Console.Write(array[i]);
        }
    }

    Console.WriteLine("]");
}

// funzione che ritorna il quadrato di un numero
int Quadrato(int numero)
{
    return numero * numero;
}

// funzione che ti genera una copia dell'array che gli viene passata ed eleva tutti i suoi elementi al quadrato
int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] arrayCopy = (int[])array.Clone();

    for (int i = 0;i < arrayCopy.Length;i++)
    {
        arrayCopy[i] = Quadrato(arrayCopy[i]);
    }

    return arrayCopy;
}

// funzione che fa la somma di tutti gli elementi che si trovano dentro l'array passata
int sommaElementiArray(int[] array)
{
    int somma = 0;

    for (int i = 0; i < array.Length; i++)
    {
        somma += array[i];
    }

    return somma;
}