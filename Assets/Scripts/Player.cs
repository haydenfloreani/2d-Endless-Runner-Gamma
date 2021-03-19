using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public Vector2 targetPos;
    public float Yincrement;
    public float speed;
    public float fallincrement;


    public float maxHeight;
    public float minHeight;
    public float waterlevel;
   public int health = 3; 
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
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            transform.position = targetPos;
        }

        if (transform.position.y >= waterlevel)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - fallincrement);
            transform.position = targetPos;
    
        }
    }

}

