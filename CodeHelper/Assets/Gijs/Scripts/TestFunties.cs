using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestFunties : MonoBehaviour
{

    public int positie;
    public GameObject playerCharacter;
    // Start is called before the first frame update
    void Start()
    {
        if (positie < 3)
        {
            //om naar rechts te bewegen
            playerCharacter.transform.Translate(1f,0,0);
            positie++;
            
        }
        else
        {
            Debug.Log("speler kan niet meer naar rechts bewegen");
        }
        if (positie > 0)
        {
            //om naar links te bewegen
            playerCharacter.transform.Translate(-1f,0,0);
            positie--;
        }
        else
        {
            Debug.Log("speler kan niet meer naar links bewegen");
        }
        
        
        
      
        
    }

    // Update is called once per frame
    void Update()
    {
        //playerCharacter.transform.Translate(1,0,0);
    }
}
