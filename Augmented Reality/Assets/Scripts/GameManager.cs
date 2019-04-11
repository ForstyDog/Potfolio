using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

	public int _enemyCount = 1;
	
	// Use this for initialization
	void Start ()
	{
		Debug.Log(_enemyCount);
	}
	
	// Update is called once per frame
	void Update () {
		_enemyCount = EnemyScript.enemyCount;
		if (_enemyCount == 0)
		{
			SceneManager.LoadScene("GameOver");
		}
	}
}
