using System.Collections;

public class Song
{
    public string Title { get; set; }
}

//This class implements IEnumerable<Song> to be foreach-compatible.
public class Playlist : IEnumerable<Song>
{
    private List<Song> _song = new List<Song>();
    public void AddSong(Song song)
    {
        _song.Add(song);
    }

    public IEnumerator<Song> GetEnumerator()
    {
        return _song.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Playlist myPlaylist = new Playlist();
        myPlaylist.AddSong(new Song { Title = "Chamak Challo" });
        myPlaylist.AddSong(new Song { Title = "Tum Hi Ho" });
        myPlaylist.AddSong(new Song { Title = "Baby Doll" });

        //// We can now use foreach directly on our custom Playlist object
        foreach (Song song in myPlaylist)
        {
            Console.WriteLine(song.Title);
        }
    }
}