﻿using GameOfProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfProject.Abstract
{
    public interface IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer);
    }
}
