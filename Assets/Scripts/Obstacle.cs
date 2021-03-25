using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public float speed;
    public int damage = 1;
    public float endX;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == ("Player"))
            Destroy(gameObject);

        //player takes damage
        other.GetComponent<Player>().health -= damage;  
    }


    // Update is called once per frame
    void Update()
    {
        //increases speed over time
        transform.Translate(Vector2.left * speed * Time.deltaTime);


    }
}
