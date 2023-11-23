//=================================
// Copyright (c) Tarteeb LLC
// Check your english speaking easy
//=================================

using Moq;
using Newtonsoft.Json.Converters;
using speech_master.core.Models.Users;
using speech_master.core.Models.Users.Exceptions;
using System;
using System.Data;
using System.Security.Cryptography;

namespace speech_master.core.Services.Foundations.Users
{
    public partial class UserService
    {
        private void ValidateUserOnAdd(User user)
        {
            Validate(
                (Rule: IsInvalid(user.Id), Parameter: nameof(User.Id)),
                (Rule: IsInvalid(user.Name), Parameter: nameof(User.Name)));
        }

        private void ValidateUserOnModify(User user)
        {
            Validate(
                (Rule: IsInvalid(user.Id), Parameter: nameof(User.Id)),
                (Rule: IsInvalid(user.Name), Parameter: nameof(User.Name)));
        }

        private void ValidateUserId(Guid userId) =>
            Validate((Rule: IsInvalid(userId), Parameter: nameof(User.Id)));

        private static dynamic IsInvalid(Guid userId) => new
        {
            Condition = userId == default,
            Message = "Id is required"
        };

        private static dynamic IsInvalid(string text) => new
        {
            Condition = String.IsNullOrEmpty(text),
            Message = "Text is required"
        };

        private static void Validate(params (dynamic Rule, string Parameter)[] validations)
        {
            var invalidUserException = new InvalidUserException();

            foreach((dynamic rule, string parameter) in validations)
            {
                if(rule.Condition)
                {
                    invalidUserException.UpsertDataList(
                        key: parameter,
                        value: rule.Message);
                }

                invalidUserException.ThrowIfContainsErrors();
            }
        }
    }
}
