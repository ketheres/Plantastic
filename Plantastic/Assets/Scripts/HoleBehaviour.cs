using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleBehaviour : StateMachineBehaviour
{
    GameManager gameManager;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool("isHole", false); // to prevent loop transitions to mainmenu
        Debug.Log("Welcome to the cellar");
        
        gameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        gameManager.BGSprite.sprite = gameManager.chapters[gameManager.currentChapter].holeBG;
        gameManager.menuButton.onClick.AddListener(onMenuClick);
        gameManager.cellarButton.gameObject.SetActive(true);
        gameManager.cellarButton.onClick.AddListener(OnCellarClick);
    }

	// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetBool("isCellar", true);
        }
        /*else if (Input.GetKeyDown(KeyCode.Q))
        {
            animator.SetBool("isMainMenu", true);
        }*/
    }

	// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        gameManager.currentTurn++;
        if(gameManager.currentTurn == gameManager.turnLimit)
        {
            Debug.Log("Last turn begins. Make it count.");
        }
        else if(gameManager.currentChapter >= gameManager.turnLimit)
        {
            Debug.Log("Gaem Ovre");
        }
        Debug.Log("Currently it is turn #"+gameManager.currentTurn);
        gameManager.cellarButton.onClick.RemoveListener(OnCellarClick);
        gameManager.menuButton.onClick.RemoveListener(onMenuClick);
    }
    void onMenuClick()
    {
        gameManager.animator.SetBool("isMainMenu", true);
    }
    void OnCellarClick()
    {
        gameManager.animator.SetBool("isCellar", true);
    }
    // OnStateMove is called right after Animator.OnAnimatorMove(). Code that processes and affects root motion should be implemented here
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    //
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK(). Code that sets up animation IK (inverse kinematics) should be implemented here.
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    //
    //}
}
