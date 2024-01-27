using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    public KeyCode key;
    bool active = false;
    GameObject note;
    void Start()
    {
        
    }

  
    void Update()
    {
        if (Input.GetKeyDown(key) && active)
        {
            Destroy(note);
            ScoreManager.instance.AddPointsPlayerOne();
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
