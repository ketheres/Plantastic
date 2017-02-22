using UnityEngine;
using System.Collections;

public class Window : StateMachineBehaviour
{
    public void OnStateEnter()
    {
        Debug.Log("We are looking out of a window. The outside looks normal.");
    }
    public void OnStateExit()
    {
        Debug.Log("Got bored of the scenery? Can't be helped, I guess.");
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
