using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformDestroy : MonoBehaviour
{
    public static int waitDestroy = 0;

    public float timeToDestroy = 3.0f;
    float timeCount = 0f;

    bool on = false;

    void Start(){ }

    void Update()
    {
        if (this != null)
        if (on)
        {
            timeCount += Time.deltaTime;
            if (timeCount > timeToDestroy)
                    GameObject.Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!on)
        {
            on = true;
            this.GetComponent<SpriteRenderer>().color = Color.gray;

            onBoardBallCount.countChange += ballcountChange;
            waitDestroy++;
        }
    }
    void ballcountChange()
    {
        if (this != null)
        {
            GameObject.Destroy(this.gameObject);
        }
    }
    private void OnDisable()
    {
        onBoardBallCount.countChange -= ballcountChange;
        waitDestroy--;
    }

}
