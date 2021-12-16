using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour
{
    public GameObject coinPFB;//thetw ta coins apo to unity
    public float minY, maxY;//pou thelw na emfanizetai to coin,tyxaia

    float cointimer;//timer
    public float maxTime;//megsto pou to thetw apo unity


    void Start()
    {
        CoinGenerate();//kalw tin synartisi
    }

    
    void Update()
    {
        
        cointimer += Time.deltaTime;//auksanei to timer
        if (cointimer >= maxTime)//otan ftasei to max time pou exw thesei st unity
        {
            CoinGenerate();//kalw tin sinartisi
            cointimer = 0;//midenizw to timer
        }
    }

    void CoinGenerate()
    {
        float randYpos = Random.Range(minY, maxY);//tyxaia y anamesa sto miny kai to maxy pou ta thetw sto unity

        GameObject newCoin = Instantiate(coinPFB); //dimiourgw nea coinPFB
        newCoin.transform.position = new Vector2(transform.position.x, randYpos); //dimiourgia se tyxaia thesi y

       

    }

}
