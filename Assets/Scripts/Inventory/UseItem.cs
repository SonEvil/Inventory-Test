using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItem : MonoBehaviour {

    public GameObject fish;
    public GameObject arrow;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void useFish ()
    {
        fish.SetActive(true);
        arrow.SetActive(false);
    }

    public void useMeat()
    {
        arrow.SetActive(true);
        fish.SetActive(false);
    }
}
