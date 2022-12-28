using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    //objet a tirer
    public GameObject ball;

    //objet a tirer distance de spawn
    public float offset = 1.0f;

    //timer de shoot
    public float fireRate = 1.0f;
    float lastFire = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        //mise a 1 du timer de shoot
        lastFire = fireRate;
    }

    // Update is called once per frame
    void Update()
    {
        //ajour de dur� au timer de shoot
        lastFire += Time.deltaTime;

        //verification de touche appuyer et du timer
        if (Input.GetMouseButtonDown(0))
            if (lastFire > fireRate)
            {
                //remise a zero du timer
                lastFire = lastFire % fireRate;

                //instansiation de l'objet a tirer
                GameObject oball = GameObject.Instantiate(ball);
                oball.transform.position = transform.position - transform.up * offset;

                //direction de l'objet a tirer
                oball.GetComponent<moveBall>().direction = -transform.up;

            }


    }
}
