using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public string codeName { get; set; }
    public int codeNumber { get; set; }

    public GameObject[] codeBlocks;
    public List<GameObject> codeList = new List<GameObject>();

    void Start()
    {
        codeList.Add(codeBlocks[0]);
        codeList.Add(codeBlocks[1]);
        codeList.Add(codeBlocks[2]);
        codeList.Add(codeBlocks[3]);

        foreach (GameObject value in codeList)
        {
            print(value);
        }
    }
}
