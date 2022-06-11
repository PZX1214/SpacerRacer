using UnityEngine.SceneManagement;
using UnityEngine;
//allows access to the other scene home page -> game scene
public class MenuEvents : MonoBehaviour
{
    public void LoadLevel(int index)
    {
        SceneManager.LoadScene(index);
    }
}
