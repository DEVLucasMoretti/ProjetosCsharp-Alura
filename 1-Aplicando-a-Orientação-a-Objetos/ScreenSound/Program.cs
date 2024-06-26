using ScreenSound;
using ScreenSound.DesafioHoraPratica;


Banda queen = new Banda("Queen");

Album albumdDoQueen = new Album("A night at the opera");

Musica musica1 = new Musica(queen, "Love of my life")
{
    Duracao = 213,         //propiedades opicionais da classe
    Disponivel = true,     //propiedades opicionais da classe
};
//musica1.Duracao = 213;
//musica1.Disponivel = true;
//ao invés de fazer um por utilizamos um construtor e para propiedades adiconais, utilizamos as chaves
Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,        //propiedades opicionais da classe
    Disponivel = false,   //propiedades opicionais da classe
};
musica2.Duracao = 354;

albumdDoQueen.AdicionarMusica(musica1);
albumdDoQueen.AdicionarMusica(musica2);


queen.AdicionarAlbum(albumdDoQueen);
queen.ExibirDiscografia();
musica1.ExibirFichaTecnica();
Console.WriteLine("");
musica2.ExibirFichaTecnica();




Episodio ep1 = new(1, "Técinicas de Facilitação", 45);
ep1.AdicionarConvidados("Lucas Moretti");
ep1.AdicionarConvidados("Wilson Neves");

Episodio ep2 = new(3, "Técinicas de Aprendizado", 65);
ep2.AdicionarConvidados("Clodoaldo Nunes");
ep2.AdicionarConvidados("Flavia Moura");

Episodio ep3 = new(2, "Técinicas de Memorização", 25);
ep3.AdicionarConvidados("Daniel Silva");
ep3.AdicionarConvidados("Victoria Fernades");

Podcast podcast = new("Douglassola", "Podcast especial");
podcast.AdicionarEpsodio(ep1);
podcast.AdicionarEpsodio(ep2);
podcast.AdicionarEpsodio(ep3);
Console.WriteLine("\n");
podcast.ExibirDetalhes();