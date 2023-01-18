using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucketMove : MonoBehaviour
{
    public float speed = 1.0f;
    public float min = -3.0f;
    public float max = 3.0f;

    bool doRight = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (doRight)
        {
            transform.position += Vector3.right * Time.deltaTime * speed;
            if (transform.position.x > max)
            {
                transform.position.Set(max, transform.position.y, 0);
                doRight = !doRight;
            }
        }
        else
        {
            transform.position -= Vector3.right * Time.deltaTime * speed;
            if (transform.position.x < min)
            {
                transform.position.Set(min, transform.position.y, 0);
                doRight = !doRight;
            }
        }

    }
}
