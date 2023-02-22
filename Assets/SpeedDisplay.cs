using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class SpeedDisplay : MonoBehaviour
{
    public TextMeshProUGUI speedText;
    public Rigidbody rb;

    // Update is called once per frame
    void Update()
    {
        float currentSpeed = rb.velocity.magnitude;
        speedText.text = "Speed: " + currentSpeed.ToString("0.00");
    }
}
