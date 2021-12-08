using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageUpdate : MonoBehaviour
{
    public Image imagelabel;
    // Start is called before the first frame update
    void Start()
    {
        imagelabel = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        imagelabel.sprite = QuantityManager.sprite;
    }
}
