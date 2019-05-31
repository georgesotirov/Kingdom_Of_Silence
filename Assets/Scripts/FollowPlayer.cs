
using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public float m_speed = 0.1f;
    Camera mycam;


    private void Start()
    {
        mycam = GetComponent<Camera>();
    }
    void Update()
    {
        mycam.orthographicSize = (Screen.height / 50f ) / 4f;
        if (player)
        {
            transform.position = Vector3.Lerp(transform.position, player.position, m_speed) + new Vector3(0, 0, -10);
        }
    }

}