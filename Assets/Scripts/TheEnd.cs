using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheEnd : MonoBehaviour
{
    public Main main;
    public Sprite theEndSprite;

    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.tag == "Player")
        {
            GetComponent<SpriteRenderer>().sprite = theEndSprite;
            main.TheEnd();
        }
    }
}
