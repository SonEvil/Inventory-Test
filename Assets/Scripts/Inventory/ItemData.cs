using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class ItemData : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerEnterHandler,IPointerExitHandler {

    public Item item;
    public int amount;
	public int slot;

    private Inventory inv;
    private UseItem useItem;
    private Tooltip tooltip;
	private Vector2 offset;

    public float iditem;

    void Start()
    {
        inv = GameObject.Find("Inventory").GetComponent<Inventory>();
        useItem = GameObject.Find("Inventory").GetComponent<UseItem>();
        tooltip = inv.GetComponent<Tooltip>();
        this.transform.SetParent(inv.slots[slot].transform);
        this.transform.position = inv.slots[slot].transform.position;
        iditem = item.ID;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (item != null) {
			offset = eventData.position - new Vector2(this.transform.position.x, this.transform.position.y);
			this.transform.SetParent(this.transform.parent.parent);
            this.transform.position = eventData.position - offset;
			GetComponent<CanvasGroup>().blocksRaycasts = false;
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
		if (item != null) {
			this.transform.position = eventData.position - offset;
		}
    }

    public void OnEndDrag(PointerEventData eventData)
    {
		this.transform.SetParent (inv.slots[slot].transform);
		this.transform.position = inv.slots [slot].transform.position;
		GetComponent<CanvasGroup>().blocksRaycasts = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        tooltip.Deactivate();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        tooltip.Activate(item);
    }

    public void use() {

        if (iditem == 0)
        {
            useItem.useFish();
        }

        if (iditem == 1)
        {
            useItem.useMeat();
        }
    }
}
