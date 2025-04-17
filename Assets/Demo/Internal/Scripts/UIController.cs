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

    /*
     * public => 외부 접근 가능, 인스펙터 노출
     * private => 외부 접근 불가능, 인스펙터 노출x SerializeField사용시 노출가능 (가장 많이 사용)
     * protected => 외부 접근 불가능, 상속받은 클래스에서만 사용 가능
     * 
     */


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
