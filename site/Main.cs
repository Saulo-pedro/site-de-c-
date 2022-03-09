using System;

class Program{
  public static void Main(){
    int op = 0;
    do{
      try{
      op = Menu();
        switch(op){
          case 1 : InserirPlaylist(); break;
          case 2 : ListarPlaylist(); break;
          case 3 : AtualizarPlaylist(); break;
          case 4 : ExcluirPlaylist(); break;
        }
      }catch(Exception erro) {
        op = -1;
        Console.WriteLine("Erro: " + erro.Message);
      }
    }while(op != 0);
  }

  public static int Menu(){
    Console.WriteLine();
    Console.WriteLine("-------- Escolha uma opção -----");
    Console.WriteLine("01 - Inserir uma nova Playlist");
    Console.WriteLine("02 - Listar as playlists cadastradas");
    Console.WriteLine("03 - Atualizar as playlists cadastradas");
    Console.WriteLine("04 - Excluir uma playlist cadastrada");
    Console.WriteLine("00 - finalizar o sistema");
    Console.WriteLine("--------------------------------");
    Console.Write("opção: ");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine();
    return n;
  }
  public static void InserirPlaylist(){
    Console.Write("Inserir o id: ");
    int z = int.Parse(Console.ReadLine());
    Console.Write("Inserir uma nova Playlist: ");
    string x = Console.ReadLine();
    Console.Write("Inserir uma nova musica: ");
    string y = Console.ReadLine();

    Playlist obj = new Playlist(x, y, z);
    Sistema.InserirPlaylist(obj);
    Console.WriteLine("--- operação realizada com sucesso ------");
  }
  public static void ListarPlaylist(){
    Console.WriteLine("---------- listar as playlists existentes");
    foreach(Playlist obj in Sistema.ListarPlaylist())
      Console.WriteLine(obj);
    Console.WriteLine("-------------------------");
  }
  public static void AtualizarPlaylist(){
  Console.Write("Inserir o id: ");
      int z = int.Parse(Console.ReadLine());
      Console.Write("Atualizar uma nova Playlist: ");
      string x = Console.ReadLine();
      Console.Write("Atualizar uma nova musica: ");
      string y = Console.ReadLine();
  
      Playlist obj = new Playlist(x, y, z);
      Sistema.AtualizarPlaylist(obj);
      Console.WriteLine("--- operação realizada com sucesso ------");
  }
  public static void ExcluirPlaylist(){
  Console.Write("Inserir o id: ");
      int z = int.Parse(Console.ReadLine());
      string x = "";
      string y = "";
  
      Playlist obj = new Playlist(x, y, z);
      Sistema.ExcluirPlaylist(obj);
      Console.WriteLine("--- operação realizada com sucesso ------");
  }
}
  // lista de videos
  public static void InserirVideo(){
    Console.Write("Informe o id: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Informe Nome do video: ");
    string nome = Console.ReadLine();
    Console.Write("Informe a duração do video: ");
    DateTime duracao = DateTime.Parse(Console.ReadLine());

    ListarPlaylist();
    Console.Write("Informe o id da Playlist: ");
    int idPlaylist = int.Parse(Console.ReadLine());
    
    Video obj = new Video(id, nome, duracao, idPlaylist);
    Sistema.InserirVideo(obj);
    Console.WriteLine("--- operação realizada com sucesso ------");
  }
  public static void ListarVideo(){
    Console.WriteLine("---------- listar as playlists existentes: ");
    foreach(Video obj in Sistema.ListarVideo())
      Console.WriteLine(obj);
    Console.WriteLine("-------------------------");
  }
  public static void AtualizarVideo(){
    Console.Write("Informe o id do video para ser atualizado");
    int id = int.Parse(Console.ReadLine());
  
    Console.Write("Informe Nome do video: ");
    string nome = Console.ReadLine();
    Console.Write("Informe a duração do video: ");
    DateTime duracao = DateTime.Parse(Console.ReadLine());
    ListarPlaylist();
    Console.Write("Informe o id da Playlist: ");
    int idPlaylist = int.Parse(Console.ReadLine());
  
      Video obj = new Video(id, nome, duracao, idPlaylist);
      Sistema.AtualizarVideo(obj);
      Console.WriteLine("--- operação realizada com sucesso ------");
  }
  public static void ExcluirVideo(){
  Console.Write("Inserir o id: ");
      int id = int.Parse(Console.ReadLine());
  
      Video obj = new Video(id);
      Sistema.ExcluirVideo(obj);
      Console.WriteLine("--- operação realizada com sucesso ------");
  }
}
