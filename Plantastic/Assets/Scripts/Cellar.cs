using UnityEngine;
using System.Collections;

public class Cellar : StateMachineBehaviour
{
    void OnStateEnter()
    {
        Debug.Log("We are in a cellar. It is damp and moldy.");
    }
    void OnStateExit()
    {
        Debug.Log("Hm? What is it that you wish to do?");
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
