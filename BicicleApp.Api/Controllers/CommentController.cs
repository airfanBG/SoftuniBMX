﻿using BicycleApp.Services.Contracts;
using BicycleApp.Services.Models.Comment;
using Microsoft.AspNetCore.Mvc;

namespace BicicleApp.Api.Controllers
{
    [Route("api/comment")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService commentService;

        public CommentController(ICommentService commentService)
        {
            this.commentService = commentService;
        }

        [HttpPost]
        [Route("add")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> AddNewComment([FromBody] CommentAddDto commentAddDto)
        {
            if (commentAddDto == null)
            {
                return BadRequest(commentAddDto);
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(commentAddDto);
            }

            try
            {
                var result = await commentService.AddNewCommentAsync(commentAddDto);
                if (result)
                {
                    return StatusCode(StatusCodes.Status201Created, true);
                }

                return BadRequest(commentAddDto);
            }
            catch (Exception)
            {
                return StatusCode(500, false);
            }
        }

        [HttpPost]
        [Route("edit")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> EditComment([FromBody] CommentEditDto commentEditDto)
        {
            if (commentEditDto == null)
            {
                return BadRequest(commentEditDto);
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(commentEditDto);
            }

            try
            {
                var result = await commentService.EditCommentAsync(commentEditDto);
                if (result)
                {
                    return StatusCode(StatusCodes.Status202Accepted, true);
                }

                return BadRequest(commentEditDto);
            }
            catch (Exception)
            {
                return StatusCode(500, false);
            }
        }

        [HttpGet]
        [Route("find")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<CommentEditDto>> GetComment([FromQuery] string clientId, [FromQuery] int partId)
        {
            if (clientId == null || partId == null)
            {
                return BadRequest();
            }

            try
            {
                var model = await commentService.GetCommentAsync(clientId, partId);

                return Ok(model);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
