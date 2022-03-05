using System;

class Canal{
  private string Canal;

  public Canal(string canal){
    this.Canal = canal;
  }
  public void SetCanal(){
    this.Canal = canal;
  }
  public string GetCanal(){
    return canal;
  }
  public override string ToString(){
    return $"{canal}";
  }
}