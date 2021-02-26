using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public float speed;



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == ("Player"))
            Destroy(gameObject);
        Debug.Log("hit detected");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);


    }
}
