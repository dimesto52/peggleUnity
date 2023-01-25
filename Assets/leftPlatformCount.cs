using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftPlatformCount : MonoBehaviour
{

    private static int count = 0;
    public static int Count
    {
        get { return count; }
        set 
        {
            countChange?.Invoke(value);
            count = value; 
        }
    }
    public static Action<int> countChange;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        leftPlatformCount.Count++;
    }
    private void OnDisable()
    {
        leftPlatformCount.Count--;
    }

}
