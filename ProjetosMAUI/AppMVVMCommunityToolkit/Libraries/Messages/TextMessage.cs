﻿using CommunityToolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMVVMCommunityToolkit.Libraries.Messages
{
    public class TextMessage : ValueChangedMessage<String>
    {
        public TextMessage(string text) : base(text)
        {
            
        }
    }
}
