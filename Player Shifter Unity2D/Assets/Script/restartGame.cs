using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class restartGame : MonoBehaviour
{
    public Text MsgGameover;

    private void Start()
    {
        MsgGameover.text = "Game Over\nPress to Restart";
    }

    private void Update()
    {
        if (Input.anyKey)
        {
            MsgGameover.text = "Restarting...!";
            Invoke("Restarter", 1f);
        }
    }

    void Restarter()
    {
        SceneManager.LoadScene("lvl");
    }
}
