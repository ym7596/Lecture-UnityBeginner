using UnityEngine;
using UnityEngine.UI;
using TMPro;
using NUnit.Framework.Internal;


public class UIController : MonoBehaviour
{
    public Texture texture;
    public Sprite sprite;

    public Image image;
    public RawImage rawImage;
    public TextMeshProUGUI text;
    public TMP_Text text2;
    public Toggle toggle;
    public Slider slider;
    public Button button;
    public TMP_Dropdown dropdown;
    public TMP_InputField inputField;

    public Test test;

    [SerializeField]
    private Sprite p_sprite;


    private void Start()
    {
        
        
        //image.sprite = texture.sprite
        image.sprite = sprite;
        rawImage.texture = texture;

        text.text = "Hello World!";
        text2.text = "No Hello";

        dropdown.options.Clear();
        dropdown.options.Add(new TMP_Dropdown.OptionData("나의 옵션"));
    }

    public void ToggleClick(bool isOn)
    {
        Debug.Log(isOn);
    }

    public void SliderHandle(float value)
    {
        Debug.Log(value);
    }

    public void ButtonClick()
    {
        Debug.Log("Button Clicked");
    }

    public void InputChange(string value)
    {
        Debug.Log(value);
    }
}
