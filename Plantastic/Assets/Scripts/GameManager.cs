using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    [Header("Header")]
    [Tooltip("Tooltip")]
    public Chapter[]    chapters;
    public int          currentChapter;
    public GameObject[] inventory;
    public Card[]       cards;
    public int          day;
    public TurnPhase    turnPhase;
    public Animator     animator;
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