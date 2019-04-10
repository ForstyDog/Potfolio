using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class DragableObjects : MonoBehaviour
{
    public static bool _released = false;
    public static bool isDragable = true;
    
    private bool rightSpot = false;
    
    private Vector3 screenPoint;
    private Vector3 offset;

    private Vector3 startPos;

    private Rigidbody2D m_RigidBody2D;
    [SerializeField] private bool _dragable = true;

    public FuctionsScript _Fuctions;
    void Start()
    {
        m_RigidBody2D = GetComponent<Rigidbody2D>();
        startPos = this.gameObject.transform.position;
    }

    private void OnMouseDown()
    {
        m_RigidBody2D.constraints = RigidbodyConstraints2D.FreezeRotation;
        if(_dragable)
            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    private void OnMouseDrag()
    {
        if (_dragable)
        {
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
            transform.position = curPosition;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Slot")
        {
            rightSpot = true;
            Debug.Log("I MADE IT!");
            //this.enabled = false;
        }
    }

    private void OnMouseUp()
    {
        if (rightSpot == true)
        {
            m_RigidBody2D.constraints = RigidbodyConstraints2D.FreezeAll;
            _dragable = false;
            isDragable = false;
            _released = true;
        }
    }

    public void Update()
    {
        if (FuctionsScript.hasRested == true)
        {
            _dragable = true;
            isDragable = true;
            this.gameObject.transform.position = startPos;
        }
    }

    public void Test()
    {
        
    }
}

        