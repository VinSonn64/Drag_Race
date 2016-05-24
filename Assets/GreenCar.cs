using UnityEngine;
using System.Collections;

public class GreenCar : Car {
    
	// Use this for initialization
	void Start () {
        this.GetComponent<Renderer>().material = Paintjob;//Sets this cars color
        this.TopSpeed = 2f;//Sets speed for Green Car
	}
	
	// Update is called once per frame
	void Update () {
        Accelerate();//Inherit Accelerate function from Car class
	}
}
