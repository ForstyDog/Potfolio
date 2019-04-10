using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class fieldChecking1 : MonoBehaviour
{
    public GameObject field2;
    public FuctionsScript _Fuctions;
    public DragableObjects _DObjects;
        
    public void Start()
    {
        field2.GetComponent<BoxCollider2D>().enabled = false;
    }

    public void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log(DragableObjects.isDragable);
        if (field2.GetComponent<BoxCollider2D>().enabled != true && DragableObjects.isDragable == false)
        {
            field2.GetComponent<BoxCollider2D>().enabled = true;
            other.gameObject.transform.position = this.transform.position;
            Invoke("BoxOff", 1);   
        }
    }

    void Update()
    {
        if (FuctionsScript.hasRested == true)
        {
            field2.GetComponent<BoxCollider2D>().enabled = false;
            this.gameObject.GetComponent<BoxCollider2D>().enabled = true;
        }
    }

    private void BoxOff()
    {   
        this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
    }
}
