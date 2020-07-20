﻿using Application.Common.Commands;
using Domain.Entities;
using Domain.Repositories;

namespace Application.Users.Commands
{
    public class DeleteUserCommand : ICommand
    {
        public User User { get; set; }
    }

    internal class DeleteUserCommandHandler : ICommandHandler<DeleteUserCommand>
    {
        private readonly IUserRepository _userRepository;

        public DeleteUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Handle(DeleteUserCommand command)
        {
            _userRepository.Delete(command.User);
            _userRepository.UnitOfWork.SaveChanges();
        }
    }
}
