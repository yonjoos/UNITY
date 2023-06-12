using UnityEngine;

public class SkyboxRotator : MonoBehaviour
{
    public float RotationPerSecond = 100;
    private bool _rotate;

    protected void Update()
    {
        if (_rotate) RenderSettings.skybox.SetFloat("_Rotation", Time.time * RotationPerSecond);
    }

    public void ToggleSkyboxRotation()
    {
        _rotate = !_rotate;
    }
}