using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    [SerializeField] private Image imgItem;
    [SerializeField] private GameObject goCount;
    [SerializeField] private Text txtCount;

    private ItemBase _item; //»πµÊ«— æ∆¿Ã≈€
    private Itemsss itemsss;
    int i;
    int x;

    public ItemBase item
    {
        get {
            itemsss.SetItemList(i);
            return itemsss.GetItemList()[x]; }
        set
        {
            itemsss.SetItemList(i);
            _item = value;
            if (_item != null)
            {
                imgItem.sprite = itemsss.GetItemList()[x].ItemImage;
                imgItem.color = new Color(1, 1, 1, 1);
            }
            else
            {
                imgItem.color = new Color(1, 1, 1, 0);
            }
        }
    }
}