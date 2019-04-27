using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimManager : MonoBehaviour {

    public static AnimManager instance;

    void Awake()
    {
        instance = this;
    }
    public Animation wangfumentouAnim;
    public Animation wangfumenshenAnim;
    public Animation wangfutaijiAnim;

    public Animation guangliangmentouAnim;
    public Animation guangliangmenshenAnim;
    public Animation guangliangtaijiAnim;

    public Animation jinzhumentouAnim;
    public Animation jinzhumenshenAnim;
    public Animation jinzhutaijiAnim;

    public Animation manzimentouAnim;
    public Animation manzimenshenAnim;
    public Animation manzitaijiAnim;

    public Animation ruyimentouAnim;
    public Animation ruyimenshenAnim;
    public Animation ruyitaijiAnim;



    
}
