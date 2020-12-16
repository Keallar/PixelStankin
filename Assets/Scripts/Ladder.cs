using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    public GameObject Ladder1;
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                Ladder1.GetComponent<EdgeCollider2D>().offset = new Vector2(0, 0);
            }
        }
        if (other.tag == "Player")
        {
        if (Input.GetKey(KeyCode.DownArrow))       
            {
                Ladder1.GetComponent<EdgeCollider2D>().offset = new Vector2(10, 0); 
            }
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

