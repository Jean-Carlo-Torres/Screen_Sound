using ScreenSound.Models;

/*
Musica musica1 = new Musica();
musica1.Nome = "Stairway to Heaven";
musica1.Artista = "Led Zeppelin";
musica1.Genero = "Rock";
musica1.Duracao = 480;
musica1.Disponivel = true;
Console.WriteLine(musica1.Disponivel);
Console.WriteLine(musica1.Descricao);

Musica musica2 = new Musica();
musica2.Nome = "Bohemian Rhapsody";
musica2.Artista = "Queen";
musica2.Genero = "Rock";
musica2.Duracao = 420;
musica2.Disponivel = false;
Console.WriteLine(musica2.Disponivel);
Console.WriteLine(musica2.Descricao);

Musica musica3 = new Musica();
musica3.Nome = "Hurt";
musica3.Artista = "Jonny Cash";
musica3.Genero = "Country";
musica3.Duracao = 220;
musica3.Disponivel = true;
Console.WriteLine(musica3.Disponivel);
Console.WriteLine(musica3.Descricao);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
musica3.ExibirFichaTecnica();
*/

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

