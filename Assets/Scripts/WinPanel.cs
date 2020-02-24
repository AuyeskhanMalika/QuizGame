using UnityEngine;
using UnityEngine.UI;

public class WinPanel : MonoBehaviour
{
    [SerializeField]
    private Text winText;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }
   public void SetPanelActive(bool state)
    {
        gameObject.SetActive(state);
    }
}
