using UnityEngine;

public class WebShooter : MonoBehaviour
{
    [Header("Player")]
    [SerializeField] private GameObject player;
    private PlayerMovement playerMovement;

    [Header("Graphics")]
    [SerializeField] private LineRenderer lr;

    [Header("Keybinds")]
    [SerializeField] private KeyCode shootKey = KeyCode.Mouse0;
    [SerializeField] private KeyCode pushKey = KeyCode.Mouse0;

    [Header("Grappling Hook")]
    [SerializeField] private float range = 100f;
    [SerializeField] private float aimAssistSize = 1.5f;
    [SerializeField] private float assistSpeedMin = 10f;
    [SerializeField] private float assistSpeedMax = 50f;
    [SerializeField] private float assistSpeedMultiplier;
    [SerializeField] private float aimationDuration = 1f;
    [Space]
    [SerializeField] private GameObject debugAssist;

    [Header("Animation")]
    [SerializeField] private int quality;
    [SerializeField] private float waveCount;
    [SerializeField] private float waveHeight;
    [SerializeField] private AnimationCurve affectCurve;

    [Header("PlayerState")]
    [SerializeField] private State state;

    private Vector3 hookShotPosition;
    private float hookshotSize;
    private bool hasReel = false;
    private bool alreadyReel = false;

    public enum State
    {
        Normal,
        HookshotFlyingPlayer,
        HookshotThrown
    }

    private void Awake()
    {
        state = State.Normal;
        lr.enabled = false;
    }

    private void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        if(state == State.Normal)
        {
            if (Input.GetKeyDown(pushKey))
            {
                hasReel = true;
            }
            else
            {
                hasReel = false;
            }

            alreadyReel = false;
        }
    }
}
