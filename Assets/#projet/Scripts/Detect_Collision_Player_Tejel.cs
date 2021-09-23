using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class Detect_Collision_Player_Tejel : MonoBehaviour
{
    public bool isColored = true;

    public GameObject green_tejel;
    public GameObject grey_tejel;

    public UnityEvent whenColored;
    
    private void Start() {
    if (isColored) {
        //GetComponent<SpriteRenderer>().sprite = green_tejel;
        GetComponent<Renderer>().GameObject = green_tejel;
    }
    else {
        //GetComponent<SpriteRenderer>().sprite = grey_tejel;
        GetComponent<Renderer>().GameObject = green_tejel;
    }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player") && isColored)
        {
            Debug.Log("collision!!!!!!");
            whenColored?.Invoke();
        }
    }
    public void Colorer()
    {
        isColored = true;
        GetComponent<SpriteRenderer>().sprite = green_tejel;
    }

}
