internal class Program
{
    private static void Main(string[] args)
    {


        Console.WriteLine("Saisir le niveau de son personnage");
        int niveau = int.Parse(Console.ReadLine());

        Console.WriteLine("Classe de son personnage ");
        char classe = char.Parse(Console.ReadLine());

        Console.WriteLine("Saisir le nombre de quêtes accomplis");
        int quetes = int.Parse(Console.ReadLine());

        if (niveau <= 10)
        {
            Console.WriteLine("Novice");
        }
        else if (niveau > 10 && niveau <= 20)
        {
            Console.WriteLine("Adepte");
        }
        else if (quetes < 5)
        {
            Console.WriteLine("Apprenti assermenté");
        }
        else if (niveau > 20 && niveau <= 30 || classe == 'M' && niveau >= 25)
        {
            Console.WriteLine("Vétéran");
        }
        else if (niveau > 30 && quetes > 20 && classe == 'G' && classe == 'M')
        {
            Console.WriteLine("Maître de Guilde");
        }
        else if (classe == 'R')
        {
            Console.WriteLine("Examen spécial ");
        }
        else if (niveau > 30 && quetes <= 20)
        {
            Console.WriteLine("Statut inderterminé / Hors la loi ");
        }
    }
}