using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BetaTestPanel : BasePanel, IPointerDownHandler
{
    [SerializeField] private Button fbBtn;
    [SerializeField] private Button twitterBtn;
    [SerializeField] private Button youtubeBtn;
    [SerializeField] private Button closeBtn;

    private ISceneManagement sceneManagement;

    public void OnPointerDown(PointerEventData eventData)
    {
        BackToMenu();
    }

    public void BackToMenu()
    {
        SoundManager.Instance.Play(Sounds.UI_POPUP);
        sceneManagement.ChangeScene(1);
    }

    public override void OverrideText()
    {
        throw new System.NotImplementedException();
    }

    private void Awake()
    {
        Services.Find(out sceneManagement);

        closeBtn.onClick.AddListener(BackToMenu);
        fbBtn.onClick.AddListener(() => Application.OpenURL("https://www.facebook.com/GemDep"));
        twitterBtn.onClick.AddListener(() => Application.OpenURL("https://twitter.com/Qun71380816"));
        youtubeBtn.onClick.AddListener(() => Application.OpenURL("https://www.youtube.com/channel/UC9WA78S7bTNtV6z3yDWZv7Q"));
    }


}