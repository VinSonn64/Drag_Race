using UnityEngine;
using System.Collections;

public class RedCar : Car {

	// Use this for initialization
	void Start () {
        this.GetComponent<Renderer>().material = Paintjob;//Sets this cars color
        this.TopSpeed = 1.5f; //Sets speed for Red Car
	}
	
	// Update is called once per frame
	void Update () {
        Accelerate();//Inherit Accelerate function from Car class
	}
}
