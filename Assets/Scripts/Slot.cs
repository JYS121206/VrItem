using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    [SerializeField] private Image imgItem;
    [SerializeField] private GameObject goCount;
    [SerializeField] private Text txtCount;

    private Itemsss _item;
    int x;

    public Itemsss item
    {
        get { return _item; }
        set
        {
            _item = value;
            if (_item != null)
            {
                imgItem.sprite = item.GetItemList()[x].ItemImage;
                imgItem.color = new Color(1, 1, 1, 1);
            }
            else
            {
                imgItem.color = new Color(1, 1, 1, 0);
            }
        }
    }
}