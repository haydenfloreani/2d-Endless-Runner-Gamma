using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Vector2 targetPos;
    public float Yincrement;
    public float speed;



    public float maxHeight;
    public float minHeight;

    public int health = 3;

    // Start is called before the first frame update
    public void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            transform.position = targetPos;
        }
             else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
        {
              targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
             transform.position = targetPos;
           }

        }
    }

