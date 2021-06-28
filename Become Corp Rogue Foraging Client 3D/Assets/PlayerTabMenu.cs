using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTabMenu : MonoBehaviour
{
    // Inventory tab
    public GameObject inventory;
    private bool isShowingInventory  = true;
    // Character tab
    public GameObject character;
    private bool isShowingCharacter  = false;
    // Map tab
    public GameObject map;
    private bool isShowingMap  = false;

    // Start is called before the first frame update
    void Start()
    {
        inventory.SetActive(isShowingInventory);
        character.SetActive(isShowingCharacter);
        map.SetActive(isShowingMap);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowInventory() {
        Debug.Log("Inventory is pressed");
        isShowingInventory = true;
        isShowingCharacter = false;
        isShowingMap = false;
        inventory.SetActive(isShowingInventory);
        character.SetActive(isShowingCharacter);
        map.SetActive(isShowingMap);
    }

    public void ShowCharacter() {
        Debug.Log("Character is pressed");
        isShowingCharacter = true;
        isShowingInventory = false;
        isShowingMap = false;
        inventory.SetActive(isShowingInventory);
        character.SetActive(isShowingCharacter);
        map.SetActive(isShowingMap);
    }

    public void ShowMap() {
        Debug.Log("Map is pressed");
        isShowingMap = true;
        isShowingInventory = false;
        isShowingCharacter = false;
        inventory.SetActive(isShowingInventory);
        character.SetActive(isShowingCharacter);
        map.SetActive(isShowingMap);
    }
}
