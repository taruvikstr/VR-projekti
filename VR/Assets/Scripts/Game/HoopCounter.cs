using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoopCounter : MonoBehaviour
{
    public HoopGame hoopGame;
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ball")) hoopGame.Point();
    }
}
