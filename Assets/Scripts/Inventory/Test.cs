using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    public Inventory inv;
    public GameObject box;


    void Update () {
        if (Input.GetKeyDown(KeyCode.Z)) {
            inv.AddItem(1);
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            inv.AddItem(0);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            inv.RemoveItem(1);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            inv.RemoveItem(0);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            inv.RemoveItem(2);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            inv.AddItem(2);
        }
    }

    public void useItem0 ()
    {
        inv.RemoveItem(0);
    }

    public void dropItem0() {
        inv.AddItem(0);   
    }

}
