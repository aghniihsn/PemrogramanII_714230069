using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714230069
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<KpopArtist> artistList = new List<KpopArtist>();
            string choice;

            do
            {
                Console.WriteLine("K-Pop Agency Management");
                Console.WriteLine("1. Add Solo Artist");
                Console.WriteLine("2. Add Group Artist");
                Console.WriteLine("3. Display All Artists");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Stage Name: ");
                        string soloName = Console.ReadLine();
                        Console.Write("Enter Debut Year: ");
                        int soloDebutYear = int.Parse(Console.ReadLine());
                        Console.Write("Enter Genre: ");
                        string genre = Console.ReadLine();

                        SoloArtist soloArtist = new SoloArtist(soloName, soloDebutYear, genre);
                        artistList.Add(soloArtist);
                        Console.WriteLine("Solo Artist added successfully!\n");
                        break;

                    case "2":
                        Console.Write("Enter Group Name: ");
                        string groupName = Console.ReadLine();
                        Console.Write("Enter Debut Year: ");
                        int groupDebutYear = int.Parse(Console.ReadLine());
                        Console.Write("Enter Members Count: ");
                        int membersCount = int.Parse(Console.ReadLine());

                        GroupArtist groupArtist = new GroupArtist(groupName, groupDebutYear, membersCount);
                        artistList.Add(groupArtist);
                        Console.WriteLine("Group Artist added successfully!\n");
                        break;

                    case "3":
                        Console.WriteLine("Artists List:");
                        foreach (var artist in artistList)
                        {
                            artist.DisplayInfo();
                        }
                        Console.WriteLine();
                        break;

                    case "4":
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }

            } while (choice != "4");
        }
    }
}
