using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {
    public Transform[] gameObjects;
    public GameObject pumpkin;

	// Use this for initialization
	void Start () {
        StartCoroutine(startSpawning());
	}
	
    IEnumerator startSpawning()
    {
        yield return new WaitForSeconds(Random.Range(1f, 3.5f));
        Instantiate(this.pumpkin, this.gameObjects[Random.Range(0, this.gameObjects.Length)].position, Quaternion.identity);
        StartCoroutine(startSpawning());
    }
	// Update is called once per frame
	void Update () {
		
	}
} // class




















