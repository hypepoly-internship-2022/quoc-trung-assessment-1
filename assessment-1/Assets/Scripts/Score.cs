using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public Transform player;
    void Update()
    {
        scoreText.text = player.transform.position.z.ToString("0");
    }
}
