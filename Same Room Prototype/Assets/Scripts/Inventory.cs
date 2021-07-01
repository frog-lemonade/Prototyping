using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{   
    List<GameObject> _inventory = new List<GameObject>();
    public Image[] inventoryUI;

    public void SaveToInventory(GameObject newObject) {
        _inventory.Add(newObject);
        newObject.SetActive(false);

        var color = newObject.GetComponent<Renderer>().material.color;
        
        inventoryUI[_inventory.Count - 1].color = color;
        inventoryUI[_inventory.Count - 1].GetComponent<Button>().onClick.AddListener(() => { UseObject(newObject); });
    }

    public void UseObject(GameObject _object) {
        Debug.Log("Trying to use Object: " + _object.name);
    }
}
