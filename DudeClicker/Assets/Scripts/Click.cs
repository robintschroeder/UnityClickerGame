using UnityEngine;
using System.Collections;

public class Click : MonoBehaviour {

    public UnityEngine.UI.Text goldDisplay;
    public float gold = 0;
    public int goldperclick = 1;
    public UnityEngine.UI.Text gpc;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        goldDisplay.text = "Gold: " + gold;
        gpc.text = "GPC: " + goldperclick;
	}

    public void Clicked()
    {
        gold = gold + goldperclick;
    }

    

    public void OnClick()
    {
        gold = gold + goldperclick;
    }
}
