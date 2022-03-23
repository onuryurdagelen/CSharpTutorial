using Enums.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enums.Models
{
    public class Game
    {
        public string userName { get; set; }
        public Gender gender { get; set; }

        public Difficulty difficulty { get; set; }

    }
}
