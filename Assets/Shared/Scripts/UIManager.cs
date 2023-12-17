using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject DeathPanel;
    [SerializeField] GameObject HealthBar;
    [SerializeField] GameObject Star;
    [SerializeField] GameObject ButtonPause;

    public void ToggleDeathPanel(){
        DeathPanel.SetActive(!DeathPanel.activeSelf);
        HealthBar.SetActive(!HealthBar.activeSelf);
        Star.SetActive(!Star.activeSelf);
        ButtonPause.SetActive(!ButtonPause.activeSelf);
    }
}
