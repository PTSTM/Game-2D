using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    float speed = 3f;
    float TimeToDisable = 10f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SetDisaibled());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }

    IEnumerator SetDisaibled()
    {
        yield return new WaitForSeconds(TimeToDisable);
        gameObject.SetActive(false);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        StopCoroutine(SetDisaibled());
        gameObject.SetActive(false);

    }
}
