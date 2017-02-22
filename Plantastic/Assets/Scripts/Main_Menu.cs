using UnityEngine;
using System.Collections;

public class Main_Menu : StateMachineBehaviour
{
    void OnStateEnter()
    {
        Debug.Log("We are in the main menu. Are we inside of a game?");
    }
    void OnStateExit()
    {
        Debug.Log("Where are we going?");
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
