using UnityEngine;
using UnityEngine.UI;

public class WebCamPlayer : MonoBehaviour
{
    
    [SerializeField] public RawImage rawimage;
    private WebCamTexture webcamTexture;
    void Start () 
    {
        if (rawimage != null)
        {
            webcamTexture = new WebCamTexture(1080,1920,30);
            rawimage.texture = webcamTexture;
            rawimage.material.mainTexture = webcamTexture;
            webcamTexture.Play();
        }
        else
        {
            Debug.LogError("RawImage not set");
        }

    }

}