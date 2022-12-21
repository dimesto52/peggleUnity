using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class folowMousse : MonoBehaviour
{
    // Start is called before the first frame update
    /*
    void Start()
    {
        
    }*/

    // Update is called once per frame
    void Update()
    {
        //position de la sourie dans la vue 3d
        Vector3 worldposMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //position de la sourie par raport objet
        Vector3 relativPos = worldposMouse - transform.position;

        //rotation de l'objet
        float rot_z = Mathf.Atan2(relativPos.y, relativPos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rot_z + 90);
    }
}
