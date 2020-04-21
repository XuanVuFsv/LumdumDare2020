using UnityEngine;

public class SetScreen : MonoBehaviour
{
    void Start()
    {
        // Switch to 800 x 600 windowed
        Screen.SetResolution(480, 800, false);
    }
}