
using UnityEngine;

public class RotateSkybox : MonoBehaviour
{
    private int _rotation;
    public float speedMultiplier = 2;

    private void Start()
    {
        _rotation = Shader.PropertyToID("_Rotation");
    }

    private void Update()
    {
        RenderSettings.skybox.SetFloat(_rotation, Time.time * speedMultiplier);
    }
}
