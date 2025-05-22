using System;

class Program
{
    static float CacaNiquel(char a, char b, char c, char d, char e, char f, char g, char h)
    {
        char[] possibilidades = new char[] { a, b, c, d, e, f, g, h };
        Random rnd = new Random();
        int tentativas = 0;
        int dinheiro = 1000;
        int vitorias = 0;
        int premio = 280;
        int ficha = 5;

        char primeira, segunda, terceira;

        do
        {
            tentativas++;
            primeira = possibilidades[rnd.Next(possibilidades.Length)];
            segunda = possibilidades[rnd.Next(possibilidades.Length)];
            terceira = possibilidades[rnd.Next(possibilidades.Length)];

            //Console.WriteLine($"Tentativa {tentativas}: [{primeira}] [{segunda}] [{terceira}]");

            if (primeira != segunda || segunda != terceira)
            {
                dinheiro -= ficha;
            }
            else
            {
                dinheiro -= ficha;
                vitorias++;
                dinheiro += premio;
                //Console.WriteLine("Você ganhou!**************");
            }

        } while (tentativas < 10000 || dinheiro <= 0 || dinheiro >= 10000);
        if (dinheiro <= 0)
        {
            Console.WriteLine("Você Faliu! :(");
            Console.WriteLine($"Você venceu: {vitorias} vezes");
            Console.WriteLine($"Seu dinheiro: {dinheiro},00 $");
            Console.WriteLine($"Seu dinheiro ganho (mas faliu mesmo assim): {premio * vitorias},00 $");
        }
        else
        {
            Console.WriteLine("Você Ganhou na vida! :)");
            Console.WriteLine($"Você venceu: {vitorias} vezes");
            Console.WriteLine($"Seu dinheiro: {dinheiro},00 $");
            Console.WriteLine($"Seu dinheiro ganho: {premio * vitorias},00 $");
        }

        return 0.0f;
    }

    static void Main()
    {
        char A = 'A';
        char B = 'B';
        char C = 'C';
        char D = 'D';
        char E = 'E';
        char F = 'F';
        char G = 'G';
        char H = 'H';


        CacaNiquel(A, B, C, D, E, F, G, H);
    }
}
