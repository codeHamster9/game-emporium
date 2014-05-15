﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace game_emparium.xsockets.server.Models
{
    public class BonusData
    {
        public BonusItem[] bonusim;
        public string bonusFactor { get; set; }
        public BonusData(int bonusCount)
        {
            bonusim = new BonusItem[bonusCount];
        }
    }
}