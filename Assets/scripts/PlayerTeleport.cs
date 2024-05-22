using UnityEngine;

public class PlayerTeleport : MonoBehaviour 
{
    public GameObject Point;
    public Transform Player;

    public void Apply()
    {
        Player.position = Point.transform.position;
    }

}