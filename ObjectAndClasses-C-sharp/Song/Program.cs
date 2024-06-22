
using System;
namespace Songs;
class Song
{
    private string typeList;
    private string name;
    private string time;
    public Song(string typeList, string name, string time)
    {
        this.typeList = typeList;
        this.name = name;
        this.time = time;
    }
    public string nGetName()
    {
        return name;
    }
    public string GetTypeList()
    {
        return typeList;
    }
}
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Song[] songs = new Song[n];
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            string[] songInfo = input.Split('_');

            Song song = new Song(songInfo[0], songInfo[1], songInfo[2]);

            songs[i] = song;
        }

        string command = Console.ReadLine();

        if (command == "all")
        {
            foreach (Song song in songs)
            {
                Console.WriteLine(song.nGetName());
            }
        }
        else
        {
            foreach (Song song in songs)
            {
                if (song.GetTypeList() == command)
                {
                    Console.WriteLine(song.nGetName());
                }
            }
        }
    }
}
