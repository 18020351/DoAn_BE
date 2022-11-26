using Microsoft.AspNetCore.Mvc;
using SheduleManagement.Data;
using SheduleManagement.Data.Services;
using SheduleManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SheduleManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : Controller
    {
        private readonly ScheduleManagementDbContext _dbContext;
        public GroupController(ScheduleManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpPost("Update")]
        public IActionResult Update(GroupInfos data)
        {
            try
            {
                var groupService = new GroupService(_dbContext);
                var (msg, groupId) = groupService.Add(data.Creator.Id, data.Name, data.Description);
                if (msg.Length == 0) return Ok(groupId);
                return BadRequest(msg);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("Delete/{groupId}")]
        public IActionResult Delete(int groupId)
        {
            try
            {
                string msg = (new GroupService(_dbContext)).Delete(groupId);
                if (msg.Length > 0) BadRequest(msg);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("ChangeName")]
        public IActionResult ChangeName(ChangeNameModel model)
        {
            try
            {
                string msg = (new GroupService(_dbContext)).ChangeName(model.Id, model.Name);
                if (msg.Length == 0) return Ok(model.Id);
                return BadRequest(msg);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("GetGroup/{groupId}")]
        public IActionResult GetGroup(int groupId)
        {
            try
            {
                var DescriptionGroup = new GroupService(_dbContext);
                var (msg, group) = DescriptionGroup.GetGroupById(groupId);
                if (msg.Length == 0) return Ok(new
                {
                    Name = group.GroupName,
                    Description = group.GroupDescription
                }) ;
                return BadRequest(msg);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            try
            {
                var groupsService = new GroupService(_dbContext);
                var (msg, groups) = groupsService.GetAll();
                if (msg.Length > 0) return BadRequest(msg);
                return Ok(groups.Select(x => new
                {
                    Id = x.Id,
                    GroupName = x.GroupName,
                    Description = x.GroupDescription,
                    CreatorId = x.CreatorId,
                    CreateTime = x.CreatedTime,
                }).ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
