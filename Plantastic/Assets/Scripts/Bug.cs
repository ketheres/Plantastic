using UnityEngine;
using System.Collections;
[System.Serializable]
public class Bug : MonoBehaviour
{
    public enum bugType             { LADYBUG , BUTTERFLY , ASIAN_GIANT_HORNET , ERROR };
    public enum movementType        { STATIONARY , CONDITIONAL , CONSTANT };
    public enum movementCondition   { HUNGER , BLESSING }; //determine when movement type is CONDITIONAL
    public enum effect              { NULL , EATING , BOOSTING };
    public int fullness;    //determines how much the bug has eaten
    public int maxFullness; //how much the bug can eat
	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}