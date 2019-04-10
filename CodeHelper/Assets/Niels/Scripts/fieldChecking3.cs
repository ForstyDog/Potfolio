using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fieldChecking3 : MonoBehaviour
{
    public GameObject field4;

    public void Start()
    {
        field4.GetComponent<BoxCollider2D>().enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (field4.GetComponent<BoxCollider2D>().enabled != true)
        {
            field4.GetComponent<BoxCollider2D>().enabled = true;
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
            field4.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
