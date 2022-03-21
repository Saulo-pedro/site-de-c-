using System;

class Program{
  public static void Main(){

    try{
      Sistema.ArquivosAbrir();
    }
    catch(Exception erro){
      Console.WriteLine(erro.Message);
    }
    int op = 0;
    do{
      try{
      op = Menu();
        switch(op){
          case 1  : InserirCanal(); break;
          case 2  : ListarCanal(); break;
          case 3  : AtualizarCanal(); break;
          case 4  : ExcluirCanal(); break;
          case 5  : InserirPlaylist(); break;
          case 6  : ListarPlaylist(); break;
          case 7  : AtualizarPlaylist(); break;
          case 8  : ExcluirPlaylist(); break;
          case 9  :  InserirVideo(); break;
          case 10 : ListarVideo(); break;
          case 11 : AtualizarVideo(); break;
          case 12 : ExcluirVideo(); break;
        }
      }catch(Exception erro) {
        op = -1;
        Console.WriteLine("Erro: " + erro.Message);
      }
    }while(op != 0);
    try{
      Sistema.ArquivosSalvar();
    }
    catch(Exception erro){
      Console.WriteLine(erro.Message);
    }
      
    }

  public static int Menu(){
    Console.WriteLine();
    Console.WriteLine("-------- Escolha uma opção -----");
    Console.WriteLine("01 - Inserir um novo Canal");
    Console.WriteLine("02 - Listar os Canais cadastrados");
    Console.WriteLine("03 - Atualizar os Canais cadastrados");
    Console.WriteLine("04 - Excluir um Canal");
    Console.WriteLine("05 - Inserir uma nova playlist");
    Console.WriteLine("06 - Listar as playlist cadastradas");
    Console.WriteLine("07 - Atualizar as playlists cadastradas");
    Console.WriteLine("08 - Excluir uma playlist");
    Console.WriteLine("09 - Inserir um novo video");
    Console.WriteLine("10 - Listar os videos cadastrados");
    Console.WriteLine("11 - Atualizar os videos cadastrados");
    Console.WriteLine("12 - Excluir um video");
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
    Console.Write("Inserir o nome da Playlist: ");
    string x = Console.ReadLine();

    ListarCanal();
    Console.Write("Inserir o id do canal: ");
    int idCanal = int.Parse(Console.ReadLine());
    


    Playlist obj = new Playlist(x, z, idCanal);
    Sistema.InserirPlaylist(obj);
    Console.WriteLine("--- operação realizada com sucesso ------");
  }
  public static void ListarPlaylist(){
    Console.WriteLine("---------- listar as playlists existentes");
    foreach(Playlist obj in Sistema.ListarPlaylist()){
       Canal c = Sistema.ListarCanal(obj.GetIdCanal());

      Console.WriteLine($"{obj} - {c.Nome}");
    }
    Console.WriteLine("-------------------------");
  }
  public static void AtualizarPlaylist(){
  Console.Write("Inserir o id: ");
      int z = int.Parse(Console.ReadLine());
      Console.Write("Atualizar a Playlist: ");
      string x = Console.ReadLine();
    Console.Write("Atualizar o canal: ");
      int idCanal = int.Parse(Console.ReadLine());
  
      Playlist obj = new Playlist(x, z, idCanal);
      Sistema.AtualizarPlaylist(obj);
      Console.WriteLine("--- operação realizada com sucesso ------");
  }
  public static void ExcluirPlaylist(){
  Console.Write("Inserir o id: ");
      int z = int.Parse(Console.ReadLine());
      string x = "";
    int y = 0;
  
      Playlist obj = new Playlist(x, z, y);
      Sistema.ExcluirPlaylist(obj);
      Console.WriteLine("--- operação realizada com sucesso ------");
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
    ListarCanal();
    Console.Write("Informe o id do Canal: ");
    int idCanal = int.Parse(Console.ReadLine());

    
    Video obj = new Video(id, nome, duracao, idPlaylist, idCanal);
    Sistema.InserirVideo(obj);
    Console.WriteLine("--- operação realizada com sucesso ------");
  }
  public static void ListarVideo(){
    Console.WriteLine("---------- listar os videos existentes: ");
    foreach(Video obj in Sistema.ListarVideo()){
      Playlist p = Sistema.ListarPlaylist(obj.GetIdPLaylist());
      Canal c = Sistema.ListarCanal(obj.GetIdCanal());
      
    Console.WriteLine($"{obj} - {p.Getnome()} - {c.Nome}");
    }
    Console.WriteLine("--------------------------");
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

     ListarCanal();
    Console.Write("Informe o id do Canal: ");
    int idCanal = int.Parse(Console.ReadLine());
  
      Video obj = new Video(id, nome, duracao, idPlaylist, idCanal);
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


 
   // lista de canais
  public static void InserirCanal(){
    Console.Write("Informe o id: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Informe Nome do Canal: ");
    string nome = Console.ReadLine();
    
    Canal obj = new Canal { Id = id, Nome = nome};
    Sistema.InserirCanal(obj);
    Console.WriteLine("--- operação realizada com sucesso ------");
  }
  public static void ListarCanal(){
    Console.WriteLine("---------- listar os canais existentes: ");
    foreach(Canal obj in Sistema.ListarCanal())
      Console.WriteLine(obj);
    Console.WriteLine("-------------------------");
  }
  public static void AtualizarCanal(){
    Console.Write("Informe o id: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Informe Nome do Canal: ");
    string nome = Console.ReadLine();
    
    Canal obj = new Canal { Id = id, Nome = nome};
      Sistema.AtualizarCanal(obj);
      Console.WriteLine("--- operação realizada com sucesso ------");
  }
  public static void ExcluirCanal(){
      Console.Write("Inserir o id: ");
      int id = int.Parse(Console.ReadLine());
  
      Canal obj = new Canal { Id = id};
      Sistema.ExcluirCanal(obj);
      Console.WriteLine("--- operação realizada com sucesso ------");
  }
}
