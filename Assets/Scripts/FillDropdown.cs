using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FillDropdown : MonoBehaviour
{
    public List<TMP_Dropdown> d_List;
    public List<GameObject> o_List;
    private List<string> s_List;
    // Start is called before the first frame update
    void Start()
    {
        Fill();
    }

    private void Fill()
    {

        s_List = new List<string>();
        foreach (GameObject o in o_List)
        {
            s_List.Add(o.name);
        }

        foreach (TMP_Dropdown d in d_List)
        {
            d.AddOptions(s_List);
        }
    }
}
