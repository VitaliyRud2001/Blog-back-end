using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Dtos;
using Application.Dtos.QueryParams.Book;
using Application.MapperProfiles;
using Application.Services.Interface;
using AutoMapper;
using Blog_back_end.FilterExceptions;
using Infrastructure;
using Infrastructure.GenericRepositories;
using Infrastructure.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blog_back_end.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;
        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet]
        public async Task<ActionResult<PaginationDto<PostGetDto>>> GetPosts([FromQuery] PostQueryParams param)
        {
            var paginationDto = await _postService.GetAllAsync(param);
            return paginationDto;
        }
        [HttpGet("{postId}")]
        [PostExpceptionFilter]
        public async Task<ActionResult<PostGetDto>> GetById([FromRoute] int postId)
        {
            var post = await _postService.GetPostByIdAsync(postId);
            return post;
        }

        [HttpPost]
        public async Task<ActionResult<PostGetDto>> CreatePost([FromForm] PostCreateDto param)
        {
            var postAdded = await _postService.CreatePostAsync(param);
            return postAdded;
        }

    }
}
