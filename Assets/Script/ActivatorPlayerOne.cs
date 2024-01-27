using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Activator : MonoBehaviour
{
    public KeyCode key;
    bool active = false;
    GameObject note;
    public TMP_Text Multiplicateur_One;

    void Start()
    {
        Multiplicateur_One.text = ScoreManager.Multiplication_Player_One_Commun.ToString() + " multiplicateur";
    }

    void Update()
    {
        if (Input.GetKeyDown(key) && active)
        {
            Destroy(note);
            ScoreManager.Multiplication_Player_One_Commun++;
            Multiplicateur_One.text = ScoreManager.Multiplication_Player_One_Commun.ToString() + " multiplicateur";
            ScoreManager.instance.AddPointsPlayerOne();
        }
        else if (Input.GetKeyDown(key) && !active)
        {
            ScoreManager.Multiplication_Player_One_Commun = 0;
            Multiplicateur_One.text = ScoreManager.Multiplication_Player_One_Commun.ToString() + " multiplicateur";
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