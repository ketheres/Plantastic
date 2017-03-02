using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellarBehaviour : StateMachineBehaviour
{
    GameManager gameManager;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool("isCellar", false);
        gameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        gameManager.BGSprite.sprite = gameManager.chapters[gameManager.currentChapter].cellarBG;
        gameManager.cellarButton.gameObject.SetActive(false);
        gameManager.menuButton.gameObject.SetActive(true);
        gameManager.windowButton.gameObject.SetActive(true);
        gameManager.holeButton.gameObject.SetActive(true);
        gameManager.menuButton.onClick.AddListener(onMenuClick);
        gameManager.windowButton.onClick.AddListener(onWindowClick);
        gameManager.holeButton.onClick.AddListener(onHoleClick);
    }

	// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }
    void onMenuClick()
    {
        gameManager.animator.SetBool("isMainMenu", true);
    }
    void onWindowClick()
    {
        gameManager.animator.SetBool("isWindow", true);
    }
    void onHoleClick()
    {
            gameManager.animator.SetBool("isHole", true);

    }

	// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        gameManager.menuButton.onClick.RemoveListener(onMenuClick);
        gameManager.windowButton.gameObject.SetActive(false);
        gameManager.holeButton.gameObject.SetActive(false);
        gameManager.cellarButton.gameObject.SetActive(true);
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
