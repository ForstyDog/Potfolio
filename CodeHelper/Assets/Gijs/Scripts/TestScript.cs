using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    private string test123;
    private GameObject gameManager;

    private void Start()
    {
        test123 = this.gameObject.name;
        gameManager = GameObject.Find("GameManager");
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "FieldOne" && DragableObjects._released == true)
        {
            DragableObjects._released = false;
            gameManager.GetComponent<FuctionsScript>().FieldOne(test123);
        }
        else if (other.gameObject.name == "FieldTwo" && DragableObjects._released == true)
        {
            DragableObjects._released = false;
            gameManager.GetComponent<FuctionsScript>().FieldTwo(test123);
        }
        else if (other.gameObject.name == "FieldThree" && DragableObjects._released == true)
        {
            DragableObjects._released = false;
            gameManager.GetComponent<FuctionsScript>().FieldThree(test123);
        }
        else if (other.gameObject.name == "FieldFour" && DragableObjects._released == true)
        {
            DragableObjects._released = false;
            gameManager.GetComponent<FuctionsScript>().FieldFour(test123);
        }
        else
        {
            Debug.Log("Not in one of the fields");
        }
    }
}

    
