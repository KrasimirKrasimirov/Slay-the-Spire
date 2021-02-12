using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSprite : MonoBehaviour
{
    //public GameObject button;
    public Sprite buttonImage;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Image>().sprite = buttonImage;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
