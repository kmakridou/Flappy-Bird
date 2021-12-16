using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public static Score instance;//kanw public instance sto score gia na mporw na exw prosvasi apo alla scripts
    

    public Text scoreTxt;//to public text to score sto unity
    public Text highscoreTxt;//to high score text sto unity

    public int score = 0;//thetw to score 0
    int highscore = 0;// thetw to highscore 0

    private void Awake()
    {
        instance = this;//prin apo to start thetw to instance gia na mporw na to epeksergastw sto player script
    }

    void Start() 
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);//thetw to highscore 0 kata tin ekkinisi
        scoreTxt.text = score.ToString();// scoretxt = me to score se string gia na ginei text
        highscoreTxt.text = highscore.ToString();//highscoretxt  = highscore se string gia na ginei text
    }

    public void ScoreUp()
    {
    
        score += 1; //auksanw to score +1
        scoreTxt.text = score.ToString();//thelw na exw prosvasi sto text tou canvas sto score, to thetw iso me to score pou exw metatrepsi te text me tin entoli ToString()

        if(highscore < score)//otan to highscore einai mikrotero tou score
            PlayerPrefs.SetInt("highscore", score);//tote to highscore pairnei thn timi tou score

       
    }

    

    
}