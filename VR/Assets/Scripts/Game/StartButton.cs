using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public HoopGame hoopGame;
    public Animator animator;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("tigger enter: " + other.name);
        if (!hoopGame.gameON && other.name == "finger_middle_2_r" || !hoopGame.gameON && other.name == "finger_middle_1_r") ;
        {
            hoopGame.StartGame();
            animator.Play("StartButton");
        }

    }
}
