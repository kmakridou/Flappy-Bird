using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondGenerator : MonoBehaviour
{
    
    public GameObject diamondPFB;//gia na thesw apo tin unity to diamond prefab
    public float minY, maxY;//pou thelw na emfanistei
    //gia ton xrono pou dimiourgountai
    float diamondtimer;//timer
    public float maxTime;//ana posa deuterolepta


    void Start()
    {
        DiamondGenerate();//kalw tin synartish
    }


    void Update()
    {
        diamondtimer += Time.deltaTime;//metraei ton xrono
        if (diamondtimer >= maxTime)//molis ftasei sto max time pou exw thesei sto unity
        {
            DiamondGenerate();//dimiourgw ena diamond
            diamondtimer = 0;//midenizei to xronometro, gia ne ksekinisei na metra apo tin arxi
        }
    }

    void DiamondGenerate()
    {
        float randYpos = Random.Range(minY, maxY);//tyxaia y anamesa sto miny kai to maxy pou ta thetw sto unity

        GameObject newCoin = Instantiate(diamondPFB); //dimiourgw nea diamondPFB
        newCoin.transform.position = new Vector2(transform.position.x, randYpos); //dimiourgia se tyxaia thesi y



    }

}

