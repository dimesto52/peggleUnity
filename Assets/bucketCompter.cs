using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucketCompter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {

        compterBall.compter.AddBall();
        GameObject.Destroy(collision.gameObject);
        onBoardBallCount.Count--;
    }
}
