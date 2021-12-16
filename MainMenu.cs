using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//gia na exw prosvasi stis skines
public class MainMenu : MonoBehaviour
{
  public void PlayGame()
    {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//otan pataei to play to paixnidi pernaei sto game level pou einai i epomeni skini 
    }



    public void QuitGame()
    {
        Application.Quit(); // me to exit ekteleitai auto to line kai kleinei i  efarmogi moy
    }
    

}
