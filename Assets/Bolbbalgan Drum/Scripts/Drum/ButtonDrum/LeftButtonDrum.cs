﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftButtonDrum : ButtonDrum {

    override protected void onHit()
    {
        state.SelectedMenu = State.MenuOption.Play;
    }
}
