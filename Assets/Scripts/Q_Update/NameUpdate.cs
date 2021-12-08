using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameUpdate : MonoBehaviour
{
    public Text namelabel;
    // Start is called before the first frame update
    void Start()
    {
        namelabel = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        namelabel.text = " " + QuantityManager.m_name;
    }
}
