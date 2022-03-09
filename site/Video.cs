using System;

class Video{
  private int id;
  private string nome;
  private DateTime duracao;
  private int idPlaylist;
  
  public Video(int id){
    this.nome = nome;
  }
  public Video(int id, string nome, DateTime duracao, int idPlaylist){
    this.nome = nome;
    this.duracao = duracao;
    this.id = id;
    this.idPlaylist = idPlaylist;
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
  public override string ToString(){
    return $"{id} - {nome} - {duracao: HH:mm:ss} - {idPlaylist}";
  }
}
