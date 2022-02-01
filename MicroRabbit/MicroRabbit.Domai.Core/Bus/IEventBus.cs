﻿using MicroRabbit.Domai.Core.Commands;
using MicroRabbit.Domai.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Domai.Core.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T> (T command) where T : Command;

        void Publish<T>(T @event) where T : Event;

        void Subscribe<T, TH>()
            where T : Event
            where TH : IEventHandler<T>;
    }
}
