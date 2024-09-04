using UnityEngine;

public class TeleportTrigger : MonoBehaviour
{
    public GameObject Point;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.transform.position = Point.transform.position;
        }

        string gestName = other.gameObject.name;
        string tager = other.gameObject.tag;
        Debug.Log("Тук от " + gestName + " Под тегом" + tager);
        Debug.Log(name);
    }

}
