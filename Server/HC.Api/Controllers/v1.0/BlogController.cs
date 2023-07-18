﻿using HC.Service.Contracts;
using HC.Shared.Constants;
using HC.Shared.Dtos.User;
using HC.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HC.Api.Controllers.v1;

[ApiVersion("1.0")]
public class BlogController : BaseController
{
    private readonly IBlogService _blogService;

	public BlogController(IBlogService blogService)
	{
		_blogService = blogService;
	}

    [AllowAnonymous]
    [HttpGet(RoutingConstants.ServerSide.Blog.GetAll)]
    public virtual async Task<Result<List<UserResponseDto>>> GetAll(CancellationToken cancellationToken = default)
    {
        var result = await _blogService.GetAll(cancellationToken);
        return Result.Success(result);
    }

    [AllowAnonymous]
    [HttpGet(RoutingConstants.ServerSide.Blog.GetById)]
    public virtual async Task<Result<UserResponseDto>> GetById([FromQuery] int id, CancellationToken cancellationToken = default)
    {
        var result = await _blogService.GetById(id, cancellationToken);
        return Result.Success(result);
    }

    [HttpPost(RoutingConstants.ServerSide.Blog.Create)]
    public virtual async Task<Result> Create([FromBody] UserRequestDto dto, CancellationToken cancellationToken = default)
    {
        return Result.Success();
    }

    [HttpPut(RoutingConstants.ServerSide.Blog.Update)]
    public virtual async Task<Result> Update([FromQuery] int id, [FromBody] UserRequestDto dto, CancellationToken cancellationToken = default)
    {
        return Result.Success();
    }

    [HttpDelete(RoutingConstants.ServerSide.Blog.Delete)]
    public virtual async Task<Result> Delete([FromQuery] int id, CancellationToken cancellationToken = default)
    {
        return Result.Success();
    }
}
