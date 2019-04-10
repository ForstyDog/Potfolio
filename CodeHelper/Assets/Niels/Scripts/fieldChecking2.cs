using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fieldChecking2 : MonoBehaviour
{
    public GameObject field3;

    public void Start()
    {
        field3.GetComponent<BoxCollider2D>().enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (field3.GetComponent<BoxCollider2D>().enabled != true)
        {
            field3.GetComponent<BoxCollider2D>().enabled = true;
        }
    }
    public void OnTriggerStay2D(Collider2D other)
    {
        other.gameObject.transform.position = this.transform.position;
    }
    
    void Update()
    {
        if (FuctionsScript.hasRested == true)
        {
            field3.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
