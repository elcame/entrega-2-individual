using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalTime : MonoBehaviour
{
    public Text time;
    public Text level;
    public int counter;

    private void Start()
    {
        counter = 0;
        counter = PlayerPrefs.GetInt("time");
        time.text = "Total Time: " + counter.ToString() + " sec";
        level.text = "Max Level: " + PlayerPrefs.GetInt("level");
    }
}
