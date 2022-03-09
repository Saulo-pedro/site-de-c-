using System;
using System.Collections.Generic;

class Sistema{
  private static Playlist[] playlist = new Playlist[10];
  private static int nPlaylist;
  private static List<Video> videos = new List<Video>();


  public static void InserirPlaylist(Playlist obj){
    if(nPlaylist == playlist.Length)
      Array.Resize(ref playlist, 2 * playlist.Length);
    playlist[nPlaylist] = obj;
    nPlaylist++;
  }
  public static Playlist[] ListarPlaylist(){
    Playlist[] aux = new Playlist[nPlaylist];
    Array.Copy(playlist, aux, nPlaylist);
    return aux;
  }
   public static Playlist ListarPlaylist(int id){
     foreach(Playlist obj in playlist)
       if(obj != null && obj.GetId() == id) return obj;
    return null;
  }
  public static void AtualizarPlaylist(Playlist obj){
    Playlist aux = ListarPlaylist(obj.GetId());
    if(aux != null)
      aux.Setnome(obj.Getnome());
  }
  public static void ExcluirPlaylist(Playlist obj){
    int aux = PlaylistIndice(obj.GetId());
    if(aux != -1){
      for(int i = aux; i < nPlaylist - 1; i++)
        playlist[i] = playlist[i + 1];
      nPlaylist--;
    }
  }
  private static int PlaylistIndice(int id){
    for(int i = 0; i < nPlaylist; i++){
      Playlist obj = playlist[i]; 
    if(obj.GetId() == id) return i;
  }
  return -1;
    }
  // listas


  
  public static void InserirVideo(Video obj){
    videos.Add(obj);
  }
  public static List<Video> ListarVideo(){
    return videos;
  }
   public static Video ListarVideo(int id){
     foreach(Video obj in videos)
       if(obj.GetId() == id) return obj;
    return null;
  }
  public static void AtualizarVideo(Video obj){
    Video aux = ListarVideo(obj.GetId());
    if(aux != null){
      aux.Setnome(obj.Getnome());
      aux.SetId(obj.GetId());
      aux.SetDuracao(obj.GetDuracao());
      aux.SetIdPlaylist(obj.GetIdPLaylist());
    }
  }
  public static void ExcluirVideo(Video obj){
    Video aux = ListarVideo(obj.GetId());
    if(aux != null) videos.Remove(aux);   
  }
}
