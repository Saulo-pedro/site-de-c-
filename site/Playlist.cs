using System;

class Playlist{
  private int id;
  private string nome;

  public Playlist(string nome, int id){
    this.nome = nome;
    this.id = id;
  }
  public void Setnome(string nome){
    this.nome = nome;
  }
  public void SetId(int id){
    this.id = id;
  }
  
  public string Getnome(){
    return nome;
    }
 
  public int GetId(){
    return id;
  }
  public override string ToString(){
    return $"{id} - {nome}";
  }
}
