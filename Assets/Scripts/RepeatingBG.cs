using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBG : MonoBehaviour
{
    public float speed;

    public float endX;
    public float startX;

    private void Update()
    {

        // speed of bacground
        transform.Translate(Vector2.left * speed * Time.deltaTime);


        // restart background from new position
        if (transform.position.x <= endX)
        {
            Vector2 pos = new Vector2(startX, transform.position.y);
            transform.position = pos;
        }
    }
}
