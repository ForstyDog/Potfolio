using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{
	public static bool _tracked;
	public GameObject ButtonUi;
	
	DefaultTrackableEventHandler mDefaultTrackableEventHandler;
	
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update () {
		if (DefaultTrackableEventHandler.isTracked == true)
		{
			ButtonUi.SetActive(true);
		}
	}
}
