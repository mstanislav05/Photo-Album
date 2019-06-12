//Mikaela Stanislav, Technical Showcase for Lean TECHniques, 6/11/2019
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using static PhotoAlbum.Classes;

namespace PhotoAlbum
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Please Enter An Album Number(999 for all albums), or -1 to exit\n");
            int choice = Int32.Parse(Console.ReadLine());
            while (choice != -1)
            {
                //displays error message and requests new input for invalid album numbers
                if(choice != 999 && (choice > 100 || choice < 1)) {
                    Console.Write("You have entered an invalid album number. Please try again.\n");
                    choice = Int32.Parse(Console.ReadLine());
                }

                List<Photo> albumList = GetAlbum(choice);
                //sets the master album id - used to display album number upon first instance of photo from album (for all album queries)
                int masterAlbumID = 1;
                //sets master album id to requested album if a single one is desired
                if (choice != 999)
                {
                    masterAlbumID = choice;
                }

                foreach(Photo p in albumList)
                {
                    if (masterAlbumID == p.albumId)
                    {
                        Console.Write("\nPhoto Album " + p.albumId + "\n\n");
                        masterAlbumID++;
                    }
                    Console.WriteLine("[{0}] {1} ",p.id, p.title);
                }
                Console.Write("\nPlease Enter An Album Number(999 for all albums), or -1 to exit\n");
                choice = Int32.Parse(Console.ReadLine());
            }
        }

        public static List<Photo> GetAlbum(int albumNumber)
        {
            //sets url - either for a specific album or all albums
            string url = "https://jsonplaceholder.typicode.com/photos?albumId=";
            url = url + albumNumber.ToString();

            if (albumNumber == 999)
                url = "https://jsonplaceholder.typicode.com/photos";

            //reads in JSON data and deserializes it into a List of object "Photo"
            System.Net.WebClient wc = new System.Net.WebClient();
            string webData = wc.DownloadString(url);
            List<Photo> photoList = JsonConvert.DeserializeObject<List<Photo>>(webData);

            return photoList;
        }
    }
}
    


