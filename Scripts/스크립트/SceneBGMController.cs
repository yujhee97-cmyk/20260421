using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneBGMController : MonoBehaviour
{
    private AudioSource audioSource;
    private const string BGM_KEY = "BGM_MUTE";

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource != null)
        {
            audioSource.loop = true;
        }
        ApplyMuteState();
    }

    // 게임 시작 버튼용
    public void StartGame()
    {
        Debug.Log("<color=yellow>게임 시작 버튼 클릭!</color> MainGame 씬으로 이동합니다.");
        SceneManager.LoadScene("MainGame");
    }

    // BGM 끄기 버튼용
    public void ToggleBGM()
    {
        int currentMute = PlayerPrefs.GetInt(BGM_KEY, 0);
        int nextMute = (currentMute == 0) ? 1 : 0;

        PlayerPrefs.SetInt(BGM_KEY, nextMute);
        PlayerPrefs.Save();

        ApplyMuteState();

        // 콘솔에 상태 표시
        string status = (nextMute == 1) ? "뮤트(Mute)됨" : "소리 켬(On)";
        Debug.Log("<color=cyan>BGM 상태 변경:</color> " + status);
    }

    private void ApplyMuteState()
    {
        if (audioSource == null) return;
        bool isMuted = PlayerPrefs.GetInt(BGM_KEY, 0) == 1;
        audioSource.mute = isMuted;
    }

    void Update()
    {
        if (audioSource == null) return;
        if (Input.GetKeyDown(KeyCode.J) && !audioSource.isPlaying) audioSource.Play();
        if (Input.GetKeyDown(KeyCode.K) && audioSource.isPlaying) audioSource.Stop();
    }
}