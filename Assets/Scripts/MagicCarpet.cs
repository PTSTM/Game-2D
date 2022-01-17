using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicCarpet : MonoBehaviour
{
    public Transform left, right;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            RaycastHit2D leftWall = Physics2D.Raycast(left.position, Vector2.left, 0.5f);
            RaycastHit2D rightWall = Physics2D.Raycast(right.position, Vector2.right, 0.5f);
            if ((Input.GetAxis("Horizontal") > 0 && !rightWall.collider && (collision.gameObject.transform.position.x > transform.position.x)) || ((Input.GetAxis("Horizontal") < 0 && !leftWall.collider && (collision.gameObject.transform.position.x < transform.position.x))))
            transform.position = new Vector3(collision.transform.position.x, transform.position.y, transform.position.z);
        }
    }
}
