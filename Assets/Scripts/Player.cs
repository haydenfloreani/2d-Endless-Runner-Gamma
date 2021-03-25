using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject OxygenDisplay;
    public GameObject HealthDisplay;
    public Vector2 targetPos;

    public float Yincrement;
    public float Xincrement;
    public float back;
    public float front;
    public float fallincrement;

    public float oxygenLose;
    public float maxHeight;
    public float minHeight;
    public float waterlevel;
   public int health = 3;
    public float Oxygen = 100;




    // Update is called once per frame
    private void Update()
    {
        // resets game when health falls to zero
        if (health <=0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }



        // move player up and down position
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight && transform.position.y < waterlevel)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            transform.position = targetPos;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight && transform.position.y < waterlevel)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            transform.position = targetPos;
         }

        // left and right movement  please help why dose this not work
        //{
        //    if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > back)
        //    {
        //        targetPos = new Vector2(transform.position.y, (transform.position.x - Xincrement));
        //        transform.position = targetPos;
        //    }
        //    else if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < front)
        //    {
        //        targetPos = new Vector2(transform.position.y, (transform.position.x + Xincrement));
        //        transform.position = targetPos;
        //    }
        //}







        // makes player fall when above water level back into water
        if (transform.position.y >= waterlevel)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - fallincrement);
            transform.position = targetPos;
    
        }
        // oxygen feature lose when below water gain full when go above water
        {
            if (transform.position.y > waterlevel)
            {
                Oxygen = 500;
            }
            else if (transform.position.y < waterlevel)
            {
                Oxygen = Oxygen - oxygenLose;
            }
            if (Oxygen <= 0 )
            {
                Oxygen = 0;
                health -= 1;
            }


        }
        // text display for oxygen and health
        OxygenDisplay.GetComponent<Text>().text = "Oxygen:" + Oxygen + "/500";
        HealthDisplay.GetComponent<Text>().text = "Health:" + health + "/3";

    }

}

