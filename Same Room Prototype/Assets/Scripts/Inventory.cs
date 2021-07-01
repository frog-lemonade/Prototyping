using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Inventory : MonoBehaviour {
    public Image[] inventoryUI;
    public Vector3 positionToShow = new Vector3(45, 5, 6);
    public Vector3 rotationToShow = new Vector3(-90, 0, 0);
    
    public Color[] correctOrder;

    public UnityEvent onWin;

    List<GameObject> _inventory = new List<GameObject>();
    GameObject _objectShowing;

    public void SaveToInventory(GameObject newObject) {
        _inventory.Add(newObject);
        newObject.SetActive(false);

        var color = newObject.GetComponent<Renderer>().material.color;
        
        inventoryUI[_inventory.Count - 1].color = color;
        inventoryUI[_inventory.Count - 1].GetComponent<Button>().onClick.AddListener(() => { UseObject(newObject); });
        CheckOrder();
    }

    void CheckOrder() {
        for (int i = 0; i < _inventory.Count; i++) {
            //var color = _inventory[i].GetComponent<Renderer>().material.color;
            if (inventoryUI[i].color != correctOrder[i])
                return;
        }

        if (_inventory.Count == correctOrder.Length)
            onWin.Invoke();
    }

    public void UseObject(GameObject _object) {
        //Debug.Log("Trying to use Object: " + _object.name);
        _object.SetActive(true);
        _object.transform.position = positionToShow;
        _object.transform.rotation = Quaternion.Euler(rotationToShow);
        _objectShowing = _object;
    }

    public void CloseObject() {
        if (_objectShowing != null)
            _objectShowing.SetActive(false);
    }
}
