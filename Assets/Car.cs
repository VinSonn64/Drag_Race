using UnityEngine;
using System.Collections;

public class Car : MonoBehaviour {

    public float TopSpeed = 1f;// speed of car
    public Material Paintjob;//color of car


   
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
       
	}

    public void Accelerate()//Method pushes car forward at TopSpeed
    {
        Vector3 movement = new Vector3(0.0f, 0.0f, TopSpeed);

        this.GetComponent<Rigidbody>().AddForce(movement);

        
    }
}