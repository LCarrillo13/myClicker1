using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DropdownScript : MonoBehaviour
{
    public TMP_Dropdown theDropdown;
    public int optionValue;
    public GameObject lightModeObj;
    public GameObject darkModeObj;


    // Start is called before the first frame update
    void Start()
    {
        theDropdown = GetComponent<TMP_Dropdown>();      
        darkModeObj.SetActive(true);        
        Debug.Log("Dropdown value: " + theDropdown.value);
        optionValue = theDropdown.value;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnOptionChange()
    {
        optionValue = theDropdown.value;
            
        if (optionValue == 0)
        {
            darkModeObj.SetActive(true);
            lightModeObj.SetActive(false);
        }
        else if (optionValue == 1)
        {   
            lightModeObj.SetActive(true);
            darkModeObj.SetActive(false);
        }
    }
}
