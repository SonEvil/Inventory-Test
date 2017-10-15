using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tooltip : MonoBehaviour {

    private Item item;
    private string data;
    public GameObject tooltip;

	void Start () {
        tooltip.SetActive(false);
        
	}

    void Update() {
        if (tooltip.activeSelf)
        {
            tooltip.transform.position = Input.mousePosition;
        }
    }
	
	public void Activate (Item item) {
        this.item = item;
        tooltip.SetActive(true);
        ConstructDataString();
	}

    public void Deactivate()
    {
        tooltip.SetActive(false);
    }

    public void ConstructDataString()
    {
        data = "<color=#FCFF1CFF><b>" + item.Title + "</b></color>\n\n" + item.Description + "\nPower: " + item.Power;
        tooltip.transform.GetChild(0).GetComponent<Text>().text = data;
    }
}
