using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public float speed;
    public int damage = 1;
    private Vector2 screenBounds;
    public float endX;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == ("Player"))
            Destroy(gameObject);

        //player takes damage
        other.GetComponent<Player>().health -= damage;
    }

    private void Start()


    {
        //gives screenBounds value to that of what is shown on screen
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        //increases speed over time
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        //destroys gameobject once it moves off screen
        if (transform.position.x <= endX)
        {
            Destroy(this.gameObject);
        }

        //if (transform.position.x > screenBounds.x * 2)
        //{
        //    Destroy(this.gameObject);
        //}

    }
}
