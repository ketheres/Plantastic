using UnityEngine;
using System.Collections;
[System.Serializable]
public class Chapter
{
    public int turnNumber;
    public int turnLimit;
    public object objective;        //placeholder
    public Sprite cellarBG;
    public Sprite holeBG;
    public Sprite windowBG;
    public Sprite outsideBG;    //background around the board
    public GameObject audioMaster;
}