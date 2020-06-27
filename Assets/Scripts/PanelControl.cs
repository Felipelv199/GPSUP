using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PanelControl : MonoBehaviour
{
    public GameObject[] showPanels;
    public GameObject[] hidePanels;

    public void ActiveDeactiveObject()
    {
        if (showPanels.Length != 0)
        {
            foreach (GameObject panel in showPanels)
            {
                if (panel.activeSelf == true)
                {
                    panel.SetActive(false);
                }
                else
                {
                    panel.SetActive(true);
                }
            }
        }

        if (hidePanels.Length != 0)
        {
            foreach (GameObject panel in hidePanels)
            {
                if (panel.activeSelf == true)
                {
                    panel.SetActive(false);
                }
            }
        }

    }
}
