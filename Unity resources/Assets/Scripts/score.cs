using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform player;
    public Slider slider;
    float Score = 0;

    void Update()
    {
        Score = (player.position.z * 100) / 260;
        if (Score <= 100 && Score >= 0)
        {
            slider.value = Score;
        }
    
    }
}
