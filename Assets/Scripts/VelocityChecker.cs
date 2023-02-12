using System.Collections;
using UnityEngine;

public class VelocityChecker : MonoBehaviour
{
    private float speed;
    private bool bagged = false;
    void Update () {
        StartCoroutine(CalculateSpeed());
    }

    IEnumerator CalculateSpeed() {
        if (Time.time > 0.1) { 
            Vector3 lastPosition = transform.position;
            yield return new WaitForFixedUpdate();
            speed = (lastPosition - transform.position).magnitude / Time.deltaTime; 
            // Debug.Log("Current speed is " + speed);
            if ((speed >= 0f) & (speed <= 0.2f) & (!bagged))  {
                Debug.Log("Boom");
                bagged = true;
                FindObjectOfType<GameManager>().GameOver("bagged");
            }
        }
    }
}
