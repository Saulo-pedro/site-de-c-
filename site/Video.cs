using System;

class Video{
  private string nome;
  private DateTime duracao;

  public Video(string nome, DateTime duracao){
    this.nome = nome;
    this.duracao = duracao;
  }
   public void Setnome(string nome){
    this.nome = nome;
  }
  public void Setduracao(DateTime duracao){
    this.duracao = duracao;
  }
  public string Getnome(){
    return nome;
  }
  public DateTime GetDuracao(){
    return duracao;
  }
  public override string ToString(){
    return $"{nome} - {duracao: HH:mm:ss}";
  }
}