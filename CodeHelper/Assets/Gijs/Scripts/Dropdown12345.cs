using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Dropdown12345 : MonoBehaviour
{

    public Dropdown Dropdown1;
    
    // Start is called before the first frame update
    void Start()
    {
        Dropdown1.options = new List<Dropdown.OptionData>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Dropdown1Activate(int dropdown123)
    {
        Debug.Log(dropdown123);
    }
}
