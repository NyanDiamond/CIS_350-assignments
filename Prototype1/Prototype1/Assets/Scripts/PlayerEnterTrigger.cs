﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

//attatch this to the player
public class PlayerEnterTrigger : MonoBehaviour
{

    //public Text textBox;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trigger"))
        {
            //textBox.text = "You Win!";
            ScoreManager.score++;
            Destroy(other.gameObject);
        }
    }
}
