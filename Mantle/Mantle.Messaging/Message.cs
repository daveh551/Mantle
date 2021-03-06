﻿namespace Mantle.Messaging
{
    public abstract class Message<T>
    {
        protected Message(T payload)
        {
            Payload = payload;
        }

        public T Payload { get; set; }
    }
}