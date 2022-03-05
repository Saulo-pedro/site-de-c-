using System;

class Playlist{
  private int id;
  private string nome;
  private string nomeVi;

  public Playlist(string nome, string nomeVi, int id){
    this.nome = nome;
    this.nomeVi= nomeVi;
    this.id = id;
  }
  public void Setnome(string nome){
    this.nome = nome;
  }
  public void SetId(int id){
    this.id = id;
  }
  public void SetnomeVi(string nomeVi){
    this.nomeVi = nomeVi;
  }
  public string Getnome(){
    return nome;
    }
  public string GetnomeVi(){
    return nomeVi;
    }
  public int GetId(){
    return id;
  }
  public override string ToString(){
    return $"{id} - {nome} - {nomeVi}";
  }
}