using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TMP_Text ScoreTextOne;
    public TMP_Text ScoreTextTwo;
    public GameObject InitialKing;
    public GameObject LeftKing;
    public GameObject RightKing;

    int scorePlayerOne = 0;
    int scorePlayerTwo = 0;


    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        ScoreTextOne.text = scorePlayerOne.ToString() + "Score";
        ScoreTextTwo.text = scorePlayerTwo.ToString() + "Score";
    }

    // Update is called once per frame
    void Update()
    {
        if (scorePlayerOne > scorePlayerTwo)
        {
            KingLookLeft();
        }
    }

    public void AddPointsPlayerOne()
    {
        scorePlayerOne += 1;
        ScoreTextOne.text = scorePlayerOne.ToString() + "Score";
    }

    public void AddPointsPlayerTwo()
    {
        scorePlayerTwo += 1;
        ScoreTextTwo.text = scorePlayerTwo.ToString() + "Score";
    }

    public void KingLookLeft()
    {
        InitialKing.SetActive(false);
        RightKing.SetActive(false);
        LeftKing.SetActive(true);
    }

    public void KingLookRight()
    {
        InitialKing.SetActive(false);
        RightKing.SetActive(true);
        LeftKing.SetActive(false);
    }
}
