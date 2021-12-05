using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MNameUpdate : MonoBehaviour
{
    public int cnt;
    public Text namelabel;
    // Start is called before the first frame update
    void Start()
    {
        namelabel = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(ShoplistManager.shoplists.Count > cnt)
        {
            namelabel.text = ShoplistManager.shoplists[cnt].m_name;
        }
    }
}
