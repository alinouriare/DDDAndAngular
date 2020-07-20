﻿using Application.Common.Commands;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Decorators.AuditLog
{
    [Mapping(Type = typeof(AuditLogAttribute))]
    public class AuditLogCommandDecorator<TCommand> : ICommandHandler<TCommand> where TCommand : ICommand
    {
        private readonly ICommandHandler<TCommand> _handler;

        public AuditLogCommandDecorator(ICommandHandler<TCommand> handler)
        {
            _handler = handler;
        }

        public void Handle(TCommand command)
        {
            var commandJson = JsonConvert.SerializeObject(command);
            Console.WriteLine($"Command of type {command.GetType().Name}: {commandJson}");
            _handler.Handle(command);
        }
    }
}
