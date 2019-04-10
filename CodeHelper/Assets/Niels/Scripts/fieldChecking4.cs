using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fieldChecking4 : MonoBehaviour
{
    public void OnTriggerStay2D(Collider2D other)
    {
        other.gameObject.transform.position = this.transform.position;
    }
}
