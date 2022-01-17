using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LakeShark : MonoBehaviour
{
    public float speed = 20f;
    bool isWait = false;
    bool isHidden = false;
    public float waitTime = 1f;
    public Transform point;

    // Start is called before the first frame update
    void Start()
    {
        point.transform.position = new Vector3(transform.position.x, transform.position.y + 8f, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (isWait == false)
            transform.position = Vector3.MoveTowards(transform.position, point.position, speed * Time.deltaTime);
        if (transform.position == point.position)
        {
            if (isHidden)
            {
                point.transform.position = new Vector3(transform.position.x, transform.position.y + 8f, transform.position.z);
                transform.eulerAngles = new Vector3(0, 0, 0);
                isHidden = false;
            }
            else
            {
                point.transform.position = new Vector3(transform.position.x, transform.position.y - 8f, transform.position.z);
                StartCoroutine(Waiting2());
                isHidden = true;
            }

            isWait = true;
            StartCoroutine(Waiting());
        }
    }

    IEnumerator Waiting()
    {
        yield return new WaitForSeconds(waitTime);
        isWait = false;
    }

    IEnumerator Waiting2()
    {
        yield return new WaitForSeconds(waitTime);
        transform.eulerAngles = new Vector3(180, 0, 0);
    }
}
