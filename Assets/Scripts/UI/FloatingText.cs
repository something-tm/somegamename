using TMPro;
using UnityEngine;

public class FloatingText : MonoBehaviour
{
    private Camera mainCamera;
    private TextMeshPro text;

    void Awake()
    {
        mainCamera = Camera.main;
        text = GetComponent<TextMeshPro>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (mainCamera != null)
        {
            transform.forward = mainCamera.transform.forward;
        }

    }

    public void SetText(string value)
    {
        text.text = value;
    }
}