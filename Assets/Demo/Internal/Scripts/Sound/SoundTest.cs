using UnityEngine;

public class SoundTest : MonoBehaviour
{
    [SerializeField]
    private AudioClip _audioClip;

    private AudioSource _audioSource;
    // SFX -> 짧고 강렬한 소리 ex) 칼휘두르기 소리, 발자국소리, 총알발사소리
    // BGM -> 긴 음악 ex) 배경음악, 전투음악
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            PlaySFX();
        }
    }

    public void PlaySFX()
    {
        if (_audioSource.isPlaying)
            return;
       // _audioSource.PlayOneShot(_audioClip);
        _audioSource.clip = _audioClip;
        _audioSource.Play();
    }
}
