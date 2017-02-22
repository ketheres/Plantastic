using UnityEngine;
using System.Collections;

public class Hole : StateMachineBehaviour
{
    void OnStateEntered()
    {
        Debug.Log("We are in a hole. There seems to be something sinister here.");
    }
    void OnStateExit()
    {
        Debug.Log("Finally we can leave this hole. I was getting bad vibes down here.");
    }
	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
