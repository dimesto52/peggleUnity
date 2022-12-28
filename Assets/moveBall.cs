using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBall : MonoBehaviour
{
    //direction de mouvement
    public Vector3 direction = Vector3.zero;

    // Update is called once per frame
    void Update()
    {

        //mise a jour du mouvement
        transform.position += direction * Time.deltaTime; 
    }
}
