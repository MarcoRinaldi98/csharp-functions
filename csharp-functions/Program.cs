// ESERCIZIO SULLE FUNZIONI
int elementiArray = 0;
// chiedo all'utente da quanti elementi vuole che sia formata l'array
Console.Write("Da quanti elementi vuoi che sia composta l'array? ");
while (int.TryParse(Console.ReadLine(), out elementiArray) == false)
{
    Console.Write("Non hai inserito un numero! Riprova: ");
}
Console.WriteLine($"Hai scelto che l'array dovrà contenere {elementiArray} elementi");

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
Console.WriteLine($"La somma di tutti i numeri interi contenuti nell'array è {SommaElementiArray(arrayDiNumeri)}");

Console.WriteLine(); // linea vuota

// stampo la somma di tutti i numeri elevati al quadrato
Console.WriteLine($"La somma di tutti i numeri interi contenuti nell'array ed elevati al quadrato è {SommaElementiArray(ElevaArrayAlQuadrato(arrayDiNumeri))}");

Console.WriteLine();



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
int SommaElementiArray(int[] array)
{
    int somma = 0;

    for (int i = 0; i < array.Length; i++)
    {
        somma += array[i];
    }

    return somma;
}

// EXTRA BONUS
// 1 - Una funzione che, dato un numero intero n > 0, ne calcoli il fattoriale.
Console.Write("Inserisci un numero: ");
int numero = int.Parse(Console.ReadLine());

if (numero < 0)
{
    Console.WriteLine("Il numero deve essere positivo.");
}
else
{
    long fattoriale = CalcolaFattoriale(numero);
    Console.WriteLine($"Il fattoriale di {numero} è {fattoriale}");
}

Console.WriteLine();

int CalcolaFattoriale(int n)
{
    if (n == 0 || n == 1)
    {
        return 1;
    }
    else
    {
        return n * CalcolaFattoriale(n - 1);
    }
}

// 2 - Una funzione che, dato un numero intero n >= 0, restituisca l'n-esimo elemento della sequenza di Fibonacci.
Console.Write("Inserisci un numero: ");
int n = int.Parse(Console.ReadLine());

if (n < 0)
{
    Console.WriteLine("Il numero non deve essere negativo.");
}
else
{
    int risultato = CalcolaFibonacci(n);
    Console.WriteLine($"L'n-esimo elemento della sequenza di Fibonacci con n = {n} è {risultato}");
}

int CalcolaFibonacci(int n)
{
    if (n == 0)
    {
        return 0;
    }
    else if (n == 1)
    {
        return 1;
    }
    else
    {
        return CalcolaFibonacci(n - 1) + CalcolaFibonacci(n - 2);
    }
}