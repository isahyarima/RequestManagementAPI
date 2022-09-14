﻿using Authentication.ViewModel;
using Data.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Provider
{
    public interface ISecurityManager
    {
        AppUserAuth ValidateUser(string UserName, string Password);

        AppUserAuth AddToken(int adminUserId, string token);


        List<string> GetUserActivites(int roleId);

        string GenerateAuthToken(string userName, string secret);
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
        string GenerateRefreshToken();
        //Admin_Token GetRefreshTokenByToken(string name, string token);
        void AddRefreshToken(int userId, string name, string token, string username);
        void RemoveRefreshToken(string name, string token);
        void RemoveRefreshTokenByUser(int userId, string name);

       // Task<string> ForgotPassword(UserLoginVm model);


        Task<UserLoginVm> GetEmailFromConfirmationId(UserLoginVm model);

       // Task<bool> ApplicantPasswordRet(UserLoginVm model);
    }
}
