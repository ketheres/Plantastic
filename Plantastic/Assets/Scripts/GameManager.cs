using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    [Header("Header")]
    [Tooltip("Tooltip")]
    public Chapter[]        chapters;
    public int              currentChapter;
    public int              currentTurn;
    public GameObject[]     inventory;
    public Card[]           plantDeck;
    public Card[]           eventDeck;
    public int              day;
    public TurnPhase        turnPhase;
    public Animator         animator;
    public GameObject       BGHolder;
    public SpriteRenderer   BGSprite;
    public Sprite           menuBG;
    public Sprite           cellarBG;
    public Sprite           holeBG;
    public Sprite           windowBG;
	// Use this for initialization
	void Start ()
    {
        inventory = GameObject.FindGameObjectsWithTag("Item");
        BGHolder = GameObject.FindGameObjectWithTag("BG");
        BGSprite = BGHolder.GetComponent<SpriteRenderer>();
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
public enum MainState
{
    MAIN_MENU,
    CELLAR,
    HOLE,
    WINDOW
}