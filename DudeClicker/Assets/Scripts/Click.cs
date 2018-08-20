using UnityEngine;
using System.Collections;

public class Click : MonoBehaviour {

    public UnityEngine.UI.Text goldDisplay;
    public int gold = 0;
    public int goldperclick = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        goldDisplay.text = "Gold: " + gold;
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
