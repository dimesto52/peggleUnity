using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onBoardBallCount : MonoBehaviour
{
    private static int count = 0;
    public static int Count
    {
        get { return count; }
        set
        {
            if(value <=0) countChange?.Invoke();
            count = value;
        }
    }
    public static Action countChange;


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
        onBoardBallCount.Count++;
    }
    private void OnDisable()
    {
        onBoardBallCount.Count--;
    }

}
