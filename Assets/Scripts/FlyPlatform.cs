using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyPlatform : MonoBehaviour
{
    public Transform[] points;
    public float speed = 1f;
    int i = 1;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(points[0].position.x, points[0].position.y, transform.position.z);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            float posX = transform.position.x;
            float posY = transform.position.y;
            transform.position = Vector3.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);

            collision.gameObject.transform.position = new Vector3(collision.gameObject.transform.position.x + transform.position.x - posX, collision.gameObject.transform.position.y + transform.position.y - posY, collision.gameObject.transform.position.z);

            if (transform.position == points[i].position)
            {
                if (i < points.Length - 1)
                    i++;
                else 
                    i = 0;
            }
        }
    }
}
