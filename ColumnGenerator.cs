using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnGenerator : MonoBehaviour
{
    public GameObject columnPFB;//gia na balw apo tin unity to prefab pou thelw gia to column
    public float miny, maxy;// na thesw to maxy kai max pou thelw na emfanistei to column

    float timer;//timer
    public float MaxTime;//ana posa deuterolepta, to thetw sto unity

   // private int scorediff;
   // public enum Difficulty
   // {
       // Easy,
       // Medium,
       // Hard,
       // Impossible,
   // }
    void Start()
    {
        //SetDifficulty(Difficulty.Easy);
        //dimiourgia columns
        ColumnGenerate();//kalw tin sinartisi
    }


    void Update()
    {
        //dimiourgia ana x deuterolepta
        timer += Time.deltaTime;//auksanei to timer
        if (timer >= MaxTime)//otan kseperasei to max time
        {
            ColumnGenerate();//dimiourgw column
            timer = 0;//midenizei to xronometro
           
        }
    }

    void ColumnGenerate()
    {
        float randYpos = Random.Range(miny, maxy);//tyxaia y anamesa sto miny kai to maxy pou ta thetw sto unity

        GameObject newColumn = Instantiate(columnPFB); //dimiourgw nea columnPFB
        newColumn.transform.position = new Vector2(transform.position.x, randYpos); //dimiourgia se tyxaia thesi y
        //scorediff++;
       // SetDifficulty(GetDifficulty());
    }
    //  private void SetDifficulty(Difficulty difficulty)
    //{
    //switch (difficulty)
    //{
    //case Difficulty.Easy:
    //MaxTime = MaxTime;
    //break;
    // case Difficulty.Medium:
    //MaxTime = MaxTime + .7f;
    //  break;
    // case Difficulty.Hard:
    //MaxTime = MaxTime + 1;
    //break;
    // case Difficulty.Impossible:
    //MaxTime = MaxTime + 1.5f;
    //break;

    //}
    //}

    // private Difficulty GetDifficulty()
    //{
    //if (scorediff >= 30) return Difficulty.Impossible;
    //if (scorediff >= 20) return Difficulty.Hard;
    //if (scorediff >= 10) return Difficulty.Medium;
    //return Difficulty.Easy;
    //}

    //me to difficulty prospathisame na dimiourgoume pio grigora ta columns, alla me ton tropo auto to paixnidi crusharei
}

