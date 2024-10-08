using UnityEngine;

public class AparController : MonoBehaviour
{
    public void OnActivated()
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(true);
        }
    }

    public void OnDeactivated()
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }
    }
}
