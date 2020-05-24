using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        text.text = GameManager.Instance.Score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameManager.Instance.Score++;
            text.text = GameManager.Instance.Score.ToString();
        }

        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            int sceneGoTo = SceneManager.GetActiveScene().buildIndex + 1;
            if (sceneGoTo == 3) sceneGoTo = 0;
            SceneManager.LoadScene(sceneGoTo);
        }
    }
}
