using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class detectWinLose : MonoBehaviour
{
    public GameObject winUi;
    public GameObject LoseUi;

    // Start is called before the first frame update
    void Start()
    {

        leftPlatformCount.countChange += platformcountChange;
        onBoardBallCount.countChange += ballcountChange;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void platformcountChange(int platformcount)
    {
        if (platformcount == 0)
        {
            winUi.SetActive(true);
        }
    }
    void ballcountChange()
    {
        if(winUi.activeSelf != true)
        if(compterBall.compter.numBall <= 0 && platformDestroy.waitDestroy <= 0)
            LoseUi.SetActive(true);
    }

    public void replay()
    {
        leftPlatformCount.countChange -= platformcountChange;
        onBoardBallCount.countChange -= ballcountChange;

        compterBall.compter.numBall = 5;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

}
