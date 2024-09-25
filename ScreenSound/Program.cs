using Microsoft.EntityFrameworkCore;
using ScreenSound.Banco;
using ScreenSound.Menus;
using ScreenSound.Modelos;

var context = new ScreenSoundContext();
var artistaDAL = new DAL<Artista>(context);

//using (context)
//{
//    var sql = "CREATE TABLE GeneroMusica (\n    GenerosId INT NOT NULL,\n    MusicasId INT NOT NULL,\n    PRIMARY KEY (GenerosId, MusicasId),\n    FOREIGN KEY (GenerosId) REFERENCES Generos(Id) ON DELETE CASCADE,\n    FOREIGN KEY (MusicasId) REFERENCES Musicas(Id) ON DELETE CASCADE\n);\n\nCREATE INDEX IX_GeneroMusica_MusicasId ON GeneroMusica (MusicasId);";
//    context.Database.ExecuteSqlRaw(sql);
//}


//Dictionary<int, Menu> opcoes = new();
//opcoes.Add(1, new MenuRegistrarArtista());
//opcoes.Add(2, new MenuRegistrarMusica());
//opcoes.Add(3, new MenuMostrarArtistas());
//opcoes.Add(4, new MenuMostrarMusicas());
//opcoes.Add(-1, new MenuSair());

//void ExibirLogo()
//{
//    Console.WriteLine(@"

//░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
//██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
//╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
//░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
//██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
//╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
//");
//    Console.WriteLine("Boas vindas ao Screen Sound 3.0!");
//}

//void ExibirOpcoesDoMenu()
//{
//    ExibirLogo();
//    Console.WriteLine("\nDigite 1 para registrar um artista");
//    Console.WriteLine("Digite 2 para registrar a música de um artista");
//    Console.WriteLine("Digite 3 para mostrar todos os artistas");
//    Console.WriteLine("Digite 4 para exibir todas as músicas de um artista");
//    Console.WriteLine("Digite 5 para exibir músicas por ano de lançamento");
//    Console.WriteLine("Digite -1 para sair");

//    Console.Write("\nDigite a sua opção: ");
//    string opcaoEscolhida = Console.ReadLine()!;
//    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

//    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
//    {
//        Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
//        menuASerExibido.Executar(artistaDAL);
//        if (opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();
//    } 
//    else
//    {
//        Console.WriteLine("Opção inválida");
//    }
//}

//ExibirOpcoesDoMenu();