using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Roi : MonoBehaviour
{
    public GameObject InitialKing;
    public GameObject LeftKing;
    public GameObject RightKing;
    public int ScorePlayerOne;
    public int ScorePlayerTwo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ScorePlayerOne > ScorePlayerTwo)
        {
            KingLookLeft();
        }
        else 
        {
            KingLookRight();
        }
        
    }
    public void KingLookLeft()
    {
        InitialKing.SetActive(false);
        LeftKing.SetActive(true);
        RightKing.SetActive(false);
    }

    public void KingLookRight()
    {
        InitialKing.SetActive(false);
        LeftKing.SetActive(false);
        RightKing.SetActive(true);
    }
}
