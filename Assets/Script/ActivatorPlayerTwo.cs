using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;


public class ActivatorPlayerTwo : MonoBehaviour
{
    public KeyCode key;
    bool active = false;
    GameObject note;
    public TMP_Text Multiplicateur_Two;
    void Start()
    {
        Multiplicateur_Two.text = ScoreManager.Multiplication_Player_Two_Commun.ToString() + "multiplicateur";
    }


    void Update()
    {
        if (Input.GetKeyDown(key) && active)
        {
            Destroy(note);
            ScoreManager.Multiplication_Player_Two_Commun++;
            Multiplicateur_Two.text = ScoreManager.Multiplication_Player_Two_Commun.ToString() + " multiplicateur";
            ScoreManager.instance.AddPointsPlayerTwo();
        }

        else if (Input.GetKeyDown(key) && active != true)
        {
            ScoreManager.Multiplication_Player_Two_Commun = 0;
            Multiplicateur_Two.text = ScoreManager.Multiplication_Player_Two_Commun.ToString() + "multiplicateur";
        }

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        active = true;
        if (collision.gameObject.tag == "Note")
        {
            note = collision.gameObject;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        active = false;
    }
}
