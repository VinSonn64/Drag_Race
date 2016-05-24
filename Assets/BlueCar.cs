using UnityEngine;
using System.Collections;

public class BlueCar : Car  {

    public ParticleSystem Rocket1;
    public ParticleSystem Rocket2;
    
	// Use this for initialization
	void Start () {
        this.GetComponent<Renderer>().material = Paintjob;//Sets this cars color
        Rocket1.Stop();//Turns off particle effects
        Rocket2.Stop();//Turns off particle effects
	}
	
	// Update is called once per frame
	void Update () {
        Accelerate();//Inherit Accelerate function from Car class
        NOS();
	}

    void NOS()
    {
        if (Input.GetKeyDown("space"))//Once space is pressed, Activates NOS
        {
            this.TopSpeed = 10f;//Sets top speed higher
            Rocket1.Play();//Turns on particle effects
            Rocket2.Play();
        }
    }
    
}
