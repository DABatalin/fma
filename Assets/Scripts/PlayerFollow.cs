using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public GameObject player;
    public Vector3 Offset;
    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + Offset;
    }

}
