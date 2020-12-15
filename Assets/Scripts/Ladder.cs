using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    public GameObject TrigerBox;
    public GameObject Ladder1; 
    void OnTriggerEnter2D(Collider2D other)
    {   
        if (other.tag == "Player")
        {
            Ladder1.GetComponent<EdgeCollider2D>().offset = new Vector2(0, 0);
        }
    }
}
    /*void OnTriggerExit(Collider other)
    {
        if (other.name == "Player")
        {
            detected = false;
        }
    }*/

