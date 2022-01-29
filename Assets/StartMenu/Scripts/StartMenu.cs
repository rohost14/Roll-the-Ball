using UnityEngine;

public class StartMenu : MonoBehaviour
{
    [Header("Reference")]
    [SerializeField] private RectTransform menuContainer;

    [Header("Smooth")]
    [SerializeField] private bool smooth;
    [SerializeField] private float smoothSpeed = 0.1f;
    [SerializeField] private Vector3 desiredPosition;

    [Header("Logic")]
    private Vector3[] menuPositions;

    private void Start()
    {
        // Get all initals positions
        menuPositions = new Vector3[menuContainer.childCount];
        Vector3 halfScreen = new Vector3(Screen.width / 2, Screen.height / 2, 0);
        for (int i = 0; i < menuPositions.Length; i++)
            menuPositions[i] = menuContainer.GetChild(i).position - halfScreen;
    }

    private void Update()
    {
        if (smooth)
        {
            menuContainer.anchoredPosition = Vector3.Lerp(menuContainer.anchoredPosition, desiredPosition, smoothSpeed);
        }
        else
        {
            menuContainer.anchoredPosition = desiredPosition;
        }
    }

    public void StartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void MoveMenu(int id)
    {
        desiredPosition = -menuPositions[id];
    }
}
