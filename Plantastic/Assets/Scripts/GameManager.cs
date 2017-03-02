using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour
{
    [Header("Header")]
    [Tooltip("Tooltip")]
    public Chapter[]        chapters;
    public int              currentChapter;
    public int              currentTurn;
    public int              turnLimit;
    public GameObject[]     inventory;
    public Card[]           plantDeck;
    public Card[]           eventDeck;
    public int              day;
    public TurnPhase        turnPhase;
    public Animator         animator;
    public GameObject       BGHolder;
    public SpriteRenderer   BGSprite;
    public Sprite           menuBG;
    [Header("Buttons")]
    public Button           menuButton;
    public Button           cellarButton;
    public Button           windowButton;
    public Button           holeButton;
    /*public Sprite           cellarBG;
    public Sprite           holeBG;
    public Sprite           windowBG;*/
	// Use this for initialization
	void Start ()
    {
        inventory = GameObject.FindGameObjectsWithTag("Item");
        BGHolder = GameObject.FindGameObjectWithTag("BG");
        BGSprite = BGHolder.GetComponent<SpriteRenderer>();
        menuButton.gameObject.SetActive(false);
        cellarButton.gameObject.SetActive(false);
        windowButton.gameObject.SetActive(false);
        holeButton.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {
	
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