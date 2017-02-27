using UnityEngine;
using System.Collections;
[System.Serializable]
public class Plant : MonoBehaviour {
    public int  energyCost;
    public int  originalYield; //for the initial crop yield
    public int  currentYield;  //for the yield affected by the bugs
    public int  requiredAmount;//for the requirements to trigger the crop yield
    public enum needs               { something , other }; //placeholder, add required ingredients, also see requiredAmount
    public enum produces            { something , other }; //placeholder, add produced ingredients, also see originalYield and currentYield
    public enum specialEffect       { something , other }; //placeholder, add stuff like "kills bugs, overthrows the government, summons Cthulhu" later
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
