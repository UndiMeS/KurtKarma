using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockSolution : MonoBehaviour
{

    public ClockHands BigClockHand;
    public ClockHands SmallClockHand;
    public bool SmallHandIsRight;
    public bool BigHandIsRight;

    public GameObject TinyRedClockHand;
    public GameObject TniyBlueClockHand;


    public GameObject WhiteClockRing;
    public GameObject SpaceClockRing;

    static Quaternion lookRotationSmallHand;

    static Quaternion lookRotationBigHand;

    public SpriteRenderer TinyClock;
    public Sprite TinySpaceClock;
    public Sprite TinyNakedClock;
    public float speed = 5.0f;
    public bool SolutionOnce;

    public TokenCollectTwo SpaceRingCollect;
    // Start is called before the first frame update
    void Start()
    {
        lookRotationSmallHand = Quaternion.Euler (0, 0, 45.0f);
        lookRotationBigHand = Quaternion.Euler (0, 0, 270.0f);

    }

    // Update is called once per frame
    void Update()
    {


        TniyBlueClockHand.transform.rotation = SmallClockHand.TurningClockHand.transform.rotation;
        TinyRedClockHand.transform.rotation = BigClockHand.TurningClockHand.transform.rotation;


        if(SmallClockHand.TurningClockHand.transform.eulerAngles.z > 35 && SmallClockHand.TurningClockHand.transform.eulerAngles.z < 55 && SmallClockHand.MouseActive == false)
        {
            SmallHandIsRight = true;
        }
        else
        {
            SmallHandIsRight = false;
        }


        if(BigClockHand.TurningClockHand.transform.eulerAngles.z > 260 && BigClockHand.TurningClockHand.transform.eulerAngles.z < 280 && BigClockHand.MouseActive == false)
        {
            BigHandIsRight = true;
        }
        else
        {
            BigHandIsRight = false;
        }


        if(SmallHandIsRight == true && BigHandIsRight == true && SpaceRingCollect.Collected == false && SolutionOnce == false)
        {

            BigClockHand.TurningClockHand.transform.rotation = Quaternion.RotateTowards (BigClockHand.TurningClockHand.transform.rotation, lookRotationBigHand, speed * Time.deltaTime);
            SmallClockHand.TurningClockHand.transform.rotation = Quaternion.RotateTowards (SmallClockHand.transform.rotation, lookRotationSmallHand, speed * Time.deltaTime);
            WhiteClockRing.SetActive(false);
            SpaceClockRing.SetActive(true);
            TinyClock.sprite = TinySpaceClock;

            SmallClockHand.enabled = false;
            BigClockHand.enabled = false;
            SolutionOnce = true;
        }
        if(SmallHandIsRight == true && BigHandIsRight == true && SpaceRingCollect.Collected == true)
        {
            SpaceClockRing.SetActive(false);
            TinyClock.sprite = TinyNakedClock;
        }

        


    }
}
