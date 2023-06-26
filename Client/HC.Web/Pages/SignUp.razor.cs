﻿using HC.Shared.Dtos.Auth;
using HC.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace HC.Web.Pages;

public partial class SignUp
{
    [Inject] protected IAuthService _authService { get; set; } = default!;
    
    private string? _message = null;
    private SignUpRequestDto _signUpRequestDto = new();

    private async Task DoSignUp()
    {
        var result = await _authService.SignUp(_signUpRequestDto);
        _message = result.Message;
    }
}
