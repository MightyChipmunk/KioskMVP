using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuInfo : MonoBehaviour
{
    public int price;
    public string m_name;
    public Sprite sprite;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void init()
    {
        QuantityManager.price = price;
        QuantityManager.m_name = m_name;
        QuantityManager.sprite = sprite;
    }
}
