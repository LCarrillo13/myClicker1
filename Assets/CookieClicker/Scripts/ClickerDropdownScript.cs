using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClickerDropdownScript : MonoBehaviour
{
    public TMP_Dropdown theDropdown2;
    public int optionValue2;
    public GameObject clickerButton;
    public Sprite currentImage;
    public Sprite cookieImage;
    public Sprite pizzaImage;
    // Start is called before the first frame update
    void Start()
    {
        theDropdown2 = GetComponent<TMP_Dropdown>();
        optionValue2 = theDropdown2.value;  
        currentImage = clickerButton.GetComponent<Image>().sprite;



    }

    public void OnOptionChange2()
    {
        optionValue2 = theDropdown2.value;

        if (optionValue2 == 0)
        {
            currentImage = cookieImage;
        }
        else if (optionValue2 == 1)
        {
            currentImage = pizzaImage;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
