﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonApi.Models;
using PersonApi.ModelsDTO;
using PersonApi.Services.Interfaces;

namespace PersonApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : ControllerBase
    {
        private readonly ISkillService _skillService;
        public SkillController(ISkillService skillService)
        {
            _skillService = skillService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var skills = await _skillService.GetAllSkill();
            return Ok(skills);
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _skillService.GetSkill(id);
            if (result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Put(CreateSkillDTO createSkillDTO)
        {
            var result = await _skillService.CreateSkill(createSkillDTO);
            if (result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }
        [HttpPut("{skillId:int}")]
        public async Task<IActionResult> Put(int skillId, UpdateSkillDTO updateSkillDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _skillService.UpdateSkill(skillId, updateSkillDTO);
            return Ok();
        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _skillService.DeleteSkill(id);
            return Ok(result);
        }
    }
}
