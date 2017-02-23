using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    public Chapter[] chapters;
    public int currentChapter;
    public GameObject[] inventory;
    public Card[] cards;
    public int day;
    public TurnPhase turnPhase;
	// Use this for initialization
	void Start ()
    {
        inventory = GameObject.FindGameObjectsWithTag("Item");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
}

public enum TurnPhase
{
    PLANT,
    DECK,
    BUG
}
