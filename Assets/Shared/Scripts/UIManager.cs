using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject DeathPanel;
    [SerializeField] GameObject HealthBar;
    [SerializeField] GameObject Star;
    [SerializeField] GameObject ButtonPause;
    [SerializeField] GameObject PausePanel;
    [SerializeField] GameObject player;

    public void ToggleDeathPanel(){ 
        DeathPanel.SetActive(!DeathPanel.activeSelf); //Hiển thị deathpanel
        HealthBar.SetActive(!HealthBar.activeSelf); // Ẩn thanh máu
        Star.SetActive(!Star.activeSelf); // Ẩn ngôi sao
        ButtonPause.SetActive(!ButtonPause.activeSelf); //Ẩn nút pause
        player.SetActive(!player.activeSelf); // Ẩn người chơi
    }
    public void TogglePausePanel(){
        HealthBar.SetActive(!HealthBar.activeSelf);
        Star.SetActive(!Star.activeSelf);
        ButtonPause.SetActive(!ButtonPause.activeSelf);
        PausePanel.SetActive(!PausePanel.activeSelf);
        player.SetActive(!player.activeSelf); // Ẩn người chơi

        Debug.Log("Nhaasn");
    }
    public void Restart(int indexScene)
    {
        SceneManager.LoadScene(indexScene);
    }
}
