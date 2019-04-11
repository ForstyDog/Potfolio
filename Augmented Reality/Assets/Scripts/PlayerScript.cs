using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
	#region bulletVariables
	public GameObject _bulletEmitter;
	public GameObject _bullet;
	public float _bulletForwardForce = 0.1f;
	#endregion
	
	private NavMeshAgent _agent;
	private bool isWalking;

	public AudioSource Fire;
	
	// Use this for initialization
	void Start ()
	{
		_agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Input.GetButtonDown("Fire1")) {
			if (Physics.Raycast(ray, out hit, 100)) {
				if (hit.collider.CompareTag("enemy"))
				{
					Vector3 fwd = transform.TransformDirection(Vector3.forward);
					if (Physics.Raycast(transform.position, fwd, 10))
					{
						print("There is something in front of you");
						Shoot();
						Fire.Play();
						Debug.Log("Enemy has been shot");
					}
					//TODO: hits an enemy

				}
				else
				{
					isWalking = true;
					_agent.destination = hit.point;
					_agent.Resume();
				}
			}
		}
	}

	public void Shoot()
	{
		GameObject _tempBulletHandler;
		_tempBulletHandler = Instantiate(_bullet, _bulletEmitter.transform.position, _bulletEmitter.transform.rotation) as GameObject;
		_tempBulletHandler.transform.Rotate(Vector3.left * 180);
		Rigidbody _tempRigidBody;
		_tempRigidBody = _tempBulletHandler.GetComponent<Rigidbody>();
		_tempRigidBody.GetComponent<Rigidbody>().AddForce(transform.forward * _bulletForwardForce);
		Destroy(_tempBulletHandler, 5.0f);
	}
}