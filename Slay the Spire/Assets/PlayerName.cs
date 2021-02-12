using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerName : MonoBehaviour
{
    public GameObject player;
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        string characterName = player.GetComponent<SpriteRenderer>().sprite.name;
        
        text.GetComponent<TMPro.TextMeshProUGUI>().text = characterName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
