using System;

public class Video{
  private int id;
  private string nome;
  private DateTime duracao;
  private int idPlaylist;
  private int idCanal;

  public int Id{
    get => id;
    set => id = value;
  }  
  public string Nome {
    get => nome;
    set => nome = value;
  }
  public DateTime Duracao {
    get => duracao;
    set => duracao = value;
  }
  public int IdCanal{
    get => idCanal;
    set => idCanal = value;
  }
  public int IdPlaylist{
    get => idPlaylist;
    set => idPlaylist = value;
  }
  public Video(){ }
  
  public Video(int id){
    this.id = id;
  }
  public Video(int id, string nome, DateTime duracao, int idPlaylist, int idCanal){
    this.nome = nome;
    this.duracao = duracao;
    this.id = id;
    this.idPlaylist = idPlaylist;
    this.idCanal = idCanal;

  }
   public void Setnome(string nome){
    this.nome = nome;
  }
  public void SetId(int id){
    this.id = id;
  }
  public void SetDuracao(DateTime duracao){
    this.duracao = duracao;
  }
  public void SetIdPlaylist(int idPlaylist){
    this.idPlaylist = idPlaylist;
  }
  public string Getnome(){
    return nome;
  }
  public int GetId(){
    return id;
  }
  public int GetIdPLaylist(){
    return idPlaylist;
  }
  public DateTime GetDuracao(){
    return duracao;
  }
  public void SetIdCanal(int idCanal){
    this.idCanal = idCanal;
  }
  public int GetIdCanal(){
    return idCanal;
  }
  public override string ToString(){
    return $"{id} - {nome} - {duracao: HH:mm:ss} - {idPlaylist} - {idCanal} -";
  }
}
