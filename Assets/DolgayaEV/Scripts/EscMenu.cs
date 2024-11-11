using UnityEngine;
using UnityEngine.SceneManagement;

public class EscMenu : MonoBehaviour
{
    private static bool _isAwake;

    private readonly string _menu = "1Menu";

    private void Awake()
    {
        if (_isAwake)
        {
            Destroy(gameObject);
            return;
        }

        _isAwake = true;
        DontDestroyOnLoad(this);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(_menu);
        }
    }
}
