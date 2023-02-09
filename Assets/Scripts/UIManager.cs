using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private GameManager gameManager;
    public GameObject win_panel;
    public GameObject lose_panel;
    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    private void Update()
    {
        if(gameManager.winState == 1)
        {
            win_panel.SetActive(true);
        }else if(gameManager.winState == 2)
        {
            lose_panel.SetActive(true);
        }
        else
        {
            win_panel.SetActive(false);
            lose_panel.SetActive(false);
        }
    }
}
