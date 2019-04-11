using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{
	public static int enemyCount = 0;
	
	private NavMeshAgent _agentEnemy;
	public Vector3 enemyDes;
	public int currentPoint = 0;
	[Range(0f, 20f)]
	public int maxPoint = 4;

	[Range(0f, 100f)]
	public float Timer = 50f;

	public bool isTriggerd = false;
	
	public Transform[] target;
	
	[Range(0f, 1000f)]
	public float Health = 200f;

	public AudioSource DeathSound;

	void Awake()
	{
		_agentEnemy = GetComponent<NavMeshAgent>();
		enemyCount++;
	}

	void Start()
	{
		currentPoint = Random.Range(0, 3);
		currentPoint++;
		enemyDes = _agentEnemy.destination;
		enemyDes = target[currentPoint].position;
		_agentEnemy.destination = enemyDes;
	}

	private void FixedUpdate()
	{
		if (isTriggerd == true)
		{
			Timer = Timer - 1;

			if (Timer == 0)
			{
				Timer = 10f;
				isTriggerd = false;
			}
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "CheckPoint" && isTriggerd != true)
		{
			Debug.Log("Reached");
			isTriggerd = true;
				MoveEnemy();
		}

		BulletDamage beam = other.GetComponent<BulletDamage>();
		if (beam)
		{
			Debug.Log("Hit");
			Health -= beam.GetDamage();
			beam.Hit();
			Destroy(beam);
			if (Health <= 0)
			{
				DeathSound.Play();
				Destroy(gameObject);
				enemyCount--;
			}
		}
	}

	void MoveEnemy()
	{
		enemyDes = target[currentPoint].position;
		_agentEnemy.destination = enemyDes;
		currentPoint = currentPoint + 1;
		if (currentPoint == maxPoint)
		{
			currentPoint = 0;
		}
	}
}
	