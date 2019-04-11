using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

	public void LoadGame(string level)
	{
		SceneManager.LoadScene(level);
	}

	public void LoadWiki()
	{
		Application.OpenURL("https://nl.wikipedia.org/wiki/Nier:_Automata");
	}
}
