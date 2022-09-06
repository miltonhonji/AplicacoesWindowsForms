﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamploCrudVeterinary.Views
{
    public interface IPetView
    {
        string PetId { get; set; }
        string PetName { get; set; }
        string PetType { get; set; }
        string PetColour { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        string IsSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
    }
}
