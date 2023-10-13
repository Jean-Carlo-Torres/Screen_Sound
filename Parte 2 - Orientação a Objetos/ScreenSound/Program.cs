using ScreenSound.Models;

Console.WriteLine("\n - Playlist - Metallica\n");

Banda metallica = new Banda("Metallica");
Album albumDoMetallica = new Album("...And Justice for All");

Musica musica1 = new Musica(metallica, "Enter Sandman", "Rock")
{
    Duracao = 331,
    Disponivel = true
};

Musica musica2 = new Musica(metallica, "Nothing Else Matters", "Rock")
{
    Duracao = 390,
    Disponivel = true
};

Musica musica3 = new Musica(metallica, "The Unforgiven", "Rock")
{
    Duracao = 430,
    Disponivel = true
};

albumDoMetallica.AdicionarMusica(musica1);
albumDoMetallica.AdicionarMusica(musica2);
albumDoMetallica.AdicionarMusica(musica3);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
musica3.ExibirFichaTecnica();

metallica.AdicionarAlbum(albumDoMetallica);
metallica.ExibirDiscografia();

Console.WriteLine("\n===============================\n");

Console.WriteLine(" - Podcast mais ouvidos da semana\n");

Episodio ep1 = new (1, "Top Series de 2023", 90);
ep1.AdicionarConvidado("Edward");
ep1.AdicionarConvidado("Luis");

Episodio ep2 = new (2, "Técnicas de Machine Learning", 40);
ep2.AdicionarConvidado("Daniel");

Podcast podcast = new ("Podcast semanal", "Daniel");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();
