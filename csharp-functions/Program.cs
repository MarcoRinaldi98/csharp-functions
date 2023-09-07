// ESERCIZIO SULLE FUNZIONI
// chiedo all'utente da quanti elementi vuole che sia formata l'array
Console.Write("Da quanti elementi vuoi che sia composta l'array? ");
int elementiArray = int.Parse(Console.ReadLine());

// in base alla risposta dell'utente creo un array di tale dimensione e chiedo ogni numero da inserire all'utente
int[] arrayDiNumeri = new int[elementiArray];
for (int i = 0; i < arrayDiNumeri.Length; i++)
{
    Console.Write($"Inserisci il {i + 1}° numero: ");
    arrayDiNumeri[i] = int.Parse(Console.ReadLine());
}

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