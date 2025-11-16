using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private SystemController _systemController;
    private void Awake() {
        DontDestroyOnLoad(gameObject);
    }
}
