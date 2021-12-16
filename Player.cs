using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    public float S; //i taxitita pou tha kineitai o paiktis, to thetw apetheias apo to unity
    Rigidbody2D RB; //gia na exw prosvasi sto rigidbody sti unity

    public GameObject gameOverscreen;//gia na emfanizw to gameover screen
    bool Paused = false;//gia na kanw pausi
  

    void Start()
    {
        SoundManager.instance.Background_source.PlayOneShot(SoundManager.instance.background);//paizw ton ixo tou paixnidiou
        Time.timeScale = 1;//thetw to timescale = 1 gia na to allaksw meta sto gameover screen
        RB = GetComponent<Rigidbody2D>();//exw prosvasi kai mesa apo to script gia to rigidbody tis unity
       
    }

    
    void Update()
    {
        if(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)){ //bazw tin kinisi tou paikti me to pontiki kai to spacebar

            SoundManager.instance.flapsource.PlayOneShot(SoundManager.instance.flap);//me kathe klik na akougetai o ixos flap

            RB.velocity = Vector2.up * S;//thetw tin baritita poy o paiktis anevokatebainei

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)// otan o paiktis erthei se epafi me
    {
        if (collision.CompareTag("Column"))//an erthei o paiktis se epafi me to column ... exw balei sto column prefab ena diafano orio me tag Column kai kathe fora poy erxete se epafi me ayto
        {
            Score.instance.ScoreUp();//kalw tin scoreup
            
        }
        if (collision.CompareTag("Coin"))//se epafi me ta coins
        {
            Score.instance.ScoreUp();//+1
            Destroy(collision.gameObject);//svinw to coin
            SoundManager.instance.coinsound.PlayOneShot(SoundManager.instance.coin_collect);//paizei o ixos tou coin
            
        }
        if (collision.CompareTag("Diamond"))// an erhei se epafi me diamond
        { 
            Destroy(collision.gameObject);//katastrefw to diamond 

            S = S - 2;//katebazw tin taxytita pou o paiktis pidaei gia na mporei na einai pio statheros kai na exei mikrotero euros kinisis

            SoundManager.instance.coinsound.PlayOneShot(SoundManager.instance.coin_collect);//ixos sillogis diamantwn

            StartCoroutine(ResetDiamond());//kalw tin sinartisi ResetDiamond


        }
       
    }
    
    private void OnCollisionEnter2D(Collision2D collision)//an erthei se epafi
    {
        if(collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Pipe"))//an o paiktis erthei se epafi me to ground i ta pipes
        {
            SoundManager.instance.GameOverSource.PlayOneShot(SoundManager.instance.Game_over);//paizei o ixos game over
            
            gameOverscreen.SetActive(true);//emfanizetai to game over screen
            Time.timeScale = 0;//gia na stamatisei to paixnidi na kineitai
        }
    }
    public void pauseGame()//sinartisi gia pausi
    {
        if (Paused)//an paused = true
        {
            Time.timeScale = 1;//to paixnidi kilaei kanonika
            Paused = false;//kai ksanathetw to paused false
        }
        else
        {
            Time.timeScale = 0;//to paixnidi stamata
            Paused = true;//thetw to paused true
        }
    }
    public void Replay()//gia to koumpi replay
    {
        SceneManager.LoadScene("Level");//paizei ksana i skini tou paixnidiou 'level' apo tin arxi
    }

    public void quitGame()
    {
        Application.Quit();//eksodos apo tin efarmogi
    }

    private IEnumerator ResetDiamond()//sinartisi xronou gia na mporw na xrisimopoiisw tin parakatw entoli
    {//to xrisimopoiw gia na epanerxetai o paiktis meta apo 5 deyteropteta poy exei parei to power up, stin pragmatiki tou taxitita
        yield return new WaitForSeconds(5);//perimenoume 5 deuterolepta
        S = S + 2;//taxitita pali isi me tin arxiki
    }
}
