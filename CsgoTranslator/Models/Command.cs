﻿using System;

namespace CsgoTranslator
{
    public abstract class Command
    {  
        public string Name { get; private set; }
        public string Message { get; set; }
        public ChatType ChatType { get; private set; }
        public string LangParam { get; private set; }

        private bool _executed;
        public bool Executed
        {
            get
            {
                return this._executed;
            }
            set
            {
                this._executed = value;
            }
        }

        protected Command(ChatType chatType, string name, string message, string langParam = null)
        {
            this.Name = name;
            this.Message = message;
            this.ChatType = chatType;
            this.LangParam = langParam;
            Console.WriteLine($"param: {langParam}");
            this.Executed = false;
        }

        public virtual void Execute() { }
    }
}
