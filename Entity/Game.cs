﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    [Table("Game")]
    public class Game
    {
        [Key]
        public int Id { get; set; }

        public Guid IdPlayer1 { get; set; }

        public Guid IdPlayer2 { get; set; }

        public DateTime CreateDateTime { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        public Guid IdWinner { get; set; }
    }
}
