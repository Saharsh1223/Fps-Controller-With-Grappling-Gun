using UnityEngine;

public class MoveCamera : MonoBehaviour
{

    public Transform player;
    public GameObject gfx;

    void Start()
    {
        gfx.SetActive(false);
    }

    void Update()
    {
        transform.position = player.transform.position;
    }
}