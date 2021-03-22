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
    public float speed;
    public float fallincrement;

    public float oxygenLose;
    public float maxHeight;
    public float minHeight;
    public float waterlevel;
   public int health = 3;
    public float Oxygen = 100;
    // if we decide to use health



    // Update is called once per frame
    private void Update()
    {

        if (health <=0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }


        // suppose to make player move smoother
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);


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

        if (transform.position.y >= waterlevel)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - fallincrement);
            transform.position = targetPos;
    
        }
        {
            if (transform.position.y > waterlevel)
            {
                Oxygen = 100;
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

        OxygenDisplay.GetComponent<Text>().text = "Oxygen:" + Oxygen + "/100";
        HealthDisplay.GetComponent<Text>().text = "Health:" + health + "/3";

    }

}

