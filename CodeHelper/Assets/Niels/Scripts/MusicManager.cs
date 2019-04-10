using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {
    public AudioClip[] clips;
    private AudioSource AudioSource;
    public GameObject audio1;

	// Use this for initialization
	void Start () {
        AudioSource = FindObjectOfType<AudioSource>();
        AudioSource.loop = false;

        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
        GameObject[] objs2 = GameObject.FindGameObjectsWithTag("audiolisteners");
        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }
        if (objs2.Length > 1)
        {
            Destroy(audio1);
        }

        DontDestroyOnLoad(audio1);
        DontDestroyOnLoad(this.gameObject);

    }

    private AudioClip GetRandomClip()
    {
        return clips[Random.Range(0, clips.Length)];
    }
	
	// Update is called once per frame
	void Update () {
        if (!AudioSource.isPlaying)
        {
            AudioSource.clip = GetRandomClip();
            AudioSource.Play();
        }
		
	}
}
