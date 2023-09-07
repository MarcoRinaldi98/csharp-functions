

// FUNZIONI
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

int Quadrato(int numero)
{
    return numero * numero;
}

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] arrayCopy = (int[])array.Clone();

    for (int i = 0;i < arrayCopy.Length;i++)
    {
        arrayCopy[i] = Quadrato(arrayCopy[i]);
    }

    return arrayCopy;
}

int sommaElementiArray(int[] array)
{
    int somma = 0;

    for (int i = 0; i < array.Length; i++)
    {
        somma += array[i];
    }

    return somma;
}