using System;

class Playlist{
  private int id;
  private string nome;
  private int idCanal;

  public Playlist(string nome, int id, int idCanal){
    this.nome = nome;
    this.id = id;
    this.idCanal = idCanal;
  }
  public void Setnome(string nome){
    this.nome = nome;
  }
  public void SetId(int id){
    this.id = id;
  }
  public void SetIdCanal(int idCanal){
    this.idCanal = idCanal;
  }
  
  public string Getnome(){
    return nome;
    }
 
  public int GetId(){
    return id;
  }
  public int GetIdCanal(){
    return idCanal;
  }
  public override string ToString(){
    return $"{id} - {nome} - {idCanal}";
  }
}
