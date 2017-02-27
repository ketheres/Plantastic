using UnityEngine;
using System.Collections;
[System.Serializable]
public class Chapter
{
    public int turnNumber;
    public int turnLimit;
    public object objective;        //placeholder
    public GameObject bg;           //background of the board
    public GameObject outsideBg;    //background around the board
    public GameObject audioMaster;
}