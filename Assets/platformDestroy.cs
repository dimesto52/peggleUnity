using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformDestroy : MonoBehaviour
{

    public float timeToDestroy = 3.0f;
    float timeCount = 0f;

    bool on = false;

    void Start()
    {
        
    }

    void Update()
    {
        if(on)
        {
            timeCount+= Time.deltaTime;
            if(timeCount > timeToDestroy)
                GameObject.Destroy(this.gameObject);

        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        on = true;

        this.GetComponent<SpriteRenderer>().color = Color.gray;

    }

}
