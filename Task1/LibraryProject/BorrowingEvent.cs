﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryProject
{
    internal class BorrowingEvent : Event
	{
        public BorrowingEvent(int id, Reader reader, State state, DateTime borrowDate) : base(id, reader, state, borrowDate)
        {
        }
    }
}
