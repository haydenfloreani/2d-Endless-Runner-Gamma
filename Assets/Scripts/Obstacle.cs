using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int damage = 1;
    public float speed;
   

   
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter2d(Collider2D other)
    {
        if (other.CompareTag("Player"))
        other.GetComponent<Player>().health -= damage;
        Debug.Log(other.GetComponent<Player>().health);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);


    }
}
