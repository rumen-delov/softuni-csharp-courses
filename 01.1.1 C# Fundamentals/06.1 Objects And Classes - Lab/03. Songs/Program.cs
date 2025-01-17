﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs
{
    class Program
    {
        public class Song
        {
            public string TypeList { get; set; }

            public string Name { get; set; }

            public string Time { get; set; }
        }
        
        static void Main(string[] args)
        {
            // Number of songs as an input
            int numSongs = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < numSongs; i++)
            {
                string[] data = Console.ReadLine().
                    Split('_', StringSplitOptions.RemoveEmptyEntries);

                string type = data[0];
                string name = data[1];
                string time = data[2];

                Song song = new Song();

                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                songs.Add(song);
            }

            string typeList = Console.ReadLine();

            if (typeList == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                // Option 1
                
                //foreach (Song song in songs)
                //{
                //    if (song.TypeList == typeList)
                //    {
                //        Console.WriteLine(song.Name);
                //    }
                //}

                // Option 2
                // Using LINQ to filter the collection

                List<Song> filteredSongs = songs
                    .Where(s => s.TypeList == typeList)
                    .ToList();

                foreach (Song song in filteredSongs)
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }
}
