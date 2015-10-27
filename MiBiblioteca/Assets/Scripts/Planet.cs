using UnityEngine;
using System.Collections;

public class Planet : MonoBehaviour {
	public GameObject center;
	public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Permite girar a un objeto al rededor de otro
		//lo busque en google como: rotate around unity
		transform.RotateAround(center.transform.position , Vector3.up, speed * Time.deltaTime);
	}
}
