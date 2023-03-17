using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public HoopGame hoopGame;
    public Animator animator;
    private void OnTriggerEnter(Collider other)
    {
        if(!hoopGame.gameON && other.CompareTag("Player"))
        {
            hoopGame.StartGame();
            animator.Play("StartButton");
        }

    }
}
