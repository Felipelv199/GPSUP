using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Diagnostics;

public class ChangeMaterial : MonoBehaviour
{
    public List<TMP_Dropdown> d_List;
    public List<GameObject> o_List;
    public List<Material> materials;
    public Material m;
    private GameObject _Object;
    private Renderer rend;

    public void PlaceMaterial(GameObject _Object, int index)
    {
        rend = _Object.GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = materials[index];
    }

    public void AssaignLocateMaterial()
    {
        foreach (TMP_Dropdown d in d_List)
        {
            GameObject o = o_List[d.value];
            PlaceMaterial(o, 0);
        }
    }

    public void AssaignTraceMaterials() {
        int counter = 0;
        foreach (TMP_Dropdown d in d_List)
        {
            GameObject o = o_List[d.value];
            PlaceMaterial(o, counter);
            counter++;
        }
    }

    public void ReassignMaterials()
    {
        foreach(GameObject o in o_List)
        {
            rend = o.GetComponent<Renderer>();
            rend.enabled = true;
            rend.sharedMaterial = m;
        }
    }
}
