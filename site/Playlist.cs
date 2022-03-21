using System;

public class Playlist{
  private int id;
  private string nome;
  private int idCanal;

  public int Id{
    get => id;
    set => id = value;
  }  
  public string Nome {
    get => nome;
    set => nome = value;
  }
  public int IdCanal{
    get => idCanal;
    set => idCanal = value;
  }
  public Playlist() { }
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
