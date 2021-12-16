using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float groundspeed;// vazw taxitita sto edafos
    float groundLength;//metabliti gia to megethos tou ground

    BoxCollider2D groundCollider; // pairnw prosvasi sto box collider gia na brw to groundLength

    public float leftLim;//aristero orio pou to thetv egw apo to unity
    
    void Start()
    {
        if (gameObject.CompareTag("Ground"))//an to antikeimeno exei to tag ground
        {
            //vriskw tin thesi poy exei to x sto ground wste na mporv na to ananewnw kathe fora pou pernaei apo tin othoni
            groundCollider = GetComponent<BoxCollider2D>();//pairnw prosvasi sto ground collider
            groundLength = groundCollider.size.x;//kai apo to ground colliderpairnw to megethos x

        }
         
    }

   
    void Update()
    {
        transform.position = new Vector2(transform.position.x - groundspeed * Time.deltaTime, //gia na ginetai se pragmatiko xrono poll[plasiazw me time.deltaTime
            transform.position.y);//to y den to allazw
        if (gameObject.CompareTag("Ground"))//an to antikeimeno exei tag to edafos
        {
            if(transform.position.x <= -groundLength)//gia na ananewnei to ground kathe fora pou den fainetai stin othoni 
            {
                transform.position = new Vector2(transform.position.x + 2 * groundLength,//allazw to x stin thesi poy einai isi me 2 + to ground legth
                    transform.position.y); // to y den to allazw
            }
        }


        if (gameObject.CompareTag("Column") && gameObject.CompareTag("Coin"))//an to antikeimeno exei to tag Column i Coin
        {
            if(transform.position.x <= leftLim) // an pernaei ta oria tis othonis na diagrafetai to kathe column
            {
                Destroy(gameObject);//eksafanizw to antikeimeno
            }
        }
    }
}
