using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuctionsScript : MonoBehaviour
{

    public List<string> codeList = new List<string>();
    public static bool hasRested = false;
    public int positie;
    public GameObject playerCharacter;
    public Text errorslog;

    public Text codeExample;
    //public float itemgrabbednumber;
    public bool itemgrabbed;

    private Vector3 startPosPlayer;

    public void Start()
    {
        startPosPlayer = playerCharacter.transform.position;
        
        foreach (string values in codeList)
        {
            print(values);
        }
    }
    
    public void FieldOne(string FieldFunction)
    {
        //Invoke(FieldFunction, 0); 
        codeList.Insert(0, FieldFunction);
        foreach (string value in codeList)
        {
            print(value);
        }
    }
    public void FieldTwo(string FieldFunction2)
    {
        //Invoke(FieldFunction2, 0); 
        codeList.Insert(1, FieldFunction2);
        foreach (string value in codeList)
        {
            print(value);
        }
    }
    public void FieldThree(string FieldFunction3)
    {
        //Invoke(FieldFunction3, 0); 
        codeList.Insert(2, FieldFunction3);
        foreach (string value in codeList)
        {
            print(value);
        }
    }
    public void FieldFour(string FieldFunction4)
    {
        //Invoke(FieldFunction4, 0); 
        codeList.Insert(3, FieldFunction4);
        foreach (string value in codeList)
        {
            print(value);
        }
    }

    public void PlayFuntions()
    {
        if (codeList[0] != null)
        {
            Invoke(codeList[0], 0);
        }
        if (codeList[1] != null)
        {
            Invoke(codeList[1], 5);
        }
        /*if (codeList[2] != null)
        {
            Invoke(codeList[2], 10);
        }
        if (codeList[3] != null)
        {
            Invoke(codeList[3], 15);
        }*/
        
        
        
    }

    public void Code1()
    {
        //Debug.Log("funtie met code1 is uitgevoerd");
        if (positie > 0)
        {
            //om naar links te bewegen
            playerCharacter.transform.Translate(-4f,0,0);
            codeExample.text = "Code: playerCharacter.transform.Translate(-4f,0,0);";
            positie--;
        }
        else
        {
            errorslog.text = "Error: speler kan niet meer naar links bewegen";
            //Debug.Log("speler kan niet meer naar links bewegen");
        }
    }
    public void Code2()
    {
        if (positie < 3)
        {
            //om naar rechts te bewegen
            playerCharacter.transform.Translate(4f,0,0);
            codeExample.text = "Code: playerCharacter.transform.Translate(4f,0,0);";
            positie++;
            
        }
        else
        {
            errorslog.text = "Error: speler kan niet meer naar rechts bewegen";
            //Debug.Log("speler kan niet meer naar rechts bewegen");
        }
        //Debug.Log("funtie met code2 is uitgevoerd");
    }
    public void Code3()
    {
        Debug.Log(positie);
        if (itemgrabbed == false)
        {
           
           if (positie == 3)
           {
               itemgrabbed = true;
               codeExample.text = "Code: itemgrabbed = true;";
           }
           else
           {
               errorslog.text = "Error: speler kan niet dit object oppakken want dit object is niet nodig.";
           }
        }
        Debug.Log("funtie met code3 is uitgevoerd");
    }
    public void Code4()
    {
        if (itemgrabbed == true && positie == 1)
        {
            Debug.Log("level gehaald");
            codeExample.text = "Code: Debug.log('Level Gehaald')";
            //Debug.Log("");
        }
        else if (positie != 1)
        {
            errorslog.text = "Error: speler kan hier niet het object gebruiken ";
        }
        else if (itemgrabbed != null && positie == 1)
        {
            errorslog.text = "Error: speler heeft geen object om te gebruiken op de patient  ";
        }
        //Debug.Log("funtie met code4 is uitgevoerd");
    }

    public void level2_1()
    {
        Debug.Log(positie);
        if (itemgrabbed == false)
        {
           
            if (positie == 3)
            {
                itemgrabbed = true;
                codeExample.text = "Code: itemgrabbed = true;";
            }
            else
            {
                errorslog.text = "Error: speler kan niet dit object oppakken want dit object is niet nodig.";
            }
        }
        Debug.Log("funtie met code3 is uitgevoerd");
    }
    public void level2_2()
    {
        if (itemgrabbed == true && positie == 2)
        {
            Debug.Log("level gehaald");
            codeExample.text = "Code: Debug.log('Level Gehaald')";
            //Debug.Log("");
        }
        else if (positie != 2)
        {
            errorslog.text = "Error: speler kan hier niet het object gebruiken ";
        }
        else if (itemgrabbed != null && positie == 2)
        {
            errorslog.text = "Error: speler heeft geen object om te gebruiken op de patient  ";
        }
        //Debug.Log("funtie met code4 is uitgevoerd");
    }
    public void level3_1()
    {
        Debug.Log(positie);
        if (itemgrabbed == false)
        {
           
            if (positie == 1)
            {
                itemgrabbed = true;
                codeExample.text = "Code: itemgrabbed = true;";
            }
            else
            {
                errorslog.text = "Error: speler kan niet dit object oppakken want dit object is niet nodig.";
            }
        }
        Debug.Log("funtie met code3 is uitgevoerd");
    }
    public void level3_2()
    {
        if (itemgrabbed == true && positie == 3)
        {
            Debug.Log("level gehaald");
            codeExample.text = "Code: Debug.log('Level Gehaald')";
            //Debug.Log("");
        }
        else if (positie != 3)
        {
            errorslog.text = "Error: speler kan hier niet het object gebruiken ";
        }
        else if (itemgrabbed != null && positie == 3)
        {
            errorslog.text = "Error: speler heeft geen object om te gebruiken op de patient";
        }
        //Debug.Log("funtie met code4 is uitgevoerd");
    }
    public void level4_1()
    {
        Debug.Log(positie);
        if (itemgrabbed == false)
        {
           
            if (positie == 2)
            {
                itemgrabbed = true;
                codeExample.text = "Code: itemgrabbed = true;";
            }
            else
            {
                errorslog.text = "Error: speler kan niet dit object oppakken want dit object is niet nodig.";
            }
        }
        Debug.Log("funtie met code3 is uitgevoerd");
    }
    public void level4_2()
    {
        if (itemgrabbed == true && positie == 0)
        {
            Debug.Log("level gehaald");
            codeExample.text = "Code: Debug.log('Level Gehaald')";
            //Debug.Log("");
        }
        else if (positie != 0)
        {
            errorslog.text = "Error: speler kan hier niet het object gebruiken ";
        }
        else if (itemgrabbed != null && positie == 0)
        {
            errorslog.text = "Error: speler heeft geen object om te gebruiken op de patient";
        }
        //Debug.Log("funtie met code4 is uitgevoerd");
    }
    

    public void ResetList()
    {
        hasRested = true;
        codeList.Clear();
        Invoke("setBool", 3);
        Debug.Log("YOU PRESSED ME YOU DAFT CUNT");
        codeExample.text = "Code: ";
        //playerCharacter.transform.position = startPosPlayer;
        //positie = 0;
    }

    public void setBool()
    {
        FuctionsScript.hasRested = false;
    }
    
    
    
    
    
    private void Update()
    {
        
    }
}
